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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCidade));
            this.dataGridViewCidade = new System.Windows.Forms.DataGridView();
            this.textBoxCidadeClicada = new System.Windows.Forms.TextBox();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroCidade = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroCidade = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarCidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelecionarCidade = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidade)).BeginInit();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCidade
            // 
            this.dataGridViewCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCidade.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewCidade.Name = "dataGridViewCidade";
            this.dataGridViewCidade.ReadOnly = true;
            this.dataGridViewCidade.Size = new System.Drawing.Size(660, 282);
            this.dataGridViewCidade.TabIndex = 0;
            this.dataGridViewCidade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCidade_CellClick);
            // 
            // textBoxCidadeClicada
            // 
            this.textBoxCidadeClicada.Enabled = false;
            this.textBoxCidadeClicada.Location = new System.Drawing.Point(12, 12);
            this.textBoxCidadeClicada.Name = "textBoxCidadeClicada";
            this.textBoxCidadeClicada.Size = new System.Drawing.Size(250, 20);
            this.textBoxCidadeClicada.TabIndex = 1;
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroCidade,
            this.toolStripComboBoxTipoFiltroCidade,
            this.toolStripButtonFiltrarCidade,
            this.toolStripButtonSelecionarCidade});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 50;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroCidade
            // 
            this.toolStripTextBoxFiltroCidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroCidade.Name = "toolStripTextBoxFiltroCidade";
            this.toolStripTextBoxFiltroCidade.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroCidade.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroCidade
            // 
            this.toolStripComboBoxTipoFiltroCidade.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroCidade.Items.AddRange(new object[] {
            "CIDADE",
            "UF",
            "TODAS"});
            this.toolStripComboBoxTipoFiltroCidade.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroCidade.Name = "toolStripComboBoxTipoFiltroCidade";
            this.toolStripComboBoxTipoFiltroCidade.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarCidade
            // 
            this.toolStripButtonFiltrarCidade.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarCidade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarCidade.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarCidade.Image")));
            this.toolStripButtonFiltrarCidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarCidade.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarCidade.Name = "toolStripButtonFiltrarCidade";
            this.toolStripButtonFiltrarCidade.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarCidade.Text = "PESQUISAR";
            this.toolStripButtonFiltrarCidade.Click += new System.EventHandler(this.toolStripButtonFiltrarCidade_Click);
            // 
            // toolStripButtonSelecionarCidade
            // 
            this.toolStripButtonSelecionarCidade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarCidade.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarCidade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarCidade.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarCidade.Image")));
            this.toolStripButtonSelecionarCidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarCidade.Name = "toolStripButtonSelecionarCidade";
            this.toolStripButtonSelecionarCidade.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarCidade.Text = "SELECIONAR";
            this.toolStripButtonSelecionarCidade.Click += new System.EventHandler(this.toolStripButtonSelecionarCidade_Click);
            // 
            // FrmConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.textBoxCidadeClicada);
            this.Controls.Add(this.dataGridViewCidade);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cidade";
            this.Load += new System.EventHandler(this.FrmConsultaCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCidade)).EndInit();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCidade;
        private System.Windows.Forms.TextBox textBoxCidadeClicada;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroCidade;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroCidade;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarCidade;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarCidade;
    }
}