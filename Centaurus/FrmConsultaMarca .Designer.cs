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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaMarca));
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.textBoxMarcaClicada = new System.Windows.Forms.TextBox();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroMarca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroMarca = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarMarca = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelecionarMarca = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.ReadOnly = true;
            this.dataGridViewMarca.Size = new System.Drawing.Size(660, 269);
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
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 310);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 46;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroMarca,
            this.toolStripComboBoxTipoFiltroMarca,
            this.toolStripButtonFiltrarMarca,
            this.toolStripButtonSelecionarMarca});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 50;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroMarca
            // 
            this.toolStripTextBoxFiltroMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroMarca.Name = "toolStripTextBoxFiltroMarca";
            this.toolStripTextBoxFiltroMarca.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroMarca.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroMarca
            // 
            this.toolStripComboBoxTipoFiltroMarca.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroMarca.Items.AddRange(new object[] {
            "MARCA",
            "TODAS"});
            this.toolStripComboBoxTipoFiltroMarca.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroMarca.Name = "toolStripComboBoxTipoFiltroMarca";
            this.toolStripComboBoxTipoFiltroMarca.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarMarca
            // 
            this.toolStripButtonFiltrarMarca.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarMarca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarMarca.Image")));
            this.toolStripButtonFiltrarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarMarca.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarMarca.Name = "toolStripButtonFiltrarMarca";
            this.toolStripButtonFiltrarMarca.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarMarca.Text = "PESQUISAR";
            this.toolStripButtonFiltrarMarca.Click += new System.EventHandler(this.toolStripButtonFiltrarCategoriaSubCategoria_Click);
            // 
            // toolStripButtonSelecionarMarca
            // 
            this.toolStripButtonSelecionarMarca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarMarca.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarMarca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarMarca.Image")));
            this.toolStripButtonSelecionarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarMarca.Name = "toolStripButtonSelecionarMarca";
            this.toolStripButtonSelecionarMarca.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarMarca.Text = "SELECIONAR";
            this.toolStripButtonSelecionarMarca.Click += new System.EventHandler(this.toolStripButtonSelecionarCategoriaSubCategoria_Click);
            // 
            // FrmConsultaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.textBoxMarcaClicada);
            this.Controls.Add(this.dataGridViewMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Marca";
            this.Load += new System.EventHandler(this.FrmConsultaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMarca;
        private System.Windows.Forms.TextBox textBoxMarcaClicada;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroMarca;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroMarca;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarMarca;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarMarca;
    }
}