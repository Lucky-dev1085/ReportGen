namespace ReportGen
{
    partial class frmPaymentTicket
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
            this.VREPGENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChFraDataSet = new ReportGen.ChFraDataSet();
            this.vrepgenTableAdapter1 = new ReportGen.ChFraDataSetTableAdapters.VREPGENTableAdapter();
            this.chFraDataSet1 = new ReportGen.ChFraDataSet();
            this.VREPGENTableAdapter = new ReportGen.ChFraDataSetTableAdapters.VREPGENTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.admMovimientosPrepolizaTableAdapter1 = new ReportGen.ChFraDataSetTableAdapters.admMovimientosPrepolizaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VREPGENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VREPGENBindingSource
            // 
            this.VREPGENBindingSource.DataMember = "VREPGEN";
            this.VREPGENBindingSource.DataSource = this.ChFraDataSet;
            // 
            // ChFraDataSet
            // 
            this.ChFraDataSet.DataSetName = "ChFraDataSet";
            this.ChFraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrepgenTableAdapter1
            // 
            this.vrepgenTableAdapter1.ClearBeforeFill = true;
            // 
            // chFraDataSet1
            // 
            this.chFraDataSet1.DataSetName = "ChFraDataSet";
            this.chFraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VREPGENTableAdapter
            // 
            this.VREPGENTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ReportGen.frmPaymentTicket.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1000, 409);
            this.reportViewer2.TabIndex = 0;
            // 
            // admMovimientosPrepolizaTableAdapter1
            // 
            this.admMovimientosPrepolizaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPaymentTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 409);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmPaymentTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Notas de Venta";
            this.Load += new System.EventHandler(this.frmPaymentTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VREPGENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFraDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ChFraDataSetTableAdapters.VREPGENTableAdapter vrepgenTableAdapter1;
        private ChFraDataSet chFraDataSet1;
        private System.Windows.Forms.BindingSource VREPGENBindingSource;
        private ChFraDataSet ChFraDataSet;
        private ChFraDataSetTableAdapters.VREPGENTableAdapter VREPGENTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private ChFraDataSetTableAdapters.admMovimientosPrepolizaTableAdapter admMovimientosPrepolizaTableAdapter1;
    }
}