namespace ReportGen
{
    partial class NewAbonosForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAbonos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dEUDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chFraDataSet = new ReportGen.ChFraDataSet();
            this.dEUDORESTableAdapter = new ReportGen.ChFraDataSetTableAdapters.DEUDORESTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chFraDataSet2 = new ReportGen.ChFraDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentTableAdapter2 = new ReportGen.ChFraDataSetTableAdapters.PaymentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEUDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAbonos);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnFetchData);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 102);
            this.panel2.TabIndex = 2;
            // 
            // btnAbonos
            // 
            this.btnAbonos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonos.Location = new System.Drawing.Point(579, 54);
            this.btnAbonos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAbonos.Name = "btnAbonos";
            this.btnAbonos.Size = new System.Drawing.Size(133, 31);
            this.btnAbonos.TabIndex = 89;
            this.btnAbonos.Text = "ABONOS POR DIA/S";
            this.btnAbonos.UseVisualStyleBackColor = true;
            this.btnAbonos.Visible = false;
            this.btnAbonos.Click += new System.EventHandler(this.btnAbonos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "a :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "De :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "a :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "De :";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(466, 112);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 31);
            this.button4.TabIndex = 84;
            this.button4.Text = "Top Saldo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(260, 112);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 31);
            this.button3.TabIndex = 83;
            this.button3.Text = "Top Payments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 31);
            this.button2.TabIndex = 82;
            this.button2.Text = "Top Buyers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(579, 10);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(133, 31);
            this.btnReport.TabIndex = 81;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(435, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 80;
            this.button1.Text = "Mostrar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchData.Location = new System.Drawing.Point(435, 10);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(100, 31);
            this.btnFetchData.TabIndex = 79;
            this.btnFetchData.Text = "Mostrar Datos";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_keypress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_keypress);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(261, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dEUDORESBindingSource
            // 
            this.dEUDORESBindingSource.DataMember = "DEUDORES";
            this.dEUDORESBindingSource.DataSource = this.chFraDataSet;
            // 
            // chFraDataSet
            // 
            this.chFraDataSet.DataSetName = "ChFraDataSet";
            this.chFraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEUDORESTableAdapter
            // 
            this.dEUDORESTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.paymentBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(0, 102);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(948, 408);
            this.gridControl2.TabIndex = 24;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.chFraDataSet2;
            this.paymentBindingSource.Sort = "FechaN ASC,ClientesN ASC";
            // 
            // chFraDataSet2
            // 
            this.chFraDataSet2.DataSetName = "ChFraDataSet";
            this.chFraDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
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
            this.colTotalN});
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
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colFolioN
            // 
            this.colFolioN.Caption = "Folio";
            this.colFolioN.DisplayFormat.FormatString = "0;(0)";
            this.colFolioN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFolioN.FieldName = "FolioN";
            this.colFolioN.MaxWidth = 55;
            this.colFolioN.MinWidth = 55;
            this.colFolioN.Name = "colFolioN";
            this.colFolioN.OptionsColumn.AllowEdit = false;
            this.colFolioN.OptionsColumn.FixedWidth = true;
            this.colFolioN.Visible = true;
            this.colFolioN.VisibleIndex = 1;
            this.colFolioN.Width = 55;
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
            this.colClientesN.VisibleIndex = 2;
            this.colClientesN.Width = 244;
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
            this.colPayment.VisibleIndex = 3;
            this.colPayment.Width = 122;
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
            this.colObservations.OptionsColumn.AllowEdit = false;
            this.colObservations.Visible = true;
            this.colObservations.VisibleIndex = 4;
            this.colObservations.Width = 412;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Abonos";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total";
            // 
            // paymentTableAdapter2
            // 
            this.paymentTableAdapter2.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(465, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(659, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 33;
            // 
            // NewAbonosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 573);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panel2);
            this.Name = "NewAbonosForm";
            this.Text = "ABONOS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEUDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource dEUDORESBindingSource;
        private ChFraDataSet chFraDataSet;
        private ChFraDataSetTableAdapters.DEUDORESTableAdapter dEUDORESTableAdapter;
        private System.Windows.Forms.Button btnAbonos;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioN;
        private DevExpress.XtraGrid.Columns.GridColumn colClientesN;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaN;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;
        private DevExpress.XtraGrid.Columns.GridColumn colObservations;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadesN;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoN;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles1N;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalles21;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private ChFraDataSet chFraDataSet2;
        private ChFraDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}