﻿namespace Centaurus.Reports
{
    partial class FrmRelParticipante
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
            this.reportViewerParticipantes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerParticipantes
            // 
            this.reportViewerParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetConexao";
            this.reportViewerParticipantes.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerParticipantes.LocalReport.ReportEmbeddedResource = "Centaurus.Reports.RelParticipante .rdlc";
            this.reportViewerParticipantes.Location = new System.Drawing.Point(0, 0);
            this.reportViewerParticipantes.Name = "reportViewerParticipantes";
            this.reportViewerParticipantes.ServerReport.BearerToken = null;
            this.reportViewerParticipantes.Size = new System.Drawing.Size(752, 450);
            this.reportViewerParticipantes.TabIndex = 0;
            // 
            // FrmRelParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.reportViewerParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRelParticipante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Participantes";
            this.Load += new System.EventHandler(this.FrmTestecs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerParticipantes;
    }
}