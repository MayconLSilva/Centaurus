namespace Centaurus
{
    partial class FrmConsultaCategoriaSubCategoria
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
            this.dataGridViewCategoriaSubCategoria = new System.Windows.Forms.DataGridView();
            this.textBoxCategoriaSubCategoriaClicada = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonFiltrarCategoriaSubCategoria = new System.Windows.Forms.Button();
            this.comboBoxTipoFiltroCategoriaSubCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrarCategoriaSubCategoria = new System.Windows.Forms.TextBox();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriaSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategoriaSubCategoria
            // 
            this.dataGridViewCategoriaSubCategoria.AllowUserToAddRows = false;
            this.dataGridViewCategoriaSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoriaSubCategoria.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewCategoriaSubCategoria.Name = "dataGridViewCategoriaSubCategoria";
            this.dataGridViewCategoriaSubCategoria.ReadOnly = true;
            this.dataGridViewCategoriaSubCategoria.Size = new System.Drawing.Size(660, 257);
            this.dataGridViewCategoriaSubCategoria.TabIndex = 0;
            this.dataGridViewCategoriaSubCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCidade_CellContentClick);
            // 
            // textBoxCategoriaSubCategoriaClicada
            // 
            this.textBoxCategoriaSubCategoriaClicada.Enabled = false;
            this.textBoxCategoriaSubCategoriaClicada.Location = new System.Drawing.Point(12, 12);
            this.textBoxCategoriaSubCategoriaClicada.Name = "textBoxCategoriaSubCategoriaClicada";
            this.textBoxCategoriaSubCategoriaClicada.Size = new System.Drawing.Size(250, 20);
            this.textBoxCategoriaSubCategoriaClicada.TabIndex = 1;
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
            // buttonFiltrarCategoriaSubCategoria
            // 
            this.buttonFiltrarCategoriaSubCategoria.Location = new System.Drawing.Point(343, 329);
            this.buttonFiltrarCategoriaSubCategoria.Name = "buttonFiltrarCategoriaSubCategoria";
            this.buttonFiltrarCategoriaSubCategoria.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrarCategoriaSubCategoria.TabIndex = 16;
            this.buttonFiltrarCategoriaSubCategoria.Text = "PESQUISAR";
            this.buttonFiltrarCategoriaSubCategoria.UseVisualStyleBackColor = true;
            this.buttonFiltrarCategoriaSubCategoria.Click += new System.EventHandler(this.buttonFiltrarCidade_Click);
            // 
            // comboBoxTipoFiltroCategoriaSubCategoria
            // 
            this.comboBoxTipoFiltroCategoriaSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiltroCategoriaSubCategoria.FormattingEnabled = true;
            this.comboBoxTipoFiltroCategoriaSubCategoria.Items.AddRange(new object[] {
            "CATEGORIA",
            "TODAS"});
            this.comboBoxTipoFiltroCategoriaSubCategoria.Location = new System.Drawing.Point(216, 329);
            this.comboBoxTipoFiltroCategoriaSubCategoria.Name = "comboBoxTipoFiltroCategoriaSubCategoria";
            this.comboBoxTipoFiltroCategoriaSubCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoFiltroCategoriaSubCategoria.TabIndex = 15;
            // 
            // textBoxFiltrarCategoriaSubCategoria
            // 
            this.textBoxFiltrarCategoriaSubCategoria.Location = new System.Drawing.Point(12, 329);
            this.textBoxFiltrarCategoriaSubCategoria.Name = "textBoxFiltrarCategoriaSubCategoria";
            this.textBoxFiltrarCategoriaSubCategoria.Size = new System.Drawing.Size(198, 20);
            this.textBoxFiltrarCategoriaSubCategoria.TabIndex = 14;
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 298);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 45;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // FrmConsultaCategoriaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.buttonFiltrarCategoriaSubCategoria);
            this.Controls.Add(this.comboBoxTipoFiltroCategoriaSubCategoria);
            this.Controls.Add(this.textBoxFiltrarCategoriaSubCategoria);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.textBoxCategoriaSubCategoriaClicada);
            this.Controls.Add(this.dataGridViewCategoriaSubCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCategoriaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria/Sub-Categoria";
            this.Load += new System.EventHandler(this.FrmConsultaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriaSubCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategoriaSubCategoria;
        private System.Windows.Forms.TextBox textBoxCategoriaSubCategoriaClicada;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonFiltrarCategoriaSubCategoria;
        private System.Windows.Forms.ComboBox comboBoxTipoFiltroCategoriaSubCategoria;
        private System.Windows.Forms.TextBox textBoxFiltrarCategoriaSubCategoria;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
    }
}