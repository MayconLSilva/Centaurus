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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCategoriaSubCategoria));
            this.dataGridViewCategoriaSubCategoria = new System.Windows.Forms.DataGridView();
            this.textBoxCategoriaSubCategoriaClicada = new System.Windows.Forms.TextBox();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarCategoriaSubCategoria = new System.Windows.Forms.ToolStripButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonSubCategoria = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoria = new System.Windows.Forms.RadioButton();
            this.toolStripTextBoxFiltroCategoriaSubCategoria = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSelecionarCategoriaSubCategoria = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriaSubCategoria)).BeginInit();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCategoriaSubCategoria
            // 
            this.dataGridViewCategoriaSubCategoria.AllowUserToAddRows = false;
            this.dataGridViewCategoriaSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoriaSubCategoria.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewCategoriaSubCategoria.Name = "dataGridViewCategoriaSubCategoria";
            this.dataGridViewCategoriaSubCategoria.ReadOnly = true;
            this.dataGridViewCategoriaSubCategoria.Size = new System.Drawing.Size(660, 239);
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
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 311);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 45;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroCategoriaSubCategoria,
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria,
            this.toolStripButtonFiltrarCategoriaSubCategoria,
            this.toolStripButtonSelecionarCategoriaSubCategoria});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 49;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripComboBoxTipoFiltroCategoriaSubCategoria
            // 
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria.Items.AddRange(new object[] {
            "CÓDIGO",
            "NOME",
            "INTELIGENTE",
            "TODOS"});
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria.Name = "toolStripComboBoxTipoFiltroCategoriaSubCategoria";
            this.toolStripComboBoxTipoFiltroCategoriaSubCategoria.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarCategoriaSubCategoria
            // 
            this.toolStripButtonFiltrarCategoriaSubCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarCategoriaSubCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarCategoriaSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarCategoriaSubCategoria.Image")));
            this.toolStripButtonFiltrarCategoriaSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarCategoriaSubCategoria.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarCategoriaSubCategoria.Name = "toolStripButtonFiltrarCategoriaSubCategoria";
            this.toolStripButtonFiltrarCategoriaSubCategoria.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarCategoriaSubCategoria.Text = "PESQUISAR";
            this.toolStripButtonFiltrarCategoriaSubCategoria.Click += new System.EventHandler(this.toolStripButtonFiltrarCategoriaSubCategoria_Click);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonTodos);
            this.groupBoxTipo.Controls.Add(this.radioButtonSubCategoria);
            this.groupBoxTipo.Controls.Add(this.radioButtonCategoria);
            this.groupBoxTipo.Location = new System.Drawing.Point(442, 12);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(230, 51);
            this.groupBoxTipo.TabIndex = 50;
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
            this.radioButtonTodos.Text = "Todas";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubCategoria
            // 
            this.radioButtonSubCategoria.AutoSize = true;
            this.radioButtonSubCategoria.Location = new System.Drawing.Point(131, 25);
            this.radioButtonSubCategoria.Name = "radioButtonSubCategoria";
            this.radioButtonSubCategoria.Size = new System.Drawing.Size(91, 17);
            this.radioButtonSubCategoria.TabIndex = 1;
            this.radioButtonSubCategoria.TabStop = true;
            this.radioButtonSubCategoria.Text = "Sub-categoria";
            this.radioButtonSubCategoria.UseVisualStyleBackColor = true;
            // 
            // radioButtonCategoria
            // 
            this.radioButtonCategoria.AutoSize = true;
            this.radioButtonCategoria.Location = new System.Drawing.Point(61, 25);
            this.radioButtonCategoria.Name = "radioButtonCategoria";
            this.radioButtonCategoria.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCategoria.TabIndex = 0;
            this.radioButtonCategoria.TabStop = true;
            this.radioButtonCategoria.Text = "Categoria";
            this.radioButtonCategoria.UseVisualStyleBackColor = true;
            // 
            // toolStripTextBoxFiltroCategoriaSubCategoria
            // 
            this.toolStripTextBoxFiltroCategoriaSubCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroCategoriaSubCategoria.Name = "toolStripTextBoxFiltroCategoriaSubCategoria";
            this.toolStripTextBoxFiltroCategoriaSubCategoria.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroCategoriaSubCategoria.Text = "Filtro...";
            // 
            // toolStripButtonSelecionarCategoriaSubCategoria
            // 
            this.toolStripButtonSelecionarCategoriaSubCategoria.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarCategoriaSubCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarCategoriaSubCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarCategoriaSubCategoria.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarCategoriaSubCategoria.Image")));
            this.toolStripButtonSelecionarCategoriaSubCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarCategoriaSubCategoria.Name = "toolStripButtonSelecionarCategoriaSubCategoria";
            this.toolStripButtonSelecionarCategoriaSubCategoria.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarCategoriaSubCategoria.Text = "SELECIONAR";
            this.toolStripButtonSelecionarCategoriaSubCategoria.Click += new System.EventHandler(this.toolStripButtonSelecionarCategoriaSubCategoria_Click);
            // 
            // FrmConsultaCategoriaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.textBoxCategoriaSubCategoriaClicada);
            this.Controls.Add(this.dataGridViewCategoriaSubCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCategoriaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria/Sub-Categoria";
            this.Load += new System.EventHandler(this.FrmConsultaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriaSubCategoria)).EndInit();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategoriaSubCategoria;
        private System.Windows.Forms.TextBox textBoxCategoriaSubCategoriaClicada;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroCategoriaSubCategoria;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarCategoriaSubCategoria;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonSubCategoria;
        private System.Windows.Forms.RadioButton radioButtonCategoria;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroCategoriaSubCategoria;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarCategoriaSubCategoria;
    }
}