namespace Centaurus
{
    partial class FrmManutencao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManutencaoBD = new System.Windows.Forms.Label();
            this.labelNomeBD = new System.Windows.Forms.Label();
            this.textBoxNomeBD = new System.Windows.Forms.TextBox();
            this.buttonCriarBD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCriarTabelas = new System.Windows.Forms.Button();
            this.labelManutencaoTabelas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.buttonCriarBD);
            this.panel1.Controls.Add(this.textBoxNomeBD);
            this.panel1.Controls.Add(this.labelNomeBD);
            this.panel1.Controls.Add(this.labelManutencaoBD);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 144);
            this.panel1.TabIndex = 0;
            // 
            // labelManutencaoBD
            // 
            this.labelManutencaoBD.AutoSize = true;
            this.labelManutencaoBD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelManutencaoBD.Location = new System.Drawing.Point(24, 10);
            this.labelManutencaoBD.Name = "labelManutencaoBD";
            this.labelManutencaoBD.Size = new System.Drawing.Size(105, 13);
            this.labelManutencaoBD.TabIndex = 1;
            this.labelManutencaoBD.Text = "| Manutenção do BD";
            // 
            // labelNomeBD
            // 
            this.labelNomeBD.AutoSize = true;
            this.labelNomeBD.Location = new System.Drawing.Point(3, 43);
            this.labelNomeBD.Name = "labelNomeBD";
            this.labelNomeBD.Size = new System.Drawing.Size(53, 13);
            this.labelNomeBD.TabIndex = 1;
            this.labelNomeBD.Text = "Nome BD";
            // 
            // textBoxNomeBD
            // 
            this.textBoxNomeBD.Location = new System.Drawing.Point(6, 59);
            this.textBoxNomeBD.Name = "textBoxNomeBD";
            this.textBoxNomeBD.Size = new System.Drawing.Size(146, 20);
            this.textBoxNomeBD.TabIndex = 1;
            this.textBoxNomeBD.Text = "Centaurus";
            // 
            // buttonCriarBD
            // 
            this.buttonCriarBD.Location = new System.Drawing.Point(6, 99);
            this.buttonCriarBD.Name = "buttonCriarBD";
            this.buttonCriarBD.Size = new System.Drawing.Size(214, 23);
            this.buttonCriarBD.TabIndex = 2;
            this.buttonCriarBD.Text = "OK";
            this.buttonCriarBD.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.buttonCriarTabelas);
            this.panel2.Controls.Add(this.labelManutencaoTabelas);
            this.panel2.Location = new System.Drawing.Point(12, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 138);
            this.panel2.TabIndex = 1;
            // 
            // buttonCriarTabelas
            // 
            this.buttonCriarTabelas.Location = new System.Drawing.Point(6, 99);
            this.buttonCriarTabelas.Name = "buttonCriarTabelas";
            this.buttonCriarTabelas.Size = new System.Drawing.Size(214, 23);
            this.buttonCriarTabelas.TabIndex = 2;
            this.buttonCriarTabelas.Text = "OK";
            this.buttonCriarTabelas.UseVisualStyleBackColor = true;
            // 
            // labelManutencaoTabelas
            // 
            this.labelManutencaoTabelas.AutoSize = true;
            this.labelManutencaoTabelas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelManutencaoTabelas.Location = new System.Drawing.Point(24, 10);
            this.labelManutencaoTabelas.Name = "labelManutencaoTabelas";
            this.labelManutencaoTabelas.Size = new System.Drawing.Size(133, 13);
            this.labelManutencaoTabelas.TabIndex = 1;
            this.labelManutencaoTabelas.Text = "| Manutenção das Tabelas";
            // 
            // FrmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmManutencao";
            this.Text = "Manutenção";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCriarBD;
        private System.Windows.Forms.TextBox textBoxNomeBD;
        private System.Windows.Forms.Label labelNomeBD;
        private System.Windows.Forms.Label labelManutencaoBD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCriarTabelas;
        private System.Windows.Forms.Label labelManutencaoTabelas;
    }
}