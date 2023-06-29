namespace ProcDirection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.sslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.справочникОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportKmis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmImportNapr = new System.Windows.Forms.ToolStripMenuItem();
            this.логToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExportNapr = new System.Windows.Forms.ToolStripMenuItem();
            this.pFiltr = new System.Windows.Forms.Panel();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.lDateOut = new System.Windows.Forms.Label();
            this.lDateIn = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsViewPanel = new System.Windows.Forms.ToolStrip();
            this.tsnRefresh = new System.Windows.Forms.ToolStripButton();
            this.sebRefreshGridItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImportBd = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbCorrelate = new System.Windows.Forms.ToolStripButton();
            this.tsbExportList = new System.Windows.Forms.ToolStripButton();
            this.tsbKolKmis = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pbNapr = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsResreshNapr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImportNapr = new System.Windows.Forms.ToolStripButton();
            this.tsbCorrelatePath = new System.Windows.Forms.ToolStripButton();
            this.tsbShowImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRigth = new System.Windows.Forms.ToolStripButton();
            this.tsbLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbZoom = new System.Windows.Forms.ToolStripButton();
            this.tsbKolNapr = new System.Windows.Forms.ToolStripLabel();
            this.cebIsShow = new System.Windows.Forms.CheckBox();
            this.dgvData = new ProcDirection.DataGridViewEx();
            this.dgvNapr = new ProcDirection.DataGridViewEx();
            this.ssStatus.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.pFiltr.SuspendLayout();
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
            this.tsmExportNapr});
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
            // tsmExportNapr
            // 
            this.tsmExportNapr.Name = "tsmExportNapr";
            this.tsmExportNapr.Size = new System.Drawing.Size(195, 20);
            this.tsmExportNapr.Text = "Выгрузить список направлений";
            this.tsmExportNapr.Click += new System.EventHandler(this.tsmExportNapr_Click);
            // 
            // pFiltr
            // 
            this.pFiltr.Controls.Add(this.cebIsShow);
            this.pFiltr.Controls.Add(this.dtpDateOut);
            this.pFiltr.Controls.Add(this.dtpDateIn);
            this.pFiltr.Controls.Add(this.lDateOut);
            this.pFiltr.Controls.Add(this.lDateIn);
            this.pFiltr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFiltr.Location = new System.Drawing.Point(0, 24);
            this.pFiltr.Name = "pFiltr";
            this.pFiltr.Size = new System.Drawing.Size(1246, 72);
            this.pFiltr.TabIndex = 27;
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOut.Location = new System.Drawing.Point(107, 37);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(200, 22);
            this.dtpDateOut.TabIndex = 3;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIn.Location = new System.Drawing.Point(108, 10);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(200, 22);
            this.dtpDateIn.TabIndex = 2;
            // 
            // lDateOut
            // 
            this.lDateOut.AutoSize = true;
            this.lDateOut.Location = new System.Drawing.Point(12, 44);
            this.lDateOut.Name = "lDateOut";
            this.lDateOut.Size = new System.Drawing.Size(95, 15);
            this.lDateOut.TabIndex = 1;
            this.lDateOut.Text = "Дата окончания";
            // 
            // lDateIn
            // 
            this.lDateIn.AutoSize = true;
            this.lDateIn.Location = new System.Drawing.Point(12, 17);
            this.lDateIn.Name = "lDateIn";
            this.lDateIn.Size = new System.Drawing.Size(73, 15);
            this.lDateIn.TabIndex = 0;
            this.lDateIn.Text = "Дата начала";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 96);
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
            this.splitContainer1.Size = new System.Drawing.Size(1246, 523);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 28;
            // 
            // tsViewPanel
            // 
            this.tsViewPanel.AutoSize = false;
            this.tsViewPanel.BackColor = System.Drawing.Color.Azure;
            this.tsViewPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsnRefresh,
            this.sebRefreshGridItem,
            this.tsbImportBd,
            this.tsbImport,
            this.tsbCorrelate,
            this.tsbExportList,
            this.tsbKolKmis});
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
            // tsbImportBd
            // 
            this.tsbImportBd.AutoSize = false;
            this.tsbImportBd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImportBd.Image = ((System.Drawing.Image)(resources.GetObject("tsbImportBd.Image")));
            this.tsbImportBd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImportBd.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbImportBd.Name = "tsbImportBd";
            this.tsbImportBd.Size = new System.Drawing.Size(35, 35);
            this.tsbImportBd.Text = "Выгрузить из БД";
            this.tsbImportBd.Click += new System.EventHandler(this.tsbImportBd_Click);
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
            this.tsbImport.Text = "Выгрузить из Эксель";
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
            this.tsbCorrelate.Text = "Сравнить";
            this.tsbCorrelate.Click += new System.EventHandler(this.tsbCorrelate_Click);
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
            this.tsbExportList.Text = "Выгрузить в эксель";
            this.tsbExportList.Click += new System.EventHandler(this.tsbExportList_Click);
            // 
            // tsbKolKmis
            // 
            this.tsbKolKmis.Name = "tsbKolKmis";
            this.tsbKolKmis.Size = new System.Drawing.Size(46, 45);
            this.tsbKolKmis.Text = "Кол-во";
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
            this.splitContainer2.Size = new System.Drawing.Size(1246, 218);
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 215);
            this.panel1.TabIndex = 1;
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
            this.tsbZoom,
            this.tsbKolNapr});
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
            this.tsbCorrelatePath.Click += new System.EventHandler(this.tsbCorrelatePath_Click);
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
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 48);
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
            // tsbKolNapr
            // 
            this.tsbKolNapr.Name = "tsbKolNapr";
            this.tsbKolNapr.Size = new System.Drawing.Size(46, 45);
            this.tsbKolNapr.Text = "Кол-во";
            // 
            // cebIsShow
            // 
            this.cebIsShow.AutoSize = true;
            this.cebIsShow.Location = new System.Drawing.Point(323, 15);
            this.cebIsShow.Name = "cebIsShow";
            this.cebIsShow.Size = new System.Drawing.Size(158, 19);
            this.cebIsShow.TabIndex = 4;
            this.cebIsShow.Text = "Показать соотнесенные";
            this.cebIsShow.UseVisualStyleBackColor = true;
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
            this.dgvData.Location = new System.Drawing.Point(0, 48);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1246, 205);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNapr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNapr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNapr.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNapr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNapr.Location = new System.Drawing.Point(0, 0);
            this.dgvNapr.Name = "dgvNapr";
            this.dgvNapr.ReadOnly = true;
            this.dgvNapr.RowHeadersVisible = false;
            this.dgvNapr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNapr.Size = new System.Drawing.Size(518, 218);
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
            this.pFiltr.ResumeLayout(false);
            this.pFiltr.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem tsmExportNapr;
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
        private System.Windows.Forms.ToolStripLabel tsbKolKmis;
        private System.Windows.Forms.ToolStripLabel tsbKolNapr;
        private System.Windows.Forms.ToolStripButton tsbImportBd;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Label lDateOut;
        private System.Windows.Forms.Label lDateIn;
        private System.Windows.Forms.CheckBox cebIsShow;
    }
}

