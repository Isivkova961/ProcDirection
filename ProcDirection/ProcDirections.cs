using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Assistant.Repository;
using Assistant.Utils;
using PdfiumViewer;
using Repository.Entity.Auto;
using Repository.Repository.Auto;

namespace ProcDirection
{
    public partial class fProcDirections : Form
    {
        private readonly KmisNaprRepository _repoKmis = new KmisNaprRepository();
        private readonly NaprRepository _repoNapr = new NaprRepository();
        private Image image;
        private DataTable _dt;
        private string _filterFile;
        public string nameXmlBegin = "NGM430074T43_";
        public bool isTable = false;
        public static string folderPath = @"c:\doc\temp\";

        public BindingList<KmisNapr> kmisNaprs = new BindingList<KmisNapr>();
        public List<Napr> naprs = new List<Napr>();  
        public BindingList<NaprReestrKmis> naprReestr = new BindingList<NaprReestrKmis>();

        public PdfViewer viewer = new PdfViewer();

        public fProcDirections()
        {
            InitializeComponent();
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month - 1;
            if (month == 0)
            {
                year--;
                month = 12;
            }
            dtpDateIn.Value = new DateTime(year, month, 1);
            dtpDateOut.Value = new DateTime(year, month, DateTime.DaysInMonth(year, month));


            panel1.Controls.Add(viewer);
            viewer.Dock = DockStyle.Fill;
        }

        private void tsmImportNapr_Click(object sender, EventArgs e)
        {
            var importNapr = new fImportNapr();
            importNapr.ShowDialog();
        }

        private void DataInitKmis(string filter)
        {
            var dsKmis = _repoKmis.List(filter).ToDataSet();
            dgvData.TuneColumns(dsKmis,"kmis_napr");
        }

        private void DataInitNapr(string filter)
        {
            var dsNapr = _repoNapr.List(filter).ToDataSet();
            dgvNapr.TuneColumns(dsNapr, "napr");
        }

        private void DataInitReestr()
        {
            var _repoReestr = new ReestrRepository();
            var dsReestr = _repoReestr.List(dtpDateIn.Value, dtpDateOut.Value).ToDataSet();
            dgvData.TuneColumns(dsReestr, "reestr");
        }

        private void tsnRefresh_Click(object sender, EventArgs e)
        {
            DataInitKmis("");
            isTable = false;
        }

        private void tsmImportKmis_Click(object sender, EventArgs e)
        {
            var importKmis = new fImportData();
            importKmis.ShowDialog();
        }

        private void tbsResreshNapr_Click(object sender, EventArgs e)
        {
            DataInitNapr("");
        }

