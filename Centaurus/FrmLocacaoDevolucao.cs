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

namespace Centaurus
{
    public partial class FrmLocacaoDevolucao : Form
    {
        string botaoClicado= "INICIAL";
        string usuarioLogadoSistema;
        string idLocacaoReturn;

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
            {
                Console.WriteLine("locação manual");
            }
            else
            {
                Console.WriteLine("locação automática "+idLocacaoRetornada);
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
                    locacaoDevBLL.inserirItemLocacaoDev(modLocacaoDev);

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
                    buttonBuscarClienteDev.Enabled = false;
                    buttonLimparClienteDev.Enabled = false;
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
                    buttonBuscarClienteDev.Enabled = false;
                    buttonLimparClienteDev.Enabled = false;
                    buttonBuscarItemDev.Enabled = true;//validar se importou produto
                    buttonAdicionarItemDev.Enabled = true;
                    buttonExcluirItemDev.Enabled = true;
                    buttonBuscarLocacao.Enabled = false;

                    textBoxCodigoDev.Enabled = false;
                    textBoxClienteDev.Enabled = false;
                    textBoxDataLancamentoDev.Enabled = false;
                    textBoxUsuarioLocacaoDev.Enabled = false;
                    textBoxNumeroLocacaoDev.Enabled = false;
                    comboBoxFiltroDev.Enabled = true;
                    textBoxCodigoItemDev.Enabled = true;
                    textBoxQuantidadeItemDev.Enabled = true;
                    textBoxValorDev.Enabled = true;
                    textBoxVolumeDev.Enabled = false;
                    textBoxQtdItemDev.Enabled = false;
                    textBoxTotalDev.Enabled = false;

                    dataGridViewLocaoDev.Enabled = true;

                    /*
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
                    */

                    break;

                case "PESQUISAR":

                    break;

                case "NOVO":

                    menuLocacaoDevNovo.Enabled = false;
                    menuLocacaoDevGravar.Enabled = true;
                    menuLocacaoDevEditar.Enabled = false;
                    menuLocacaoDevCancelar.Enabled = true;
                    menuLocacaoDevExcluir.Enabled = false;

                    buttonBuscarLocacoesDev.Enabled = false;
                    buttonBuscarClienteDev.Enabled = true;
                    buttonLimparClienteDev.Enabled = true;
                    buttonBuscarItemDev.Enabled = true;
                    buttonAdicionarItemDev.Enabled = true;
                    buttonExcluirItemDev.Enabled = true;
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

            //Método para fazer o calculo de desconto e aplicar no campo total
            /*
            somadoGrid = dataGridViewLocaoDev.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            valorDesconto = Convert.ToSingle(textBoxDesconto.Text);
            float resultadoTotal = somadoGrid - valorDesconto;
            decimal resultadoTotalConvertido;
            resultadoTotalConvertido = Convert.ToDecimal(resultadoTotal.ToString("N2"));
            textBoxTotal.Text = Convert.ToString(resultadoTotalConvertido);
            */

            //Método para fazer o calculo do total de itens e setar no campo
            float somadoGridTotalItens = dataGridViewLocaoDev.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            decimal resultadoTotalItens;
            resultadoTotalItens = Convert.ToDecimal(somadoGridTotalItens.ToString("N2"));
            textBoxTotalDev.Text = Convert.ToString(resultadoTotalItens);

            //Conta a quantidade de volumes e seta no campo
            qtdRegistros = dataGridViewLocaoDev.Rows.Count;
            textBoxVolumeDev.Text = Convert.ToString(qtdRegistros);

        }



    }
}
