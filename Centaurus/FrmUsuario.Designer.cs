namespace Centaurus
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMarcaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaGravar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMarcaExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.checkBoxMarcaAtiva = new System.Windows.Forms.CheckBox();
            this.textBoxDescricaoMarca = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxCodigoMarca = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewOpcoesUsuario = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMarcaNovo,
            this.MenuMarcaGravar,
            this.MenuMarcaEditar,
            this.MenuMarcaCancelar,
            this.MenuMarcaExcluir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMarcaNovo
            // 
            this.MenuMarcaNovo.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaNovo.Image")));
            this.MenuMarcaNovo.Name = "MenuMarcaNovo";
            this.MenuMarcaNovo.Size = new System.Drawing.Size(69, 20);
            this.MenuMarcaNovo.Text = "NOVO";
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
            // 
            // MenuMarcaCancelar
            // 
            this.MenuMarcaCancelar.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaCancelar.Image")));
            this.MenuMarcaCancelar.Name = "MenuMarcaCancelar";
            this.MenuMarcaCancelar.Size = new System.Drawing.Size(95, 20);
            this.MenuMarcaCancelar.Text = "CANCELAR";
            // 
            // MenuMarcaExcluir
            // 
            this.MenuMarcaExcluir.Image = ((System.Drawing.Image)(resources.GetObject("MenuMarcaExcluir.Image")));
            this.MenuMarcaExcluir.Name = "MenuMarcaExcluir";
            this.MenuMarcaExcluir.Size = new System.Drawing.Size(80, 20);
            this.MenuMarcaExcluir.Text = "EXCLUIR";
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarMarca.Image")));
            this.buttonBuscarMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarMarca.Location = new System.Drawing.Point(76, 75);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(25, 24);
            this.buttonBuscarMarca.TabIndex = 43;
            this.buttonBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarcaAtiva
            // 
            this.checkBoxMarcaAtiva.AutoSize = true;
            this.checkBoxMarcaAtiva.Location = new System.Drawing.Point(15, 34);
            this.checkBoxMarcaAtiva.Name = "checkBoxMarcaAtiva";
            this.checkBoxMarcaAtiva.Size = new System.Drawing.Size(50, 17);
            this.checkBoxMarcaAtiva.TabIndex = 42;
            this.checkBoxMarcaAtiva.Text = "Ativa";
            this.checkBoxMarcaAtiva.UseVisualStyleBackColor = true;
            // 
            // textBoxDescricaoMarca
            // 
            this.textBoxDescricaoMarca.Location = new System.Drawing.Point(15, 120);
            this.textBoxDescricaoMarca.Name = "textBoxDescricaoMarca";
            this.textBoxDescricaoMarca.Size = new System.Drawing.Size(165, 20);
            this.textBoxDescricaoMarca.TabIndex = 41;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(12, 104);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(35, 13);
            this.labelDescricao.TabIndex = 40;
            this.labelDescricao.Text = "Nome";
            // 
            // textBoxCodigoMarca
            // 
            this.textBoxCodigoMarca.Location = new System.Drawing.Point(15, 75);
            this.textBoxCodigoMarca.Name = "textBoxCodigoMarca";
            this.textBoxCodigoMarca.Size = new System.Drawing.Size(55, 20);
            this.textBoxCodigoMarca.TabIndex = 39;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 59);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 38;
            this.labelCodigo.Text = "Código";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(186, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Login";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Senha";
            // 
            // treeViewOpcoesUsuario
            // 
            this.treeViewOpcoesUsuario.CheckBoxes = true;
            this.treeViewOpcoesUsuario.Location = new System.Drawing.Point(321, 120);
            this.treeViewOpcoesUsuario.Name = "treeViewOpcoesUsuario";
            this.treeViewOpcoesUsuario.Size = new System.Drawing.Size(121, 97);
            this.treeViewOpcoesUsuario.TabIndex = 51;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 481);
            this.Controls.Add(this.treeViewOpcoesUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBuscarMarca);
            this.Controls.Add(this.checkBoxMarcaAtiva);
            this.Controls.Add(this.textBoxDescricaoMarca);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxCodigoMarca);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaGravar;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaEditar;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaCancelar;
        private System.Windows.Forms.ToolStripMenuItem MenuMarcaExcluir;
        private System.Windows.Forms.Button buttonBuscarMarca;
        private System.Windows.Forms.CheckBox checkBoxMarcaAtiva;
        private System.Windows.Forms.TextBox textBoxDescricaoMarca;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxCodigoMarca;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewOpcoesUsuario;
    }
}