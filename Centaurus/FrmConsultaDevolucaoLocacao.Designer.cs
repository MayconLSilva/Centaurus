namespace Centaurus
{
    partial class FrmConsultaDevolucaoLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaDevolucaoLocacao));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataDevolucaoClicadoDevLocacao = new System.Windows.Forms.TextBox();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxDataLancamentoClicadoDevLocacao = new System.Windows.Forms.TextBox();
            this.textBoxNomeClicadoDevLocacao = new System.Windows.Forms.TextBox();
            this.dataGridViewDevLocacao = new System.Windows.Forms.DataGridView();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxFiltroDevLocacao = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxTipoFiltroDevLocacao = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrarDevLocacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelecionarDevLocacao = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevLocacao)).BeginInit();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Data devolução:";
            // 
            // textBoxDataDevolucaoClicadoDevLocacao
            // 
            this.textBoxDataDevolucaoClicadoDevLocacao.Enabled = false;
            this.textBoxDataDevolucaoClicadoDevLocacao.Location = new System.Drawing.Point(300, 61);
            this.textBoxDataDevolucaoClicadoDevLocacao.Name = "textBoxDataDevolucaoClicadoDevLocacao";
            this.textBoxDataDevolucaoClicadoDevLocacao.Size = new System.Drawing.Size(138, 20);
            this.textBoxDataDevolucaoClicadoDevLocacao.TabIndex = 67;
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(9, 45);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(91, 13);
            this.labelCPFCNPJ.TabIndex = 66;
            this.labelCPFCNPJ.Text = "Data lançamento:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 4);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(42, 13);
            this.labelNome.TabIndex = 65;
            this.labelNome.Text = "Cliente:";
            // 
            // textBoxDataLancamentoClicadoDevLocacao
            // 
            this.textBoxDataLancamentoClicadoDevLocacao.Enabled = false;
            this.textBoxDataLancamentoClicadoDevLocacao.Location = new System.Drawing.Point(12, 61);
            this.textBoxDataLancamentoClicadoDevLocacao.Name = "textBoxDataLancamentoClicadoDevLocacao";
            this.textBoxDataLancamentoClicadoDevLocacao.Size = new System.Drawing.Size(138, 20);
            this.textBoxDataLancamentoClicadoDevLocacao.TabIndex = 64;
            // 
            // textBoxNomeClicadoDevLocacao
            // 
            this.textBoxNomeClicadoDevLocacao.Enabled = false;
            this.textBoxNomeClicadoDevLocacao.Location = new System.Drawing.Point(12, 20);
            this.textBoxNomeClicadoDevLocacao.Name = "textBoxNomeClicadoDevLocacao";
            this.textBoxNomeClicadoDevLocacao.Size = new System.Drawing.Size(216, 20);
            this.textBoxNomeClicadoDevLocacao.TabIndex = 63;
            // 
            // dataGridViewDevLocacao
            // 
            this.dataGridViewDevLocacao.AllowUserToAddRows = false;
            this.dataGridViewDevLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevLocacao.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewDevLocacao.Name = "dataGridViewDevLocacao";
            this.dataGridViewDevLocacao.ReadOnly = true;
            this.dataGridViewDevLocacao.Size = new System.Drawing.Size(660, 216);
            this.dataGridViewDevLocacao.TabIndex = 62;
            this.dataGridViewDevLocacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevLocacao_CellClick);
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxFiltroDevLocacao,
            this.toolStripComboBoxTipoFiltroDevLocacao,
            this.toolStripButtonFiltrarDevLocacao,
            this.toolStripButtonSelecionarDevLocacao});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 336);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(684, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 61;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripTextBoxFiltroDevLocacao
            // 
            this.toolStripTextBoxFiltroDevLocacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFiltroDevLocacao.Name = "toolStripTextBoxFiltroDevLocacao";
            this.toolStripTextBoxFiltroDevLocacao.Size = new System.Drawing.Size(160, 25);
            this.toolStripTextBoxFiltroDevLocacao.Text = "Filtro...";
            // 
            // toolStripComboBoxTipoFiltroDevLocacao
            // 
            this.toolStripComboBoxTipoFiltroDevLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBoxTipoFiltroDevLocacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxTipoFiltroDevLocacao.Items.AddRange(new object[] {
            "TODOS",
            "CLIENTE",
            "DATA LANÇAMENTO",
            "DATA DEVOLUÇÃO",
            "USUÁRIO"});
            this.toolStripComboBoxTipoFiltroDevLocacao.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripComboBoxTipoFiltroDevLocacao.Name = "toolStripComboBoxTipoFiltroDevLocacao";
            this.toolStripComboBoxTipoFiltroDevLocacao.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFiltrarDevLocacao
            // 
            this.toolStripButtonFiltrarDevLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonFiltrarDevLocacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFiltrarDevLocacao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrarDevLocacao.Image")));
            this.toolStripButtonFiltrarDevLocacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrarDevLocacao.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonFiltrarDevLocacao.Name = "toolStripButtonFiltrarDevLocacao";
            this.toolStripButtonFiltrarDevLocacao.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonFiltrarDevLocacao.Text = "PESQUISAR";
            this.toolStripButtonFiltrarDevLocacao.Click += new System.EventHandler(this.toolStripButtonFiltrarDevLocacao_Click);
            // 
            // toolStripButtonSelecionarDevLocacao
            // 
            this.toolStripButtonSelecionarDevLocacao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSelecionarDevLocacao.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonSelecionarDevLocacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelecionarDevLocacao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelecionarDevLocacao.Image")));
            this.toolStripButtonSelecionarDevLocacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelecionarDevLocacao.Name = "toolStripButtonSelecionarDevLocacao";
            this.toolStripButtonSelecionarDevLocacao.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonSelecionarDevLocacao.Text = "SELECIONAR";
            this.toolStripButtonSelecionarDevLocacao.Click += new System.EventHandler(this.toolStripButtonSelecionarDevLocacao_Click);
            // 
            // FrmConsultaDevolucaoLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDataDevolucaoClicadoDevLocacao);
            this.Controls.Add(this.labelCPFCNPJ);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxDataLancamentoClicadoDevLocacao);
            this.Controls.Add(this.textBoxNomeClicadoDevLocacao);
            this.Controls.Add(this.dataGridViewDevLocacao);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaDevolucaoLocacao";
            this.Text = "Consulta Devolucao Locacao";
            this.Load += new System.EventHandler(this.FrmConsultaDevolucaoLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevLocacao)).EndInit();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDataDevolucaoClicadoDevLocacao;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxDataLancamentoClicadoDevLocacao;
        private System.Windows.Forms.TextBox textBoxNomeClicadoDevLocacao;
        private System.Windows.Forms.DataGridView dataGridViewDevLocacao;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFiltroDevLocacao;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipoFiltroDevLocacao;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrarDevLocacao;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelecionarDevLocacao;
    }
}