using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assistant.Repository;
using Assistant.Utils;
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

        public List<KmisNapr> kmisNaprs = new List<KmisNapr>();
        public List<Napr> naprs = new List<Napr>();  

        public fProcDirections()
        {
            InitializeComponent();
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
            var path = fi.DirectoryName;
            var arr = Directory.GetFiles(path);
            naprs = (from s in arr
                        let str = path
                        select s.Replace(str + "\\", "")
                into data1
                        select data1.Replace(".jpg", "")
                into data1
                     select data1.Replace(".JPG", "")
                into data1
                        select new Napr(data1, path)).ToList();
            dgvNapr.DataSource = naprs;
            tsbKolNapr.Text = "Кол-во:" + naprs.Count.ToString();
        }

        private void tsbShowImage_Click(object sender, EventArgs e)
        {
            var path = dgvNapr.CurrentRow.Cells["path"].Value.ToString() + @"\" +
                       dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString() + ".jpg";
            image = Image.FromFile(path);
            pbNapr.Image = image;
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbNapr.Image = image;
        }

        private void tsbRigth_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbNapr.Image = image;

        }

        private void tsbZoom_Click(object sender, EventArgs e)
        {
            pbNapr.Width = image.Width;
            pbNapr.Height = image.Height;
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
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
                    Console.WriteLine("File successfully renamed.");
                }
                naprs.FirstOrDefault(x => x.fio_d == dgvNapr.CurrentRow.Cells["fio_d"].Value.ToString()).fio_d = newName;
                Correlate();
            }
            catch (IOException es)
            {
                Console.WriteLine("The renaming failed: {0}", es.ToString());
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
            //DataInitReestr();
            var _repoReestr = new ReestrRepository();
            var dsReestr = _repoReestr.List(dtpDateIn.Value, dtpDateOut.Value).ToDataSet();
            dgvData.TuneColumns(dsReestr,"reestr");
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
            dgvData.DataSource = kmisNaprs;
            tsbKolKmis.Text = "Кол-во:" + kmisNaprs.Count.ToString();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNapr.Rows)
            {
                var path = row.Cells["path"].Value.ToString() + @"\" +
                row.Cells["fio_d"].Value.ToString() + ".jpg";
                File.Delete(path);
            }
        }

        private void tsmExportNapr_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.Cancel) return;
            FileInfo fi = new FileInfo(dialog.FileName);
            foreach (DataGridViewRow row in dgvNapr.Rows)
            {
                var path1 = fi.DirectoryName + @"\" + row.Cells["fio_d"].Value.ToString() + ".jpg";
                var path = row.Cells["path"].Value.ToString() + @"\" +
                row.Cells["fio_d"].Value.ToString() + ".jpg";
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
                     select new Napr(data1, pathDir)).ToList();
            dgvNapr.DataSource = naprs;
            tsbKolNapr.Text = "Кол-во:" + naprs.Count.ToString();
        }
    }
}
