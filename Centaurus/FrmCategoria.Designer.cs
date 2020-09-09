namespace Centaurus
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigoCategoria = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCategoriaNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoriaGravar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoriaEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoriaCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategoriaExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCategoriaAtiva = new System.Windows.Forms.CheckBox();
            this.buttonBuscarCategoria = new System.Windows.Forms.Button();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonCategoria = new System.Windows.Forms.RadioButton();
            this.radioButtonSubCategoria = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
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
            // textBoxCodigoCategoria
            // 
            this.textBoxCodigoCategoria.Location = new System.Drawing.Point(12, 80);
            this.textBoxCodigoCategoria.Name = "textBoxCodigoCategoria";
            this.textBoxCodigoCategoria.Size = new System.Drawing.Size(55, 20);
            this.textBoxCodigoCategoria.TabIndex = 1;
            // 
            // textBoxDescricaoCategoria
            // 
            this.textBoxDescricaoCategoria.Location = new System.Drawing.Point(12, 129);
            this.textBoxDescricaoCategoria.Name = "textBoxDescricaoCategoria";
            this.textBoxDescricaoCategoria.Size = new System.Drawing.Size(165, 20);
            this.textBoxDescricaoCategoria.TabIndex = 3;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategoriaNovo,
            this.MenuCategoriaGravar,
            this.MenuCategoriaEditar,
            this.MenuCategoriaCancelar,
            this.MenuCategoriaExcluir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCategoriaNovo
            // 
            this.MenuCategoriaNovo.Image = ((System.Drawing.Image)(resources.GetObject("MenuCategoriaNovo.Image")));
            this.MenuCategoriaNovo.Name = "MenuCategoriaNovo";
            this.MenuCategoriaNovo.Size = new System.Drawing.Size(69, 20);
            this.MenuCategoriaNovo.Text = "NOVO";
            this.MenuCategoriaNovo.Click += new System.EventHandler(this.MenuMarcaNovo_Click);
            // 
            // MenuCategoriaGravar
            // 
            this.MenuCategoriaGravar.Image = ((System.Drawing.Image)(resources.GetObject("MenuCategoriaGravar.Image")));
            this.MenuCategoriaGravar.Name = "MenuCategoriaGravar";
            this.MenuCategoriaGravar.Size = new System.Drawing.Size(78, 20);
            this.MenuCategoriaGravar.Text = "GRAVAR";
            this.MenuCategoriaGravar.Click += new System.EventHandler(this.MenuMarcaGravar_Click);
            // 
            // MenuCategoriaEditar
            // 
            this.MenuCategoriaEditar.Image = ((System.Drawing.Image)(resources.GetObject("MenuCategoriaEditar.Image")));
            this.MenuCategoriaEditar.Name = "MenuCategoriaEditar";
            this.MenuCategoriaEditar.Size = new System.Drawing.Size(72, 20);
            this.MenuCategoriaEditar.Text = "EDITAR";
            this.MenuCategoriaEditar.Click += new System.EventHandler(this.MenuMarcaEditar_Click);
            // 
            // MenuCategoriaCancelar
            // 
            this.MenuCategoriaCancelar.Image = ((System.Drawing.Image)(resources.GetObject("MenuCategoriaCancelar.Image")));
            this.MenuCategoriaCancelar.Name = "MenuCategoriaCancelar";
            this.MenuCategoriaCancelar.Size = new System.Drawing.Size(95, 20);
            this.MenuCategoriaCancelar.Text = "CANCELAR";
            this.MenuCategoriaCancelar.Click += new System.EventHandler(this.MenuMarcaCancelar_Click);
            // 
            // MenuCategoriaExcluir
            // 
            this.MenuCategoriaExcluir.Image = ((System.Drawing.Image)(resources.GetObject("MenuCategoriaExcluir.Image")));
            this.MenuCategoriaExcluir.Name = "MenuCategoriaExcluir";
            this.MenuCategoriaExcluir.Size = new System.Drawing.Size(80, 20);
            this.MenuCategoriaExcluir.Text = "EXCLUIR";
            this.MenuCategoriaExcluir.Click += new System.EventHandler(this.MenuMarcaExcluir_Click);
            // 
            // checkBoxCategoriaAtiva
            // 
            this.checkBoxCategoriaAtiva.AutoSize = true;
            this.checkBoxCategoriaAtiva.Location = new System.Drawing.Point(12, 39);
            this.checkBoxCategoriaAtiva.Name = "checkBoxCategoriaAtiva";
            this.checkBoxCategoriaAtiva.Size = new System.Drawing.Size(50, 17);
            this.checkBoxCategoriaAtiva.TabIndex = 5;
            this.checkBoxCategoriaAtiva.Text = "Ativa";
            this.checkBoxCategoriaAtiva.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarCategoria
            // 
            this.buttonBuscarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCategoria.Image")));
            this.buttonBuscarCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarCategoria.Location = new System.Drawing.Point(73, 80);
            this.buttonBuscarCategoria.Name = "buttonBuscarCategoria";
            this.buttonBuscarCategoria.Size = new System.Drawing.Size(50, 24);
            this.buttonBuscarCategoria.TabIndex = 37;
            this.buttonBuscarCategoria.UseVisualStyleBackColor = true;
            this.buttonBuscarCategoria.Click += new System.EventHandler(this.buttonBuscarParticipante_Click);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonSubCategoria);
            this.groupBoxTipo.Controls.Add(this.radioButtonCategoria);
            this.groupBoxTipo.Location = new System.Drawing.Point(306, 39);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(216, 61);
            this.groupBoxTipo.TabIndex = 38;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Selecione o tipo:";
            // 
            // radioButtonCategoria
            // 
            this.radioButtonCategoria.AutoSize = true;
            this.radioButtonCategoria.Location = new System.Drawing.Point(6, 23);
            this.radioButtonCategoria.Name = "radioButtonCategoria";
            this.radioButtonCategoria.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCategoria.TabIndex = 0;
            this.radioButtonCategoria.TabStop = true;
            this.radioButtonCategoria.Text = "Categoria";
            this.radioButtonCategoria.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubCategoria
            // 
            this.radioButtonSubCategoria.AutoSize = true;
            this.radioButtonSubCategoria.Location = new System.Drawing.Point(110, 25);
            this.radioButtonSubCategoria.Name = "radioButtonSubCategoria";
            this.radioButtonSubCategoria.Size = new System.Drawing.Size(92, 17);
            this.radioButtonSubCategoria.TabIndex = 1;
            this.radioButtonSubCategoria.TabStop = true;
            this.radioButtonSubCategoria.Text = "Sub-Categoria";
            this.radioButtonSubCategoria.UseVisualStyleBackColor = true;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.buttonBuscarCategoria);
            this.Controls.Add(this.checkBoxCategoriaAtiva);
            this.Controls.Add(this.textBoxDescricaoCategoria);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxCodigoCategoria);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias/Sub-Categorias";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigoCategoria;
        private System.Windows.Forms.TextBox textBoxDescricaoCategoria;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoriaNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoriaGravar;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoriaEditar;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoriaCancelar;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoriaExcluir;
        private System.Windows.Forms.CheckBox checkBoxCategoriaAtiva;
        private System.Windows.Forms.Button buttonBuscarCategoria;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonSubCategoria;
        private System.Windows.Forms.RadioButton radioButtonCategoria;
    }
}