using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.DTO;
using Centaurus.DAL;
using Centaurus.BLL;
using Centaurus.Model;
using Centaurus.Bll;

namespace Centaurus
{
    public partial class FrmLocacaoDevolucao : Form
    {
        string botaoClicado= "INICIAL";
        string usuarioLogadoSistema;
        string idLocacaoReturn;//Váriavel para guardar o id da locação vinda da tela locação quando gerado devolução automática
        string idClienteReturn;//Váriavel para guardar o id do cliente vinda da tela locação quando pesquisado a locação para devolução
        string qtdRestanteProdutoReturn;
        string idProdutovariacaoReturn;

        string codigoItemClicado;//váriaveis para guardar informações para posterior exclusão do item da tabela devolução.

        FrmConsultaLocacao frmConsultaLocacao;
        FrmConsultaProdutoDevolucao frmConsultaProdDev;
        FrmConsultaDevolucaoLocacao frmConsultaDevLoc;

        LocacaoDevolucaoDAO locacaoDevDAO = new LocacaoDevolucaoDAO();

        public FrmLocacaoDevolucao(string idLocacaoRetornada,string usuarioLogado)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            usuarioLogadoSistema = usuarioLogado;
            idLocacaoReturn = idLocacaoRetornada;

            if(String.IsNullOrEmpty(idLocacaoRetornada) == true)
            {   //Aqui é a locação gerada manualmente caso queira importar algo
                
            }
            else
            {
                //Aqui entra na locação automática gerada a partir da tela locação
                botaoClicado = "INICIAL-EDIT";
                textBoxUsuarioLocacaoDev.Text = usuarioLogadoSistema;
                textBoxNumeroLocacaoDev.Text = idLocacaoRetornada;

                buscarInformacoesLocacao();

                var result = MessageBox.Show("Deseja importar os itens da locação na devolução? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Método importar os itens  
                    LocacaoDevolucaoBLL locacaoDevBLL = new LocacaoDevolucaoBLL();
                    LocacaoDevolucaoModelo modLocacaoDev = new LocacaoDevolucaoModelo();

                    modLocacaoDev.idLocacao = Convert.ToInt32(textBoxNumeroLocacaoDev.Text);
                    modLocacaoDev.idLocacaoDev = Convert.ToInt32(textBoxCodigoDev.Text);
                    locacaoDevBLL.importarItensLocacaoDev(modLocacaoDev);

                    carregarItens();
                }         

            }

            inativarBotoesCampos();

        }

