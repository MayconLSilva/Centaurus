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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("PARTICIPANTE");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Marca");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Categoria/Sub-Categoria");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("PRODUTO", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("USUÁRIOS");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Locação");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Dev. Locação");
            this.menuStripUsuarios = new System.Windows.Forms.MenuStrip();
            this.MenuUsuarioNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarioGravar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarioEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarioCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuarioExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.checkBoxUsuarioAtiva = new System.Windows.Forms.CheckBox();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxCodigoUsuario = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonBuscarNomeUsuario = new System.Windows.Forms.Button();
            this.textBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeViewOpcoesUsuario = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipPesquisarPorCodigo = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripUsuarios
            // 
            this.menuStripUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarioNovo,
            this.MenuUsuarioGravar,
            this.MenuUsuarioEditar,
            this.MenuUsuarioCancelar,
            this.MenuUsuarioExcluir});
            this.menuStripUsuarios.Location = new System.Drawing.Point(0, 0);
            this.menuStripUsuarios.Name = "menuStripUsuarios";
            this.menuStripUsuarios.Size = new System.Drawing.Size(494, 24);
            this.menuStripUsuarios.TabIndex = 5;
            this.menuStripUsuarios.Text = "menuStrip1";
            // 
            // MenuUsuarioNovo
            // 
            this.MenuUsuarioNovo.Image = ((System.Drawing.Image)(resources.GetObject("MenuUsuarioNovo.Image")));
            this.MenuUsuarioNovo.Name = "MenuUsuarioNovo";
            this.MenuUsuarioNovo.Size = new System.Drawing.Size(69, 20);
            this.MenuUsuarioNovo.Text = "NOVO";
            this.MenuUsuarioNovo.Click += new System.EventHandler(this.MenuUsuarioNovo_Click);
            // 
            // MenuUsuarioGravar
            // 
            this.MenuUsuarioGravar.Image = ((System.Drawing.Image)(resources.GetObject("MenuUsuarioGravar.Image")));
            this.MenuUsuarioGravar.Name = "MenuUsuarioGravar";
            this.MenuUsuarioGravar.Size = new System.Drawing.Size(78, 20);
            this.MenuUsuarioGravar.Text = "GRAVAR";
            this.MenuUsuarioGravar.Click += new System.EventHandler(this.MenuMarcaGravar_Click);
            // 
            // MenuUsuarioEditar
            // 
            this.MenuUsuarioEditar.Image = ((System.Drawing.Image)(resources.GetObject("MenuUsuarioEditar.Image")));
            this.MenuUsuarioEditar.Name = "MenuUsuarioEditar";
            this.MenuUsuarioEditar.Size = new System.Drawing.Size(72, 20);
            this.MenuUsuarioEditar.Text = "EDITAR";
            this.MenuUsuarioEditar.Click += new System.EventHandler(this.MenuUsuarioEditar_Click);
            // 
            // MenuUsuarioCancelar
            // 
            this.MenuUsuarioCancelar.Image = ((System.Drawing.Image)(resources.GetObject("MenuUsuarioCancelar.Image")));
            this.MenuUsuarioCancelar.Name = "MenuUsuarioCancelar";
            this.MenuUsuarioCancelar.Size = new System.Drawing.Size(95, 20);
            this.MenuUsuarioCancelar.Text = "CANCELAR";
            this.MenuUsuarioCancelar.Click += new System.EventHandler(this.MenuUsuarioCancelar_Click);
            // 
            // MenuUsuarioExcluir
            // 
            this.MenuUsuarioExcluir.Image = ((System.Drawing.Image)(resources.GetObject("MenuUsuarioExcluir.Image")));
            this.MenuUsuarioExcluir.Name = "MenuUsuarioExcluir";
            this.MenuUsuarioExcluir.Size = new System.Drawing.Size(80, 20);
            this.MenuUsuarioExcluir.Text = "EXCLUIR";
            this.MenuUsuarioExcluir.Click += new System.EventHandler(this.MenuUsuarioExcluir_Click);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarUsuario.Image")));
            this.buttonBuscarUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(76, 75);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(25, 24);
            this.buttonBuscarUsuario.TabIndex = 43;
            this.buttonBuscarUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // checkBoxUsuarioAtiva
            // 
            this.checkBoxUsuarioAtiva.AutoSize = true;
            this.checkBoxUsuarioAtiva.Location = new System.Drawing.Point(15, 34);
            this.checkBoxUsuarioAtiva.Name = "checkBoxUsuarioAtiva";
            this.checkBoxUsuarioAtiva.Size = new System.Drawing.Size(50, 17);
            this.checkBoxUsuarioAtiva.TabIndex = 42;
            this.checkBoxUsuarioAtiva.Text = "Ativo";
            this.checkBoxUsuarioAtiva.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(15, 120);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(165, 20);
            this.textBoxNomeUsuario.TabIndex = 41;
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
            // textBoxCodigoUsuario
            // 
            this.textBoxCodigoUsuario.Location = new System.Drawing.Point(15, 75);
            this.textBoxCodigoUsuario.Name = "textBoxCodigoUsuario";
            this.textBoxCodigoUsuario.Size = new System.Drawing.Size(55, 20);
            this.textBoxCodigoUsuario.TabIndex = 39;
            this.textBoxCodigoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCodigoUsuario_KeyDown);
            this.textBoxCodigoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoUsuario_KeyPress);
            this.textBoxCodigoUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxCodigoUsuario_MouseMove);
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
            // buttonBuscarNomeUsuario
            // 
            this.buttonBuscarNomeUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarNomeUsuario.Image")));
            this.buttonBuscarNomeUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarNomeUsuario.Location = new System.Drawing.Point(186, 117);
            this.buttonBuscarNomeUsuario.Name = "buttonBuscarNomeUsuario";
            this.buttonBuscarNomeUsuario.Size = new System.Drawing.Size(25, 24);
            this.buttonBuscarNomeUsuario.TabIndex = 44;
            this.buttonBuscarNomeUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarNomeUsuario.Click += new System.EventHandler(this.buttonBuscarNomeUsuario_Click);
            // 
            // textBoxLoginUsuario
            // 
            this.textBoxLoginUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLoginUsuario.Location = new System.Drawing.Point(15, 163);
            this.textBoxLoginUsuario.Name = "textBoxLoginUsuario";
            this.textBoxLoginUsuario.Size = new System.Drawing.Size(165, 20);
            this.textBoxLoginUsuario.TabIndex = 46;
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
            // textBoxSenhaUsuario
            // 
            this.textBoxSenhaUsuario.Location = new System.Drawing.Point(15, 208);
            this.textBoxSenhaUsuario.Name = "textBoxSenhaUsuario";
            this.textBoxSenhaUsuario.PasswordChar = '*';
            this.textBoxSenhaUsuario.Size = new System.Drawing.Size(165, 20);
            this.textBoxSenhaUsuario.TabIndex = 48;
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
            this.treeViewOpcoesUsuario.Location = new System.Drawing.Point(3, 3);
            this.treeViewOpcoesUsuario.Name = "treeViewOpcoesUsuario";
            treeNode1.Name = "btnParticipante";
            treeNode1.Text = "PARTICIPANTE";
            treeNode2.Name = "btnProduto";
            treeNode2.Text = "Produto";
            treeNode3.Name = "btnMarca";
            treeNode3.Text = "Marca";
            treeNode4.Name = "btnCategoriaSubCategoria";
            treeNode4.Text = "Categoria/Sub-Categoria";
            treeNode5.Name = "btnGrupoProduto";
            treeNode5.Text = "PRODUTO";
            treeNode6.Name = "btnUsuarios";
            treeNode6.Text = "USUÁRIOS";
            treeNode7.Name = "btnLocacao";
            treeNode7.Text = "Locação";
            treeNode8.Name = "btnDevLocacao";
            treeNode8.Text = "Dev. Locação";
            this.treeViewOpcoesUsuario.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeViewOpcoesUsuario.Size = new System.Drawing.Size(207, 269);
            this.treeViewOpcoesUsuario.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.treeViewOpcoesUsuario);
            this.panel1.Location = new System.Drawing.Point(269, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 275);
            this.panel1.TabIndex = 52;
            // 
            // toolTipPesquisarPorCodigo
            // 
            this.toolTipPesquisarPorCodigo.IsBalloon = true;
            this.toolTipPesquisarPorCodigo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPesquisarPorCodigo.ToolTipTitle = "Pesquisa..";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSenhaUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLoginUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarNomeUsuario);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.checkBoxUsuarioAtiva);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxCodigoUsuario);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.menuStripUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.menuStripUsuarios.ResumeLayout(false);
            this.menuStripUsuarios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarioNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarioGravar;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarioEditar;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarioCancelar;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuarioExcluir;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.CheckBox checkBoxUsuarioAtiva;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxCodigoUsuario;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonBuscarNomeUsuario;
        private System.Windows.Forms.TextBox textBoxLoginUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenhaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeViewOpcoesUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipPesquisarPorCodigo;
    }
}