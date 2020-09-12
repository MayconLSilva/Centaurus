namespace Centaurus
{
    partial class FrmDialogDesconto_Locacao
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
            this.textBoxDescontoDadoValor_dialogDesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescontoDadoPorcentagem_dialogDesconto = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescontoDadoValor_dialogDesconto
            // 
            this.textBoxDescontoDadoValor_dialogDesconto.Location = new System.Drawing.Point(15, 41);
            this.textBoxDescontoDadoValor_dialogDesconto.MaxLength = 10;
            this.textBoxDescontoDadoValor_dialogDesconto.Name = "textBoxDescontoDadoValor_dialogDesconto";
            this.textBoxDescontoDadoValor_dialogDesconto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescontoDadoValor_dialogDesconto.TabIndex = 0;
            this.textBoxDescontoDadoValor_dialogDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescontoDadoValor_dialogDesconto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha e informe o desconto que deseja utilizar!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desconto em valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desconto em %";
            // 
            // textBoxDescontoDadoPorcentagem_dialogDesconto
            // 
            this.textBoxDescontoDadoPorcentagem_dialogDesconto.Location = new System.Drawing.Point(15, 82);
            this.textBoxDescontoDadoPorcentagem_dialogDesconto.MaxLength = 10;
            this.textBoxDescontoDadoPorcentagem_dialogDesconto.Name = "textBoxDescontoDadoPorcentagem_dialogDesconto";
            this.textBoxDescontoDadoPorcentagem_dialogDesconto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescontoDadoPorcentagem_dialogDesconto.TabIndex = 3;
            this.textBoxDescontoDadoPorcentagem_dialogDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescontoDadoPorcentagem_dialogDesconto_KeyPress);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(294, 79);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FrmDialogDesconto_Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 114);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescontoDadoPorcentagem_dialogDesconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescontoDadoValor_dialogDesconto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogDesconto_Locacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDialogDesconto_Locacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxDescontoDadoPorcentagem_dialogDesconto;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxDescontoDadoValor_dialogDesconto;
    }
}