        public void inativarBotoesCampos()
        {
            switch (botaoClicado)
            {
                case "INICIAL":
                    menuLocacaoDevNovo.Enabled = true;
                    menuLocacaoDevGravar.Enabled = false;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = false;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = true;
                    buttonBuscarItemDev.Enabled = false;
                    buttonAdicionarItemDev.Enabled = false;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = true;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = false;
                    textBoxCodigoItemDev.Enabled = false;
                    textBoxQuantidadeItemDev.Enabled = false;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = false;

                    textBoxCodigoDev.Clear();
                    textBoxClienteDev.Clear();
                    textBoxDataLancamentoDev.Clear();
                    textBoxUsuarioLocacaoDev.Clear();
                    textBoxNumeroLocacaoDev.Clear();
                    //comboBoxFiltroDev.Clear();
                    textBoxCodigoItemDev.Clear();
                    textBoxQuantidadeItemDev.Clear();
                    textBoxValorDev.Clear();
                    textBoxVolumeDev.Text = "0";
                    textBoxQtdItemDev.Text = "0";
                    textBoxTotalDev.Text = "0";

                    break;

                case "INICIAL-EDIT":

                    menuLocacaoDevNovo.Enabled = false;
                    menuLocacaoDevGravar.Enabled = true;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = true;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = false;                    
                    buttonBuscarItemDev.Enabled = true;//validar se importou produto
                    buttonAdicionarItemDev.Enabled = true;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = false;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = true;
                    textBoxCodigoItemDev.Enabled = true;
                    textBoxQuantidadeItemDev.Enabled = true;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = true;
                  
                    break;

                case "IMPORTARLOC":

                    menuLocacaoDevNovo.Enabled = false;
                    menuLocacaoDevGravar.Enabled = true;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = true;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = false;
                    buttonBuscarItemDev.Enabled = true;//validar se importou produto
                    buttonAdicionarItemDev.Enabled = true;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = false;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = true;
                    textBoxCodigoItemDev.Enabled = true;
                    textBoxQuantidadeItemDev.Enabled = true;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = true;
                    
                    if(textBoxCodigoDev.Text == null)
                    {
                        textBoxCodigoDev.Text = "0";
                    }

                    break;

                case "NOVO":

                    menuLocacaoDevNovo.Enabled = false;
                    menuLocacaoDevGravar.Enabled = true;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = true;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = false;
                    buttonBuscarItemDev.Enabled = true;
                    buttonAdicionarItemDev.Enabled = true;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = true;

                    textBoxCodigoDev.Enabled = false;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = true;
                    textBoxCodigoItemDev.Enabled = true;
                    textBoxQuantidadeItemDev.Enabled = true;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = true;

                    textBoxCodigoDev.Clear();
                    textBoxClienteDev.Clear();
                    textBoxDataLancamentoDev.Clear();
                    textBoxUsuarioLocacaoDev.Clear();
                    textBoxNumeroLocacaoDev.Clear();
                    //comboBoxFiltroDev.Clear();
                    textBoxCodigoItemDev.Clear();
                    textBoxQuantidadeItemDev.Clear();
                    textBoxValorDev.Clear();
                    textBoxVolumeDev.Text = "0";
                    textBoxQtdItemDev.Text = "0";
                    textBoxTotalDev.Text = "0";

                    break;

                case "GRAVAR":

                    menuLocacaoDevNovo.Enabled = true;
                    menuLocacaoDevGravar.Enabled = false;
                    menuLocacaoDevEditar.Enabled = true;
                    menuLocacaoDevCancelar.Enabled = false;
                    menuLocacaoDevExcluir.Enabled = true;

                    buttonBuscarLocacoesDev.Enabled = true;
                    buttonBuscarItemDev.Enabled = false;
                    buttonAdicionarItemDev.Enabled = false;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = true;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = false;
                    textBoxCodigoItemDev.Enabled = false;
                    textBoxQuantidadeItemDev.Enabled = false;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = false;

                    break;

                case "EDITAR":

                    menuLocacaoDevNovo.Enabled = false;
                    menuLocacaoDevGravar.Enabled = true;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = true;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = false;
                    buttonBuscarItemDev.Enabled = true;//validar se importou produto
                    buttonAdicionarItemDev.Enabled = true;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = false;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = true;
                    textBoxCodigoItemDev.Enabled = true;
                    textBoxQuantidadeItemDev.Enabled = true;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = true;

                    if (textBoxCodigoDev.Text == null)
                    {
                        textBoxCodigoDev.Text = "0";
                    }
                    
                    break;

                case "CANCELAR":

                    menuLocacaoDevNovo.Enabled = true;
                    menuLocacaoDevGravar.Enabled = false;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = false;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = true;
                    buttonBuscarItemDev.Enabled = false;
                    buttonAdicionarItemDev.Enabled = false;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = true;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = false;
                    textBoxCodigoItemDev.Enabled = false;
                    textBoxQuantidadeItemDev.Enabled = false;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = false;

                    textBoxCodigoDev.Clear();
                    textBoxClienteDev.Clear();
                    textBoxDataLancamentoDev.Clear();
                    textBoxUsuarioLocacaoDev.Clear();
                    textBoxNumeroLocacaoDev.Clear();
                    //comboBoxFiltroDev.Clear();
                    textBoxCodigoItemDev.Clear();
                    textBoxQuantidadeItemDev.Clear();
                    textBoxValorDev.Clear();
                    textBoxVolumeDev.Text = "0";
                    textBoxQtdItemDev.Text = "0";
                    textBoxTotalDev.Text = "0";

                    break;

                case "EXCLUIR":

                    menuLocacaoDevNovo.Enabled = true;
                    menuLocacaoDevGravar.Enabled = false;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = false;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = true;
                    buttonBuscarItemDev.Enabled = false;
                    buttonAdicionarItemDev.Enabled = false;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = true;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = false;
                    textBoxCodigoItemDev.Enabled = false;
                    textBoxQuantidadeItemDev.Enabled = false;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = false;

                    textBoxCodigoDev.Clear();
                    textBoxClienteDev.Clear();
                    textBoxDataLancamentoDev.Clear();
                    textBoxUsuarioLocacaoDev.Clear();
                    textBoxNumeroLocacaoDev.Clear();
                    //comboBoxFiltroDev.Clear();
                    textBoxCodigoItemDev.Clear();
                    textBoxQuantidadeItemDev.Clear();
                    textBoxValorDev.Clear();
                    textBoxVolumeDev.Text = "0";
                    textBoxQtdItemDev.Text = "0";
                    textBoxTotalDev.Text = "0";

                    break;

                case "PESQUISAR":

                    menuLocacaoDevNovo.Enabled = false;
                    menuLocacaoDevGravar.Enabled = false;
                    menuLocacaoDevEditar.Enabled = true;
                    menuLocacaoDevCancelar.Enabled = false;
                    menuLocacaoDevExcluir.Enabled = true;

                    buttonBuscarLocacoesDev.Enabled = false;
                    buttonBuscarItemDev.Enabled = false;
                    buttonAdicionarItemDev.Enabled = false;
                    buttonExcluirItemDev.Enabled = false;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = false;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = false;
                    textBoxCodigoItemDev.Enabled = false;
                    textBoxQuantidadeItemDev.Enabled = false;
                    textBoxValorDev.Enabled = false;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;                                     

                    break;
            }
        }

