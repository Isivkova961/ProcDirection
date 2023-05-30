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
                select new Napr(data1)).ToList();
            dgvData.DataSource = lis1;
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.Cancel) return;
                FileInfo fi = new FileInfo(openDialog.FileName);
            tbPath.Text = fi.DirectoryName;
        }
    }
}
