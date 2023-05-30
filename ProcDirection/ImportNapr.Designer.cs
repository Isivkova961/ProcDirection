namespace ProcDirection
{
    partial class fImportNapr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportNapr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsViewPanel = new System.Windows.Forms.ToolStrip();
            this.tsnRefresh = new System.Windows.Forms.ToolStripButton();
            this.sebRefreshGridItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadTable = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new ProcDirection.DataGridViewEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLoad = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lPath = new System.Windows.Forms.Label();
            this.ssStatus.SuspendLayout();
            this.tsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslVersion});
            this.ssStatus.Location = new System.Drawing.Point(0, 384);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssStatus.Size = new System.Drawing.Size(490, 22);
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
            this.tsbImport});
            this.tsViewPanel.Location = new System.Drawing.Point(0, 0);
            this.tsViewPanel.Name = "tsViewPanel";
            this.tsViewPanel.Size = new System.Drawing.Size(490, 48);
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
            // tsbLoadTable
            // 
            this.tsbLoadTable.AutoSize = false;
            this.tsbLoadTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoadTable.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadTable.Image")));
            this.tsbLoadTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLoadTable.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbLoadTable.Name = "tsbLoadTable";
            this.tsbLoadTable.Size = new System.Drawing.Size(35, 35);
            this.tsbLoadTable.Text = "Загрузить файлы";
            this.tsbLoadTable.Click += new System.EventHandler(this.tsbLoadTable_Click);
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
            this.tsbImport.Text = "Испорт списка направлений";
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
            this.dgvData.Location = new System.Drawing.Point(0, 88);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(490, 296);
            this.dgvData.TabIndex = 31;
            this.dgvData.VirtualMode = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bLoad);
            this.panel1.Controls.Add(this.tbPath);
            this.panel1.Controls.Add(this.lPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 40);
            this.panel1.TabIndex = 32;
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.Location = new System.Drawing.Point(455, 8);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(23, 23);
            this.bLoad.TabIndex = 2;
            this.bLoad.Text = "...";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(59, 8);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(398, 22);
            this.tbPath.TabIndex = 1;
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(12, 15);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(41, 15);
            this.lPath.TabIndex = 0;
            this.lPath.Text = "Папка";
            // 
            // fImportNapr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 406);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsViewPanel);
            this.Controls.Add(this.ssStatus);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Name = "fImportNapr";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт списка пациентов";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fImportNapr_KeyDown);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tsViewPanel.ResumeLayout(false);
            this.tsViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private DataGridViewEx dgvData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lPath;
    }
}