        private void menuLocacaoDevNovo_Click(object sender, EventArgs e)
        {
            botaoClicado = "NOVO";
            inativarBotoesCampos();

            textBoxUsuarioLocacaoDev.Text = usuarioLogadoSistema;
            textBoxDataLancamentoDev.Text = DateTime.Now.ToString();
        }

        public void buscarInformacoesLocacao()
        { 
            LocacaoDevolucaoModelo modlocacaoDev = new LocacaoDevolucaoModelo();
            LocacaoDevolucaoDAO locacaoDevDao = new LocacaoDevolucaoDAO();            

            try
            {
                //Método enviar a id da locacao para pesquisar a devolução da locação
                modlocacaoDev.idLocacao = Convert.ToInt32(idLocacaoReturn);
                modlocacaoDev = locacaoDevDao.buscarLocacaoDev(modlocacaoDev);

                string nomeCliente = modlocacaoDev.nomeClienteLocacaoDev;
                int idCliente = modlocacaoDev.idClienteLocacaoDev;
                textBoxClienteDev.Text = idCliente + " - " + nomeCliente;
                int idDevLocacao = modlocacaoDev.idLocacaoDev;
                textBoxCodigoDev.Text = Convert.ToString(idDevLocacao);
                DateTime dataLanc = modlocacaoDev.dataLancamentoLocacaoDev;
                textBoxDataLancamentoDev.Text = Convert.ToString(dataLanc);

            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        private void carregarItens()
        {
            dataGridViewLocaoDev.DataSource = locacaoDevDAO.listarItens(textBoxCodigoDev.Text);
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            float somadoGrid, valorDesconto;
            int qtdRegistros;

            //Renomeando as colunas
            dataGridViewLocaoDev.Columns[0].HeaderText = "Código";
            dataGridViewLocaoDev.Columns[2].HeaderText = "Descrição";
            dataGridViewLocaoDev.Columns[3].HeaderText = "UN";
            dataGridViewLocaoDev.Columns[4].HeaderText = "Qtd";
            dataGridViewLocaoDev.Columns[5].HeaderText = "R$ Unit.";
            dataGridViewLocaoDev.Columns[6].HeaderText = "R$ Total";
            dataGridViewLocaoDev.Columns[7].HeaderText = "Marca";
            dataGridViewLocaoDev.Columns[8].HeaderText = "Categoria";
            dataGridViewLocaoDev.Columns[9].HeaderText = "Sub-Categoria";
            dataGridViewLocaoDev.Columns[10].HeaderText = "Fornecedor";

            //Configurando o tamanho das colunas
            dataGridViewLocaoDev.Columns[0].Width = 45;
            dataGridViewLocaoDev.Columns[2].Width = 170;
            dataGridViewLocaoDev.Columns[3].Width = 50;
            dataGridViewLocaoDev.Columns[4].Width = 45;
            dataGridViewLocaoDev.Columns[5].Width = 60;
            dataGridViewLocaoDev.Columns[6].Width = 60;
            dataGridViewLocaoDev.Columns[7].Width = 90;
            dataGridViewLocaoDev.Columns[8].Width = 90;
            dataGridViewLocaoDev.Columns[9].Width = 90;
            dataGridViewLocaoDev.Columns[10].Width = 120;

            //Ocultando algumas colunas na tabela
            dataGridViewLocaoDev.Columns["CodigoProdutoVariacao"].Visible = false;
            dataGridViewLocaoDev.Columns["idLocacao_locacaoitens"].Visible = false;
            dataGridViewLocaoDev.Columns["idlocacaoitens"].Visible = false;

            //Convertendo as colunas do dataGridView            
            this.dataGridViewLocaoDev.Columns[5].ValueType = typeof(decimal);
            this.dataGridViewLocaoDev.Columns[5].DefaultCellStyle.Format = "N2";
            this.dataGridViewLocaoDev.Columns[6].ValueType = typeof(decimal);
            this.dataGridViewLocaoDev.Columns[6].DefaultCellStyle.Format = "N2";

            //Método para contar a quantidade de itens na tabela
            textBoxQtdItemDev.Text = dataGridViewLocaoDev.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["QtdLocada"].Value)).ToString("N2");

            //Método para fazer o calculo do total de itens e setar no campo
            float somadoGridTotalItens = dataGridViewLocaoDev.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            decimal resultadoTotalItens;
            resultadoTotalItens = Convert.ToDecimal(somadoGridTotalItens.ToString("N2"));
            textBoxTotalDev.Text = Convert.ToString(resultadoTotalItens);

            //Conta a quantidade de volumes e seta no campo
            qtdRegistros = dataGridViewLocaoDev.Rows.Count;
            textBoxVolumeDev.Text = Convert.ToString(qtdRegistros);

        }

