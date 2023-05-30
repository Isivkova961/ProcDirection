using System.Windows.Forms;

namespace ProcDirection
{
    public class DataGridViewEx : DataGridView
    {
        readonly DataGridViewCellStyle _dataGridViewCellStyle1 = new DataGridViewCellStyle();
        readonly DataGridViewCellStyle _dataGridViewCellStyle2 = new DataGridViewCellStyle();
        public DataGridViewEx() : base()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            _dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            _dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            _dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            _dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            _dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = _dataGridViewCellStyle1;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            _dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            _dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            _dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            _dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            _dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.DefaultCellStyle = _dataGridViewCellStyle2;
            this.Location = new System.Drawing.Point(0, 98);
            this.Name = "dgvGrid";
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.VirtualMode = true;


        }

        

    }
}
