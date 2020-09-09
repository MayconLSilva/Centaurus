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
            this.buttonFiltrarProduto = new System.Windows.Forms.Button();
            this.comboBoxTipoFiltroProduto = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrarProduto = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.textBoxProdutoClicado = new System.Windows.Forms.TextBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonServico = new System.Windows.Forms.RadioButton();
            this.radioButtonProduto = new System.Windows.Forms.RadioButton();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelTipoPesquisa = new System.Windows.Forms.Label();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFiltrarProduto
            // 
            this.buttonFiltrarProduto.Location = new System.Drawing.Point(343, 329);
            this.buttonFiltrarProduto.Name = "buttonFiltrarProduto";
            this.buttonFiltrarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarProduto.TabIndex = 28;
            this.buttonFiltrarProduto.Text = "PESQUISAR";
            this.buttonFiltrarProduto.UseVisualStyleBackColor = true;
            this.buttonFiltrarProduto.Click += new System.EventHandler(this.buttonFiltrarProduto_Click);
            // 
            // comboBoxTipoFiltroProduto
            // 
            this.comboBoxTipoFiltroProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiltroProduto.FormattingEnabled = true;
            this.comboBoxTipoFiltroProduto.Items.AddRange(new object[] {
            "TODOS",
            "CÓDIGO",
            "NOME",
            "CATEGORIA",
            "SUB-CATEGORIA",
            "MARCA",
            "FORNECEDOR",
            "TIPO",
            "INTELIGENTE"});
            this.comboBoxTipoFiltroProduto.Location = new System.Drawing.Point(216, 329);
            this.comboBoxTipoFiltroProduto.Name = "comboBoxTipoFiltroProduto";
            this.comboBoxTipoFiltroProduto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoFiltroProduto.TabIndex = 27;
            // 
            // textBoxFiltrarProduto
            // 
            this.textBoxFiltrarProduto.Location = new System.Drawing.Point(12, 329);
            this.textBoxFiltrarProduto.Name = "textBoxFiltrarProduto";
            this.textBoxFiltrarProduto.Size = new System.Drawing.Size(198, 20);
            this.textBoxFiltrarProduto.TabIndex = 26;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(553, 326);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(119, 23);
            this.buttonSelecionar.TabIndex = 25;
            this.buttonSelecionar.Text = "SELECIONAR";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
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
            this.dataGridViewProduto.Size = new System.Drawing.Size(660, 219);
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
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(12, 313);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 40;
            this.labelFiltro.Text = "Filtro";
            // 
            // labelTipoPesquisa
            // 
            this.labelTipoPesquisa.AutoSize = true;
            this.labelTipoPesquisa.Location = new System.Drawing.Point(213, 313);
            this.labelTipoPesquisa.Name = "labelTipoPesquisa";
            this.labelTipoPesquisa.Size = new System.Drawing.Size(73, 13);
            this.labelTipoPesquisa.TabIndex = 41;
            this.labelTipoPesquisa.Text = "Tipo pesquisa";
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(12, 291);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 45;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "label1";
            // 
            // FrmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.labelTipoPesquisa);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.buttonFiltrarProduto);
            this.Controls.Add(this.comboBoxTipoFiltroProduto);
            this.Controls.Add(this.textBoxFiltrarProduto);
            this.Controls.Add(this.buttonSelecionar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrarProduto;
        private System.Windows.Forms.ComboBox comboBoxTipoFiltroProduto;
        private System.Windows.Forms.TextBox textBoxFiltrarProduto;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.TextBox textBoxProdutoClicado;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonServico;
        private System.Windows.Forms.RadioButton radioButtonProduto;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelTipoPesquisa;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.Label label1;
    }
}