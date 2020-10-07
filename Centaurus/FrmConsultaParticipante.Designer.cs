namespace Centaurus
{
    partial class FrmConsultaParticipante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaParticipante));
            this.dataGridViewParticipantes = new System.Windows.Forms.DataGridView();
            this.textBoxNomeClicado = new System.Windows.Forms.TextBox();
            this.textBoxCPFCNPJClicado = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefoneClicado = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEnderecoClicado = new System.Windows.Forms.TextBox();
            this.textBoxCidadeClicada = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonFornecedor = new System.Windows.Forms.RadioButton();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroParticipante = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroParticipante = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarParticipante = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelecionarParticipante = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantes)).BeginInit();
            this.groupBoxTipo.SuspendLayout();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewParticipantes
            // 
            this.dataGridViewParticipantes.AllowUserToAddRows = false;
            this.dataGridViewParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipantes.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewParticipantes.Name = "dataGridViewParticipantes";
            this.dataGridViewParticipantes.ReadOnly = true;
            this.dataGridViewParticipantes.Size = new System.Drawing.Size(660, 179);
            this.dataGridViewParticipantes.TabIndex = 0;
            this.dataGridViewParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParticipantes_CellClick);
            // 
            // textBoxNomeClicado
            // 
            this.textBoxNomeClicado.Enabled = false;
            this.textBoxNomeClicado.Location = new System.Drawing.Point(12, 25);
            this.textBoxNomeClicado.Name = "textBoxNomeClicado";
            this.textBoxNomeClicado.Size = new System.Drawing.Size(216, 20);
            this.textBoxNomeClicado.TabIndex = 1;
            // 
            // textBoxCPFCNPJClicado
            // 
            this.textBoxCPFCNPJClicado.Enabled = false;
            this.textBoxCPFCNPJClicado.Location = new System.Drawing.Point(234, 25);
            this.textBoxCPFCNPJClicado.Name = "textBoxCPFCNPJClicado";
            this.textBoxCPFCNPJClicado.Size = new System.Drawing.Size(138, 20);
            this.textBoxCPFCNPJClicado.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome:";
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(231, 9);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(62, 13);
            this.labelCPFCNPJ.TabIndex = 4;
            this.labelCPFCNPJ.Text = "CPF/CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefone:";
            // 
            // textBoxTelefoneClicado
            // 
            this.textBoxTelefoneClicado.Enabled = false;
            this.textBoxTelefoneClicado.Location = new System.Drawing.Point(156, 104);
            this.textBoxTelefoneClicado.Name = "textBoxTelefoneClicado";
            this.textBoxTelefoneClicado.Size = new System.Drawing.Size(138, 20);
            this.textBoxTelefoneClicado.TabIndex = 6;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(9, 48);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 7;
            this.labelEndereco.Text = "Endereço:";
            // 
            // textBoxEnderecoClicado
            // 
            this.textBoxEnderecoClicado.Enabled = false;
            this.textBoxEnderecoClicado.Location = new System.Drawing.Point(12, 64);
            this.textBoxEnderecoClicado.Name = "textBoxEnderecoClicado";
            this.textBoxEnderecoClicado.Size = new System.Drawing.Size(357, 20);
            this.textBoxEnderecoClicado.TabIndex = 8;
            // 
            // textBoxCidadeClicada
            // 
            this.textBoxCidadeClicada.Enabled = false;
            this.textBoxCidadeClicada.Location = new System.Drawing.Point(12, 104);
            this.textBoxCidadeClicada.Name = "textBoxCidadeClicada";
            this.textBoxCidadeClicada.Size = new System.Drawing.Size(138, 20);
            this.textBoxCidadeClicada.TabIndex = 10;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(9, 88);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 9;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 312);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 46;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonFuncionario);
            this.groupBoxTipo.Controls.Add(this.radioButtonTodos);
            this.groupBoxTipo.Controls.Add(this.radioButtonFornecedor);
            this.groupBoxTipo.Controls.Add(this.radioButtonCliente);
            this.groupBoxTipo.Location = new System.Drawing.Point(405, 9);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(276, 51);
            this.groupBoxTipo.TabIndex = 47;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Selecione o tipo:";
            // 
            // radioButtonFuncionario
            // 
            this.radioButtonFuncionario.AutoSize = true;
            this.radioButtonFuncionario.Location = new System.Drawing.Point(196, 25);
            this.radioButtonFuncionario.Name = "radioButtonFuncionario";
            this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFuncionario.TabIndex = 3;
            this.radioButtonFuncionario.TabStop = true;
            this.radioButtonFuncionario.Text = "Funcionario";
            this.radioButtonFuncionario.UseVisualStyleBackColor = true;
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
            // radioButtonFornecedor
            // 
            this.radioButtonFornecedor.AutoSize = true;
            this.radioButtonFornecedor.Location = new System.Drawing.Point(116, 25);
            this.radioButtonFornecedor.Name = "radioButtonFornecedor";
            this.radioButtonFornecedor.Size = new System.Drawing.Size(79, 17);
            this.radioButtonFornecedor.TabIndex = 1;
            this.radioButtonFornecedor.TabStop = true;
            this.radioButtonFornecedor.Text = "Fornecedor";
            this.radioButtonFornecedor.UseVisualStyleBackColor = true;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Location = new System.Drawing.Point(61, 25);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCliente.TabIndex = 0;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroParticipante,
            this.toolStripComboBoxTipoFiltroParticipante,
            this.toolStripButtonFiltrarParticipante,
            this.toolStripButtonSelecionarParticipante});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 48;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroParticipante
            // 
            this.toolStripTextBoxFiltroParticipante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroParticipante.Name = "toolStripTextBoxFiltroParticipante";
            this.toolStripTextBoxFiltroParticipante.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroParticipante.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroParticipante
            // 
            this.toolStripComboBoxTipoFiltroParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroParticipante.Items.AddRange(new object[] {
            "TODOS",
            "NOME",
            "CPF/CNPJ",
            "TELEFONE/CELULAR",
            "INTELIGENTE"});
            this.toolStripComboBoxTipoFiltroParticipante.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroParticipante.Name = "toolStripComboBoxTipoFiltroParticipante";
            this.toolStripComboBoxTipoFiltroParticipante.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarParticipante
            // 
            this.toolStripButtonFiltrarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarParticipante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarParticipante.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarParticipante.Image")));
            this.toolStripButtonFiltrarParticipante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarParticipante.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarParticipante.Name = "toolStripButtonFiltrarParticipante";
            this.toolStripButtonFiltrarParticipante.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarParticipante.Text = "PESQUISAR";
            this.toolStripButtonFiltrarParticipante.Click += new System.EventHandler(this.toolStripButtonFiltrarParticipante_Click);
            // 
            // toolStripButtonSelecionarParticipante
            // 
            this.toolStripButtonSelecionarParticipante.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarParticipante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarParticipante.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarParticipante.Image")));
            this.toolStripButtonSelecionarParticipante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarParticipante.Name = "toolStripButtonSelecionarParticipante";
            this.toolStripButtonSelecionarParticipante.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarParticipante.Text = "SELECIONAR";
            this.toolStripButtonSelecionarParticipante.Click += new System.EventHandler(this.toolStripButtonSelecionarParticipante_Click);
            // 
            // FrmConsultaParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.textBoxCidadeClicada);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxEnderecoClicado);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxTelefoneClicado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCPFCNPJ);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxCPFCNPJClicado);
            this.Controls.Add(this.textBoxNomeClicado);
            this.Controls.Add(this.dataGridViewParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaParticipante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Participante";
            this.Load += new System.EventHandler(this.FrmConsultaParticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantes)).EndInit();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParticipantes;
        private System.Windows.Forms.TextBox textBoxNomeClicado;
        private System.Windows.Forms.TextBox textBoxCPFCNPJClicado;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTelefoneClicado;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEnderecoClicado;
        private System.Windows.Forms.TextBox textBoxCidadeClicada;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonFuncionario;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonFornecedor;
        private System.Windows.Forms.RadioButton radioButtonCliente;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroParticipante;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroParticipante;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarParticipante;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarParticipante;
    }
}