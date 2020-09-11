namespace Centaurus
{
    partial class FrmConsultaLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaLocacao));
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroLocacao = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroLocacao = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarLocacao = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewLocacao = new System.Windows.Forms.DataGridView();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxDataLancamentoClicadoLocacao = new System.Windows.Forms.TextBox();
            this.textBoxNomeClicadoLocacao = new System.Windows.Forms.TextBox();
            this.textBoxDataPrevEntregaClicadoLocacao = new System.Windows.Forms.TextBox();
            this.labelDataDevolucao = new System.Windows.Forms.Label();
            this.labelQuantidadeDeRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataDevolucaoClicadoLocacao = new System.Windows.Forms.TextBox();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroLocacao,
            this.toolStripComboBoxTipoFiltroLocacao,
            this.toolStripButtonFiltrarLocacao});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 49;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroLocacao
            // 
            this.toolStripTextBoxFiltroLocacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroLocacao.Name = "toolStripTextBoxFiltroLocacao";
            this.toolStripTextBoxFiltroLocacao.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroLocacao.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroLocacao
            // 
            this.toolStripComboBoxTipoFiltroLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroLocacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroLocacao.Items.AddRange(new object[] {
            "TODOS",
            "CLIENTE",
            "DATA LANÇAMENTO",
            "DATA DEVOLUÇÃO",
            "USUÁRIO"});
            this.toolStripComboBoxTipoFiltroLocacao.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroLocacao.Name = "toolStripComboBoxTipoFiltroLocacao";
            this.toolStripComboBoxTipoFiltroLocacao.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarLocacao
            // 
            this.toolStripButtonFiltrarLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarLocacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarLocacao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarLocacao.Image")));
            this.toolStripButtonFiltrarLocacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarLocacao.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarLocacao.Name = "toolStripButtonFiltrarLocacao";
            this.toolStripButtonFiltrarLocacao.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarLocacao.Text = "PESQUISAR";
            this.toolStripButtonFiltrarLocacao.Click += new System.EventHandler(this.toolStripButtonFiltrarLocacao_Click);
            // 
            // dataGridViewLocacao
            // 
            this.dataGridViewLocacao.AllowUserToAddRows = false;
            this.dataGridViewLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocacao.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewLocacao.Name = "dataGridViewLocacao";
            this.dataGridViewLocacao.ReadOnly = true;
            this.dataGridViewLocacao.Size = new System.Drawing.Size(660, 216);
            this.dataGridViewLocacao.TabIndex = 51;
            this.dataGridViewLocacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocacao_CellClick);
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(9, 49);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(91, 13);
            this.labelCPFCNPJ.TabIndex = 55;
            this.labelCPFCNPJ.Text = "Data lançamento:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 8);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 13);
            this.labelNome.TabIndex = 54;
            this.labelNome.Text = "Cliente:";
            // 
            // textBoxDataLancamentoClicadoLocacao
            // 
            this.textBoxDataLancamentoClicadoLocacao.Enabled = false;
            this.textBoxDataLancamentoClicadoLocacao.Location = new System.Drawing.Point(12, 65);
            this.textBoxDataLancamentoClicadoLocacao.Name = "textBoxDataLancamentoClicadoLocacao";
            this.textBoxDataLancamentoClicadoLocacao.Size = new System.Drawing.Size(138, 20);
            this.textBoxDataLancamentoClicadoLocacao.TabIndex = 53;
            // 
            // textBoxNomeClicadoLocacao
            // 
            this.textBoxNomeClicadoLocacao.Enabled = false;
            this.textBoxNomeClicadoLocacao.Location = new System.Drawing.Point(12, 24);
            this.textBoxNomeClicadoLocacao.Name = "textBoxNomeClicadoLocacao";
            this.textBoxNomeClicadoLocacao.Size = new System.Drawing.Size(216, 20);
            this.textBoxNomeClicadoLocacao.TabIndex = 52;
            // 
            // textBoxDataPrevEntregaClicadoLocacao
            // 
            this.textBoxDataPrevEntregaClicadoLocacao.Enabled = false;
            this.textBoxDataPrevEntregaClicadoLocacao.Location = new System.Drawing.Point(156, 65);
            this.textBoxDataPrevEntregaClicadoLocacao.Name = "textBoxDataPrevEntregaClicadoLocacao";
            this.textBoxDataPrevEntregaClicadoLocacao.Size = new System.Drawing.Size(138, 20);
            this.textBoxDataPrevEntregaClicadoLocacao.TabIndex = 56;
            // 
            // labelDataDevolucao
            // 
            this.labelDataDevolucao.AutoSize = true;
            this.labelDataDevolucao.Location = new System.Drawing.Point(153, 47);
            this.labelDataDevolucao.Name = "labelDataDevolucao";
            this.labelDataDevolucao.Size = new System.Drawing.Size(100, 13);
            this.labelDataDevolucao.TabIndex = 57;
            this.labelDataDevolucao.Text = "Data Prev. entrega:";
            // 
            // labelQuantidadeDeRegistros
            // 
            this.labelQuantidadeDeRegistros.AutoSize = true;
            this.labelQuantidadeDeRegistros.Location = new System.Drawing.Point(9, 310);
            this.labelQuantidadeDeRegistros.Name = "labelQuantidadeDeRegistros";
            this.labelQuantidadeDeRegistros.Size = new System.Drawing.Size(35, 13);
            this.labelQuantidadeDeRegistros.TabIndex = 58;
            this.labelQuantidadeDeRegistros.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Data devolução:";
            // 
            // textBoxDataDevolucaoClicadoLocacao
            // 
            this.textBoxDataDevolucaoClicadoLocacao.Enabled = false;
            this.textBoxDataDevolucaoClicadoLocacao.Location = new System.Drawing.Point(300, 65);
            this.textBoxDataDevolucaoClicadoLocacao.Name = "textBoxDataDevolucaoClicadoLocacao";
            this.textBoxDataDevolucaoClicadoLocacao.Size = new System.Drawing.Size(138, 20);
            this.textBoxDataDevolucaoClicadoLocacao.TabIndex = 59;
            // 
            // FrmConsultaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDataDevolucaoClicadoLocacao);
            this.Controls.Add(this.labelQuantidadeDeRegistros);
            this.Controls.Add(this.labelDataDevolucao);
            this.Controls.Add(this.textBoxDataPrevEntregaClicadoLocacao);
            this.Controls.Add(this.labelCPFCNPJ);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxDataLancamentoClicadoLocacao);
            this.Controls.Add(this.textBoxNomeClicadoLocacao);
            this.Controls.Add(this.dataGridViewLocacao);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Locação";
            this.Load += new System.EventHandler(this.FrmConsultaLocacao_Load);
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroLocacao;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroLocacao;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarLocacao;
        private System.Windows.Forms.DataGridView dataGridViewLocacao;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxDataLancamentoClicadoLocacao;
        private System.Windows.Forms.TextBox textBoxNomeClicadoLocacao;
        private System.Windows.Forms.TextBox textBoxDataPrevEntregaClicadoLocacao;
        private System.Windows.Forms.Label labelDataDevolucao;
        private System.Windows.Forms.Label labelQuantidadeDeRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDataDevolucaoClicadoLocacao;
    }
}