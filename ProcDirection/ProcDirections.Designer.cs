﻿namespace ProcDirection
{
    partial class fProcDirections
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProcDirections));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.справочникОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportKmis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportNapr = new System.Windows.Forms.ToolStripMenuItem();
            this.логToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьСписокНаправленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pFiltr = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsViewPanel = new System.Windows.Forms.ToolStrip();
            this.tsnRefresh = new System.Windows.Forms.ToolStripButton();
            this.sebRefreshGridItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbCorrelate = new System.Windows.Forms.ToolStripButton();
            this.tsbExportList = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pbNapr = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsResreshNapr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImportNapr = new System.Windows.Forms.ToolStripButton();
            this.tsbCorrelatePath = new System.Windows.Forms.ToolStripButton();
            this.tsbShowImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbRigth = new System.Windows.Forms.ToolStripButton();
            this.tsbZoom = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvData = new ProcDirection.DataGridViewEx();
            this.dgvNapr = new ProcDirection.DataGridViewEx();
            this.ssStatus.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNapr)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapr)).BeginInit();
            this.SuspendLayout();
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslVersion});
            this.ssStatus.Location = new System.Drawing.Point(0, 619);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssStatus.Size = new System.Drawing.Size(1246, 22);
            this.ssStatus.TabIndex = 25;
            // 
            // sslVersion
            // 
            this.sslVersion.Name = "sslVersion";
            this.sslVersion.Size = new System.Drawing.Size(0, 17);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msMenu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникОрганизацийToolStripMenuItem,
            this.логToolStripMenuItem,
            this.выгрузитьСписокНаправленийToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1246, 24);
            this.msMenu.TabIndex = 26;
            this.msMenu.Text = "menuStrip1";
            // 
            // справочникОрганизацийToolStripMenuItem
            // 
            this.справочникОрганизацийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmImportKmis,
            this.tsmImportNapr});
            this.справочникОрганизацийToolStripMenuItem.Name = "справочникОрганизацийToolStripMenuItem";
            this.справочникОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.справочникОрганизацийToolStripMenuItem.Text = "Импорт";
            // 
            // tsmImportKmis
            // 
            this.tsmImportKmis.Name = "tsmImportKmis";
            this.tsmImportKmis.Size = new System.Drawing.Size(189, 22);
            this.tsmImportKmis.Text = "Списка пациентов";
            this.tsmImportKmis.Click += new System.EventHandler(this.tsmImportKmis_Click);
            // 
            // tsmImportNapr
            // 
            this.tsmImportNapr.Name = "tsmImportNapr";
            this.tsmImportNapr.Size = new System.Drawing.Size(189, 22);
            this.tsmImportNapr.Text = "Списка направлений";
            this.tsmImportNapr.Click += new System.EventHandler(this.tsmImportNapr_Click);
            // 
            // логToolStripMenuItem
            // 
            this.логToolStripMenuItem.Name = "логToolStripMenuItem";
            this.логToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.логToolStripMenuItem.Text = "Лог";
            // 
            // выгрузитьСписокНаправленийToolStripMenuItem
            // 
            this.выгрузитьСписокНаправленийToolStripMenuItem.Name = "выгрузитьСписокНаправленийToolStripMenuItem";
            this.выгрузитьСписокНаправленийToolStripMenuItem.Size = new System.Drawing.Size(195, 20);
            this.выгрузитьСписокНаправленийToolStripMenuItem.Text = "Выгрузить список направлений";
            // 
            // pFiltr
            // 
            this.pFiltr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFiltr.Location = new System.Drawing.Point(0, 24);
            this.pFiltr.Name = "pFiltr";
            this.pFiltr.Size = new System.Drawing.Size(1246, 100);
            this.pFiltr.TabIndex = 27;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 124);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvData);
            this.splitContainer1.Panel1.Controls.Add(this.tsViewPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 495);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 28;
            // 
            // tsViewPanel
            // 
            this.tsViewPanel.AutoSize = false;
            this.tsViewPanel.BackColor = System.Drawing.Color.Azure;
            this.tsViewPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsnRefresh,
            this.sebRefreshGridItem,
            this.tsbImport,
            this.tsbCorrelate,
            this.tsbExportList});
            this.tsViewPanel.Location = new System.Drawing.Point(0, 0);
            this.tsViewPanel.Name = "tsViewPanel";
            this.tsViewPanel.Size = new System.Drawing.Size(1246, 48);
            this.tsViewPanel.TabIndex = 28;
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
            this.tsnRefresh.Click += new System.EventHandler(this.tsnRefresh_Click);
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
            this.tsbImport.Text = "Добавить";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbCorrelate
            // 
            this.tsbCorrelate.AutoSize = false;
            this.tsbCorrelate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCorrelate.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorrelate.Image")));
            this.tsbCorrelate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCorrelate.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbCorrelate.Name = "tsbCorrelate";
            this.tsbCorrelate.Size = new System.Drawing.Size(35, 35);
            this.tsbCorrelate.Text = "Копировать";
            // 
            // tsbExportList
            // 
            this.tsbExportList.AutoSize = false;
            this.tsbExportList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportList.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportList.Image")));
            this.tsbExportList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExportList.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbExportList.Name = "tsbExportList";
            this.tsbExportList.Size = new System.Drawing.Size(35, 35);
            this.tsbExportList.Text = "Изменить";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 48);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvNapr);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.pbNapr);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(1246, 203);
            this.splitContainer2.SplitterDistance = 518;
            this.splitContainer2.TabIndex = 29;
            // 
            // pbNapr
            // 
            this.pbNapr.Location = new System.Drawing.Point(11, 12);
            this.pbNapr.Name = "pbNapr";
            this.pbNapr.Size = new System.Drawing.Size(724, 203);
            this.pbNapr.TabIndex = 0;
            this.pbNapr.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Azure;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsResreshNapr,
            this.toolStripSeparator2,
            this.tsbImportNapr,
            this.tsbCorrelatePath,
            this.tsbShowImage,
            this.toolStripSeparator3,
            this.tsbDelete,
            this.toolStripSeparator4,
            this.tsbRigth,
            this.tsbLeft,
            this.tsbZoom});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1246, 48);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsResreshNapr
            // 
            this.tbsResreshNapr.AutoSize = false;
            this.tbsResreshNapr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsResreshNapr.Image = ((System.Drawing.Image)(resources.GetObject("tbsResreshNapr.Image")));
            this.tbsResreshNapr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsResreshNapr.ImageTransparentColor = System.Drawing.Color.White;
            this.tbsResreshNapr.Name = "tbsResreshNapr";
            this.tbsResreshNapr.Size = new System.Drawing.Size(35, 35);
            this.tbsResreshNapr.Text = "Обновить";
            this.tbsResreshNapr.Click += new System.EventHandler(this.tbsResreshNapr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbImportNapr
            // 
            this.tsbImportNapr.AutoSize = false;
            this.tsbImportNapr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImportNapr.Image = ((System.Drawing.Image)(resources.GetObject("tsbImportNapr.Image")));
            this.tsbImportNapr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImportNapr.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbImportNapr.Name = "tsbImportNapr";
            this.tsbImportNapr.Size = new System.Drawing.Size(35, 35);
            this.tsbImportNapr.Text = "Добавить";
            this.tsbImportNapr.Click += new System.EventHandler(this.tsbImportNapr_Click);
            // 
            // tsbCorrelatePath
            // 
            this.tsbCorrelatePath.AutoSize = false;
            this.tsbCorrelatePath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCorrelatePath.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorrelatePath.Image")));
            this.tsbCorrelatePath.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCorrelatePath.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbCorrelatePath.Name = "tsbCorrelatePath";
            this.tsbCorrelatePath.Size = new System.Drawing.Size(35, 35);
            this.tsbCorrelatePath.Text = "Соотнести";
            // 
            // tsbShowImage
            // 
            this.tsbShowImage.AutoSize = false;
            this.tsbShowImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShowImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowImage.Image")));
            this.tsbShowImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShowImage.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbShowImage.Name = "tsbShowImage";
            this.tsbShowImage.Size = new System.Drawing.Size(35, 35);
            this.tsbShowImage.Text = "Показать изображение";
            this.tsbShowImage.Click += new System.EventHandler(this.tsbShowImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(35, 35);
            this.tsbDelete.Text = "Удалить";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 48);
            // 
            // tsbLeft
            // 
            this.tsbLeft.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLeft.AutoSize = false;
            this.tsbLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbLeft.Image")));
            this.tsbLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLeft.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbLeft.Name = "tsbLeft";
            this.tsbLeft.Size = new System.Drawing.Size(35, 35);
            this.tsbLeft.Text = "Повернуть против часов";
            this.tsbLeft.Click += new System.EventHandler(this.tsbLeft_Click);
            // 
            // tsbRigth
            // 
            this.tsbRigth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbRigth.AutoSize = false;
            this.tsbRigth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRigth.Image = ((System.Drawing.Image)(resources.GetObject("tsbRigth.Image")));
            this.tsbRigth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRigth.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbRigth.Name = "tsbRigth";
            this.tsbRigth.Size = new System.Drawing.Size(35, 35);
            this.tsbRigth.Text = "Повернуть по часовой";
            this.tsbRigth.Click += new System.EventHandler(this.tsbRigth_Click);
            // 
            // tsbZoom
            // 
            this.tsbZoom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbZoom.AutoSize = false;
            this.tsbZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoom.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoom.Image")));
            this.tsbZoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbZoom.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbZoom.Name = "tsbZoom";
            this.tsbZoom.Size = new System.Drawing.Size(35, 35);
            this.tsbZoom.Text = "Изменение размеров";
            this.tsbZoom.Click += new System.EventHandler(this.tsbZoom_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 215);
            this.panel1.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 48);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1246, 192);
            this.dgvData.TabIndex = 29;
            this.dgvData.VirtualMode = true;
            // 
            // dgvNapr
            // 
            this.dgvNapr.AllowUserToAddRows = false;
            this.dgvNapr.AllowUserToDeleteRows = false;
            this.dgvNapr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNapr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNapr.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNapr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNapr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNapr.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNapr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNapr.Location = new System.Drawing.Point(0, 0);
            this.dgvNapr.Name = "dgvNapr";
            this.dgvNapr.ReadOnly = true;
            this.dgvNapr.RowHeadersVisible = false;
            this.dgvNapr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNapr.Size = new System.Drawing.Size(518, 203);
            this.dgvNapr.TabIndex = 30;
            this.dgvNapr.VirtualMode = true;
            // 
            // fProcDirections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 641);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pFiltr);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.ssStatus);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fProcDirections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка направлений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tsViewPanel.ResumeLayout(false);
            this.tsViewPanel.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNapr)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel sslVersion;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem справочникОрганизацийToolStripMenuItem;
        private System.Windows.Forms.Panel pFiltr;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip tsViewPanel;
        private System.Windows.Forms.ToolStripButton tsnRefresh;
        private System.Windows.Forms.ToolStripSeparator sebRefreshGridItem;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbCorrelate;
        private System.Windows.Forms.ToolStripButton tsbExportList;
        private System.Windows.Forms.ToolStripMenuItem tsmImportKmis;
        private System.Windows.Forms.ToolStripMenuItem tsmImportNapr;
        private System.Windows.Forms.ToolStripMenuItem логToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьСписокНаправленийToolStripMenuItem;
        private DataGridViewEx dgvData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbShowImage;
        private System.Windows.Forms.ToolStripButton tsbCorrelatePath;
        private System.Windows.Forms.ToolStripButton tsbImportNapr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbsResreshNapr;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DataGridViewEx dgvNapr;
        private System.Windows.Forms.PictureBox pbNapr;
        private System.Windows.Forms.ToolStripButton tsbLeft;
        private System.Windows.Forms.ToolStripButton tsbRigth;
        private System.Windows.Forms.ToolStripButton tsbZoom;
        private System.Windows.Forms.Panel panel1;
    }
}

