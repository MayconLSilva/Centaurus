
namespace Centaurus.Reports
{
    partial class FrmRelMarca
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
            this.reportViewerMarca = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MarcaModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaModeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerMarca
            // 
            this.reportViewerMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRelMarca";
            reportDataSource1.Value = this.MarcaModeloBindingSource;
            this.reportViewerMarca.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerMarca.LocalReport.ReportEmbeddedResource = "Centaurus.Reports.RelMarca.rdlc";
            this.reportViewerMarca.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMarca.Name = "reportViewerMarca";
            this.reportViewerMarca.ServerReport.BearerToken = null;
            this.reportViewerMarca.Size = new System.Drawing.Size(752, 450);
            this.reportViewerMarca.TabIndex = 0;
            // 
            // MarcaModeloBindingSource
            // 
            this.MarcaModeloBindingSource.DataSource = typeof(Centaurus.Model.MarcaModelo);
            // 
            // FrmRelMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.reportViewerMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRelMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Marca";
            this.Load += new System.EventHandler(this.FrmRelMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaModeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMarca;
        private System.Windows.Forms.BindingSource MarcaModeloBindingSource;
    }
}