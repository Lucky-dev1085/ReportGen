namespace ReportGen
{
    partial class FormDEUDORES
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
            this.DEUDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChFraDataSet = new ReportGen.ChFraDataSet();
            this.deudoresTableAdapter = new ReportGen.ChFraDataSetTableAdapters.DEUDORESTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            //this.admMovimientosPrepolizaTableAdapter1 = new ReportGen.ChFraDataSetTableAdapters.admMovimientosPrepolizaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DEUDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.chFraDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DEUDORESBindingSource
            // 
            this.DEUDORESBindingSource.DataMember = "DEUDORES";
            this.DEUDORESBindingSource.DataSource = this.ChFraDataSet;
            // 
            // ChFraDataSet
            // 
            this.ChFraDataSet.DataSetName = "ChFraDataSet";
            this.ChFraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deudoresTableAdapter
            // 
            this.deudoresTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            //pcg  this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ReportGen.ReportDEUDORES.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            //pcg  this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(701, 409);
            this.reportViewer2.TabIndex = 0;
            // 
            // admMovimientosPrepolizaTableAdapter1
            // 
            //this.admMovimientosPrepolizaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 409);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Notas de Venta";
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDEUDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DEUDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.chFraDataSet1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private ChFraDataSetTableAdapters.DEUDORESTableAdapter deudoresTableAdapter;
        private System.Windows.Forms.BindingSource DEUDORESBindingSource;
        private ChFraDataSet ChFraDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}