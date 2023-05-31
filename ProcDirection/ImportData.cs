using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assistant.Repository;
using Assistant.Utils;

namespace ProcDirection
{
    public partial class fImportData : Form
    {
        private DataTable _dt;
        private string _filterFile;
        public fImportData()
        {
            InitializeComponent();
        }

        private void tsbLoadTable_Click(object sender, EventArgs e)
        {
            var ofDialog = new OpenFileDialog { Filter = _filterFile };
            if (ofDialog.ShowDialog() == DialogResult.Cancel)
                return;
            _dt = ExcelUtils.TableWorkExcel(ofDialog.FileName);
            _dt = GridUtils.CheckColumn(_dt);
            dgvData.DataSource = _dt;
            TempValue.GetMessageOk("Перед импортом проверьте, чтобы все столбцы были соотнесены");
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {

        }
    }
}
