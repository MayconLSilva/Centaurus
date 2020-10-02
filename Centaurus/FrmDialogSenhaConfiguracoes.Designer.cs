namespace Centaurus
{
    partial class FrmDialogSenhaConfiguracoes
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
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(96, 46);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(145, 43);
            this.textBoxSenha.MaxLength = 10;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(129, 20);
            this.textBoxSenha.TabIndex = 7;
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(96, 15);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUsuario.Location = new System.Drawing.Point(145, 12);
            this.textBoxUsuario.MaxLength = 10;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(129, 20);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(145, 79);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(129, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FrmDialogSenhaConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 114);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogSenhaConfiguracoes";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSenha;
        public System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonOK;
    }
}