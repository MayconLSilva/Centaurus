namespace Centaurus
{
    partial class FrmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaProduto));
            this.textBoxProdutoClicado = new System.Windows.Forms.TextBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonServico = new System.Windows.Forms.RadioButton();
            this.radioButtonProduto = new System.Windows.Forms.RadioButton();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroProduto = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroProduto = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelecionarProduto = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.groupBoxTipo.SuspendLayout();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxProdutoClicado
            // 
            this.textBoxProdutoClicado.Enabled = false;
            this.textBoxProdutoClicado.Location = new System.Drawing.Point(12, 12);
            this.textBoxProdutoClicado.Name = "textBoxProdutoClicado";
            this.textBoxProdutoClicado.Size = new System.Drawing.Size(250, 20);
            this.textBoxProdutoClicado.TabIndex = 24;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.Size = new System.Drawing.Size(660, 241);
            this.dataGridViewProduto.TabIndex = 23;
            this.dataGridViewProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduto_CellClick);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonTodos);
            this.groupBoxTipo.Controls.Add(this.radioButtonServico);
            this.groupBoxTipo.Controls.Add(this.radioButtonProduto);
            this.groupBoxTipo.Location = new System.Drawing.Point(457, 12);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(215, 51);
            this.groupBoxTipo.TabIndex = 39;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Selecione o tipo:";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(6, 25);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 2;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonServico
            // 
            this.radioButtonServico.AutoSize = true;
            this.radioButtonServico.Location = new System.Drawing.Point(135, 25);
            this.radioButtonServico.Name = "radioButtonServico";
            this.radioButtonServico.Size = new System.Drawing.Size(61, 17);
            this.radioButtonServico.TabIndex = 1;
            this.radioButtonServico.TabStop = true;
            this.radioButtonServico.Text = "Serviço";
            this.radioButtonServico.UseVisualStyleBackColor = true;
            // 
            // radioButtonProduto
            // 
            this.radioButtonProduto.AutoSize = true;
            this.radioButtonProduto.Location = new System.Drawing.Point(67, 25);
            this.radioButtonProduto.Name = "radioButtonProduto";
            this.radioButtonProduto.Size = new System.Drawing.Size(62, 17);
            this.radioButtonProduto.TabIndex = 0;
            this.radioButtonProduto.TabStop = true;
            this.radioButtonProduto.Text = "Produto";
            this.radioButtonProduto.UseVisualStyleBackColor = true;
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 313);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 45;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "label1";
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroProduto,
            this.toolStripComboBoxTipoFiltroProduto,
            this.toolStripButtonFiltrarProduto,
            this.toolStripButtonSelecionarProduto});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 51;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroProduto
            // 
            this.toolStripTextBoxFiltroProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroProduto.Name = "toolStripTextBoxFiltroProduto";
            this.toolStripTextBoxFiltroProduto.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroProduto.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroProduto
            // 
            this.toolStripComboBoxTipoFiltroProduto.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroProduto.Items.AddRange(new object[] {
            "TODOS",
            "CÓDIGO",
            "NOME",
            "CATEGORIA",
            "SUB-CATEGORIA",
            "MARCA",
            "FORNECEDOR",
            "TIPO",
            "INTELIGENTE"});
            this.toolStripComboBoxTipoFiltroProduto.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroProduto.Name = "toolStripComboBoxTipoFiltroProduto";
            this.toolStripComboBoxTipoFiltroProduto.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarProduto
            // 
            this.toolStripButtonFiltrarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarProduto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarProduto.Image")));
            this.toolStripButtonFiltrarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarProduto.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarProduto.Name = "toolStripButtonFiltrarProduto";
            this.toolStripButtonFiltrarProduto.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarProduto.Text = "PESQUISAR";
            this.toolStripButtonFiltrarProduto.Click += new System.EventHandler(this.toolStripButtonFiltrarProduto_Click);
            // 
            // toolStripButtonSelecionarProduto
            // 
            this.toolStripButtonSelecionarProduto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarProduto.Image")));
            this.toolStripButtonSelecionarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarProduto.Name = "toolStripButtonSelecionarProduto";
            this.toolStripButtonSelecionarProduto.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarProduto.Text = "SELECIONAR";
            this.toolStripButtonSelecionarProduto.Click += new System.EventHandler(this.toolStripButtonSelecionarProduto_Click);
            // 
            // FrmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.textBoxProdutoClicado);
            this.Controls.Add(this.dataGridViewProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produto";
            this.Load += new System.EventHandler(this.FrmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxProdutoClicado;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonServico;
        private System.Windows.Forms.RadioButton radioButtonProduto;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroProduto;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroProduto;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarProduto;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarProduto;
    }
}