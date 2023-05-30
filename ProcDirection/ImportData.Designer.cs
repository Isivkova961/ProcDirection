namespace ProcDirection
{
    partial class fImportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsViewPanel = new System.Windows.Forms.ToolStrip();
            this.tsnRefresh = new System.Windows.Forms.ToolStripButton();
            this.sebRefreshGridItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbDelByFiltr = new System.Windows.Forms.ToolStripButton();
            this.pFiltr = new System.Windows.Forms.Panel();
            this.dgvData = new DataGridViewEx();
            this.tsbLoadTable = new System.Windows.Forms.ToolStripButton();
            this.ssStatus.SuspendLayout();
            this.tsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslVersion});
            this.ssStatus.Location = new System.Drawing.Point(0, 690);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssStatus.Size = new System.Drawing.Size(1114, 22);
            this.ssStatus.TabIndex = 26;
            // 
            // sslVersion
            // 
            this.sslVersion.Name = "sslVersion";
            this.sslVersion.Size = new System.Drawing.Size(0, 17);
            // 
            // tsViewPanel
            // 
            this.tsViewPanel.AutoSize = false;
            this.tsViewPanel.BackColor = System.Drawing.Color.Azure;
            this.tsViewPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsnRefresh,
            this.sebRefreshGridItem,
            this.tsbLoadTable,
            this.tsbImport,
            this.tsbDelByFiltr});
            this.tsViewPanel.Location = new System.Drawing.Point(0, 0);
            this.tsViewPanel.Name = "tsViewPanel";
            this.tsViewPanel.Size = new System.Drawing.Size(1114, 48);
            this.tsViewPanel.TabIndex = 29;
            this.tsViewPanel.Text = "toolStrip1";
            // 
            // tsnRefresh
            // 
            this.tsnRefresh.AutoSize = false;
            this.tsnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsnRefresh.Image")));
            this.tsnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsnRefresh.ImageTransparentColor = System.Drawing.Color.White;
            this.tsnRefresh.Name = "tsnRefresh";
            this.tsnRefresh.Size = new System.Drawing.Size(35, 35);
            this.tsnRefresh.Text = "Обновить";
            // 
            // sebRefreshGridItem
            // 
            this.sebRefreshGridItem.Name = "sebRefreshGridItem";
            this.sebRefreshGridItem.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbImport
            // 
            this.tsbImport.AutoSize = false;
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(35, 35);
            this.tsbImport.Text = "Испорт списка пациентов";
            // 
            // tsbDelByFiltr
            // 
            this.tsbDelByFiltr.AutoSize = false;
            this.tsbDelByFiltr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelByFiltr.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelByFiltr.Image")));
            this.tsbDelByFiltr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelByFiltr.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbDelByFiltr.Name = "tsbDelByFiltr";
            this.tsbDelByFiltr.Size = new System.Drawing.Size(35, 35);
            this.tsbDelByFiltr.Text = "Убрать данные по фильтру";
            // 
            // pFiltr
            // 
            this.pFiltr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFiltr.Location = new System.Drawing.Point(0, 48);
            this.pFiltr.Name = "pFiltr";
            this.pFiltr.Size = new System.Drawing.Size(1114, 100);
            this.pFiltr.TabIndex = 30;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 148);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1114, 542);
            this.dgvData.TabIndex = 31;
            this.dgvData.VirtualMode = true;
            // 
            // tsbLoadTable
            // 
            this.tsbLoadTable.AutoSize = false;
            this.tsbLoadTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadTable.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadTable.Image")));
            this.tsbLoadTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoadTable.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbLoadTable.Name = "tsbLoadTable";
            this.tsbLoadTable.Size = new System.Drawing.Size(35, 35);
            this.tsbLoadTable.Text = "Загрузить таблицу";
            // 
            // fImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1114, 712);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pFiltr);
            this.Controls.Add(this.tsViewPanel);
            this.Controls.Add(this.ssStatus);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Name = "fImportData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт списка пациентов";
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tsViewPanel.ResumeLayout(false);
            this.tsViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslVersion;
        private System.Windows.Forms.ToolStrip tsViewPanel;
        private System.Windows.Forms.ToolStripButton tsnRefresh;
        private System.Windows.Forms.ToolStripSeparator sebRefreshGridItem;
        private System.Windows.Forms.ToolStripButton tsbLoadTable;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbDelByFiltr;
        private System.Windows.Forms.Panel pFiltr;
        private DataGridViewEx dgvData;
    }
}