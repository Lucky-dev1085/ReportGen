namespace ReportGen
{
    partial class FrmClient
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChFraDataSet = new ReportGen.ChFraDataSet();
            this.VREPGENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VREPGENTableAdapter = new ReportGen.ChFraDataSetTableAdapters.VREPGENTableAdapter();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentTableAdapter = new ReportGen.ChFraDataSetTableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VREPGENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VREPGENBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.PaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportGen.RepClient.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            //pcg  this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChFraDataSet
            // 
            this.ChFraDataSet.DataSetName = "ChFraDataSet";
            this.ChFraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VREPGENBindingSource
            // 
            this.VREPGENBindingSource.DataMember = "VREPGEN";
            this.VREPGENBindingSource.DataSource = this.ChFraDataSet;
            // 
            // VREPGENTableAdapter
            // 
            this.VREPGENTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentBindingSource
            // 
            this.PaymentBindingSource.DataMember = "Payment";
            this.PaymentBindingSource.DataSource = this.ChFraDataSet;
            // 
            // PaymentTableAdapter
            // 
            this.PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmClient";
            this.Text = "FrmClient";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VREPGENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VREPGENBindingSource;
        private ChFraDataSet ChFraDataSet;
        private System.Windows.Forms.BindingSource PaymentBindingSource;
        private ChFraDataSetTableAdapters.VREPGENTableAdapter VREPGENTableAdapter;
        private ChFraDataSetTableAdapters.PaymentTableAdapter PaymentTableAdapter;
    }
}