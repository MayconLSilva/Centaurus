namespace Centaurus
{
    partial class FrmLocacaoDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocacaoDevolucao));
            this.menuStripLocacao = new System.Windows.Forms.MenuStrip();
            this.menuLocacaoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoGravar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFuncoes = new System.Windows.Forms.ToolStripDropDownButton();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.labelUsuarioLocacao = new System.Windows.Forms.Label();
            this.textBoxUsuarioLocacao = new System.Windows.Forms.TextBox();
            this.groupBoxItens = new System.Windows.Forms.GroupBox();
            this.labelQtdItem = new System.Windows.Forms.Label();
            this.textBoxQuantidadeItem = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.buttonExcluirItem = new System.Windows.Forms.Button();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarItem = new System.Windows.Forms.Button();
            this.textBoxCodigoItem = new System.Windows.Forms.TextBox();
            this.dataGridViewLocao = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQtdItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxDataLancamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLimparCliente = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.buttonBuscarLocacoes = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNumeroLocacao = new System.Windows.Forms.Label();
            this.textBoxNumeroLocacao = new System.Windows.Forms.TextBox();
            this.menuStripLocacao.SuspendLayout();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.groupBoxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocao)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripLocacao
            // 
            this.menuStripLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripLocacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLocacaoNovo,
            this.menuLocacaoGravar,
            this.menuLocacaoEditar,
            this.menuLocacaoCancelar,
            this.menuLocacaoExcluir});
            this.menuStripLocacao.Location = new System.Drawing.Point(0, 0);
            this.menuStripLocacao.Name = "menuStripLocacao";
            this.menuStripLocacao.Size = new System.Drawing.Size(759, 24);
            this.menuStripLocacao.TabIndex = 3;
            // 
            // menuLocacaoNovo
            // 
            this.menuLocacaoNovo.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoNovo.Image")));
            this.menuLocacaoNovo.Name = "menuLocacaoNovo";
            this.menuLocacaoNovo.Size = new System.Drawing.Size(69, 20);
            this.menuLocacaoNovo.Text = "NOVO";
            // 
            // menuLocacaoGravar
            // 
            this.menuLocacaoGravar.Enabled = false;
            this.menuLocacaoGravar.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoGravar.Image")));
            this.menuLocacaoGravar.Name = "menuLocacaoGravar";
            this.menuLocacaoGravar.Size = new System.Drawing.Size(78, 20);
            this.menuLocacaoGravar.Text = "GRAVAR";
            // 
            // menuLocacaoEditar
            // 
            this.menuLocacaoEditar.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoEditar.Image")));
            this.menuLocacaoEditar.Name = "menuLocacaoEditar";
            this.menuLocacaoEditar.Size = new System.Drawing.Size(72, 20);
            this.menuLocacaoEditar.Text = "EDITAR";
            // 
            // menuLocacaoCancelar
            // 
            this.menuLocacaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoCancelar.Image")));
            this.menuLocacaoCancelar.Name = "menuLocacaoCancelar";
            this.menuLocacaoCancelar.Size = new System.Drawing.Size(95, 20);
            this.menuLocacaoCancelar.Text = "CANCELAR";
            // 
            // menuLocacaoExcluir
            // 
            this.menuLocacaoExcluir.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoExcluir.Image")));
            this.menuLocacaoExcluir.Name = "menuLocacaoExcluir";
            this.menuLocacaoExcluir.Size = new System.Drawing.Size(80, 20);
            this.menuLocacaoExcluir.Text = "EXCLUIR";
            // 
            // toolStripMenusConsultaParticipante
            // 
            this.toolStripMenusConsultaParticipante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenusConsultaParticipante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenusConsultaParticipante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFuncoes});
            this.toolStripMenusConsultaParticipante.Location = new System.Drawing.Point(0, 456);
            this.toolStripMenusConsultaParticipante.Name = "toolStripMenusConsultaParticipante";
            this.toolStripMenusConsultaParticipante.Size = new System.Drawing.Size(759, 25);
            this.toolStripMenusConsultaParticipante.TabIndex = 104;
            this.toolStripMenusConsultaParticipante.Text = "Consulta Participante";
            // 
            // toolStripDropDownButtonFuncoes
            // 
            this.toolStripDropDownButtonFuncoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFuncoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devoluçãoToolStripMenuItem});
            this.toolStripDropDownButtonFuncoes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFuncoes.Image")));
            this.toolStripDropDownButtonFuncoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFuncoes.Name = "toolStripDropDownButtonFuncoes";
            this.toolStripDropDownButtonFuncoes.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButtonFuncoes.Text = "FUNÇÕES";
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVolume.Location = new System.Drawing.Point(15, 414);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(45, 13);
            this.labelVolume.TabIndex = 125;
            this.labelVolume.Text = "Volume:";
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(18, 430);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(68, 20);
            this.textBoxVolume.TabIndex = 124;
            // 
            // labelUsuarioLocacao
            // 
            this.labelUsuarioLocacao.AutoSize = true;
            this.labelUsuarioLocacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUsuarioLocacao.Location = new System.Drawing.Point(636, 75);
            this.labelUsuarioLocacao.Name = "labelUsuarioLocacao";
            this.labelUsuarioLocacao.Size = new System.Drawing.Size(46, 13);
            this.labelUsuarioLocacao.TabIndex = 123;
            this.labelUsuarioLocacao.Text = "Usuário:";
            // 
            // textBoxUsuarioLocacao
            // 
            this.textBoxUsuarioLocacao.Location = new System.Drawing.Point(639, 91);
            this.textBoxUsuarioLocacao.Name = "textBoxUsuarioLocacao";
            this.textBoxUsuarioLocacao.Size = new System.Drawing.Size(110, 20);
            this.textBoxUsuarioLocacao.TabIndex = 122;
            // 
            // groupBoxItens
            // 
            this.groupBoxItens.Controls.Add(this.labelQtdItem);
            this.groupBoxItens.Controls.Add(this.textBoxQuantidadeItem);
            this.groupBoxItens.Controls.Add(this.labelNomeProduto);
            this.groupBoxItens.Controls.Add(this.comboBoxFiltro);
            this.groupBoxItens.Controls.Add(this.buttonExcluirItem);
            this.groupBoxItens.Controls.Add(this.buttonAdicionarItem);
            this.groupBoxItens.Controls.Add(this.textBoxValor);
            this.groupBoxItens.Controls.Add(this.label3);
            this.groupBoxItens.Controls.Add(this.buttonBuscarItem);
            this.groupBoxItens.Controls.Add(this.textBoxCodigoItem);
            this.groupBoxItens.Controls.Add(this.dataGridViewLocao);
            this.groupBoxItens.Location = new System.Drawing.Point(12, 174);
            this.groupBoxItens.Name = "groupBoxItens";
            this.groupBoxItens.Size = new System.Drawing.Size(733, 237);
            this.groupBoxItens.TabIndex = 121;
            this.groupBoxItens.TabStop = false;
            this.groupBoxItens.Text = "Itens";
            // 
            // labelQtdItem
            // 
            this.labelQtdItem.AutoSize = true;
            this.labelQtdItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelQtdItem.Location = new System.Drawing.Point(164, 20);
            this.labelQtdItem.Name = "labelQtdItem";
            this.labelQtdItem.Size = new System.Drawing.Size(27, 13);
            this.labelQtdItem.TabIndex = 106;
            this.labelQtdItem.Text = "Qtd:";
            // 
            // textBoxQuantidadeItem
            // 
            this.textBoxQuantidadeItem.Location = new System.Drawing.Point(167, 35);
            this.textBoxQuantidadeItem.MaxLength = 5;
            this.textBoxQuantidadeItem.Name = "textBoxQuantidadeItem";
            this.textBoxQuantidadeItem.Size = new System.Drawing.Size(51, 20);
            this.textBoxQuantidadeItem.TabIndex = 104;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(6, 20);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(157, 13);
            this.labelNomeProduto.TabIndex = 110;
            this.labelNomeProduto.Text = "                                                  ";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Cód. Interno",
            "Cód. Sequenc.",
            "Cód. Fabric.",
            "Cód. Barras"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(6, 35);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(63, 21);
            this.comboBoxFiltro.TabIndex = 109;
            // 
            // buttonExcluirItem
            // 
            this.buttonExcluirItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirItem.Image")));
            this.buttonExcluirItem.Location = new System.Drawing.Point(310, 35);
            this.buttonExcluirItem.Name = "buttonExcluirItem";
            this.buttonExcluirItem.Size = new System.Drawing.Size(25, 24);
            this.buttonExcluirItem.TabIndex = 107;
            this.buttonExcluirItem.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarItem.Image")));
            this.buttonAdicionarItem.Location = new System.Drawing.Point(279, 35);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Size = new System.Drawing.Size(25, 24);
            this.buttonAdicionarItem.TabIndex = 106;
            this.buttonAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(224, 35);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(49, 20);
            this.textBoxValor.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(221, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "R$:";
            // 
            // buttonBuscarItem
            // 
            this.buttonBuscarItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarItem.Image")));
            this.buttonBuscarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarItem.Location = new System.Drawing.Point(138, 35);
            this.buttonBuscarItem.Name = "buttonBuscarItem";
            this.buttonBuscarItem.Size = new System.Drawing.Size(25, 24);
            this.buttonBuscarItem.TabIndex = 103;
            this.buttonBuscarItem.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigoItem
            // 
            this.textBoxCodigoItem.Location = new System.Drawing.Point(78, 35);
            this.textBoxCodigoItem.Name = "textBoxCodigoItem";
            this.textBoxCodigoItem.Size = new System.Drawing.Size(54, 20);
            this.textBoxCodigoItem.TabIndex = 102;
            // 
            // dataGridViewLocao
            // 
            this.dataGridViewLocao.AllowUserToAddRows = false;
            this.dataGridViewLocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocao.Location = new System.Drawing.Point(6, 62);
            this.dataGridViewLocao.Name = "dataGridViewLocao";
            this.dataGridViewLocao.Size = new System.Drawing.Size(721, 169);
            this.dataGridViewLocao.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(92, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 120;
            this.label8.Text = "Qtd. Itens:";
            // 
            // textBoxQtdItem
            // 
            this.textBoxQtdItem.Location = new System.Drawing.Point(95, 430);
            this.textBoxQtdItem.Name = "textBoxQtdItem";
            this.textBoxQtdItem.Size = new System.Drawing.Size(68, 20);
            this.textBoxQtdItem.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(654, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Total R$:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(657, 430);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(90, 20);
            this.textBoxTotal.TabIndex = 117;
            // 
            // textBoxDataLancamento
            // 
            this.textBoxDataLancamento.Location = new System.Drawing.Point(639, 46);
            this.textBoxDataLancamento.Name = "textBoxDataLancamento";
            this.textBoxDataLancamento.Size = new System.Drawing.Size(110, 20);
            this.textBoxDataLancamento.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(636, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Data lançamento:";
            // 
            // buttonLimparCliente
            // 
            this.buttonLimparCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimparCliente.Image")));
            this.buttonLimparCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLimparCliente.Location = new System.Drawing.Point(292, 91);
            this.buttonLimparCliente.Name = "buttonLimparCliente";
            this.buttonLimparCliente.Size = new System.Drawing.Size(50, 24);
            this.buttonLimparCliente.TabIndex = 114;
            this.buttonLimparCliente.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCliente.Image")));
            this.buttonBuscarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(236, 91);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(50, 24);
            this.buttonBuscarCliente.TabIndex = 113;
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(12, 91);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(218, 20);
            this.textBoxCliente.TabIndex = 111;
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFornecedor.Location = new System.Drawing.Point(9, 75);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(42, 13);
            this.labelFornecedor.TabIndex = 112;
            this.labelFornecedor.Text = "Cliente:";
            // 
            // buttonBuscarLocacoes
            // 
            this.buttonBuscarLocacoes.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarLocacoes.Image")));
            this.buttonBuscarLocacoes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarLocacoes.Location = new System.Drawing.Point(68, 46);
            this.buttonBuscarLocacoes.Name = "buttonBuscarLocacoes";
            this.buttonBuscarLocacoes.Size = new System.Drawing.Size(50, 24);
            this.buttonBuscarLocacoes.TabIndex = 110;
            this.buttonBuscarLocacoes.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 46);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(50, 20);
            this.textBoxCodigo.TabIndex = 108;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCodigo.Location = new System.Drawing.Point(9, 30);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 109;
            this.labelCodigo.Text = "Código:";
            // 
            // labelNumeroLocacao
            // 
            this.labelNumeroLocacao.AutoSize = true;
            this.labelNumeroLocacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNumeroLocacao.Location = new System.Drawing.Point(636, 118);
            this.labelNumeroLocacao.Name = "labelNumeroLocacao";
            this.labelNumeroLocacao.Size = new System.Drawing.Size(60, 13);
            this.labelNumeroLocacao.TabIndex = 127;
            this.labelNumeroLocacao.Text = "Nº locação";
            // 
            // textBoxNumeroLocacao
            // 
            this.textBoxNumeroLocacao.Location = new System.Drawing.Point(639, 134);
            this.textBoxNumeroLocacao.Name = "textBoxNumeroLocacao";
            this.textBoxNumeroLocacao.Size = new System.Drawing.Size(110, 20);
            this.textBoxNumeroLocacao.TabIndex = 126;
            // 
            // FrmLocacaoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 481);
            this.Controls.Add(this.labelNumeroLocacao);
            this.Controls.Add(this.textBoxNumeroLocacao);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.labelUsuarioLocacao);
            this.Controls.Add(this.textBoxUsuarioLocacao);
            this.Controls.Add(this.groupBoxItens);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxQtdItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxDataLancamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLimparCliente);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.buttonBuscarLocacoes);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.toolStripMenusConsultaParticipante);
            this.Controls.Add(this.menuStripLocacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLocacaoDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locacao Devolucao";
            this.menuStripLocacao.ResumeLayout(false);
            this.menuStripLocacao.PerformLayout();
            this.toolStripMenusConsultaParticipante.ResumeLayout(false);
            this.toolStripMenusConsultaParticipante.PerformLayout();
            this.groupBoxItens.ResumeLayout(false);
            this.groupBoxItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLocacao;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoNovo;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoGravar;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoEditar;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoCancelar;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoExcluir;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFuncoes;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.Label labelUsuarioLocacao;
        private System.Windows.Forms.TextBox textBoxUsuarioLocacao;
        private System.Windows.Forms.GroupBox groupBoxItens;
        private System.Windows.Forms.Label labelQtdItem;
        private System.Windows.Forms.TextBox textBoxQuantidadeItem;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Button buttonExcluirItem;
        private System.Windows.Forms.Button buttonAdicionarItem;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscarItem;
        private System.Windows.Forms.TextBox textBoxCodigoItem;
        private System.Windows.Forms.DataGridView dataGridViewLocao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxQtdItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxDataLancamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLimparCliente;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Button buttonBuscarLocacoes;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNumeroLocacao;
        private System.Windows.Forms.TextBox textBoxNumeroLocacao;
    }
}