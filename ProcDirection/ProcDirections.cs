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
            var lis1 = (from s in arr
                        let str = path
                        select s.Replace(str + "\\", "")
                into data1
                        select data1.Replace(".jpg", "")
                into data1
                        select new Napr(data1, path)).ToList();
            dgvNapr.DataSource = lis1;
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
            _dt = GridUtils.CheckColumn(_dt);
            dgvData.DataSource = _dt;
        }
    }
}
