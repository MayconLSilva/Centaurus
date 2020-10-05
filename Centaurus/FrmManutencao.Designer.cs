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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCriarBD = new System.Windows.Forms.Button();
            this.textBoxNomeBD = new System.Windows.Forms.TextBox();
            this.labelNomeBD = new System.Windows.Forms.Label();
            this.labelManutencaoBD = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCriarTabelas = new System.Windows.Forms.Button();
            this.labelManutencaoTabelas = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPorcentagemProcesso = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelInformacoesProgresso = new System.Windows.Forms.Label();
            this.backgroundWorkerIndeterminada = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonCriarBD);
            this.panel1.Controls.Add(this.textBoxNomeBD);
            this.panel1.Controls.Add(this.labelNomeBD);
            this.panel1.Controls.Add(this.labelManutencaoBD);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 144);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Centaurus.Properties.Resources.bd;
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCriarBD
            // 
            this.buttonCriarBD.Location = new System.Drawing.Point(6, 99);
            this.buttonCriarBD.Name = "buttonCriarBD";
            this.buttonCriarBD.Size = new System.Drawing.Size(214, 23);
            this.buttonCriarBD.TabIndex = 2;
            this.buttonCriarBD.Text = "OK";
            this.buttonCriarBD.UseVisualStyleBackColor = true;
            this.buttonCriarBD.Click += new System.EventHandler(this.buttonCriarBD_Click);
            // 
            // textBoxNomeBD
            // 
            this.textBoxNomeBD.Location = new System.Drawing.Point(6, 59);
            this.textBoxNomeBD.Name = "textBoxNomeBD";
            this.textBoxNomeBD.Size = new System.Drawing.Size(146, 20);
            this.textBoxNomeBD.TabIndex = 1;
            this.textBoxNomeBD.Text = "Centaurus";
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
            // labelManutencaoBD
            // 
            this.labelManutencaoBD.AutoSize = true;
            this.labelManutencaoBD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelManutencaoBD.Location = new System.Drawing.Point(47, 15);
            this.labelManutencaoBD.Name = "labelManutencaoBD";
            this.labelManutencaoBD.Size = new System.Drawing.Size(105, 13);
            this.labelManutencaoBD.TabIndex = 1;
            this.labelManutencaoBD.Text = "| Manutenção do BD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.buttonCriarTabelas);
            this.panel2.Controls.Add(this.labelManutencaoTabelas);
            this.panel2.Location = new System.Drawing.Point(12, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 138);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Centaurus.Properties.Resources.table_grid_icon_icons_com_73384;
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCriarTabelas
            // 
            this.buttonCriarTabelas.Location = new System.Drawing.Point(6, 99);
            this.buttonCriarTabelas.Name = "buttonCriarTabelas";
            this.buttonCriarTabelas.Size = new System.Drawing.Size(214, 23);
            this.buttonCriarTabelas.TabIndex = 2;
            this.buttonCriarTabelas.Text = "OK";
            this.buttonCriarTabelas.UseVisualStyleBackColor = true;
            this.buttonCriarTabelas.Click += new System.EventHandler(this.buttonCriarTabelas_Click);
            // 
            // labelManutencaoTabelas
            // 
            this.labelManutencaoTabelas.AutoSize = true;
            this.labelManutencaoTabelas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelManutencaoTabelas.Location = new System.Drawing.Point(47, 16);
            this.labelManutencaoTabelas.Name = "labelManutencaoTabelas";
            this.labelManutencaoTabelas.Size = new System.Drawing.Size(133, 13);
            this.labelManutencaoTabelas.TabIndex = 1;
            this.labelManutencaoTabelas.Text = "| Manutenção das Tabelas";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 446);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(695, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // labelPorcentagemProcesso
            // 
            this.labelPorcentagemProcesso.AutoSize = true;
            this.labelPorcentagemProcesso.Location = new System.Drawing.Point(713, 452);
            this.labelPorcentagemProcesso.Name = "labelPorcentagemProcesso";
            this.labelPorcentagemProcesso.Size = new System.Drawing.Size(35, 13);
            this.labelPorcentagemProcesso.TabIndex = 3;
            this.labelPorcentagemProcesso.Text = "label1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelInformacoesProgresso
            // 
            this.labelInformacoesProgresso.AutoSize = true;
            this.labelInformacoesProgresso.Location = new System.Drawing.Point(9, 430);
            this.labelInformacoesProgresso.Name = "labelInformacoesProgresso";
            this.labelInformacoesProgresso.Size = new System.Drawing.Size(35, 13);
            this.labelInformacoesProgresso.TabIndex = 4;
            this.labelInformacoesProgresso.Text = "label2";
            // 
            // FrmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 481);
            this.Controls.Add(this.labelInformacoesProgresso);
            this.Controls.Add(this.labelPorcentagemProcesso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmManutencao";
            this.Text = "Manutenção";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelPorcentagemProcesso;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelInformacoesProgresso;
        private System.ComponentModel.BackgroundWorker backgroundWorkerIndeterminada;
    }
}