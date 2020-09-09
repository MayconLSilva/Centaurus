namespace Centaurus
{
    partial class FrmConsultaMarca
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
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.textBoxMarcaClicada = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonFiltrarCidade = new System.Windows.Forms.Button();
            this.comboBoxTipoFiltroMarca = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrarMarca = new System.Windows.Forms.TextBox();
            this.labelTipoPesquisa = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.ReadOnly = true;
            this.dataGridViewMarca.Size = new System.Drawing.Size(660, 249);
            this.dataGridViewMarca.TabIndex = 0;
            this.dataGridViewMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCidade_CellContentClick);
            // 
            // textBoxMarcaClicada
            // 
            this.textBoxMarcaClicada.Enabled = false;
            this.textBoxMarcaClicada.Location = new System.Drawing.Point(12, 12);
            this.textBoxMarcaClicada.Name = "textBoxMarcaClicada";
            this.textBoxMarcaClicada.Size = new System.Drawing.Size(250, 20);
            this.textBoxMarcaClicada.TabIndex = 1;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(553, 9);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(119, 23);
            this.buttonSelecionar.TabIndex = 2;
            this.buttonSelecionar.Text = "SELECIONAR";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonFiltrarCidade
            // 
            this.buttonFiltrarCidade.Location = new System.Drawing.Point(343, 329);
            this.buttonFiltrarCidade.Name = "buttonFiltrarCidade";
            this.buttonFiltrarCidade.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarCidade.TabIndex = 16;
            this.buttonFiltrarCidade.Text = "PESQUISAR";
            this.buttonFiltrarCidade.UseVisualStyleBackColor = true;
            this.buttonFiltrarCidade.Click += new System.EventHandler(this.buttonFiltrarCidade_Click);
            // 
            // comboBoxTipoFiltroMarca
            // 
            this.comboBoxTipoFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiltroMarca.FormattingEnabled = true;
            this.comboBoxTipoFiltroMarca.Items.AddRange(new object[] {
            "MARCA",
            "TODAS"});
            this.comboBoxTipoFiltroMarca.Location = new System.Drawing.Point(216, 329);
            this.comboBoxTipoFiltroMarca.Name = "comboBoxTipoFiltroMarca";
            this.comboBoxTipoFiltroMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoFiltroMarca.TabIndex = 15;
            // 
            // textBoxFiltrarMarca
            // 
            this.textBoxFiltrarMarca.Location = new System.Drawing.Point(12, 329);
            this.textBoxFiltrarMarca.Name = "textBoxFiltrarMarca";
            this.textBoxFiltrarMarca.Size = new System.Drawing.Size(198, 20);
            this.textBoxFiltrarMarca.TabIndex = 14;
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
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(12, 290);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 46;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // FrmConsultaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.labelTipoPesquisa);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.buttonFiltrarCidade);
            this.Controls.Add(this.comboBoxTipoFiltroMarca);
            this.Controls.Add(this.textBoxFiltrarMarca);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.textBoxMarcaClicada);
            this.Controls.Add(this.dataGridViewMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Marca";
            this.Load += new System.EventHandler(this.FrmConsultaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMarca;
        private System.Windows.Forms.TextBox textBoxMarcaClicada;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonFiltrarCidade;
        private System.Windows.Forms.ComboBox comboBoxTipoFiltroMarca;
        private System.Windows.Forms.TextBox textBoxFiltrarMarca;
        private System.Windows.Forms.Label labelTipoPesquisa;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
    }
}