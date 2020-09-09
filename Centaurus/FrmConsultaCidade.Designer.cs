namespace Centaurus
{
    partial class FrmConsultaCidade
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
            this.dataGridViewCidade = new System.Windows.Forms.DataGridView();
            this.textBoxCidadeClicada = new System.Windows.Forms.TextBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonFiltrarCidade = new System.Windows.Forms.Button();
            this.comboBoxTipoFiltroCidade = new System.Windows.Forms.ComboBox();
            this.textBoxFiltrarCidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCidade
            // 
            this.dataGridViewCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCidade.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewCidade.Name = "dataGridViewCidade";
            this.dataGridViewCidade.ReadOnly = true;
            this.dataGridViewCidade.Size = new System.Drawing.Size(660, 285);
            this.dataGridViewCidade.TabIndex = 0;
            this.dataGridViewCidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCidade_CellContentClick);
            // 
            // textBoxCidadeClicada
            // 
            this.textBoxCidadeClicada.Enabled = false;
            this.textBoxCidadeClicada.Location = new System.Drawing.Point(12, 12);
            this.textBoxCidadeClicada.Name = "textBoxCidadeClicada";
            this.textBoxCidadeClicada.Size = new System.Drawing.Size(250, 20);
            this.textBoxCidadeClicada.TabIndex = 1;
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
            // comboBoxTipoFiltroCidade
            // 
            this.comboBoxTipoFiltroCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFiltroCidade.FormattingEnabled = true;
            this.comboBoxTipoFiltroCidade.Items.AddRange(new object[] {
            "CIDADE",
            "UF",
            "TODAS"});
            this.comboBoxTipoFiltroCidade.Location = new System.Drawing.Point(216, 329);
            this.comboBoxTipoFiltroCidade.Name = "comboBoxTipoFiltroCidade";
            this.comboBoxTipoFiltroCidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoFiltroCidade.TabIndex = 15;
            // 
            // textBoxFiltrarCidade
            // 
            this.textBoxFiltrarCidade.Location = new System.Drawing.Point(12, 329);
            this.textBoxFiltrarCidade.Name = "textBoxFiltrarCidade";
            this.textBoxFiltrarCidade.Size = new System.Drawing.Size(198, 20);
            this.textBoxFiltrarCidade.TabIndex = 14;
            // 
            // FrmConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonFiltrarCidade);
            this.Controls.Add(this.comboBoxTipoFiltroCidade);
            this.Controls.Add(this.textBoxFiltrarCidade);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.textBoxCidadeClicada);
            this.Controls.Add(this.dataGridViewCidade);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cidade";
            this.Load += new System.EventHandler(this.FrmConsultaCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCidade;
        private System.Windows.Forms.TextBox textBoxCidadeClicada;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonFiltrarCidade;
        private System.Windows.Forms.ComboBox comboBoxTipoFiltroCidade;
        private System.Windows.Forms.TextBox textBoxFiltrarCidade;
    }
}