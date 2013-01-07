namespace Pizzaria.Tela
{
    partial class PdfGenerator
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
        //    this.rvPdf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CRelatorioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvPdf
            // 
          //  this.rvPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.CRelatorioBindingSource;
           // this.rvPdf.LocalReport.DataSources.Add(reportDataSource1);
           // this.rvPdf.LocalReport.ReportEmbeddedResource = "Pizzaria.ReportView.rdlc";
           // this.rvPdf.Location = new System.Drawing.Point(0, 0);
           // this.rvPdf.Name = "rvPdf";
           // this.rvPdf.Size = new System.Drawing.Size(626, 507);
           // this.rvPdf.TabIndex = 0;
            // 
            // CRelatorioBindingSource
            // 
            this.CRelatorioBindingSource.DataSource = typeof(Pizzaria.Classes.CRelatorio);
            // 
            // PdfGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 507);
           // this.Controls.Add(this.rvPdf);
            this.Name = "PdfGenerator";
            this.Text = "PdfGenerator";
            this.Load += new System.EventHandler(this.PdfGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CRelatorioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

     //   private Microsoft.Reporting.WinForms.ReportViewer rvPdf;
        private System.Windows.Forms.BindingSource CRelatorioBindingSource;
    }
}