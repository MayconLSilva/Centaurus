namespace Centaurus
{
    partial class FrmConsultaSubCategoria
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
            this.buttonFiltrarSubCategoria = new System.Windows.Forms.Button();
            this.comboBoxTipoFiltroSubCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrarSubCategoria = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.textBoxSubCategoriaClicada = new System.Windows.Forms.TextBox();
            this.dataGridViewSubCategoria = new System.Windows.Forms.DataGridView();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.labelTipoPesquisa = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFiltrarSubCategoria
            // 
            this.buttonFiltrarSubCategoria.Location = new System.Drawing.Point(343, 329);
            this.buttonFiltrarSubCategoria.Name = "buttonFiltrarSubCategoria";
            this.buttonFiltrarSubCategoria.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarSubCategoria.TabIndex = 28;
            this.buttonFiltrarSubCategoria.Text = "PESQUISAR";
            this.buttonFiltrarSubCategoria.UseVisualStyleBackColor = true;
            this.buttonFiltrarSubCategoria.Click += new System.EventHandler(this.buttonFiltrarSubCategoria_Click);
            // 
            // comboBoxTipoFiltroSubCategoria
            // 
            this.comboBoxTipoFiltroSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiltroSubCategoria.FormattingEnabled = true;
            this.comboBoxTipoFiltroSubCategoria.Items.AddRange(new object[] {
            "CATEGORIA",
            "TODAS"});
            this.comboBoxTipoFiltroSubCategoria.Location = new System.Drawing.Point(216, 329);
            this.comboBoxTipoFiltroSubCategoria.Name = "comboBoxTipoFiltroSubCategoria";
            this.comboBoxTipoFiltroSubCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoFiltroSubCategoria.TabIndex = 27;
            // 
            // textBoxFiltrarSubCategoria
            // 
            this.textBoxFiltrarSubCategoria.Location = new System.Drawing.Point(12, 329);
            this.textBoxFiltrarSubCategoria.Name = "textBoxFiltrarSubCategoria";
            this.textBoxFiltrarSubCategoria.Size = new System.Drawing.Size(198, 20);
            this.textBoxFiltrarSubCategoria.TabIndex = 26;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(553, 9);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(119, 23);
            this.buttonSelecionar.TabIndex = 25;
            this.buttonSelecionar.Text = "SELECIONAR";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // textBoxSubCategoriaClicada
            // 
            this.textBoxSubCategoriaClicada.Enabled = false;
            this.textBoxSubCategoriaClicada.Location = new System.Drawing.Point(12, 12);
            this.textBoxSubCategoriaClicada.Name = "textBoxSubCategoriaClicada";
            this.textBoxSubCategoriaClicada.Size = new System.Drawing.Size(250, 20);
            this.textBoxSubCategoriaClicada.TabIndex = 24;
            // 
            // dataGridViewSubCategoria
            // 
            this.dataGridViewSubCategoria.AllowUserToAddRows = false;
            this.dataGridViewSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubCategoria.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewSubCategoria.Name = "dataGridViewSubCategoria";
            this.dataGridViewSubCategoria.ReadOnly = true;
            this.dataGridViewSubCategoria.Size = new System.Drawing.Size(660, 248);
            this.dataGridViewSubCategoria.TabIndex = 23;
            this.dataGridViewSubCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubCategoria_CellContentClick);
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(12, 289);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 45;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // labelTipoPesquisa
            // 
            this.labelTipoPesquisa.AutoSize = true;
            this.labelTipoPesquisa.Location = new System.Drawing.Point(213, 313);
            this.labelTipoPesquisa.Name = "labelTipoPesquisa";
            this.labelTipoPesquisa.Size = new System.Drawing.Size(73, 13);
            this.labelTipoPesquisa.TabIndex = 47;
            this.labelTipoPesquisa.Text = "Tipo pesquisa";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(12, 313);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 46;
            this.labelFiltro.Text = "Filtro";
            // 
            // FrmConsultaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.labelTipoPesquisa);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.buttonFiltrarSubCategoria);
            this.Controls.Add(this.comboBoxTipoFiltroSubCategoria);
            this.Controls.Add(this.textBoxFiltrarSubCategoria);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.textBoxSubCategoriaClicada);
            this.Controls.Add(this.dataGridViewSubCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Sub-Categoria";
            this.Load += new System.EventHandler(this.FrmConsultaSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFiltrarSubCategoria;
        private System.Windows.Forms.ComboBox comboBoxTipoFiltroSubCategoria;
        private System.Windows.Forms.TextBox textBoxFiltrarSubCategoria;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.TextBox textBoxSubCategoriaClicada;
        private System.Windows.Forms.DataGridView dataGridViewSubCategoria;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.Label labelTipoPesquisa;
        private System.Windows.Forms.Label labelFiltro;
    }
}