        private void menuLocacaoDevGravar_Click(object sender, EventArgs e)
        {
            LocacaoDevolucaoModelo locDevMod = new LocacaoDevolucaoModelo();
            finalizarLocacaoDev(locDevMod);
        }

        public void finalizarLocacaoDev(LocacaoDevolucaoModelo modLocacao)
        {
            LocacaoDevolucaoBLL devolucaoBLL = new LocacaoDevolucaoBLL();

            if (String.IsNullOrEmpty(idClienteReturn) == true)
            {   //Clausula utilizada para salvar a locação quando a mesma for gerada pela tela de locação
                modLocacao.qtdItensLocacaoDev = Convert.ToSingle(textBoxQtdItemDev.Text);
                modLocacao.totalLocacaoDev = Convert.ToSingle(textBoxTotalDev.Text);
                modLocacao.usuarioLocacaoDev = textBoxUsuarioLocacaoDev.Text;
                modLocacao.dataDevolucaoLocacaoDev = Convert.ToDateTime(textBoxDataLancamentoDev.Text);
                modLocacao.idLocacaoDev = Convert.ToInt32(textBoxCodigoDev.Text);

                devolucaoBLL.salvarLocacao(modLocacao);
            }
            else
            {   //Clausula utilizada para salvar a locação quando a mesma for gerda manualmente pela tela de devolução da locação
                modLocacao.idClienteLocacaoDev = Convert.ToInt32(idClienteReturn);
                modLocacao.qtdItensLocacaoDev = Convert.ToSingle(textBoxQtdItemDev.Text);
                modLocacao.totalLocacaoDev = Convert.ToSingle(textBoxTotalDev.Text);
                modLocacao.idLocacao = Convert.ToInt32(textBoxNumeroLocacaoDev.Text);
                modLocacao.usuarioLocacaoDev = textBoxUsuarioLocacaoDev.Text;
                modLocacao.dataDevolucaoLocacaoDev = Convert.ToDateTime(textBoxDataLancamentoDev.Text);
                modLocacao.idLocacaoDev = Convert.ToInt32(textBoxCodigoDev.Text);

                devolucaoBLL.salvarLocacao(modLocacao);
            }
            
            MessageBox.Show("Devolução da locação finalizada! ", "Devolução Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            botaoClicado = "GRAVAR";
            inativarBotoesCampos();
           

        }

        private void dataGridViewLocaoDev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonExcluirItemDev.Enabled = true;

            codigoItemClicado = dataGridViewLocaoDev.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void buttonBuscarLocacao_Click(object sender, EventArgs e)
        {
            frmConsultaLocacao = new FrmConsultaLocacao();
            DialogResult dr = frmConsultaLocacao.ShowDialog(this);

            idClienteReturn = frmConsultaLocacao.idClienteEnvia;
            if (String.IsNullOrEmpty(idClienteReturn) == true)
            {
                MessageBox.Show("Você não selecionou nenhuma locação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                botaoClicado = "IMPORTARLOC";

                string nomeClienteReturn = frmConsultaLocacao.NomeClienteEnvia;
                textBoxClienteDev.Text = idClienteReturn + " - " + nomeClienteReturn;
                textBoxNumeroLocacaoDev.Text = frmConsultaLocacao.idLocacaoEnvia;

                var result = MessageBox.Show("Deseja importar os itens da locação na devolução? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Método gera id da locação para vincular nos itens que serão importados
                    LocacaoDevolucaoModelo modLocDev = new LocacaoDevolucaoModelo();
                    gerarID(modLocDev);

                    //Método importar os itens da locação para devolução da locação
                    LocacaoDevolucaoBLL locacaoDevBLL = new LocacaoDevolucaoBLL();
                    LocacaoDevolucaoModelo modLocacaoDev = new LocacaoDevolucaoModelo();
                    modLocacaoDev.idLocacao = Convert.ToInt32(textBoxNumeroLocacaoDev.Text);
                    modLocacaoDev.idLocacaoDev = Convert.ToInt32(textBoxCodigoDev.Text);
                    locacaoDevBLL.importarItensLocacaoDev(modLocacaoDev);

                    //Método carrega os itens na tabela
                    carregarItens();
                }

                inativarBotoesCampos();
            }
        }

        private void menuLocacaoDevExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                botaoClicado = "EXCLUIR";
                LocacaoDevolucaoModelo modLocDev = new LocacaoDevolucaoModelo();
                exluirLocacao(modLocDev);
                inativarBotoesCampos();
            }            
        }

