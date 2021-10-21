namespace ReportGen
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.vREPGENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chFraDataSet = new ReportGen.ChFraDataSet();
            this.vREPGENTableAdapter = new ReportGen.ChFraDataSetTableAdapters.VREPGENTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIDMOVIMIENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ARM_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Armador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ENTREG_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ENTREG_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbPrinter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTotals = new System.Windows.Forms.CheckBox();
            this.lnkSettings = new System.Windows.Forms.LinkLabel();
            this.btnSticker = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAbonos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.chkCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vREPGENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // vREPGENBindingSource
            // 
            this.vREPGENBindingSource.DataMember = "VREPGEN";
            this.vREPGENBindingSource.DataSource = this.chFraDataSet;
            // 
            // chFraDataSet
            // 
            this.chFraDataSet.DataSetName = "ChFraDataSet";
            this.chFraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vREPGENTableAdapter
            // 
            this.vREPGENTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vREPGENBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1503, 598);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colFolio,
            this.colClientes,
            this.colUnidades,
            this.colProducto,
            this.colDetalles1,
            this.colDetalles2,
            this.colTotal,
            this.colCIDMOVIMIENTO,
            this.colHide,
            this.ARM_Fecha,
            this.Armador,
            this.ENTREG_Fecha,
            this.ENTREG_User});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GridView1_RowStyle);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.GridView1_SelectionChanged);
            this.gridView1.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.GridView1_CustomRowFilter);
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MaxWidth = 65;
            this.colFecha.MinWidth = 65;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.FixedWidth = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 65;
            // 
            // colFolio
            // 
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.OptionsColumn.FixedWidth = true;
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 3;
            this.colFolio.Width = 65;
            // 
            // colClientes
            // 
            this.colClientes.FieldName = "Clientes";
            this.colClientes.Name = "colClientes";
            this.colClientes.Visible = true;
            this.colClientes.VisibleIndex = 4;
            this.colClientes.Width = 82;
            // 
            // colUnidades
            // 
            this.colUnidades.DisplayFormat.FormatString = "#,##0.00";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.MaxWidth = 53;
            this.colUnidades.MinWidth = 53;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.OptionsColumn.FixedWidth = true;
            this.colUnidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unidades", "{0:0.##}")});
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 8;
            this.colUnidades.Width = 53;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 5;
            this.colProducto.Width = 93;
            // 
            // colDetalles1
            // 
            this.colDetalles1.FieldName = "Detalles1";
            this.colDetalles1.Name = "colDetalles1";
            this.colDetalles1.OptionsColumn.FixedWidth = true;
            this.colDetalles1.Visible = true;
            this.colDetalles1.VisibleIndex = 6;
            this.colDetalles1.Width = 131;
            // 
            // colDetalles2
            // 
            this.colDetalles2.FieldName = "Detalles2";
            this.colDetalles2.Name = "colDetalles2";
            this.colDetalles2.OptionsColumn.FixedWidth = true;
            this.colDetalles2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Detalles2", "TOTAL")});
            this.colDetalles2.Visible = true;
            this.colDetalles2.VisibleIndex = 7;
            this.colDetalles2.Width = 212;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "\'$\'#,0.00;(\'$\'#,0.00)";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.FixedWidth = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            this.colTotal.Width = 80;
            // 
            // colCIDMOVIMIENTO
            // 
            this.colCIDMOVIMIENTO.Caption = "ID";
            this.colCIDMOVIMIENTO.FieldName = "CIDMOVIMIENTO";
            this.colCIDMOVIMIENTO.MaxWidth = 25;
            this.colCIDMOVIMIENTO.MinWidth = 40;
            this.colCIDMOVIMIENTO.Name = "colCIDMOVIMIENTO";
            this.colCIDMOVIMIENTO.OptionsColumn.FixedWidth = true;
            this.colCIDMOVIMIENTO.Visible = true;
            this.colCIDMOVIMIENTO.VisibleIndex = 1;
            this.colCIDMOVIMIENTO.Width = 25;
            // 
            // colHide
            // 
            this.colHide.Caption = "hidden";
            this.colHide.FieldName = "Hide";
            this.colHide.MinWidth = 10;
            this.colHide.Name = "colHide";
            this.colHide.OptionsColumn.AllowEdit = false;
            this.colHide.OptionsColumn.AllowSize = false;
            this.colHide.OptionsColumn.FixedWidth = true;
            this.colHide.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colHide.Width = 10;
            // 
            // ARM_Fecha
            // 
            this.ARM_Fecha.Caption = "ARM de Fecha";
            this.ARM_Fecha.FieldName = "ARM_Fecha";
            this.ARM_Fecha.MaxWidth = 75;
            this.ARM_Fecha.MinWidth = 75;
            this.ARM_Fecha.Name = "ARM_Fecha";
            this.ARM_Fecha.OptionsColumn.AllowEdit = false;
            this.ARM_Fecha.Visible = true;
            this.ARM_Fecha.VisibleIndex = 10;
            // 
            // Armador
            // 
            this.Armador.Caption = "Armador";
            this.Armador.FieldName = "Armador";
            this.Armador.Name = "Armador";
            this.Armador.OptionsColumn.AllowEdit = false;
            this.Armador.Visible = true;
            this.Armador.VisibleIndex = 11;
            this.Armador.Width = 58;
            // 
            // ENTREG_Fecha
            // 
            this.ENTREG_Fecha.Caption = "ENTRET de Fecha";
            this.ENTREG_Fecha.FieldName = "ENTREG_Fecha";
            this.ENTREG_Fecha.Name = "ENTREG_Fecha";
            this.ENTREG_Fecha.OptionsColumn.AllowEdit = false;
            this.ENTREG_Fecha.Visible = true;
            this.ENTREG_Fecha.VisibleIndex = 12;
            this.ENTREG_Fecha.Width = 58;
            // 
            // ENTREG_User
            // 
            this.ENTREG_User.Caption = "ENTREG";
            this.ENTREG_User.FieldName = "ENTREG_User";
            this.ENTREG_User.Name = "ENTREG_User";
            this.ENTREG_User.OptionsColumn.AllowEdit = false;
            this.ENTREG_User.Visible = true;
            this.ENTREG_User.VisibleIndex = 13;
            this.ENTREG_User.Width = 62;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gridControl1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            this.printableComponentLink1.SkipArea = ((DevExpress.XtraPrinting.BrickModifier)((((((((DevExpress.XtraPrinting.BrickModifier.DetailHeader | DevExpress.XtraPrinting.BrickModifier.DetailFooter) 
            | DevExpress.XtraPrinting.BrickModifier.ReportHeader) 
            | DevExpress.XtraPrinting.BrickModifier.ReportFooter) 
            | DevExpress.XtraPrinting.BrickModifier.MarginalHeader) 
            | DevExpress.XtraPrinting.BrickModifier.MarginalFooter) 
            | DevExpress.XtraPrinting.BrickModifier.InnerPageHeader) 
            | DevExpress.XtraPrinting.BrickModifier.InnerPageFooter)));
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(60, 112);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 32);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Reporte Especial";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(719, 107);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(177, 32);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Filtrar Seleccionados";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(257, 116);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEdit1.Name = "checkEdit1";
            // 
            // 
            // 
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Filtro de Notas";
            this.checkEdit1.Size = new System.Drawing.Size(157, 21);
            this.checkEdit1.TabIndex = 4;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1052, 53);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 17);
            this.linkLabel1.TabIndex = 85;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Usuarios";
            this.linkLabel1.Click += new System.EventHandler(this.LinkLabel1_Click);
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(308, 65);
            this.cmbPrinter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.Size = new System.Drawing.Size(401, 24);
            this.cmbPrinter.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "Printer :";
            // 
            // chkTotals
            // 
            this.chkTotals.AutoSize = true;
            this.chkTotals.Checked = true;
            this.chkTotals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTotals.Location = new System.Drawing.Point(429, 27);
            this.chkTotals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTotals.Name = "chkTotals";
            this.chkTotals.Size = new System.Drawing.Size(105, 21);
            this.chkTotals.TabIndex = 82;
            this.chkTotals.Text = "Quitar Total";
            this.chkTotals.UseVisualStyleBackColor = true;
            this.chkTotals.CheckedChanged += new System.EventHandler(this.chkTotals_CheckedChanged);
            // 
            // lnkSettings
            // 
            this.lnkSettings.AutoSize = true;
            this.lnkSettings.Location = new System.Drawing.Point(1052, 18);
            this.lnkSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Size = new System.Drawing.Size(48, 17);
            this.lnkSettings.TabIndex = 81;
            this.lnkSettings.TabStop = true;
            this.lnkSettings.Text = "Config";
            this.lnkSettings.Visible = false;
            // 
            // btnSticker
            // 
            this.btnSticker.Enabled = false;
            this.btnSticker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSticker.Location = new System.Drawing.Point(719, 59);
            this.btnSticker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSticker.Name = "btnSticker";
            this.btnSticker.Size = new System.Drawing.Size(177, 38);
            this.btnSticker.TabIndex = 80;
            this.btnSticker.Text = "Imp.Etiquetas";
            this.btnSticker.UseVisualStyleBackColor = true;
            this.btnSticker.Click += new System.EventHandler(this.btnSticker_Click);
            this.btnSticker.MouseHover += new System.EventHandler(this.btnSticker_MouseHover);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(719, 17);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(177, 38);
            this.btnReport.TabIndex = 79;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchData.Location = new System.Drawing.Point(577, 17);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(133, 38);
            this.btnFetchData.TabIndex = 78;
            this.btnFetchData.Text = "Mostrar Datos";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.BtnFetchData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "a:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(256, 23);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(157, 22);
            this.dtpToDate.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "De :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(60, 23);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(157, 22);
            this.dtpFromDate.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAbonos);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.btnFetchData);
            this.groupBox1.Controls.Add(this.checkEdit1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cmbPrinter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSticker);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.chkTotals);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lnkSettings);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.checkEdit2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1503, 149);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1289, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 52);
            this.button3.TabIndex = 95;
            this.button3.Text = "PAGOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAbonos
            // 
            this.btnAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonos.Location = new System.Drawing.Point(1289, 79);
            this.btnAbonos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbonos.Name = "btnAbonos";
            this.btnAbonos.Size = new System.Drawing.Size(139, 52);
            this.btnAbonos.TabIndex = 94;
            this.btnAbonos.Text = "ABONOS";
            this.btnAbonos.UseVisualStyleBackColor = true;
            this.btnAbonos.Click += new System.EventHandler(this.btnAbonos_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1143, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 52);
            this.button2.TabIndex = 93;
            this.button2.Text = "PRODUCCION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1143, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 92;
            this.button1.Text = "DEUDORES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(899, 68);
            this.checkEdit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEdit2.Name = "checkEdit2";
            // 
            // 
            // 
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Caption = "";
            this.checkEdit2.Size = new System.Drawing.Size(24, 19);
            this.checkEdit2.TabIndex = 91;
            this.checkEdit2.Visible = false;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(976, 79);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton4.Location = new System.Drawing.Point(976, 107);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(159, 32);
            this.simpleButton4.TabIndex = 89;
            this.simpleButton4.Text = "Cambiar Fecha";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton3.Location = new System.Drawing.Point(569, 107);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(141, 32);
            this.simpleButton3.TabIndex = 87;
            this.simpleButton3.Text = "Todas las Notas";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkCell,
            this.fechaDataGridViewTextBoxColumn,
            this.folioDataGridViewTextBoxColumn,
            this.clientesDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.detalles1DataGridViewTextBoxColumn,
            this.detalles2DataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.vREPGENBindingSource;
            this.dgvData.Location = new System.Drawing.Point(0, 149);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 4;
            this.dgvData.Size = new System.Drawing.Size(1191, 530);
            this.dgvData.TabIndex = 87;
            this.dgvData.Visible = false;
            // 
            // chkCell
            // 
            this.chkCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chkCell.Frozen = true;
            this.chkCell.HeaderText = "";
            this.chkCell.MinimumWidth = 6;
            this.chkCell.Name = "chkCell";
            this.chkCell.Width = 50;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            // 
            // clientesDataGridViewTextBoxColumn
            // 
            this.clientesDataGridViewTextBoxColumn.DataPropertyName = "Clientes";
            this.clientesDataGridViewTextBoxColumn.HeaderText = "Clientes";
            this.clientesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientesDataGridViewTextBoxColumn.Name = "clientesDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // detalles1DataGridViewTextBoxColumn
            // 
            this.detalles1DataGridViewTextBoxColumn.DataPropertyName = "Detalles1";
            this.detalles1DataGridViewTextBoxColumn.HeaderText = "Detalles1";
            this.detalles1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detalles1DataGridViewTextBoxColumn.Name = "detalles1DataGridViewTextBoxColumn";
            // 
            // detalles2DataGridViewTextBoxColumn
            // 
            this.detalles2DataGridViewTextBoxColumn.DataPropertyName = "Detalles2";
            this.detalles2DataGridViewTextBoxColumn.HeaderText = "Detalles2";
            this.detalles2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detalles2DataGridViewTextBoxColumn.Name = "detalles2DataGridViewTextBoxColumn";
            // 
            // unidadesDataGridViewTextBoxColumn
            // 
            this.unidadesDataGridViewTextBoxColumn.DataPropertyName = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadesDataGridViewTextBoxColumn.Name = "unidadesDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 747);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Notas de Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vREPGENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ChFraDataSet chFraDataSet;
        private System.Windows.Forms.BindingSource vREPGENBindingSource;
        private ChFraDataSetTableAdapters.VREPGENTableAdapter vREPGENTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbPrinter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTotals;
        private System.Windows.Forms.LinkLabel lnkSettings;
        private System.Windows.Forms.Button btnSticker;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.Columns.GridColumn colCIDMOVIMIENTO;
        private System.Windows.Forms.DataGridView dgvData;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.Columns.GridColumn colHide;
        private System.Windows.Forms.Button btnAbonos;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraGrid.Columns.GridColumn ARM_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Armador;
        private DevExpress.XtraGrid.Columns.GridColumn ENTREG_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn ENTREG_User;
    }
}