        private void tsbImportNapr_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.Cancel) return;
            FileInfo fi = new FileInfo(openDialog.FileName);
            OpenFile(fi.DirectoryName);
        }

        private void OpenFile(string pathName)
        {
            var path = pathName;
            var arr = Directory.GetFiles(path);
            naprs = (from s in arr.Where(x => x != path + "\\Thumbs.db")
                     let str = path
                     select s.Replace(str + "\\", "")
                into data1
                     select data1.Replace(".jpg", "")
                into data1
                     select data1.Replace(".JPG", "")
                into data1
                     select data1.Replace(".pdf", "")
                into data1
                     select data1.Replace(".PDF", "")
                into data1
                     select new Napr(data1, path)).ToList();
            dgvNapr.DataSource = naprs;
            tsbKolNapr.Text = "Кол-во:" + naprs.Count.ToString();
        }

        private void tsbShowImage_Click(object sender, EventArgs e)
        {
            var path = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString() + ".pdf";
            
            try
            {
                PdfDocument document = PdfDocument.Load(path);
                 // Если вы хотите отобразить в форме
                viewer.Document = document;
                //TempValue.GetMessageOk(viewer.Renderer.Zoom.ToString());
                viewer.Renderer.Zoom = 3;
            }
            catch (Exception ex)
            {
                TempValue.GetMessageError(ex.Message);
            }
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
            viewer.Renderer.RotateLeft();
            
        }

        private void tsbRigth_Click(object sender, EventArgs e)
        {
            viewer.Renderer.RotateRight();

        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            isTable = false;
            var ofDialog = new OpenFileDialog { Filter = _filterFile };
            if (ofDialog.ShowDialog() == DialogResult.Cancel)
                return;
            _dt = ExcelUtils.TableWorkExcel(ofDialog.FileName);
            foreach (DataRow row in _dt.Rows)
            {
                var kmisNapr = new KmisNapr
                {
                    fio = row.ItemArray[0].ToString(),
                    fio_d = row.ItemArray[1].ToString(),
                    numberib = row.ItemArray[2].ToString(),
                    date_gosp = row.ItemArray[3].ToString(),
                    date_vipis = row.ItemArray[4].ToString(),
                    otdel = row.ItemArray[5].ToString(),
                    address = row.ItemArray[6].ToString(),
                    type_gosp = row.ItemArray[7].ToString(),
                    polis = row.ItemArray[8].ToString()
                };
                kmisNaprs.Add(kmisNapr);
            }
            dgvData.DataSource = kmisNaprs;
            tsbKolKmis.Text = "Кол-во:" + kmisNaprs.Count.ToString();
        }

        private void Correlate()
        {
            var kmisNaprs1 = new List<KmisNapr>();
            foreach (var kmisNapr in kmisNaprs)
            {
                if (naprs.Any(x => x.fio_d.ToLower() == kmisNapr.fio_d.ToLower()))
                {
                    if (cebIsShow.Checked) kmisNaprs1.Add(kmisNapr);
                }
                else
                {
                    if (!cebIsShow.Checked) kmisNaprs1.Add(kmisNapr);
                }
            }
            dgvData.DataSource = kmisNaprs1;
            tsbKolKmis.Text = "Кол-во:" + kmisNaprs1.Count.ToString();

            var naprs1 = new List<Napr>();
            foreach (var napr in naprs)
            {
                if (kmisNaprs.Any(x => x.fio_d.ToLower() == napr.fio_d.ToLower()))
                {
                    if (cebIsShow.Checked) naprs1.Add(napr);
                }
                else
                {
                    if (!cebIsShow.Checked) naprs1.Add(napr);
                }
            }

            dgvNapr.DataSource = naprs1;
            tsbKolNapr.Text = "Кол-во:" + naprs1.Count.ToString();
        }
            

        private void tsbCorrelate_Click(object sender, EventArgs e)
        {
            isTable = false;
            Correlate();
        }

        private void tsbCorrelatePath_Click(object sender, EventArgs e)
        {
            var newName = dgvData.CurrentRow.Cells["fio_d"].Value.ToString();
            var path = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString() + ".jpg";
            var pathNew = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       newName + ".jpg";
            try
            {
                File.Move(path, pathNew);

                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл успешно переименован");
                }
                naprs.FirstOrDefault(x => x.fio_d == dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString()).fio_d = newName;
                if (isTable) Correlate2();
                         else Correlate();
            }
            catch (IOException es)
            {
                MessageBox.Show(es.ToString());
            }
            
        }

        private void tsbExportList_Click(object sender, EventArgs e)
        {
            var savedialog= new SaveFileDialog();
            var path = "";
            savedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savedialog.FilterIndex = 1;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                path = savedialog.FileName;
            }
            var kmisNaprList = new List<KmisNaprList>();
            foreach (DataGridViewRow dataRow in dgvData.Rows)
            {
                var kmis = new KmisNaprList
                {
                    fio = dataRow.Cells["fio"].Value.ToString(),
                    numberib = dataRow.Cells["numberib"].Value.ToString(),
                    otdel = dataRow.Cells["otdel"].Value.ToString()
                };
                kmisNaprList.Add(kmis);
            }
            var sb = new StringBuilder();
            kmisNaprList.Sort(delegate (KmisNaprList x, KmisNaprList y) {
                return x.otdel.CompareTo(y.otdel);
            });
            var otdel = "";
            foreach (var naprList in kmisNaprList)
            {
                if (otdel != naprList.otdel)
                {
                    otdel = naprList.otdel;
                    sb.AppendLine(otdel);
                }
                sb.AppendLine(naprList.numberib + " " + naprList.fio);
            }
            var dataWriter = sb.ToString();
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(dataWriter);
                sw.Close();
            }
        }

        private void tsbImportBd_Click(object sender, EventArgs e)
        {
            isTable = false;
            //DataInitReestr();
            var _repoReestr = new ReestrRepository();
            var dsReestr = _repoReestr.List(dtpDateIn.Value, dtpDateOut.Value).ToDataSet();
            dgvData.TuneColumns(dsReestr,"reestr");
            kmisNaprs.Clear();
            foreach (DataGridViewRow dataRow in dgvData.Rows)
            {
                var reestr = new KmisNapr
                {
                    fio = dataRow.Cells["fio"].Value.ToString(),
                    fio_d = dataRow.Cells["fio_d"].Value.ToString(),
                    numberib = dataRow.Cells["numberib"].Value.ToString(),
                    date_gosp = dataRow.Cells["date_gosp"].Value.ToString(),
                    date_vipis = dataRow.Cells["date_vipis"].Value.ToString(),
                    otdel = dataRow.Cells["otdel"].Value.ToString(),
                    polis = dataRow.Cells["polis"].Value.ToString(),
                    type_gosp = dataRow.Cells["type_gosp"].Value.ToString()
                };
                kmisNaprs.Add(reestr);
            }
            dgvData.DataSource = null;
            dgvData.DataSource = kmisNaprs;
            tsbKolKmis.Text = "Кол-во:" + kmisNaprs.Count.ToString();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var path = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString() + ".jpg";
            var napr = naprs.FirstOrDefault(x => x.fio_d == dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString());
            naprs.Remove(napr);
            File.Delete(path);
            Correlate();
        }

        private void tsmExportNapr_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel) return;
            FileInfo fi = new FileInfo(dialog.FileName);
            foreach (DataGridViewRow row in dgvNapr.Rows)
            {
                var path1 = fi.DirectoryName + @"\" + row.Cells["fio_d"].Value.ToString() + ".pdf";
                var path = row.Cells["path"].Value.ToString() + @"\" +
                row.Cells["fio_d"].Value.ToString() + ".pdf";
                File.Move(path, path1);
            }
            MessageBox.Show(@"Данные направления перенесены");
            var pathDir = dgvNapr.CurrentRow.Cells["path"].Value.ToString();
            var arr = Directory.GetFiles(pathDir);
            naprs = (from s in arr
                     let str = pathDir
                     select s.Replace(str + "\\", "")
                into data1
                     select data1.Replace(".jpg", "")
                into data1
                     select data1.Replace(".JPG", "")
                into data1
                     select data1.Replace(".pdf", "")
                 into data1
                     select data1.Replace(".PDF", "")
                into data1
                     select new Napr(data1, pathDir)).ToList();
            dgvNapr.DataSource = naprs;
            tsbKolNapr.Text = "Кол-во:" + naprs.Count.ToString();
        }

        private void tsbDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNapr.Rows)
            {
                var path = row.Cells["path"].Value.ToString() + @"\" +
                row.Cells["fio_d"].Value.ToString() + ".jpg";
                File.Delete(path);
            }
            Correlate();
        }

        private void tsbRename_Click(object sender, EventArgs e)
        {
            var newName = tstbRename.Text;
            var path = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString() + ".jpg";
            var pathNew = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       newName + ".jpg";
            try
            {
                File.Move(path, pathNew);

                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл успешно переименован");
                }
                naprs.FirstOrDefault(x => x.fio_d == dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString()).fio_d = newName;
                Correlate();
                tstbRename.Text = "";
            }
            catch (IOException es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void tsLoadReestrNapr_Click(object sender, EventArgs e)
        {
            isTable = true;
            var _repoReestr = new NaprReestrListRepository();
            var dsReestr = _repoReestr.List(dtpDateIn.Value.Date, dtpDateOut.Value.Date).ToArray();
            //dgvData.TuneColumns(dsReestr, "napr_reestr");
            foreach (var arr in dsReestr)
            {
                var reestr = new NaprReestrKmis()
                {
                    reestr_id = arr.reestr_id?.ToString(),
                    formpom = arr.formpom?.ToString(),
                    fio_d = arr.fio_d?.ToString(),
                    kod = arr.kod?.ToString(),
                    tipoplat = arr.tipoplat?.ToString(),
                    stacolny = arr.staconly?.ToString(),
                    step = arr.step?.ToString(),
                    tipdpfs = arr.tipdpfs?.ToString(),
                    sdpfs = arr.sdpfs?.ToString(),
                    ndpfs = arr.ndpfs?.ToString(),
                    st_okato = arr.st_okato?.ToString(),
                    ogrnsmo = arr.ogrnsmo?.ToString(),
                    fam = arr.fam?.ToString(),
                    im = arr.im?.ToString(),
                    ot = arr.ot?.ToString(),
                    pol = arr.pol?.ToString(),
                    drojd = arr.drojd?.ToString(),
                    telefon = arr.telefon?.ToString(),
                    kodamb = arr.kodamb?.ToString(),
                    rnotdelamb = arr.rnotdelamb?.ToString(),
                    rnpodramb = arr.rnpodramb?.ToString(),
                    nnapr = arr.nnapr?.ToString(),
                    dnapr = arr.dnapr?.ToString(),
                    profot = arr.profot?.ToString(),
                    profil_k = arr.profil_k?.ToString(),
                    formamp = arr.formamp?.ToString(),
                    mkbnapr = arr.mkbnapr?.ToString(),
                    uslok = arr.uslok?.ToString(),
                    kodstac = arr.kodstac?.ToString(),
                    dgospplan = arr.dgospplan?.ToString(),
                    rnotdelstac = arr.rnotdelstac?.ToString(),
                    rnpodrstac = arr.rnpodrstac?.ToString(),
                    mkbpo = arr.mkbpo?.ToString(),
                    nib = arr.nib?.ToString(),
                    dgospfakt = arr.dgospfakt?.ToString(),
                    vrgospfakt = arr.vrgospfakt?.ToString(),
                    dvyb = arr.dvyb?.ToString(),
                    ishod = arr.ishod?.ToString(),
                    plandlitgosp = arr.plandlitgosp?.ToString(),
                    id = arr.id?.ToString(),
                    rnvrachamb = arr.rnvrachamb?.ToString()
                    

                };
                naprReestr.Add(reestr);
            }
            dgvData.DataSource = null;
            dgvData.DataSource = naprReestr;
            tsbKolKmis.Text = "Кол-во:" + naprReestr.Count.ToString();
        }

        private void tsbDrop_Click(object sender, EventArgs e)
        {
            isTable = true;
            var _repoReestr = new NaprReestrListRepository();
            _repoReestr.Drop().Exec();
        }

        private void RefreshNaprReestr()
        {
            isTable = true;
            var _repoReestr = new NaprReestrListRepository();
            var dsReestr = _repoReestr.List2(cobStatus.Text).ToArray();
            naprReestr.Clear();
            foreach (var arr in dsReestr)
            {
                var reestr = new NaprReestrKmis()
                {
                    reestr_id = arr.reestr_id?.ToString(),
                    formpom = arr.formpom?.ToString(),
                    fio_d = arr.fio_d?.ToString(),
                    kod = arr.kod?.ToString(),
                    tipoplat = arr.tipoplat?.ToString(),
                    stacolny = arr.staconly?.ToString(),
                    step = arr.step?.ToString(),
                    tipdpfs = arr.tipdpfs?.ToString(),
                    sdpfs = arr.sdpfs?.ToString(),
                    ndpfs = arr.ndpfs?.ToString(),
                    st_okato = arr.st_okato?.ToString(),
                    ogrnsmo = arr.ogrnsmo?.ToString(),
                    fam = arr.fam?.ToString(),
                    im = arr.im?.ToString(),
                    ot = arr.ot?.ToString(),
                    pol = arr.pol?.ToString(),
                    drojd = arr.drojd?.ToString(),
                    telefon = arr.telefon?.ToString(),
                    kodamb = arr.kodamb?.ToString(),
                    rnotdelamb = arr.rnotdelamb?.ToString(),
                    rnpodramb = arr.rnpodramb?.ToString(),
                    nnapr = arr.nnapr?.ToString(),
                    dnapr = arr.dnapr?.ToString(),
                    profot = arr.profot?.ToString(),
                    profil_k = arr.profil_k?.ToString(),
                    formamp = arr.formamp?.ToString(),
                    mkbnapr = arr.mkbnapr?.ToString(),
                    uslok = arr.uslok?.ToString(),
                    kodstac = arr.kodstac?.ToString(),
                    dgospplan = arr.dgospplan?.ToString(),
                    rnotdelstac = arr.rnotdelstac?.ToString(),
                    rnpodrstac = arr.rnpodrstac?.ToString(),
                    mkbpo = arr.mkbpo?.ToString(),
                    nib = arr.nib?.ToString(),
                    dgospfakt = arr.dgospfakt?.ToString(),
                    vrgospfakt = arr.vrgospfakt?.ToString(),
                    dvyb = arr.dvyb?.ToString(),
                    ishod = arr.ishod?.ToString(),
                    plandlitgosp = arr.plandlitgosp?.ToString(),
                    id = arr.id?.ToString(),
                    rnvrachamb = arr.rnvrachamb?.ToString(),
                    isLoad = arr.isLoad,
                    filtr = arr.filtr?.ToString(),
                    name_xml = arr.name_xml?.ToString(),
                    status = arr.status?.ToString(),
                    pathPdf = arr.pathPdf?.ToString()

                };
                naprReestr.Add(reestr);
            }
            dgvData.DataSource = naprReestr;
            tsbKolKmis.Text = "Кол-во:" + naprReestr.Count.ToString();
        }

        private void tsbRefreshNaprReestr_Click(object sender, EventArgs e)
        {
            RefreshNaprReestr();
        }

        public static XElement CreateXML(NaprReestrKmis person, string step)
        {
            var xml =  new XElement(
                "zap",
                    new XElement("kod", person.kod),
                    new XElement("tipoplat", person.tipoplat),
                    new XElement("staconly", person.stacolny),
                    new XElement("step", person.step),
                    new XElement("id", person.id),
                    new XElement("tipdpfs", person.tipdpfs),
                    new XElement("sdpfs", person.sdpfs),
                    new XElement("ndpfs", person.ndpfs),
                    new XElement("st_okato", person.st_okato),
                    new XElement("ogrnsmo", person.ogrnsmo),
                    new XElement("fam", person.fam),
                    new XElement("im", person.im),
                    new XElement("ot", person.ot),
                    new XElement("pol", person.pol),
                    new XElement("drojd", person.drojd),
                    new XElement("telefon", person.telefon),
                    new XElement("kodamb", person.kodamb),
                    new XElement("rnotdelamb", person.rnotdelamb),
                    new XElement("rnpodramb", person.rnpodramb),
                    new XElement("rnvrachamb", person.rnvrachamb),
                    new XElement("nnapr", person.nnapr),
                    new XElement("dnapr", person.dnapr),
                    new XElement("profot", person.profot),
                    new XElement("profil_k", person.profil_k),
                    new XElement("formamp", person.formamp),
                    new XElement("mkbnapr", person.mkbnapr),
                    new XElement("uslok", person.uslok),
                    new XElement("kodstac", person.kodstac),
                    new XElement("dgospplan", person.dgospplan),
                    new XElement("rnotdelstac", person.rnotdelstac),
                    new XElement("rnpodrstac", person.rnpodrstac),
                    new XElement("mkbpo", person.mkbpo),
                    new XElement("nib", person.nib),
                    new XElement("dgospfakt", person.dgospfakt),
                    new XElement("vrgospfakt", person.vrgospfakt));
            if (step == "3")
            {
                xml.Add(new XElement("dvyb", person.dvyb));
                xml.Add(new XElement("ishod", person.ishod));
            }
            xml.Add(new XElement("plandlitgosp", person.plandlitgosp));
            if (person.formpom == "3" && person.st_okato == "33000" && person.step == "1")
                xml.Add(new XElement("napr_pdf", ConvertPdfBase64(person)));
            if (person.formpom == "3" && person.st_okato != "33000" && person.step == "2")
                xml.Add(new XElement("napr_pdf", ConvertPdfBase64(person)));
            return xml;
        }

        public static string ConvertPdfBase64(NaprReestrKmis person)
        {
            Byte[] fileBytes = File.ReadAllBytes(person.pathPdf);
            var content = Convert.ToBase64String(fileBytes);
            return content;
        }



        public void SaveXml(XElement xml, string path)
        {
            xml.Save(path);
            //TempValue.GetMessageOk("Файл сохранен в " + path);
        }

        public void CreateXmlNapr(string path)
        {
            XmlData dataXml = new XmlData() {reestr_id = "", step = "", tipopl = "", num = 1, i = 0, nameXml = ""};

            var date1 = dtpDateIn.Value.ToString("yyMM");
            var namexml = nameXmlBegin + date1;
            var path1 = "";

            XElement xml = new XElement("gosp");
            var naprReestrs = naprReestr.Where(x => x.isLoad == false).ToList();
            if (cebNumberReestr.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.reestr_id == tbNumerReestr.Text && x.isLoad == false).ToList();
            }
            if (cebExtr.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.formpom == "1" && x.isLoad == false).ToList();
            }
            if (cebVMP.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.filtr == "5_11ВМП КС" && x.isLoad == false).ToList();
            }
            if (cebPlanKirov.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.formpom == "3" && x.st_okato == "33000" && x.isLoad == false).ToList();
            }
            if (cebPlanInog.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.formpom == "3" && x.st_okato != "33000" && x.isLoad == false).ToList();
            }
            if (cebIsLoad.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.status == "Error" && x.isLoad == false).ToList();
            }

            foreach (var napr in naprReestrs.OrderBy(x => x.reestr_id).ThenBy(x => x.name_xml).ThenBy(x => x.step).ThenBy(x => x.formpom))
            {
                if (napr.formpom == "3" && napr.pathPdf == null) continue;
                if (dataXml.reestr_id == "")
                {
                    dataXml.reestr_id = napr.reestr_id;
                    dataXml.step = napr.step;
                    dataXml.tipopl = napr.formpom;
                    dataXml.nameXml = napr.name_xml;
                }

                if (dataXml.reestr_id != napr.reestr_id)
                {
                    SaveXml(xml, path + @"\\" + path1);

                    dataXml.reestr_id = napr.reestr_id;
                    dataXml.step = napr.step;
                    dataXml.tipopl = napr.formpom;
                    dataXml.nameXml = napr.name_xml;
                    dataXml.i = 0;
                    dataXml.num = 1;

                }

                if (dataXml.i > 20)
                {
                    SaveXml(xml, path + @"\\" + path1);

                    dataXml.i = 0;
                    dataXml.num++;
                }
                else
                {
                    if (dataXml.nameXml != napr.name_xml)
                    {
                        SaveXml(xml, path + @"\\" + path1);

                        dataXml.step = napr.step;
                        dataXml.tipopl = napr.formpom;
                        dataXml.nameXml = napr.name_xml;
                        dataXml.i = 0;
                        dataXml.num++;
                    }
                    if (dataXml.step != napr.step)
                    {
                        SaveXml(xml, path + @"\\" + path1);

                        dataXml.step = napr.step;
                        dataXml.tipopl = napr.formpom;
                        dataXml.nameXml = napr.name_xml;
                        dataXml.i = 0;
                        dataXml.num++;
                    }

                    if (dataXml.tipopl != napr.formpom)
                    {
                        SaveXml(xml, path + @"\\"+ path1);

                        dataXml.step = napr.step;
                        dataXml.tipopl = napr.formpom;
                        dataXml.nameXml = napr.name_xml;
                        dataXml.i = 0;
                        dataXml.num++;
                    }
                }
                if (dataXml.i == 0)
                {
                    if (!string.IsNullOrEmpty(napr.name_xml))
                    {
                        var indexIn = napr.name_xml.IndexOf(dataXml.reestr_id, StringComparison.Ordinal) + 4;
                        var indexOut = napr.name_xml.IndexOf(".xml");
                        var step = napr.name_xml.Substring(indexIn, indexOut - indexIn);
                        path1 = napr.name_xml.Remove(indexOut - 1, napr.name_xml.Length - (indexOut - 1)) +
                                (Int32.Parse(step) + 1) + ".xml";
                    }
                    else
                    {
                        path1 = namexml + dataXml.num.ToString("D2") + "_" + dataXml.reestr_id + dataXml.step + ".xml";
                    }
                    xml = new XElement("gosp");
                    dataXml.i++;
                }
                xml.Add(CreateXML(napr, dataXml.step));
                UpdateData(napr.kod, path1, "Ok", "", 1, (Int32.Parse(dataXml.step)+1).ToString());
                dataXml.i++;
                
            }
            if (dataXml.i > 0)
            {
                SaveXml(xml, path + @"\\" + path1);
            }
        }

        private void UpdateData(string kod, string nameXml, string status, string pathPdf, int isLoad, string step)
        {
            var repo = new NaprReestrListRepository();
            repo.Update(kod, nameXml, status, pathPdf, isLoad, step).Exec();
        }

        private void tsbExportXml_Click(object sender, EventArgs e)
        {
            isTable = true;
            var savedialog = new FolderBrowserDialog();
            var path = @"y:\КМИС\Реестры\2025\Общие данные\Направления\";
            //if (savedialog.ShowDialog() == DialogResult.OK)
            //{
            //    path = savedialog.SelectedPath;
            //}
            CreateXmlNapr(path);
            TempValue.GetMessageOk("Файлы выгружены");
            RefreshNaprReestr();
            CheckChanger();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsbCollect2_Click(object sender, EventArgs e)
        {
            isTable = true;
            Correlate2();
        }

        private void Correlate2()
        {
            var kmisNaprs1 = new List<NaprReestrKmis>();
            foreach (var kmisNapr in naprReestr.Where(x=>x.formpom != "1").OrderBy(x=>x.fio_d))
            {
                if (naprs.Any(x => x.fio_d.ToLower() == kmisNapr.fio_d.ToLower()))
                {
                    if (cebIsShow.Checked)
                    {
                        var napr = naprs.FirstOrDefault(x => x.fio_d.ToLower() == kmisNapr.fio_d.ToLower());
                        kmisNapr.pathPdf = napr.path + @"\" + napr.fio_d + ".pdf";
                        UpdateData(kmisNapr.kod,"","", kmisNapr.pathPdf,kmisNapr.isLoad?1:0,kmisNapr.step);
                        kmisNaprs1.Add(kmisNapr);
                    }
                }
                else
                {
                    if (!cebIsShow.Checked) kmisNaprs1.Add(kmisNapr);
                }
            }
            dgvData.DataSource = kmisNaprs1;
            tsbKolKmis.Text = "Кол-во:" + kmisNaprs1.Count.ToString();

            var naprs1 = new List<Napr>();
            foreach (var napr in naprs)
            {
                if (naprReestr.Any(x => x.fio_d.ToLower() == napr.fio_d.ToLower()))
                {
                    if (cebIsShow.Checked) naprs1.Add(napr);
                }
                else
                {
                    if (!cebIsShow.Checked) naprs1.Add(napr);
                }
            }

            dgvNapr.DataSource = naprs1;
            tsbKolNapr.Text = "Кол-во:" + naprs1.Count.ToString();
        }

        private void tsbEditStatus_Click(object sender, EventArgs e)
        {
            var newStep = tbStep.Text;
            try
            {
                naprReestr.FirstOrDefault(x => x.kod == dgvData.CurrentRow.Cells["kod"].Value.ToString()).step = newStep;
                UpdateData(dgvData.CurrentRow.Cells["kod"].Value.ToString(), "", "", "", 0, newStep);
                tbStep.Text = "";
            }
            catch (IOException es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void tsbEditLoad_Click(object sender, EventArgs e)
        {
            bool isLoad = (bool) dgvData.CurrentRow.Cells["isLoad"].Value;
            var step = Int32.Parse(dgvData.CurrentRow.Cells["step"].Value.ToString()) + 1;
            try
            {
                naprReestr.FirstOrDefault(x => x.kod == dgvData.CurrentRow.Cells["kod"].Value.ToString()).isLoad = !isLoad;
                naprReestr.FirstOrDefault(x => x.kod == dgvData.CurrentRow.Cells["kod"].Value.ToString()).step = step.ToString();
                UpdateData(dgvData.CurrentRow.Cells["kod"].Value.ToString(), "","","", !isLoad == true ? 1 : 0, step.ToString());
                dgvData.DataSource = null;
                dgvData.DataSource = naprReestr;
            }
            catch (IOException es)
            {
                MessageBox.Show(es.ToString());
            }
            
        }

        private void CheckChanger()
        {
            var naprReestrs = naprReestr.ToList();
            if (cebNumberReestr.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.reestr_id == tbNumerReestr.Text).ToList();
            }
            if (cebExtr.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.formpom == "1" && x.isLoad == false).ToList();
            }
            if (cebVMP.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.filtr == "5_11ВМП КС" && x.isLoad == false).ToList();
            }
            if (cebPlanKirov.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.formpom == "3" && x.st_okato == "33000" && x.isLoad == false).ToList();
            }
            if (cebPlanInog.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.formpom == "3" && x.st_okato != "33000" && x.isLoad == false).ToList();
            }
            if (cebIsLoad.Checked)
            {
                naprReestrs = naprReestrs.Where(x => x.isLoad == true).ToList();
            }
            dgvData.DataSource = null;
            dgvData.DataSource = naprReestrs;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckChanger();
        }

        private void cebPlanKirov_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanger(); 
        }

        private void cebVMP_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanger();
        }

        private void cebExtr_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanger();
        }

        private void cebPlanInog_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanger();
        }

        private void cebError_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanger();
        }

        private void tsbEditNameFile_Click(object sender, EventArgs e)
        {
            string folderPath = dgvNapr.CurrentRow.Cells["path"].Value.ToString(); // Замени на путь к твоей папке

            try
            {
                // Получаем все PDF файлы в папке
                string[] pdfFiles = Directory.GetFiles(folderPath, "*.pdf");

                foreach (string filePath in pdfFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string newFileName = fileName.Replace(" ", "").Replace(".", "").ToUpper();
                    string newFilePath = Path.Combine(folderPath, newFileName + ".pdf");

                    // Проверяем, нужно ли переименовывать (если имя уже соответствует условиям)
                    if (filePath != newFilePath)
                    {
                        File.Move(filePath, newFilePath);
                    }
                }


                TempValue.GetMessageOk("Переименование завершено.");
                OpenFile(folderPath);

            }
            catch (Exception ex)
            {
                TempValue.GetMessageError(ex.Message);
            }
        }

        private void обработатьОтчетыСчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameFiles();
        }

        static void RenameFiles()
        {
            string[] folders = Directory.GetDirectories(folderPath);
            //создаем папки со страховыми, куда будем перемещать итоговые папки
            string[] nameDirectory = new string[6] { "Общая", "ФОМС", "СОГАЗ", "Макс М", "Ингострах", "Капитал" };
            foreach (var name in nameDirectory)
            {
                NewDirectory(name);
            }

            foreach (string folder in folders)
            {
                string[] files = Directory.GetFiles(folder);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string folderName = new DirectoryInfo(folder).Name;
                    folderName = fileName.Replace("-страницы", "");
                    for (var i = 0; i < 6; i++)
                    {
                        if (folderName.IndexOf("-" + (i + 1)) > -1)
                        {
                            File.Move(file, Path.Combine(folderPath + nameDirectory[i], folderName));
                            break;
                        }
                    }
                }
                Directory.Delete(folder, true);
            }


        }

        static void NewDirectory(string name)
        {
            //создаем папки со страховыми, куда будем перемещать итоговые папки
            if (!Directory.Exists(folderPath + name))
            {
                Directory.CreateDirectory(folderPath + name);
            }
        }
    }
}