        private void buttonExcluirItemDev_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                LocacaoDevolucaoBLL bllLocaDev = new LocacaoDevolucaoBLL();
                LocacaoDevolucaoModelo modLocaDev = new LocacaoDevolucaoModelo();

                modLocaDev.codigoItem = Convert.ToInt32(codigoItemClicado);
                bllLocaDev.excluirItemLocacaoDev(modLocaDev);

                carregarItens();
                buttonExcluirItemDev.Enabled = false;
            }
        }

        //Método gerar id da devolução da locação e setar no campo
        public void gerarID(LocacaoDevolucaoModelo modLocDev)
        {
            LocacaoDevolucaoDAO daoLocDev = new LocacaoDevolucaoDAO();
            LocacaoDevolucaoBLL bllLocDev = new LocacaoDevolucaoBLL();

            //Método gera a id da locação devolução
            modLocDev.dataLancamentoLocacaoDev = Convert.ToDateTime(textBoxDataLancamentoDev.Text);
            bllLocDev.gerarIDLocacaoDev(modLocDev);


            //Método chama o ultimo registro
            string data = textBoxDataLancamentoDev.Text;
            var dataConvertida = DateTime.Parse(data).ToString("yyyy-MM-dd HH:mm:ss");
            daoLocDev.pegarIdGerada(dataConvertida);
            string idReturn = daoLocDev.numeroIncluido;
            textBoxCodigoDev.Text = idReturn;

        }

        private void buttonBuscarItemDev_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxNumeroLocacaoDev.Text) == true)
            {
                MessageBox.Show("Você não selecionou nenhuma locação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmConsultaProdDev = new FrmConsultaProdutoDevolucao(textBoxNumeroLocacaoDev.Text);
                DialogResult dr = frmConsultaProdDev.ShowDialog(this);
                
                string idProduto = frmConsultaProdDev.idProdutoEnvia;
                if (String.IsNullOrEmpty(idProduto) == true)
                {
                    MessageBox.Show("Você não selecionou nenhum produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBoxCodigoItemDev.Text = idProduto;
                    idProdutovariacaoReturn = frmConsultaProdDev.idVariacaoProdutoEnvia;
                    string valorProdutoLocado = frmConsultaProdDev.valorLocadoProdutoEnvia;
                    float valorProdutoConvertido = Convert.ToSingle(valorProdutoLocado);

                    decimal valorProdutoFormatado;
                    valorProdutoFormatado = Convert.ToDecimal(valorProdutoConvertido.ToString("N2"));
                    textBoxValorDev.Text = Convert.ToString(valorProdutoFormatado);
                    textBoxQuantidadeItemDev.Text = "1";

                    qtdRestanteProdutoReturn = frmConsultaProdDev.qtdRestanteProdutoEnvia;
                }                
            }
        }

        private void textBoxQuantidadeItemDev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonAdicionarItemDev_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBoxQuantidadeItemDev.Text) > Convert.ToInt32(qtdRestanteProdutoReturn))
            {
                MessageBox.Show("Quantidade informada maior que a disponivel para devolução! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (String.IsNullOrEmpty(textBoxCodigoDev.Text) == true)
                {
                    LocacaoDevolucaoModelo modLocDev = new LocacaoDevolucaoModelo();
                    gerarID(modLocDev);

                    inserirItemDevLocacao(modLocDev);
                }
                else
                {
                    LocacaoDevolucaoModelo modLocDev = new LocacaoDevolucaoModelo();
                    inserirItemDevLocacao(modLocDev);
                }
            }
        }

        private void menuLocacaoDevCancelar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCodigoDev.Text) == true)
            {
                botaoClicado = "CANCELAR";
                inativarBotoesCampos();
            }
            else if(textBoxCodigoDev.Text == "0")
            {
                botaoClicado = "CANCELAR";
                inativarBotoesCampos();
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    LocacaoDevolucaoBLL bllLocaDev = new LocacaoDevolucaoBLL();
                    LocacaoDevolucaoModelo modLocaDev = new LocacaoDevolucaoModelo();

                    modLocaDev.codigoItem = Convert.ToInt32(codigoItemClicado);
                    bllLocaDev.excluirItemLocacaoDev(modLocaDev);

                    carregarItens();
                    buttonExcluirItemDev.Enabled = false;
                }
                else
                {
                    botaoClicado = "CANCELAR";
                    inativarBotoesCampos();
                }
            }            
        }

        public void inserirItemDevLocacao(LocacaoDevolucaoModelo modLocDev)
        {
            LocacaoDevolucaoBLL bllDevLoc = new LocacaoDevolucaoBLL();
            modLocDev.idProdutoDevLocacao = Convert.ToInt32(textBoxCodigoItemDev.Text);
            modLocDev.idProdutoVariacaoDevLocacao = Convert.ToInt32(idProdutovariacaoReturn);
            modLocDev.qtdProdutoDevLocacao = Convert.ToDouble(textBoxQuantidadeItemDev.Text);
            modLocDev.valorProdutoDevLocacao = Convert.ToSingle(textBoxValorDev.Text);
            modLocDev.idLocacaoDev = Convert.ToInt32(textBoxCodigoDev.Text);
            bllDevLoc.inserirItemDevLocacao(modLocDev);

            textBoxCodigoItemDev.Clear();
            textBoxQuantidadeItemDev.Clear();
            textBoxValorDev.Clear();
            idProdutovariacaoReturn = null;

            carregarItens();

        }

        public void exluirLocacao(LocacaoDevolucaoModelo modLocDev)
        {
            LocacaoDevolucaoBLL bllLocDev = new LocacaoDevolucaoBLL();
            modLocDev.idLocacaoDev = Convert.ToInt32(textBoxCodigoDev.Text);
            bllLocDev.excluirLocacao(modLocDev);
            MessageBox.Show("Devolução da locação excluida", "Excluir Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonBuscarLocacoesDev_Click(object sender, EventArgs e)
        {
            frmConsultaDevLoc = new FrmConsultaDevolucaoLocacao();
            DialogResult dr = frmConsultaDevLoc.ShowDialog(this);

            idClienteReturn = frmConsultaDevLoc.idClienteEnvia;
            if (String.IsNullOrEmpty(idClienteReturn) == true)
            {
                MessageBox.Show("Você não selecionou nenhuma devolução!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                botaoClicado = "PESQUISAR";

                string nomeClienteReturn = frmConsultaDevLoc.NomeClienteEnvia;
                textBoxClienteDev.Text = idClienteReturn + " - " + nomeClienteReturn;
                textBoxCodigoDev.Text = frmConsultaDevLoc.idDevLocacaoEnvia;
                textBoxDataLancamentoDev.Text = frmConsultaDevLoc.DataLancamentoEnvia;
                textBoxUsuarioLocacaoDev.Text = frmConsultaDevLoc.UsuarioEnvia;

                //textBoxNumeroLocacaoDev.Text = frmConsultaDevLoc.idLocacaoEnvia;

                carregarItens();
                inativarBotoesCampos();
            }
        }

        private void menuLocacaoDevEditar_Click(object sender, EventArgs e)
        {
            botaoClicado = "EDITAR";
            inativarBotoesCampos();            
        }

        private void textBoxCodigoItemDev_KeyDown(object sender, KeyEventArgs e)
        {
            ProdutoModelo produtoModelo = new ProdutoModelo();
            ProdutoBLL produtoBLL = new ProdutoBLL();

            if (e.KeyCode == Keys.Enter)
            {
                if (comboBoxFiltroDev.SelectedItem == "Cód. Barras")
                { 

                }
                else
                {
                    produtoModelo.idProduto = Convert.ToInt32(textBoxCodigoItemDev.Text);
                    produtoModelo.idLocacao = Convert.ToInt32(textBoxNumeroLocacaoDev.Text);
                    produtoBLL.buscarProdutoClickDev(produtoModelo);

                    //Verifico  se o retorno do código do produto é maior que um, caso seja abro a tela para selecionar o produto variação
                    if(produtoModelo.idProduto > 1)
                    {

                    }
                    else
                    //Aqui já puxo o item pelo código informado
                    {
                        string nomeProduto = produtoModelo.descricaoProduto;
                        labelNomeProduto.Text = nomeProduto;

                        float valorProduto = produtoModelo.vendaProduto;
                        textBoxValorDev.Text = Convert.ToString(valorProduto);

                        idProdutovariacaoReturn = Convert.ToString(produtoModelo.idProdVariacao);

                        qtdRestanteProdutoReturn = Convert.ToString(produtoModelo.qtdRestanteProdutoDev);
                        //Verifico se ainda existe itens restante a ser devolvido deste código
                        if(Convert.ToInt32(qtdRestanteProdutoReturn) <= 0)
                        {
                            textBoxQuantidadeItemDev.Text = "0";
                            MessageBox.Show("Não existe mais itens deste produto a ser devolvido! ", "Atenção!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            textBoxQuantidadeItemDev.Text = "1";
                        }
                    }
                }
            }
        }
    }
}
