namespace ReportGen
{
    partial class FrmPagos
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
            System.Windows.Forms.Label clientesNLabel;
            System.Windows.Forms.Label fechaNLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label folioNLabel;
            System.Windows.Forms.Label observationsLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cRAZONSOCIALLabel;
            this.vREPGENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chFraDataSet = new ReportGen.ChFraDataSet();
            this.clientesNTextBox = new System.Windows.Forms.TextBox();
            this.fechaNDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.observationsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioPagoN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Recibio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientesN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservations = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadesN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles1N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.vREPGENTableAdapter = new ReportGen.ChFraDataSetTableAdapters.VREPGENTableAdapter();
            this.paymentTableAdapter = new ReportGen.ChFraDataSetTableAdapters.PaymentTableAdapter();
            this.folioNComboBox = new System.Windows.Forms.TextBox();
            this.admClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admClientesTableAdapter = new ReportGen.ChFraDataSetTableAdapters.admClientesTableAdapter();
            this.tableAdapterManager = new ReportGen.ChFraDataSetTableAdapters.TableAdapterManager();
            this.cRAZONSOCIALComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalles2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPrinter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaTime = new DevExpress.XtraGrid.Columns.GridColumn();
            clientesNLabel = new System.Windows.Forms.Label();
            fechaNLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            folioNLabel = new System.Windows.Forms.Label();
            observationsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cRAZONSOCIALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vREPGENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesNLabel
            // 
            clientesNLabel.AutoSize = true;
            clientesNLabel.Location = new System.Drawing.Point(20, 15);
            clientesNLabel.Name = "clientesNLabel";
            clientesNLabel.Size = new System.Drawing.Size(39, 13);
            clientesNLabel.TabIndex = 3;
            clientesNLabel.Text = "Cliente";
            // 
            // fechaNLabel
            // 
            fechaNLabel.AutoSize = true;
            fechaNLabel.Location = new System.Drawing.Point(27, 58);
            fechaNLabel.Name = "fechaNLabel";
            fechaNLabel.Size = new System.Drawing.Size(37, 13);
            fechaNLabel.TabIndex = 4;
            fechaNLabel.Text = "Fecha";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(278, 58);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(38, 13);
            paymentLabel.TabIndex = 6;
            paymentLabel.Text = "Abono";
            // 
            // folioNLabel
            // 
            folioNLabel.AutoSize = true;
            folioNLabel.Location = new System.Drawing.Point(460, 57);
            folioNLabel.Name = "folioNLabel";
            folioNLabel.Size = new System.Drawing.Size(29, 13);
            folioNLabel.TabIndex = 8;
            folioNLabel.Text = "Folio";
            // 
            // observationsLabel
            // 
            observationsLabel.AutoSize = true;
            observationsLabel.Location = new System.Drawing.Point(8, 99);
            observationsLabel.Name = "observationsLabel";
            observationsLabel.Size = new System.Drawing.Size(81, 13);
            observationsLabel.TabIndex = 10;
            observationsLabel.Text = "Observaciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 169);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 13;
            label1.Text = "Abonos";
            // 
            // cRAZONSOCIALLabel
            // 
            cRAZONSOCIALLabel.AutoSize = true;
            cRAZONSOCIALLabel.Location = new System.Drawing.Point(263, 15);
            cRAZONSOCIALLabel.Name = "cRAZONSOCIALLabel";
            cRAZONSOCIALLabel.Size = new System.Drawing.Size(66, 13);
            cRAZONSOCIALLabel.TabIndex = 26;
            cRAZONSOCIALLabel.Text = "Select Clinet";
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
            // clientesNTextBox
            // 
            this.clientesNTextBox.Location = new System.Drawing.Point(95, 12);
            this.clientesNTextBox.Name = "clientesNTextBox";
            this.clientesNTextBox.ReadOnly = true;
            this.clientesNTextBox.Size = new System.Drawing.Size(159, 20);
            this.clientesNTextBox.TabIndex = 4;
            // 
            // fechaNDateTimePicker
            // 
            this.fechaNDateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.fechaNDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNDateTimePicker.Location = new System.Drawing.Point(95, 55);
            this.fechaNDateTimePicker.Name = "fechaNDateTimePicker";
            this.fechaNDateTimePicker.Size = new System.Drawing.Size(159, 20);
            this.fechaNDateTimePicker.TabIndex = 5;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(335, 55);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTextBox.TabIndex = 7;
            this.paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentTextBox_KeyPress);
            // 
            // observationsTextBox
            // 
            this.observationsTextBox.Location = new System.Drawing.Point(95, 87);
            this.observationsTextBox.Multiline = true;
            this.observationsTextBox.Name = "observationsTextBox";
            this.observationsTextBox.Size = new System.Drawing.Size(797, 37);
            this.observationsTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar Abono";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Abonos";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Saldo";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.paymentBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(11, 190);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(889, 194);
            this.gridControl2.TabIndex = 23;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.chFraDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFolioPagoN,
            this.Recibio,
            this.colFolioN,
            this.colClientesN,
            this.colFechaN,
            this.colPayment,
            this.colBalance,
            this.colObservations,
            this.colUnidadesN,
            this.colProductoN,
            this.colDetalles1N,
            this.colDetalles21,
            this.colTotalN,
            this.FechaTime});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView2.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridcontrol2_cellValueChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colFolioPagoN
            // 
            this.colFolioPagoN.Caption = "Folio Pago";
            this.colFolioPagoN.DisplayFormat.FormatString = "0;(0)";
            this.colFolioPagoN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFolioPagoN.FieldName = "FolioPago";
            this.colFolioPagoN.MaxWidth = 60;
            this.colFolioPagoN.MinWidth = 35;
            this.colFolioPagoN.Name = "colFolioPagoN";
            this.colFolioPagoN.OptionsColumn.AllowEdit = false;
            this.colFolioPagoN.Visible = true;
            this.colFolioPagoN.VisibleIndex = 2;
            this.colFolioPagoN.Width = 60;
            // 
            // Recibio
            // 
            this.Recibio.Caption = "Recibio";
            this.Recibio.FieldName = "Recibio";
            this.Recibio.Name = "Recibio";
            this.Recibio.OptionsColumn.AllowEdit = false;
            this.Recibio.Visible = true;
            this.Recibio.VisibleIndex = 1;
            this.Recibio.Width = 93;
            // 
            // colFolioN
            // 
            this.colFolioN.Caption = "Folio";
            this.colFolioN.DisplayFormat.FormatString = "0;(0)";
            this.colFolioN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFolioN.FieldName = "FolioN";
            this.colFolioN.MaxWidth = 45;
            this.colFolioN.MinWidth = 45;
            this.colFolioN.Name = "colFolioN";
            this.colFolioN.OptionsColumn.AllowEdit = false;
            this.colFolioN.OptionsColumn.FixedWidth = true;
            this.colFolioN.Visible = true;
            this.colFolioN.VisibleIndex = 3;
            this.colFolioN.Width = 45;
            // 
            // colClientesN
            // 
            this.colClientesN.Caption = "Cliente";
            this.colClientesN.FieldName = "ClientesN";
            this.colClientesN.Name = "colClientesN";
            this.colClientesN.OptionsColumn.AllowEdit = false;
            this.colClientesN.OptionsColumn.FixedWidth = true;
            this.colClientesN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "ClientesN", "TOTAL")});
            this.colClientesN.Visible = true;
            this.colClientesN.VisibleIndex = 4;
            this.colClientesN.Width = 224;
            // 
            // colFechaN
            // 
            this.colFechaN.Caption = "Fecha";
            this.colFechaN.FieldName = "FechaN";
            this.colFechaN.Name = "colFechaN";
            this.colFechaN.OptionsColumn.AllowEdit = false;
            this.colFechaN.OptionsColumn.FixedWidth = true;
            this.colFechaN.Visible = true;
            this.colFechaN.VisibleIndex = 0;
            this.colFechaN.Width = 97;
            // 
            // colPayment
            // 
            this.colPayment.Caption = "Abonos";
            this.colPayment.DisplayFormat.FormatString = "0,0.00";
            this.colPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPayment.FieldName = "Payment";
            this.colPayment.Name = "colPayment";
            this.colPayment.OptionsColumn.AllowEdit = false;
            this.colPayment.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", "{0:c}")});
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 5;
            this.colPayment.Width = 79;
            // 
            // colBalance
            // 
            this.colBalance.Caption = "Balance";
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance", "SUM:=  {0:n2}")});
            // 
            // colObservations
            // 
            this.colObservations.Caption = "Observaciones";
            this.colObservations.FieldName = "Observations";
            this.colObservations.Name = "colObservations";
            this.colObservations.Visible = true;
            this.colObservations.VisibleIndex = 6;
            this.colObservations.Width = 273;
            // 
            // colUnidadesN
            // 
            this.colUnidadesN.Caption = "Unidades";
            this.colUnidadesN.FieldName = "UnidadesN";
            this.colUnidadesN.Name = "colUnidadesN";
            // 
            // colProductoN
            // 
            this.colProductoN.FieldName = "ProductoN";
            this.colProductoN.Name = "colProductoN";
            // 
            // colDetalles1N
            // 
            this.colDetalles1N.FieldName = "Detalles1N";
            this.colDetalles1N.Name = "colDetalles1N";
            // 
            // colDetalles21
            // 
            this.colDetalles21.FieldName = "Detalles2";
            this.colDetalles21.Name = "colDetalles21";
            // 
            // colTotalN
            // 
            this.colTotalN.FieldName = "TotalN";
            this.colTotalN.Name = "colTotalN";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 33);
            this.button2.TabIndex = 24;
            this.button2.Text = "Borrar Abono Seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(723, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 32);
            this.button4.TabIndex = 25;
            this.button4.Text = "Guardar y Calcular Saldo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // vREPGENTableAdapter
            // 
            this.vREPGENTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // folioNComboBox
            // 
            this.folioNComboBox.Location = new System.Drawing.Point(509, 55);
            this.folioNComboBox.Name = "folioNComboBox";
            this.folioNComboBox.Size = new System.Drawing.Size(100, 20);
            this.folioNComboBox.TabIndex = 26;
            this.folioNComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admClientesBindingSource
            // 
            this.admClientesBindingSource.DataMember = "admClientes";
            this.admClientesBindingSource.DataSource = this.chFraDataSet;
            // 
            // admClientesTableAdapter
            // 
            this.admClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admAcumuladosTableAdapter = null;
            this.tableAdapterManager.admAcumuladosTiposTableAdapter = null;
            this.tableAdapterManager.admAgentesTableAdapter = null;
            this.tableAdapterManager.admAlmacenesTableAdapter = null;
            this.tableAdapterManager.admAsientosContablesTableAdapter = null;
            this.tableAdapterManager.admAsocAcumConceptosTableAdapter = null;
            this.tableAdapterManager.admAsocCargosAbonosTableAdapter = null;
            this.tableAdapterManager.admBanderasTableAdapter = null;
            this.tableAdapterManager.admBitacorasTableAdapter = null;
            this.tableAdapterManager.admCapasProductoTableAdapter = null;
            this.tableAdapterManager.admCaracteristicasTableAdapter = null;
            this.tableAdapterManager.admCaracteristicasValoresTableAdapter = null;
            this.tableAdapterManager.admClasificacionesTableAdapter = null;
            this.tableAdapterManager.admClasificacionesValoresTableAdapter = null;
            this.tableAdapterManager.admClientesTableAdapter = this.admClientesTableAdapter;
            this.tableAdapterManager.admComponentesPaqueteTableAdapter = null;
            this.tableAdapterManager.admConceptosBackTableAdapter = null;
            this.tableAdapterManager.admConceptosTableAdapter = null;
            this.tableAdapterManager.admConversionesUnidadTableAdapter = null;
            this.tableAdapterManager.admCostosHistoricosTableAdapter = null;
            this.tableAdapterManager.admCuentasBancariasTableAdapter = null;
            this.tableAdapterManager.admDatosAddendaTableAdapter = null;
            this.tableAdapterManager.admDocumentosModelosBackTableAdapter = null;
            this.tableAdapterManager.admDocumentosModeloTableAdapter = null;
            this.tableAdapterManager.admDocumentosTableAdapter = null;
            this.tableAdapterManager.admDomiciliosTableAdapter = null;
            this.tableAdapterManager.admEjerciciosTableAdapter = null;
            this.tableAdapterManager.admExistenciaCostoTableAdapter = null;
            this.tableAdapterManager.admFoliosDigitalesTableAdapter = null;
            this.tableAdapterManager.admMaximosMinimosTableAdapter = null;
            this.tableAdapterManager.admMonedasTableAdapter = null;
            this.tableAdapterManager.admMovimientosCapasTableAdapter = null;
            this.tableAdapterManager.admMovimientosContablesTableAdapter = null;
            this.tableAdapterManager.admMovimientosPrepolizaTableAdapter = null;
            this.tableAdapterManager.admMovimientosSerieTableAdapter = null;
            this.tableAdapterManager.admMovimientosTableAdapter = null;
            this.tableAdapterManager.admMovtosBancariosTableAdapter = null;
            this.tableAdapterManager.admMovtosCEPsTableAdapter = null;
            this.tableAdapterManager.admMovtosInvFisicoSerieCaTableAdapter = null;
            this.tableAdapterManager.admMovtosInvFisicoTableAdapter = null;
            this.tableAdapterManager.admNumerosSerieTableAdapter = null;
            this.tableAdapterManager.admParametrosBackTableAdapter = null;
            this.tableAdapterManager.admParametrosTableAdapter = null;
            this.tableAdapterManager.admPreciosCompraTableAdapter = null;
            this.tableAdapterManager.admPrepolizasTableAdapter = null;
            this.tableAdapterManager.admProductosDetallesTableAdapter = null;
            this.tableAdapterManager.admProductosFotosTableAdapter = null;
            this.tableAdapterManager.admProductosTableAdapter = null;
            this.tableAdapterManager.admPromocionesTableAdapter = null;
            this.tableAdapterManager.admProyectosTableAdapter = null;
            this.tableAdapterManager.admSATSegmentosTableAdapter = null;
            this.tableAdapterManager.admTiposCambioTableAdapter = null;
            this.tableAdapterManager.admUnidadesMedidaPesoTableAdapter = null;
            this.tableAdapterManager.admVistasCamposTableAdapter = null;
            this.tableAdapterManager.admVistasConsultasTableAdapter = null;
            this.tableAdapterManager.admVistasPorModuloTableAdapter = null;
            this.tableAdapterManager.admVistasRecursosTableAdapter = null;
            this.tableAdapterManager.admVistasRelacionesTableAdapter = null;
            this.tableAdapterManager.admVistasTablasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.UpdateOrder = ReportGen.ChFraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cRAZONSOCIALComboBox
            // 
            this.cRAZONSOCIALComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cRAZONSOCIALComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admClientesBindingSource, "CRAZONSOCIAL", true));
            this.cRAZONSOCIALComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.admClientesBindingSource, "CRAZONSOCIAL", true));
            this.cRAZONSOCIALComboBox.DataSource = this.admClientesBindingSource;
            this.cRAZONSOCIALComboBox.DisplayMember = "CRAZONSOCIAL";
            this.cRAZONSOCIALComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cRAZONSOCIALComboBox.FormattingEnabled = true;
            this.cRAZONSOCIALComboBox.Location = new System.Drawing.Point(335, 12);
            this.cRAZONSOCIALComboBox.Name = "cRAZONSOCIALComboBox";
            this.cRAZONSOCIALComboBox.Size = new System.Drawing.Size(201, 21);
            this.cRAZONSOCIALComboBox.TabIndex = 27;
            this.cRAZONSOCIALComboBox.ValueMember = "CRAZONSOCIAL";
            this.cRAZONSOCIALComboBox.SelectedIndexChanged += new System.EventHandler(this.cRAZONSOCIALComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(495, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 32);
            this.button3.TabIndex = 29;
            this.button3.Text = "Imprimir Reporte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 32;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vREPGENBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(13, 463);
            this.gridControl1.MainView = this.gridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(889, 194);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl1.Visible = false;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colFolio,
            this.colClientes,
            this.colUnidades,
            this.colProducto,
            this.colDetalles1,
            this.colDetalles2,
            this.colTotal});
            this.gridView.GridControl = this.gridControl1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.FixedWidth = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 70;
            // 
            // colFolio
            // 
            this.colFolio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.OptionsColumn.FixedWidth = true;
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 1;
            this.colFolio.Width = 50;
            // 
            // colClientes
            // 
            this.colClientes.FieldName = "Clientes";
            this.colClientes.Name = "colClientes";
            this.colClientes.OptionsColumn.FixedWidth = true;
            this.colClientes.Visible = true;
            this.colClientes.VisibleIndex = 2;
            this.colClientes.Width = 120;
            // 
            // colUnidades
            // 
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.OptionsColumn.FixedWidth = true;
            this.colUnidades.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Unidades", "{0:0.##}")});
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 6;
            this.colUnidades.Width = 60;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.FixedWidth = true;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 3;
            this.colProducto.Width = 125;
            // 
            // colDetalles1
            // 
            this.colDetalles1.FieldName = "Detalles1";
            this.colDetalles1.Name = "colDetalles1";
            this.colDetalles1.OptionsColumn.FixedWidth = true;
            this.colDetalles1.Visible = true;
            this.colDetalles1.VisibleIndex = 4;
            this.colDetalles1.Width = 170;
            // 
            // colDetalles2
            // 
            this.colDetalles2.FieldName = "Detalles2";
            this.colDetalles2.Name = "colDetalles2";
            this.colDetalles2.OptionsColumn.FixedWidth = true;
            this.colDetalles2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Detalles2", "TOTAL")});
            this.colDetalles2.Visible = true;
            this.colDetalles2.VisibleIndex = 5;
            this.colDetalles2.Width = 210;
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
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 65;
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(95, 138);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.Size = new System.Drawing.Size(302, 21);
            this.cmbPrinter.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Printer :";
            // 
            // FechaTime
            // 
            this.FechaTime.Caption = "FechaTime";
            this.FechaTime.FieldName = "FechaTime";
            this.FechaTime.Name = "FechaTime";
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 489);
            this.Controls.Add(this.cmbPrinter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(cRAZONSOCIALLabel);
            this.Controls.Add(this.cRAZONSOCIALComboBox);
            this.Controls.Add(this.folioNComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(observationsLabel);
            this.Controls.Add(this.observationsTextBox);
            this.Controls.Add(folioNLabel);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(fechaNLabel);
            this.Controls.Add(this.fechaNDateTimePicker);
            this.Controls.Add(clientesNLabel);
            this.Controls.Add(this.clientesNTextBox);
            this.Name = "FrmPagos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPagos_Closing);
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.Shown += new System.EventHandler(this.FrmPagos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.vREPGENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox clientesNTextBox;
        private System.Windows.Forms.DateTimePicker fechaNDateTimePicker;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox observationsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colClientesN;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaN;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioN;
        private DevExpress.XtraGrid.Columns.GridColumn colObservations;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadesN;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoN;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles1N;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles21;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private ChFraDataSet chFraDataSet;
        private System.Windows.Forms.BindingSource vREPGENBindingSource;
        private ChFraDataSetTableAdapters.VREPGENTableAdapter vREPGENTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private ChFraDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.TextBox folioNComboBox;
        private System.Windows.Forms.BindingSource admClientesBindingSource;
        private ChFraDataSetTableAdapters.admClientesTableAdapter admClientesTableAdapter;
        private ChFraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cRAZONSOCIALComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioPagoN;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn Recibio;
        private System.Windows.Forms.ComboBox cmbPrinter;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn FechaTime;
    }
}