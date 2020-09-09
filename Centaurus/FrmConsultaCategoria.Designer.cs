namespace Centaurus
{
    partial class FrmConsultaCategoria
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
            this.buttonFiltrarCategoria = new System.Windows.Forms.Button();
            this.comboBoxTipoFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.textBoxCategoriaClicada = new System.Windows.Forms.TextBox();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.labelTipoPesquisa = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFiltrarCategoria
            // 
            this.buttonFiltrarCategoria.Location = new System.Drawing.Point(343, 329);
            this.buttonFiltrarCategoria.Name = "buttonFiltrarCategoria";
            this.buttonFiltrarCategoria.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarCategoria.TabIndex = 22;
            this.buttonFiltrarCategoria.Text = "PESQUISAR";
            this.buttonFiltrarCategoria.UseVisualStyleBackColor = true;
            this.buttonFiltrarCategoria.Click += new System.EventHandler(this.buttonFiltrarCategoria_Click);
            // 
            // comboBoxTipoFiltroCategoria
            // 
            this.comboBoxTipoFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiltroCategoria.FormattingEnabled = true;
            this.comboBoxTipoFiltroCategoria.Items.AddRange(new object[] {
            "CATEGORIA",
            "TODAS"});
            this.comboBoxTipoFiltroCategoria.Location = new System.Drawing.Point(216, 329);
            this.comboBoxTipoFiltroCategoria.Name = "comboBoxTipoFiltroCategoria";
            this.comboBoxTipoFiltroCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoFiltroCategoria.TabIndex = 21;
            this.comboBoxTipoFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoFiltroCategoria_SelectedIndexChanged);
            // 
            // textBoxFiltrarCategoria
            // 
            this.textBoxFiltrarCategoria.Location = new System.Drawing.Point(12, 329);
            this.textBoxFiltrarCategoria.Name = "textBoxFiltrarCategoria";
            this.textBoxFiltrarCategoria.Size = new System.Drawing.Size(198, 20);
            this.textBoxFiltrarCategoria.TabIndex = 20;
            this.textBoxFiltrarCategoria.TextChanged += new System.EventHandler(this.textBoxFiltrarCategoria_TextChanged);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(553, 9);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(119, 23);
            this.buttonSelecionar.TabIndex = 19;
            this.buttonSelecionar.Text = "SELECIONAR";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // textBoxCategoriaClicada
            // 
            this.textBoxCategoriaClicada.Enabled = false;
            this.textBoxCategoriaClicada.Location = new System.Drawing.Point(12, 12);
            this.textBoxCategoriaClicada.Name = "textBoxCategoriaClicada";
            this.textBoxCategoriaClicada.Size = new System.Drawing.Size(250, 20);
            this.textBoxCategoriaClicada.TabIndex = 18;
            this.textBoxCategoriaClicada.TextChanged += new System.EventHandler(this.textBoxCategoriaClicada_TextChanged);
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.AllowUserToAddRows = false;
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.ReadOnly = true;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(660, 246);
            this.dataGridViewCategoria.TabIndex = 17;
            this.dataGridViewCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategoria_CellContentClick);
            // 
            // labelTipoPesquisa
            // 
            this.labelTipoPesquisa.AutoSize = true;
            this.labelTipoPesquisa.Location = new System.Drawing.Point(213, 313);
            this.labelTipoPesquisa.Name = "labelTipoPesquisa";
            this.labelTipoPesquisa.Size = new System.Drawing.Size(73, 13);
            this.labelTipoPesquisa.TabIndex = 43;
            this.labelTipoPesquisa.Text = "Tipo pesquisa";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(12, 313);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 42;
            this.labelFiltro.Text = "Filtro";
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 287);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 44;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // FrmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.labelTipoPesquisa);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.buttonFiltrarCategoria);
            this.Controls.Add(this.comboBoxTipoFiltroCategoria);
            this.Controls.Add(this.textBoxFiltrarCategoria);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.textBoxCategoriaClicada);
            this.Controls.Add(this.dataGridViewCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.FrmConsultaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrarCategoria;
        private System.Windows.Forms.ComboBox comboBoxTipoFiltroCategoria;
        private System.Windows.Forms.TextBox textBoxFiltrarCategoria;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.TextBox textBoxCategoriaClicada;
        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.Label labelTipoPesquisa;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
    }
}