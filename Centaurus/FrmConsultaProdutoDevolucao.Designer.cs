namespace Centaurus
{
    partial class FrmConsultaProdutoDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaProdutoDevolucao));
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroDevLocacao = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroDevLocacao = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarDevLocacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelecionarDevLocacao = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewProdutosDevLocacao = new System.Windows.Forms.DataGridView();
            this.textBoxProdutoClicado = new System.Windows.Forms.TextBox();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosDevLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroDevLocacao,
            this.toolStripComboBoxTipoFiltroDevLocacao,
            this.toolStripButtonFiltrarDevLocacao,
            this.toolStripButtonSelecionarDevLocacao});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 49;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroDevLocacao
            // 
            this.toolStripTextBoxFiltroDevLocacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroDevLocacao.Name = "toolStripTextBoxFiltroDevLocacao";
            this.toolStripTextBoxFiltroDevLocacao.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroDevLocacao.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroDevLocacao
            // 
            this.toolStripComboBoxTipoFiltroDevLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroDevLocacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroDevLocacao.Items.AddRange(new object[] {
            "TODOS",
            "CÓDIGO",
            "NOME",
            "CATEGORIA",
            "SUB-CATEGORIA",
            "MARCA",
            "FORNECEDOR",
            "TIPO",
            "INTELIGENTE"});
            this.toolStripComboBoxTipoFiltroDevLocacao.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroDevLocacao.Name = "toolStripComboBoxTipoFiltroDevLocacao";
            this.toolStripComboBoxTipoFiltroDevLocacao.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarDevLocacao
            // 
            this.toolStripButtonFiltrarDevLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarDevLocacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarDevLocacao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarDevLocacao.Image")));
            this.toolStripButtonFiltrarDevLocacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarDevLocacao.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarDevLocacao.Name = "toolStripButtonFiltrarDevLocacao";
            this.toolStripButtonFiltrarDevLocacao.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarDevLocacao.Text = "PESQUISAR";
            // 
            // toolStripButtonSelecionarDevLocacao
            // 
            this.toolStripButtonSelecionarDevLocacao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarDevLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarDevLocacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarDevLocacao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarDevLocacao.Image")));
            this.toolStripButtonSelecionarDevLocacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarDevLocacao.Name = "toolStripButtonSelecionarDevLocacao";
            this.toolStripButtonSelecionarDevLocacao.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarDevLocacao.Text = "SELECIONAR";
            this.toolStripButtonSelecionarDevLocacao.Click += new System.EventHandler(this.toolStripButtonSelecionar_Click);
            // 
            // dataGridViewProdutosDevLocacao
            // 
            this.dataGridViewProdutosDevLocacao.AllowUserToAddRows = false;
            this.dataGridViewProdutosDevLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosDevLocacao.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewProdutosDevLocacao.Name = "dataGridViewProdutosDevLocacao";
            this.dataGridViewProdutosDevLocacao.ReadOnly = true;
            this.dataGridViewProdutosDevLocacao.Size = new System.Drawing.Size(660, 232);
            this.dataGridViewProdutosDevLocacao.TabIndex = 50;
            this.dataGridViewProdutosDevLocacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutosDevLocacao_CellClick);
            // 
            // textBoxProdutoClicado
            // 
            this.textBoxProdutoClicado.Enabled = false;
            this.textBoxProdutoClicado.Location = new System.Drawing.Point(12, 12);
            this.textBoxProdutoClicado.Name = "textBoxProdutoClicado";
            this.textBoxProdutoClicado.Size = new System.Drawing.Size(250, 20);
            this.textBoxProdutoClicado.TabIndex = 51;
            // 
            // FrmConsultaProdutoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.textBoxProdutoClicado);
            this.Controls.Add(this.dataGridViewProdutosDevLocacao);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaProdutoDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produtos";
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosDevLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroDevLocacao;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroDevLocacao;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarDevLocacao;
        private System.Windows.Forms.DataGridView dataGridViewProdutosDevLocacao;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarDevLocacao;
        private System.Windows.Forms.TextBox textBoxProdutoClicado;
    }
}