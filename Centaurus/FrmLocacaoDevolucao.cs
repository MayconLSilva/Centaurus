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

namespace Centaurus
{
    public partial class FrmLocacaoDevolucao : Form
    {
        string botaoClicado= "INICIAL";
        string usuarioLogadoSistema;
        string idLocacaoReturn;

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
                //throw new Exception("Erro ao buscar locação devolução, tela devolução " + erro.Message);
            }
        }



    }
}
