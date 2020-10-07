namespace Centaurus
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigoMarca = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoMarca = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.menuStripMarca = new System.Windows.Forms.MenuStrip();
            this.MenuMarcaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaGravar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxMarcaAtiva = new System.Windows.Forms.CheckBox();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.toolTipMarca = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(9, 64);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código";
            // 
            // textBoxCodigoMarca
            // 
            this.textBoxCodigoMarca.Location = new System.Drawing.Point(12, 80);
            this.textBoxCodigoMarca.Name = "textBoxCodigoMarca";
            this.textBoxCodigoMarca.Size = new System.Drawing.Size(55, 20);
            this.textBoxCodigoMarca.TabIndex = 1;
            this.textBoxCodigoMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoMarca_KeyDown);
            this.textBoxCodigoMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoMarca_KeyPress);
            this.textBoxCodigoMarca.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxCodigoMarca_MouseMove);
            // 
            // textBoxDescricaoMarca
            // 
            this.textBoxDescricaoMarca.Location = new System.Drawing.Point(12, 129);
            this.textBoxDescricaoMarca.Name = "textBoxDescricaoMarca";
            this.textBoxDescricaoMarca.Size = new System.Drawing.Size(165, 20);
            this.textBoxDescricaoMarca.TabIndex = 3;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(9, 113);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descrição";
            // 
            // menuStripMarca
            // 
            this.menuStripMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripMarca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMarcaNovo,
            this.MenuMarcaGravar,
            this.MenuMarcaEditar,
            this.MenuMarcaCancelar,
            this.MenuMarcaExcluir});
            this.menuStripMarca.Location = new System.Drawing.Point(0, 0);
            this.menuStripMarca.Name = "menuStripMarca";
            this.menuStripMarca.Size = new System.Drawing.Size(534, 24);
            this.menuStripMarca.TabIndex = 4;
            this.menuStripMarca.Text = "menuStrip1";
            // 
            // MenuMarcaNovo
            // 
            this.MenuMarcaNovo.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaNovo.Image")));
            this.MenuMarcaNovo.Name = "MenuMarcaNovo";
            this.MenuMarcaNovo.Size = new System.Drawing.Size(69, 20);
            this.MenuMarcaNovo.Text = "NOVO";
            this.MenuMarcaNovo.Click += new System.EventHandler(this.MenuMarcaNovo_Click);
            // 
            // MenuMarcaGravar
            // 
            this.MenuMarcaGravar.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaGravar.Image")));
            this.MenuMarcaGravar.Name = "MenuMarcaGravar";
            this.MenuMarcaGravar.Size = new System.Drawing.Size(78, 20);
            this.MenuMarcaGravar.Text = "GRAVAR";
            this.MenuMarcaGravar.Click += new System.EventHandler(this.MenuMarcaGravar_Click);
            // 
            // MenuMarcaEditar
            // 
            this.MenuMarcaEditar.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaEditar.Image")));
            this.MenuMarcaEditar.Name = "MenuMarcaEditar";
            this.MenuMarcaEditar.Size = new System.Drawing.Size(72, 20);
            this.MenuMarcaEditar.Text = "EDITAR";
            this.MenuMarcaEditar.Click += new System.EventHandler(this.MenuMarcaEditar_Click);
            // 
            // MenuMarcaCancelar
            // 
            this.MenuMarcaCancelar.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaCancelar.Image")));
            this.MenuMarcaCancelar.Name = "MenuMarcaCancelar";
            this.MenuMarcaCancelar.Size = new System.Drawing.Size(95, 20);
            this.MenuMarcaCancelar.Text = "CANCELAR";
            this.MenuMarcaCancelar.Click += new System.EventHandler(this.MenuMarcaCancelar_Click);
            // 
            // MenuMarcaExcluir
            // 
            this.MenuMarcaExcluir.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaExcluir.Image")));
            this.MenuMarcaExcluir.Name = "MenuMarcaExcluir";
            this.MenuMarcaExcluir.Size = new System.Drawing.Size(80, 20);
            this.MenuMarcaExcluir.Text = "EXCLUIR";
            this.MenuMarcaExcluir.Click += new System.EventHandler(this.MenuMarcaExcluir_Click);
            // 
            // checkBoxMarcaAtiva
            // 
            this.checkBoxMarcaAtiva.AutoSize = true;
            this.checkBoxMarcaAtiva.Location = new System.Drawing.Point(12, 39);
            this.checkBoxMarcaAtiva.Name = "checkBoxMarcaAtiva";
            this.checkBoxMarcaAtiva.Size = new System.Drawing.Size(50, 17);
            this.checkBoxMarcaAtiva.TabIndex = 5;
            this.checkBoxMarcaAtiva.Text = "Ativa";
            this.checkBoxMarcaAtiva.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarMarca.Image")));
            this.buttonBuscarMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarMarca.Location = new System.Drawing.Point(73, 80);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(50, 24);
            this.buttonBuscarMarca.TabIndex = 37;
            this.buttonBuscarMarca.UseVisualStyleBackColor = true;
            this.buttonBuscarMarca.Click += new System.EventHandler(this.buttonBuscarParticipante_Click);
            // 
            // toolTipMarca
            // 
            this.toolTipMarca.IsBalloon = true;
            this.toolTipMarca.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMarca.ToolTipTitle = "Atenção...";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.buttonBuscarMarca);
            this.Controls.Add(this.checkBoxMarcaAtiva);
            this.Controls.Add(this.textBoxDescricaoMarca);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxCodigoMarca);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.menuStripMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMarca;
            this.MaximizeBox = false;
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Marca";
            this.menuStripMarca.ResumeLayout(false);
            this.menuStripMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigoMarca;
        private System.Windows.Forms.TextBox textBoxDescricaoMarca;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.MenuStrip menuStripMarca;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaGravar;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaEditar;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaCancelar;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaExcluir;
        private System.Windows.Forms.CheckBox checkBoxMarcaAtiva;
        private System.Windows.Forms.Button buttonBuscarMarca;
        private System.Windows.Forms.ToolTip toolTipMarca;
    }
}