using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcDirection
{
    public partial class fProcDirections : Form
    {
        public fProcDirections()
        {
            InitializeComponent();
        }

        private void tsmImportNapr_Click(object sender, EventArgs e)
        {
            var importNapr = new fImportNapr();
            importNapr.ShowDialog();
        }

    }
}
