namespace Centaurus
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuPrincipalCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItemCategoriaSubCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItemMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItemProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItemUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipalMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItemLocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.devLocaçãoToolStripMenuItemDevLocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPrincipalCadastros,
            this.MenuPrincipalMovimentos,
            this.rELATÓRIOSToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(759, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // MenuPrincipalCadastros
            // 
            this.MenuPrincipalCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.usuarioToolStripMenuItemUsuario});
            this.MenuPrincipalCadastros.Name = "MenuPrincipalCadastros";
            this.MenuPrincipalCadastros.Size = new System.Drawing.Size(85, 20);
            this.MenuPrincipalCadastros.Text = "CADASTROS";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Enabled = false;
            this.participantesToolStripMenuItem.Image = global::Centaurus.Properties.Resources.participante;
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.participantesToolStripMenuItem.Text = "Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItemCategoriaSubCategoria,
            this.marcaToolStripMenuItemMarca,
            this.produtoToolStripMenuItemProduto});
            this.produtoToolStripMenuItem.Enabled = false;
            this.produtoToolStripMenuItem.Image = global::Centaurus.Properties.Resources.produto;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // categoriaToolStripMenuItemCategoriaSubCategoria
            // 
            this.categoriaToolStripMenuItemCategoriaSubCategoria.Enabled = false;
            this.categoriaToolStripMenuItemCategoriaSubCategoria.Name = "categoriaToolStripMenuItemCategoriaSubCategoria";
            this.categoriaToolStripMenuItemCategoriaSubCategoria.Size = new System.Drawing.Size(206, 22);
            this.categoriaToolStripMenuItemCategoriaSubCategoria.Text = "Categoria/Sub-Categoria";
            this.categoriaToolStripMenuItemCategoriaSubCategoria.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItemMarca
            // 
            this.marcaToolStripMenuItemMarca.Enabled = false;
            this.marcaToolStripMenuItemMarca.Name = "marcaToolStripMenuItemMarca";
            this.marcaToolStripMenuItemMarca.Size = new System.Drawing.Size(206, 22);
            this.marcaToolStripMenuItemMarca.Text = "Marca";
            this.marcaToolStripMenuItemMarca.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItemProduto
            // 
            this.produtoToolStripMenuItemProduto.Enabled = false;
            this.produtoToolStripMenuItemProduto.Name = "produtoToolStripMenuItemProduto";
            this.produtoToolStripMenuItemProduto.Size = new System.Drawing.Size(206, 22);
            this.produtoToolStripMenuItemProduto.Text = "Produto";
            this.produtoToolStripMenuItemProduto.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItemUsuario
            // 
            this.usuarioToolStripMenuItemUsuario.Enabled = false;
            this.usuarioToolStripMenuItemUsuario.Image = global::Centaurus.Properties.Resources.usuario;
            this.usuarioToolStripMenuItemUsuario.Name = "usuarioToolStripMenuItemUsuario";
            this.usuarioToolStripMenuItemUsuario.Size = new System.Drawing.Size(142, 22);
            this.usuarioToolStripMenuItemUsuario.Text = "Usuarios";
            this.usuarioToolStripMenuItemUsuario.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // MenuPrincipalMovimentos
            // 
            this.MenuPrincipalMovimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaçãoToolStripMenuItemLocacao,
            this.devLocaçãoToolStripMenuItemDevLocacao});
            this.MenuPrincipalMovimentos.Name = "MenuPrincipalMovimentos";
            this.MenuPrincipalMovimentos.Size = new System.Drawing.Size(95, 20);
            this.MenuPrincipalMovimentos.Text = "MOVIMENTOS";
            // 
            // locaçãoToolStripMenuItemLocacao
            // 
            this.locaçãoToolStripMenuItemLocacao.Enabled = false;
            this.locaçãoToolStripMenuItemLocacao.Image = global::Centaurus.Properties.Resources.locacao;
            this.locaçãoToolStripMenuItemLocacao.Name = "locaçãoToolStripMenuItemLocacao";
            this.locaçãoToolStripMenuItemLocacao.Size = new System.Drawing.Size(144, 22);
            this.locaçãoToolStripMenuItemLocacao.Text = "Locação";
            this.locaçãoToolStripMenuItemLocacao.Click += new System.EventHandler(this.locaçãoToolStripMenuItem_Click);
            // 
            // devLocaçãoToolStripMenuItemDevLocacao
            // 
            this.devLocaçãoToolStripMenuItemDevLocacao.Enabled = false;
            this.devLocaçãoToolStripMenuItemDevLocacao.Image = global::Centaurus.Properties.Resources.devlocacao;
            this.devLocaçãoToolStripMenuItemDevLocacao.Name = "devLocaçãoToolStripMenuItemDevLocacao";
            this.devLocaçãoToolStripMenuItemDevLocacao.Size = new System.Drawing.Size(144, 22);
            this.devLocaçãoToolStripMenuItemDevLocacao.Text = "Dev. Locação";
            this.devLocaçãoToolStripMenuItemDevLocacao.Click += new System.EventHandler(this.devLocaçãoToolStripMenuItem_Click);
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem1});
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // participantesToolStripMenuItem1
            // 
            this.participantesToolStripMenuItem1.Name = "participantesToolStripMenuItem1";
            this.participantesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.participantesToolStripMenuItem1.Text = "Participantes";
            this.participantesToolStripMenuItem1.Click += new System.EventHandler(this.participantesToolStripMenuItem1_Click);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 24);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(759, 444);
            this.painelPrincipal.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelUsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(759, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelUsuarioLogado
            // 
            this.labelUsuarioLogado.Name = "labelUsuarioLogado";
            this.labelUsuarioLogado.Size = new System.Drawing.Size(118, 17);
            this.labelUsuarioLogado.Text = "toolStripStatusLabel1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Centaurus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuPrincipalCadastros;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItemCategoriaSubCategoria;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItemMarca;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItemProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuPrincipalMovimentos;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItemLocacao;
        private System.Windows.Forms.ToolStripMenuItem devLocaçãoToolStripMenuItemDevLocacao;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItemUsuario;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelUsuarioLogado;
    }
}

