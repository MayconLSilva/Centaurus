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
            this.menuLocacaoDevNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoDevGravar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoDevEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoDevCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocacaoDevExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenusConsultaParticipante = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFuncoes = new System.Windows.Forms.ToolStripDropDownButton();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textBoxVolumeDev = new System.Windows.Forms.TextBox();
            this.labelUsuarioLocacao = new System.Windows.Forms.Label();
            this.textBoxUsuarioLocacaoDev = new System.Windows.Forms.TextBox();
            this.groupBoxItens = new System.Windows.Forms.GroupBox();
            this.labelQtdItem = new System.Windows.Forms.Label();
            this.textBoxQuantidadeItemDev = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.comboBoxFiltroDev = new System.Windows.Forms.ComboBox();
            this.buttonExcluirItemDev = new System.Windows.Forms.Button();
            this.buttonAdicionarItemDev = new System.Windows.Forms.Button();
            this.textBoxValorDev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscarItemDev = new System.Windows.Forms.Button();
            this.textBoxCodigoItemDev = new System.Windows.Forms.TextBox();
            this.dataGridViewLocaoDev = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQtdItemDev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalDev = new System.Windows.Forms.TextBox();
            this.textBoxDataLancamentoDev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClienteDev = new System.Windows.Forms.TextBox();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.buttonBuscarLocacoesDev = new System.Windows.Forms.Button();
            this.textBoxCodigoDev = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNumeroLocacao = new System.Windows.Forms.Label();
            this.textBoxNumeroLocacaoDev = new System.Windows.Forms.TextBox();
            this.buttonBuscarLocacao = new System.Windows.Forms.Button();
            this.labelInformativoGravar = new System.Windows.Forms.Label();
            this.menuStripLocacao.SuspendLayout();
            this.toolStripMenusConsultaParticipante.SuspendLayout();
            this.groupBoxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocaoDev)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripLocacao
            // 
            this.menuStripLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripLocacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLocacaoDevNovo,
            this.menuLocacaoDevGravar,
            this.menuLocacaoDevEditar,
            this.menuLocacaoDevCancelar,
            this.menuLocacaoDevExcluir});
            this.menuStripLocacao.Location = new System.Drawing.Point(0, 0);
            this.menuStripLocacao.Name = "menuStripLocacao";
            this.menuStripLocacao.Size = new System.Drawing.Size(759, 24);
            this.menuStripLocacao.TabIndex = 3;
            // 
            // menuLocacaoDevNovo
            // 
            this.menuLocacaoDevNovo.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoDevNovo.Image")));
            this.menuLocacaoDevNovo.Name = "menuLocacaoDevNovo";
            this.menuLocacaoDevNovo.Size = new System.Drawing.Size(69, 20);
            this.menuLocacaoDevNovo.Text = "NOVO";
            this.menuLocacaoDevNovo.Click += new System.EventHandler(this.menuLocacaoDevNovo_Click);
            // 
            // menuLocacaoDevGravar
            // 
            this.menuLocacaoDevGravar.Enabled = false;
            this.menuLocacaoDevGravar.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoDevGravar.Image")));
            this.menuLocacaoDevGravar.Name = "menuLocacaoDevGravar";
            this.menuLocacaoDevGravar.Size = new System.Drawing.Size(78, 20);
            this.menuLocacaoDevGravar.Text = "GRAVAR";
            this.menuLocacaoDevGravar.Click += new System.EventHandler(this.menuLocacaoDevGravar_Click);
            // 
            // menuLocacaoDevEditar
            // 
            this.menuLocacaoDevEditar.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoDevEditar.Image")));
            this.menuLocacaoDevEditar.Name = "menuLocacaoDevEditar";
            this.menuLocacaoDevEditar.Size = new System.Drawing.Size(72, 20);
            this.menuLocacaoDevEditar.Text = "EDITAR";
            // 
            // menuLocacaoDevCancelar
            // 
            this.menuLocacaoDevCancelar.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoDevCancelar.Image")));
            this.menuLocacaoDevCancelar.Name = "menuLocacaoDevCancelar";
            this.menuLocacaoDevCancelar.Size = new System.Drawing.Size(95, 20);
            this.menuLocacaoDevCancelar.Text = "CANCELAR";
            // 
            // menuLocacaoDevExcluir
            // 
            this.menuLocacaoDevExcluir.Image = ((System.Drawing.Image)(resources.GetObject("menuLocacaoDevExcluir.Image")));
            this.menuLocacaoDevExcluir.Name = "menuLocacaoDevExcluir";
            this.menuLocacaoDevExcluir.Size = new System.Drawing.Size(80, 20);
            this.menuLocacaoDevExcluir.Text = "EXCLUIR";
            this.menuLocacaoDevExcluir.Click += new System.EventHandler(this.menuLocacaoDevExcluir_Click);
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
            this.toolStripDropDownButtonFuncoes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFuncoes.Image")));
            this.toolStripDropDownButtonFuncoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFuncoes.Name = "toolStripDropDownButtonFuncoes";
            this.toolStripDropDownButtonFuncoes.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButtonFuncoes.Text = "FUNÇÕES";
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
            // textBoxVolumeDev
            // 
            this.textBoxVolumeDev.Location = new System.Drawing.Point(18, 430);
            this.textBoxVolumeDev.Name = "textBoxVolumeDev";
            this.textBoxVolumeDev.Size = new System.Drawing.Size(68, 20);
            this.textBoxVolumeDev.TabIndex = 124;
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
            // textBoxUsuarioLocacaoDev
            // 
            this.textBoxUsuarioLocacaoDev.Location = new System.Drawing.Point(639, 91);
            this.textBoxUsuarioLocacaoDev.Name = "textBoxUsuarioLocacaoDev";
            this.textBoxUsuarioLocacaoDev.Size = new System.Drawing.Size(110, 20);
            this.textBoxUsuarioLocacaoDev.TabIndex = 122;
            // 
            // groupBoxItens
            // 
            this.groupBoxItens.Controls.Add(this.labelQtdItem);
            this.groupBoxItens.Controls.Add(this.textBoxQuantidadeItemDev);
            this.groupBoxItens.Controls.Add(this.labelNomeProduto);
            this.groupBoxItens.Controls.Add(this.comboBoxFiltroDev);
            this.groupBoxItens.Controls.Add(this.buttonExcluirItemDev);
            this.groupBoxItens.Controls.Add(this.buttonAdicionarItemDev);
            this.groupBoxItens.Controls.Add(this.textBoxValorDev);
            this.groupBoxItens.Controls.Add(this.label3);
            this.groupBoxItens.Controls.Add(this.buttonBuscarItemDev);
            this.groupBoxItens.Controls.Add(this.textBoxCodigoItemDev);
            this.groupBoxItens.Controls.Add(this.dataGridViewLocaoDev);
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
            // textBoxQuantidadeItemDev
            // 
            this.textBoxQuantidadeItemDev.Location = new System.Drawing.Point(167, 35);
            this.textBoxQuantidadeItemDev.MaxLength = 5;
            this.textBoxQuantidadeItemDev.Name = "textBoxQuantidadeItemDev";
            this.textBoxQuantidadeItemDev.Size = new System.Drawing.Size(51, 20);
            this.textBoxQuantidadeItemDev.TabIndex = 104;
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
            // comboBoxFiltroDev
            // 
            this.comboBoxFiltroDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroDev.FormattingEnabled = true;
            this.comboBoxFiltroDev.Items.AddRange(new object[] {
            "Cód. Interno",
            "Cód. Sequenc.",
            "Cód. Fabric.",
            "Cód. Barras"});
            this.comboBoxFiltroDev.Location = new System.Drawing.Point(6, 35);
            this.comboBoxFiltroDev.Name = "comboBoxFiltroDev";
            this.comboBoxFiltroDev.Size = new System.Drawing.Size(63, 21);
            this.comboBoxFiltroDev.TabIndex = 109;
            // 
            // buttonExcluirItemDev
            // 
            this.buttonExcluirItemDev.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirItemDev.Image")));
            this.buttonExcluirItemDev.Location = new System.Drawing.Point(310, 35);
            this.buttonExcluirItemDev.Name = "buttonExcluirItemDev";
            this.buttonExcluirItemDev.Size = new System.Drawing.Size(25, 24);
            this.buttonExcluirItemDev.TabIndex = 107;
            this.buttonExcluirItemDev.UseVisualStyleBackColor = true;
            this.buttonExcluirItemDev.Click += new System.EventHandler(this.buttonExcluirItemDev_Click);
            // 
            // buttonAdicionarItemDev
            // 
            this.buttonAdicionarItemDev.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarItemDev.Image")));
            this.buttonAdicionarItemDev.Location = new System.Drawing.Point(279, 35);
            this.buttonAdicionarItemDev.Name = "buttonAdicionarItemDev";
            this.buttonAdicionarItemDev.Size = new System.Drawing.Size(25, 24);
            this.buttonAdicionarItemDev.TabIndex = 106;
            this.buttonAdicionarItemDev.UseVisualStyleBackColor = true;
            // 
            // textBoxValorDev
            // 
            this.textBoxValorDev.Location = new System.Drawing.Point(224, 35);
            this.textBoxValorDev.Name = "textBoxValorDev";
            this.textBoxValorDev.Size = new System.Drawing.Size(49, 20);
            this.textBoxValorDev.TabIndex = 104;
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
            // buttonBuscarItemDev
            // 
            this.buttonBuscarItemDev.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarItemDev.Image")));
            this.buttonBuscarItemDev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarItemDev.Location = new System.Drawing.Point(138, 35);
            this.buttonBuscarItemDev.Name = "buttonBuscarItemDev";
            this.buttonBuscarItemDev.Size = new System.Drawing.Size(25, 24);
            this.buttonBuscarItemDev.TabIndex = 103;
            this.buttonBuscarItemDev.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigoItemDev
            // 
            this.textBoxCodigoItemDev.Location = new System.Drawing.Point(78, 35);
            this.textBoxCodigoItemDev.Name = "textBoxCodigoItemDev";
            this.textBoxCodigoItemDev.Size = new System.Drawing.Size(54, 20);
            this.textBoxCodigoItemDev.TabIndex = 102;
            // 
            // dataGridViewLocaoDev
            // 
            this.dataGridViewLocaoDev.AllowUserToAddRows = false;
            this.dataGridViewLocaoDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocaoDev.Location = new System.Drawing.Point(6, 62);
            this.dataGridViewLocaoDev.Name = "dataGridViewLocaoDev";
            this.dataGridViewLocaoDev.Size = new System.Drawing.Size(721, 169);
            this.dataGridViewLocaoDev.TabIndex = 101;
            this.dataGridViewLocaoDev.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocaoDev_CellClick);
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
            // textBoxQtdItemDev
            // 
            this.textBoxQtdItemDev.Location = new System.Drawing.Point(95, 430);
            this.textBoxQtdItemDev.Name = "textBoxQtdItemDev";
            this.textBoxQtdItemDev.Size = new System.Drawing.Size(68, 20);
            this.textBoxQtdItemDev.TabIndex = 119;
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
            // textBoxTotalDev
            // 
            this.textBoxTotalDev.Location = new System.Drawing.Point(657, 430);
            this.textBoxTotalDev.Name = "textBoxTotalDev";
            this.textBoxTotalDev.Size = new System.Drawing.Size(90, 20);
            this.textBoxTotalDev.TabIndex = 117;
            // 
            // textBoxDataLancamentoDev
            // 
            this.textBoxDataLancamentoDev.Location = new System.Drawing.Point(639, 46);
            this.textBoxDataLancamentoDev.Name = "textBoxDataLancamentoDev";
            this.textBoxDataLancamentoDev.Size = new System.Drawing.Size(110, 20);
            this.textBoxDataLancamentoDev.TabIndex = 115;
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
            // textBoxClienteDev
            // 
            this.textBoxClienteDev.Location = new System.Drawing.Point(12, 91);
            this.textBoxClienteDev.Name = "textBoxClienteDev";
            this.textBoxClienteDev.Size = new System.Drawing.Size(218, 20);
            this.textBoxClienteDev.TabIndex = 111;
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
            // buttonBuscarLocacoesDev
            // 
            this.buttonBuscarLocacoesDev.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarLocacoesDev.Image")));
            this.buttonBuscarLocacoesDev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarLocacoesDev.Location = new System.Drawing.Point(68, 46);
            this.buttonBuscarLocacoesDev.Name = "buttonBuscarLocacoesDev";
            this.buttonBuscarLocacoesDev.Size = new System.Drawing.Size(50, 24);
            this.buttonBuscarLocacoesDev.TabIndex = 110;
            this.buttonBuscarLocacoesDev.UseVisualStyleBackColor = true;
            // 
            // textBoxCodigoDev
            // 
            this.textBoxCodigoDev.Location = new System.Drawing.Point(12, 46);
            this.textBoxCodigoDev.Name = "textBoxCodigoDev";
            this.textBoxCodigoDev.Size = new System.Drawing.Size(50, 20);
            this.textBoxCodigoDev.TabIndex = 108;
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
            // textBoxNumeroLocacaoDev
            // 
            this.textBoxNumeroLocacaoDev.Location = new System.Drawing.Point(639, 134);
            this.textBoxNumeroLocacaoDev.Name = "textBoxNumeroLocacaoDev";
            this.textBoxNumeroLocacaoDev.Size = new System.Drawing.Size(79, 20);
            this.textBoxNumeroLocacaoDev.TabIndex = 126;
            // 
            // buttonBuscarLocacao
            // 
            this.buttonBuscarLocacao.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarLocacao.Image")));
            this.buttonBuscarLocacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuscarLocacao.Location = new System.Drawing.Point(724, 131);
            this.buttonBuscarLocacao.Name = "buttonBuscarLocacao";
            this.buttonBuscarLocacao.Size = new System.Drawing.Size(25, 24);
            this.buttonBuscarLocacao.TabIndex = 128;
            this.buttonBuscarLocacao.UseVisualStyleBackColor = true;
            this.buttonBuscarLocacao.Click += new System.EventHandler(this.buttonBuscarLocacao_Click);
            // 
            // labelInformativoGravar
            // 
            this.labelInformativoGravar.AutoSize = true;
            this.labelInformativoGravar.ForeColor = System.Drawing.Color.Red;
            this.labelInformativoGravar.Location = new System.Drawing.Point(454, 159);
            this.labelInformativoGravar.Name = "labelInformativoGravar";
            this.labelInformativoGravar.Size = new System.Drawing.Size(291, 13);
            this.labelInformativoGravar.TabIndex = 129;
            this.labelInformativoGravar.Text = "Não esqueça de clicar em gravar para finalizar a devolução!";
            // 
            // FrmLocacaoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 481);
            this.Controls.Add(this.labelInformativoGravar);
            this.Controls.Add(this.buttonBuscarLocacao);
            this.Controls.Add(this.labelNumeroLocacao);
            this.Controls.Add(this.textBoxNumeroLocacaoDev);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.textBoxVolumeDev);
            this.Controls.Add(this.labelUsuarioLocacao);
            this.Controls.Add(this.textBoxUsuarioLocacaoDev);
            this.Controls.Add(this.groupBoxItens);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxQtdItemDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTotalDev);
            this.Controls.Add(this.textBoxDataLancamentoDev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClienteDev);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.buttonBuscarLocacoesDev);
            this.Controls.Add(this.textBoxCodigoDev);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocaoDev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLocacao;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoDevNovo;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoDevGravar;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoDevEditar;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoDevCancelar;
        private System.Windows.Forms.ToolStripMenuItem menuLocacaoDevExcluir;
        private System.Windows.Forms.ToolStrip toolStripMenusConsultaParticipante;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFuncoes;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox textBoxVolumeDev;
        private System.Windows.Forms.Label labelUsuarioLocacao;
        private System.Windows.Forms.TextBox textBoxUsuarioLocacaoDev;
        private System.Windows.Forms.GroupBox groupBoxItens;
        private System.Windows.Forms.Label labelQtdItem;
        private System.Windows.Forms.TextBox textBoxQuantidadeItemDev;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.ComboBox comboBoxFiltroDev;
        private System.Windows.Forms.Button buttonExcluirItemDev;
        private System.Windows.Forms.Button buttonAdicionarItemDev;
        private System.Windows.Forms.TextBox textBoxValorDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscarItemDev;
        private System.Windows.Forms.TextBox textBoxCodigoItemDev;
        private System.Windows.Forms.DataGridView dataGridViewLocaoDev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxQtdItemDev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalDev;
        private System.Windows.Forms.TextBox textBoxDataLancamentoDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClienteDev;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Button buttonBuscarLocacoesDev;
        private System.Windows.Forms.TextBox textBoxCodigoDev;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNumeroLocacao;
        private System.Windows.Forms.TextBox textBoxNumeroLocacaoDev;
        private System.Windows.Forms.Button buttonBuscarLocacao;
        private System.Windows.Forms.Label labelInformativoGravar;
    }
}