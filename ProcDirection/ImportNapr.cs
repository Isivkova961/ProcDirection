using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assistant.Repository;
using Repository.Entity.Auto;
using Repository.Repository.Auto;

namespace ProcDirection
{
    public partial class fImportNapr : Form
    {
        public fImportNapr()
        {
            InitializeComponent();
        }

        private void fImportNapr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void tsbLoadTable_Click(object sender, EventArgs e)
        {
            var path = tbPath.Text;
            var arr = Directory.GetFiles(path);
            var lis1 = (from s in arr
                let str = tbPath.Text
                select s.Replace(str + "\\", "")
                into data1
                select data1.Replace(".jpg", "")
                into data1
                select new Napr(data1, path)).ToList();
            dgvData.DataSource = lis1;
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.Cancel) return;
                FileInfo fi = new FileInfo(openDialog.FileName);
            tbPath.Text = fi.DirectoryName;
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            var naprList = new List<Napr>();
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                var arr = row;
                var napr = new Napr(row.Cells["fio_d"].Value.ToString(), row.Cells["path"].Value.ToString());
                naprList.Add(napr);
            }
            var _repo = new NaprRepository();
            _repo.Save(naprList, true);

        }
    }
}
