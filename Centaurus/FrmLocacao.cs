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
using Centaurus.BLL;
using Centaurus.Dao;
using System.Globalization;
using Microsoft.VisualBasic;
using Centaurus.Model;
using Centaurus.Bll;

namespace Centaurus
{
    public partial class FrmLocacao : Form
    {
        string botaoClicado = "INICIAR",botaoInserir="NAOCLICADO";
        int flag = 0;

        //Váriavel para guardar o nome do usuário logado no sistema
        string returnUsuarioLogado;

        //Váriavel para guardar o valor de retorno da consulta do cliente
        public string idClienteReturn;
        FrmConsultaParticipante frmConsultaParticipante;

        //Váriavel para guardar o valor de retorno da consulta do produto
        string idProdutoReturn, idVariacaoProdutoReturn, valorProdutoReturn, custoProdutoReturn,valorOriginalProdutoReturn,nomeProdutoReturn;
        FrmConsultaProduto frmConsultaProduto;

        //Váriavel para guardar o valor de retorno da consulta da locacação
        FrmConsultaLocacao frmConsultaLocacao;

        //Váriavel para pegar a informação do item clicado e sua respectiva exclusão
        string idProdutoExcluir, nomeProdutoExcluir;

        //Váriavel para guardar o valor retornado do dialog desconto dado
        FrmDialogDesconto_Locacao frmDesconto;
        float descontoReturn,totalRetun;

        LocacaoBLL locacaoBLL = new LocacaoBLL();

        public FrmLocacao()
        {
            //InitializeComponent();

            //this.StartPosition = FormStartPosition.Manual;
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            //this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            //inativaAtivaCampos();
        }

        public FrmLocacao(string valorRetornado)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            inativaAtivaCampos();
            returnUsuarioLogado = valorRetornado;
        }

        private void menuLocacaoNovo_Click(object sender, EventArgs e)
        {
            flag = 0;
            botaoClicado = "NOVO";
            inativaAtivaCampos();
            textBoxDataLancamento.Text = DateTime.Now.ToString();
            textBoxUsuarioLocacao.Text = returnUsuarioLogado;
        }

        public void inativaAtivaCampos()
        {
            switch (botaoClicado)
            {
                case "INICIAR":

                    textBoxCodigo.Enabled = true;
                    buttonBuscarLocacoes.Enabled = true;
                    textBoxCliente.Enabled = false;
                    buttonBuscarCliente.Enabled = false;
                    buttonLimparCliente.Enabled = false;
                    dateTimePickerDataEntrega.Enabled = false;
                    comboBoxFiltro.Enabled = false;
                    textBoxCodigoItem.Enabled = false;
                    buttonBuscarItem.Enabled = false;
                    textBoxValor.Enabled = false;
                    buttonAdicionarItem.Enabled = false;
                    buttonExcluirItem.Enabled = false;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = false;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;
                    textBoxTotalItens.Enabled = false;

                    menuLocacaoNovo.Enabled = true;
                    menuLocacaoGravar.Enabled = false;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = false;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = false;

                    toolStripDropDownButtonFuncoes.Enabled = false;

                    textBoxCodigo.Clear();
                    //buttonBuscarLocacoes
                    textBoxCliente.Clear();
                    //buttonBuscarCliente
                    //buttonLimparCliente
                    //dateTimePickerDataEntrega.Clear();
                    //comboBoxFiltro
                    textBoxCodigoItem.Clear();
                    //buttonBuscarItem
                    textBoxValor.Clear();
                    //buttonAdicionarItem
                    //buttonExcluirItem
                    textBoxDataLancamento.Clear();
                    textBoxQtdItem.Clear();
                    textBoxDesconto.Clear();
                    textBoxTotal.Clear();
                    labelNomeProduto.Text = "";
                    textBoxQuantidadeItem.Clear();
                    textBoxUsuarioLocacao.Clear();
                    textBoxVolume.Clear();
                    textBoxTotalItens.Clear();

                    dataGridViewLocao.Enabled = false;

                    break;

                case "PESQUISAR":
                                        
                    menuLocacaoEditar.Enabled = true;
                    menuLocacaoCancelar.Enabled = true;
                    menuLocacaoExcluir.Enabled = true;

                    toolStripDropDownButtonFuncoes.Enabled = true;

                    break;

                case "NOVO":

                    textBoxCodigo.Enabled = false;
                    buttonBuscarLocacoes.Enabled = false;
                    textBoxCliente.Enabled = false;
                    buttonBuscarCliente.Enabled = true;
                    buttonLimparCliente.Enabled = true;
                    dateTimePickerDataEntrega.Enabled = true;
                    comboBoxFiltro.Enabled = true;
                    textBoxCodigoItem.Enabled = true;
                    buttonBuscarItem.Enabled = true;
                    textBoxValor.Enabled = true;
                    buttonAdicionarItem.Enabled = true;
                    buttonExcluirItem.Enabled = false;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = true;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;
                    textBoxTotalItens.Enabled = false;

                    menuLocacaoNovo.Enabled = false;
                    menuLocacaoGravar.Enabled = true;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = true;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = true;

                    toolStripDropDownButtonFuncoes.Enabled = false;

                    dataGridViewLocao.Enabled = true;

                    idClienteReturn = null;
                        
                    textBoxCodigo.Text = "0";
                    //buttonBuscarLocacoes
                    textBoxCliente.Clear();
                    //buttonBuscarCliente
                    //buttonLimparCliente
                    //dateTimePickerDataEntrega.Clear();
                    //comboBoxFiltro
                    textBoxCodigoItem.Clear();
                    //buttonBuscarItem
                    textBoxValor.Clear();
                    //buttonAdicionarItem
                    //buttonExcluirItem
                    textBoxDataLancamento.Clear();
                    textBoxQtdItem.Clear();
                    textBoxDesconto.Clear();
                    textBoxTotal.Clear();
                    labelNomeProduto.Text = "";
                    textBoxUsuarioLocacao.Clear();
                    textBoxVolume.Clear();

                    textBoxQtdItem.Text = "0";
                    textBoxDesconto.Text = "0";
                    textBoxTotal.Text = "0";
                    textBoxTotalItens.Text = "0";

                    comboBoxFiltro.SelectedIndex = comboBoxFiltro.FindStringExact("Cód. Interno");

                    break;

                case "GRAVAR":

                    textBoxCodigo.Enabled = true;
                    buttonBuscarLocacoes.Enabled = true;
                    textBoxCliente.Enabled = false;
                    buttonBuscarCliente.Enabled = false;
                    buttonLimparCliente.Enabled = false;
                    dateTimePickerDataEntrega.Enabled = false;
                    comboBoxFiltro.Enabled = false;
                    textBoxCodigoItem.Enabled = false;
                    buttonBuscarItem.Enabled = false;
                    textBoxValor.Enabled = false;
                    buttonAdicionarItem.Enabled = false;
                    buttonExcluirItem.Enabled = false;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = false;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;
                    textBoxTotalItens.Enabled = false;

                    menuLocacaoNovo.Enabled = true;
                    menuLocacaoGravar.Enabled = false;
                    menuLocacaoEditar.Enabled = true;
                    menuLocacaoCancelar.Enabled = false;
                    menuLocacaoExcluir.Enabled = true;
                    buttonCalcularDesconto.Enabled = false;

                    labelNomeProduto.Text = "";
                    textBoxQuantidadeItem.Clear();

                    toolStripDropDownButtonFuncoes.Enabled = true;

                    dataGridViewLocao.Enabled = false;

                    break;

                case "EDITAR":

                    textBoxCodigo.Enabled = false;
                    buttonBuscarLocacoes.Enabled = false;
                    textBoxCliente.Enabled = false;
                    buttonBuscarCliente.Enabled = true;
                    buttonLimparCliente.Enabled = true;
                    dateTimePickerDataEntrega.Enabled = true;
                    comboBoxFiltro.Enabled = true;
                    textBoxCodigoItem.Enabled = true;
                    buttonBuscarItem.Enabled = true;
                    textBoxValor.Enabled = true;
                    buttonAdicionarItem.Enabled = true;
                    buttonExcluirItem.Enabled = false;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = true;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;
                    textBoxTotalItens.Enabled = false;

                    menuLocacaoNovo.Enabled = false;
                    menuLocacaoGravar.Enabled = true;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = true;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = true;

                    toolStripDropDownButtonFuncoes.Enabled = true;

                    dataGridViewLocao.Enabled = true;

                    break;

                case "CANCELAR":

                    textBoxCodigo.Enabled = true;
                    buttonBuscarLocacoes.Enabled = true;
                    textBoxCliente.Enabled = false;
                    buttonBuscarCliente.Enabled = false;
                    buttonLimparCliente.Enabled = false;
                    dateTimePickerDataEntrega.Enabled = false;
                    comboBoxFiltro.Enabled = false;
                    textBoxCodigoItem.Enabled = false;
                    buttonBuscarItem.Enabled = false;
                    textBoxValor.Enabled = false;
                    buttonAdicionarItem.Enabled = false;
                    buttonExcluirItem.Enabled = false;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = false;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;
                    textBoxTotalItens.Enabled = false;

                    menuLocacaoNovo.Enabled = true;
                    menuLocacaoGravar.Enabled = false;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = false;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = false;

                    toolStripDropDownButtonFuncoes.Enabled = false;

                    dataGridViewLocao.Enabled = false;

                    idClienteReturn = null;

                    textBoxCodigo.Clear();
                    //buttonBuscarLocacoes
                    textBoxCliente.Clear();
                    //buttonBuscarCliente
                    //buttonLimparCliente
                    //dateTimePickerDataEntrega.Clear();
                    //comboBoxFiltro
                    textBoxCodigoItem.Clear();
                    //buttonBuscarItem
                    textBoxValor.Clear();
                    //buttonAdicionarItem
                    //buttonExcluirItem
                    textBoxDataLancamento.Clear();
                    textBoxQtdItem.Clear();
                    textBoxDesconto.Clear();
                    textBoxTotal.Clear();
                    labelNomeProduto.Text = "";
                    textBoxQuantidadeItem.Clear();
                    textBoxUsuarioLocacao.Clear();
                    textBoxVolume.Clear();
                    textBoxTotalItens.Clear();

                    break;

                case "EXCLUIR":

                    textBoxCodigo.Enabled = true;
                    buttonBuscarLocacoes.Enabled = true;
                    textBoxCliente.Enabled = false;
                    buttonBuscarCliente.Enabled = false;
                    buttonLimparCliente.Enabled = false;
                    dateTimePickerDataEntrega.Enabled = false;
                    comboBoxFiltro.Enabled = false;
                    textBoxCodigoItem.Enabled = false;
                    buttonBuscarItem.Enabled = false;
                    textBoxValor.Enabled = false;
                    buttonAdicionarItem.Enabled = false;
                    buttonExcluirItem.Enabled = false;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = false;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;
                    textBoxTotalItens.Enabled = false;

                    menuLocacaoNovo.Enabled = true;
                    menuLocacaoGravar.Enabled = false;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = false;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = false;

                    toolStripDropDownButtonFuncoes.Enabled = false;

                    dataGridViewLocao.Enabled = false;

                    idClienteReturn = null;

                    textBoxCodigo.Clear();
                    //buttonBuscarLocacoes
                    textBoxCliente.Clear();
                    //buttonBuscarCliente
                    //buttonLimparCliente
                    //dateTimePickerDataEntrega.Clear();
                    //comboBoxFiltro
                    textBoxCodigoItem.Clear();
                    //buttonBuscarItem
                    textBoxValor.Clear();
                    //buttonAdicionarItem
                    //buttonExcluirItem
                    textBoxDataLancamento.Clear();
                    textBoxQtdItem.Clear();
                    textBoxDesconto.Clear();
                    textBoxTotal.Clear();
                    labelNomeProduto.Text = "";
                    textBoxQuantidadeItem.Clear();
                    textBoxUsuarioLocacao.Clear();
                    textBoxVolume.Clear();
                    textBoxTotalItens.Clear();

                    break;
            }
        }

        private void menuLocacaoGravar_Click(object sender, EventArgs e)
        {
            LocacaoModelo locacaoModelo = new LocacaoModelo();
            salvar(locacaoModelo);
        }

        private void menuLocacaoEditar_Click(object sender, EventArgs e)
        {
            flag = 1;
            botaoClicado = "EDITAR";
            inativaAtivaCampos();
        }

        private void menuLocacaoCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativaAtivaCampos();
        }

        private void menuLocacaoExcluir_Click(object sender, EventArgs e)
        {      
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                LocacaoBLL locacaoBLL = new LocacaoBLL();
                LocacaoModelo locacaoModelo = new LocacaoModelo();

                locacaoModelo.idLocacao = Convert.ToInt32(textBoxCodigo.Text);
                locacaoBLL.excluirLocacao(locacaoModelo);

                botaoClicado = "EXCLUIR";
                inativaAtivaCampos();
            }
        }

        //Método validação para aceitar somente caractér númerico no campo
        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
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

        public void salvar(LocacaoModelo locacaoModelo)
        {
            //Condição utilizada para quando ñ for atualização ou alteração de uma locação que foi pesquisada
            if (flag == 0)
            {
                //Condição utilizada para inserir a id da locação quando clicado no botão para inserir um item
                if (textBoxCodigo.Text == "0" && botaoInserir == "CLICADO")
                {
                    locacaoModelo.dataLancamentoLocao = Convert.ToDateTime(textBoxDataLancamento.Text);
                    locacaoModelo.idClienteLocao = "";                    
                    locacaoBLL.salvarLocacao(locacaoModelo);

                    //Método chama o ultimo registro
                    locacaoModelo.dataLancamentoLocao = Convert.ToDateTime(textBoxDataLancamento.Text);
                    locacaoBLL.buscarUltimoRegistro(locacaoModelo);
                    textBoxCodigo.Text = Convert.ToString(locacaoModelo.idLocacao);

                    botaoInserir = "NAOCLICADO";                    
                }
                //Condição utilizada para salvar a locação sem item, quando usuário colocar nome, data, e clicar no botão gravar
                else if (textBoxCodigo.Text == "0" && botaoInserir == "NAOCLICADO")
                {
                    locacaoModelo.dataLancamentoLocao = Convert.ToDateTime(textBoxDataLancamento.Text);
                    locacaoModelo.dataPrevisaoEntregaLocao = Convert.ToDateTime(dateTimePickerDataEntrega.Value.ToString());
                    locacaoModelo.idClienteLocao = idClienteReturn;
                    locacaoModelo.descontoLocao = Convert.ToSingle(textBoxDesconto.Text);
                    locacaoModelo.qtdItensLocao = Convert.ToSingle(textBoxQtdItem.Text);
                    locacaoModelo.totalLocao = Convert.ToSingle(textBoxTotal.Text);
                    locacaoModelo.usuarioLocacao = textBoxUsuarioLocacao.Text;

                    if(String.IsNullOrEmpty(textBoxCliente.Text) == true)
                    {
                        MessageBox.Show("Informe o cliente antes de salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        locacaoBLL.salvarLocacao(locacaoModelo);
                        MessageBox.Show("Locação incluida com sucesso!!!", "Cadastro Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        botaoClicado = "GRAVAR";
                        inativaAtivaCampos();

                        //Método chama o ultimo registro
                        locacaoModelo.dataLancamentoLocao = Convert.ToDateTime(textBoxDataLancamento.Text);
                        locacaoBLL.buscarUltimoRegistro(locacaoModelo);
                        textBoxCodigo.Text = Convert.ToString(locacaoModelo.idLocacao);
                    }
                    
                }
                //Condição utilizada para salvar a locação com update após o botão inserir já ter gerada a id da locação
                else if (textBoxCodigo.Text != "0" && botaoInserir == "NAOCLICADO")
                {
                    locacaoModelo.dataPrevisaoEntregaLocao = Convert.ToDateTime(dateTimePickerDataEntrega.Value.ToString());
                    locacaoModelo.idClienteLocao = idClienteReturn;
                    locacaoModelo.descontoLocao = Convert.ToSingle(textBoxDesconto.Text);
                    locacaoModelo.qtdItensLocao = Convert.ToSingle(textBoxQtdItem.Text);
                    locacaoModelo.totalLocao = Convert.ToSingle(textBoxTotal.Text);
                    locacaoModelo.usuarioLocacao = textBoxUsuarioLocacao.Text;
                    locacaoModelo.idLocacao = Convert.ToInt32(textBoxCodigo.Text);

                    if (String.IsNullOrEmpty(textBoxCliente.Text) == true)
                    {
                        MessageBox.Show("Informe o cliente antes de salvar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        locacaoBLL.salvarLocacao(locacaoModelo);
                        MessageBox.Show("Locação incluida com sucesso!!!", "Cadastro Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        botaoClicado = "GRAVAR";
                        inativaAtivaCampos();
                    }  
                }
            }
            //Condição utilizada para  atualização ou alteração de uma locação que foi pesquisada
            else if (flag == 1)
            {
                locacaoModelo.dataPrevisaoEntregaLocao = Convert.ToDateTime(dateTimePickerDataEntrega.Value.ToString());
                locacaoModelo.idClienteLocao = idClienteReturn;
                locacaoModelo.descontoLocao = Convert.ToSingle(textBoxDesconto.Text);
                locacaoModelo.qtdItensLocao = Convert.ToSingle(textBoxQtdItem.Text);
                locacaoModelo.totalLocao = Convert.ToSingle(textBoxTotal.Text);
                locacaoModelo.idLocacao = Convert.ToInt32(textBoxCodigo.Text);

                locacaoBLL.atualizarLoca(locacaoModelo);
                MessageBox.Show("Locação atualizada com sucesso!!!", "Cadastro Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "GRAVAR";
                inativaAtivaCampos();
            }
        }

        //Método validação para aceitar somente caractér númerico no campo
        private void textBoxQuantidadeItem_KeyPress(object sender, KeyPressEventArgs e)
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

        //Método exluir item
        private void buttonExcluirItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o produto? \n" +nomeProdutoExcluir, "Excluir Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                LocacaoBLL locacaoBLL = new LocacaoBLL();
                LocacaoModelo locacaoModelo = new LocacaoModelo();

                locacaoModelo.idProdutoLocacaoItens = Convert.ToInt32(idProdutoExcluir);
                locacaoBLL.excluirItemLocacao(locacaoModelo);

                carregarItens();
                idProdutoExcluir = null;
            }
        }

        //Método validação para aceitar somente caractér númerico no campo
        private void textBoxDesconto_KeyPress(object sender, KeyPressEventArgs e)
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
             
        //Método chama o dialog do desconto
        private void buttonCalcularDesconto_Click(object sender, EventArgs e)
        {
            
            frmDesconto = new FrmDialogDesconto_Locacao(Convert.ToSingle(textBoxTotalItens.Text));
            DialogResult dr = frmDesconto.ShowDialog(this);

            descontoReturn = frmDesconto.descontoDadoEnvia;
            totalRetun = frmDesconto.valorFinalEnvia;
            if (String.IsNullOrEmpty(Convert.ToString(descontoReturn)) == true)
            {
                MessageBox.Show("Você não selecionou nenhum desconto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(descontoReturn == 0)
                {
                    decimal resultadoDesconto;
                    resultadoDesconto = Convert.ToDecimal(descontoReturn.ToString("N2"));
                    textBoxDesconto.Text = Convert.ToString(resultadoDesconto);

                    textBoxTotal.Text = textBoxTotalItens.Text;
                }
                else
                {
                    decimal resultadoDesconto;
                    resultadoDesconto = Convert.ToDecimal(descontoReturn.ToString("N2"));
                    textBoxDesconto.Text = Convert.ToString(resultadoDesconto);

                    decimal resultadoTotal;
                    resultadoTotal = Convert.ToDecimal(totalRetun.ToString("N2"));
                    textBoxTotal.Text = Convert.ToString(resultadoTotal);
                }                          
            }   
            
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {                  
            var result = MessageBox.Show("Deseja realmente gerar a devolução da locação? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {                
                LocacaoDevolucaoBLL locacaoDevBLL = new LocacaoDevolucaoBLL();
                LocacaoDevolucaoModelo modLocacaoDev = new LocacaoDevolucaoModelo();

                modLocacaoDev.idLocacao = Convert.ToInt32(textBoxCodigo.Text);
                locacaoDevBLL.devolucaoLocacao(modLocacaoDev);

                //Abrir tela devolução
                var FrmPrincipal = this.ParentForm;
                var painelPrincipal = FrmPrincipal.Controls.Find("painelPrincipal", true).FirstOrDefault();
                FrmLocacaoDevolucao janelaDev = new FrmLocacaoDevolucao(textBoxCodigo.Text, textBoxUsuarioLocacao.Text);
                janelaDev.TopLevel = false;
                janelaDev.Visible = true;
                painelPrincipal.Controls.Add(janelaDev);
                this.Hide();
            }
        }

        private void dataGridViewLocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdutoExcluir = dataGridViewLocao.Rows[e.RowIndex].Cells[12].Value.ToString();
            nomeProdutoExcluir = dataGridViewLocao.Rows[e.RowIndex].Cells[2].Value.ToString();

            buttonExcluirItem.Enabled = true;
        }

        private void textBoxCodigo_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipLocacao.SetToolTip(textBoxCodigo, "Você pode informar um código e clicar em enter, ou clicar na lupa de consulta!");
        }

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarLocacaoPorCodigo();
            }
        }

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxCodigoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(comboBoxFiltro.SelectedItem == "Cód. Barras")
                {
                    MessageBox.Show("chamou codigo barras");
                    

                }
                else
                {
                    ProdutoModelo produtoModelo = new ProdutoModelo();
                    ProdutoBLL produtoBLL = new ProdutoBLL();

                    produtoModelo.idProduto = Convert.ToInt32(textBoxCodigoItem.Text);
                    produtoBLL.buscarProdutoCodigos(produtoModelo);

                    if(produtoModelo.idProduto > 1)
                    {
                        MessageBox.Show("abrir dialog para escolher as variações");
                    }
                    
                }
            }
        }

        private void buttonBuscarLocacoes_Click(object sender, EventArgs e)
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
                botaoClicado = "PESQUISAR";

                textBoxCodigo.Text = frmConsultaLocacao.idLocacaoEnvia;
                string nomeClienteReturn = frmConsultaLocacao.NomeClienteEnvia;
                textBoxCliente.Text = idClienteReturn + " - " + nomeClienteReturn;
                textBoxDataLancamento.Text = frmConsultaLocacao.DataLancamentoEnvia;
                textBoxUsuarioLocacao.Text = frmConsultaLocacao.UsuarioEnvia;
                string dataPrevEntrega = frmConsultaLocacao.DataPrevEntregaEnvia;
                dateTimePickerDataEntrega.Value = Convert.ToDateTime(dataPrevEntrega);

                float valorRetunDesconto = Convert.ToSingle(frmConsultaLocacao.ValorDescontoEnvia);
                decimal resultadoDesconto;
                resultadoDesconto = Convert.ToDecimal(valorRetunDesconto.ToString("N2"));
                textBoxDesconto.Text = Convert.ToString(resultadoDesconto);
                                
                carregarItens();

                inativaAtivaCampos();
            }
        }

        private void buttonBuscarItem_Click(object sender, EventArgs e)
        {
            string tipoConsulta = "PV";
            frmConsultaProduto = new FrmConsultaProduto(tipoConsulta);
            DialogResult dr = frmConsultaProduto.ShowDialog(this);

            idProdutoReturn = frmConsultaProduto.idProdutoClicado;
            if (String.IsNullOrEmpty(idProdutoReturn) == true)
            {
                MessageBox.Show("Você não selecionou nenhum produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBoxCodigoItem.Text = idProdutoReturn;

                nomeProdutoReturn = frmConsultaProduto.nomeProdutoClicado;
                labelNomeProduto.Text = nomeProdutoReturn;

                valorProdutoReturn = frmConsultaProduto.valorProdutoClicado;
                textBoxValor.Text = valorProdutoReturn;

                custoProdutoReturn = frmConsultaProduto.custoProdutoClicado;

                valorOriginalProdutoReturn = frmConsultaProduto.valorProdutoClicado;

                idVariacaoProdutoReturn = frmConsultaProduto.idProdutoVariacaoClicado;

                textBoxQuantidadeItem.Text = "1";
            }
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            string passaTipoConsulta = "CLIENTE";
            frmConsultaParticipante = new FrmConsultaParticipante(passaTipoConsulta);
            DialogResult dr = frmConsultaParticipante.ShowDialog(this);

            string nomeParticipanteReturn = frmConsultaParticipante.nomeClienteClicado;
            if (String.IsNullOrEmpty(nomeParticipanteReturn) == true)
            {
                MessageBox.Show("Você não selecionou o fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                idClienteReturn = frmConsultaParticipante.idClicada;
                textBoxCliente.Text = idClienteReturn + " - " + nomeParticipanteReturn;
            }
        }

        public void adicionarItemLocacao(LocacaoModelo locacaoModelo)
        {
            //Valida se o campo id ñ tiver informado ele entra nesta condição para gerar
            if (textBoxCodigo.Text == "0")
            {
                botaoInserir = "CLICADO";

                //Chama o método salvar para gerar a id primeiramente da locação
                salvar(locacaoModelo);

                locacaoModelo.idProdutoLocacaoItens = Convert.ToInt32(textBoxCodigoItem.Text);
                locacaoModelo.valorLocadoLocacaoItens = Convert.ToSingle(textBoxValor.Text);
                locacaoModelo.valorOriginalLocacaoItens = Convert.ToSingle(valorOriginalProdutoReturn);
                locacaoModelo.custoDiaLocacaoItens = Convert.ToSingle(custoProdutoReturn);
                locacaoModelo.idLocacaoLocacaoItens = Convert.ToInt32(textBoxCodigo.Text);
                locacaoModelo.qtdItensLocacaoItens = Convert.ToDouble(textBoxQuantidadeItem.Text);
                locacaoModelo.idVariacaoProdutoLocacaoItens = Convert.ToInt32(idVariacaoProdutoReturn);
                locacaoBLL.inserirItensLocacao(locacaoModelo);

                textBoxCodigoItem.Clear();
                textBoxCodigoItem.Focus();
                textBoxValor.Text ="0";
                labelNomeProduto.Text = "";
                textBoxQuantidadeItem.Clear();

                carregarItens();
            }
            else
            {
                locacaoModelo.idProdutoLocacaoItens = Convert.ToInt32(textBoxCodigoItem.Text);
                locacaoModelo.valorLocadoLocacaoItens = Convert.ToSingle(textBoxValor.Text);
                locacaoModelo.valorOriginalLocacaoItens = Convert.ToSingle(valorOriginalProdutoReturn);
                locacaoModelo.custoDiaLocacaoItens = Convert.ToSingle(custoProdutoReturn);
                locacaoModelo.idLocacaoLocacaoItens = Convert.ToInt32(textBoxCodigo.Text);
                locacaoModelo.qtdItensLocacaoItens = Convert.ToDouble(textBoxQuantidadeItem.Text);
                locacaoModelo.idVariacaoProdutoLocacaoItens = Convert.ToInt32(idVariacaoProdutoReturn);
                locacaoBLL.inserirItensLocacao(locacaoModelo);

                textBoxCodigoItem.Clear();
                textBoxCodigoItem.Focus();
                textBoxValor.Text = "0";
                labelNomeProduto.Text = "";
                textBoxQuantidadeItem.Clear();

                carregarItens();
            }
        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxCodigoItem.Text) == true)
            {
                MessageBox.Show("Não selecionou um item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                LocacaoModelo locacaoModelo = new LocacaoModelo();
                adicionarItemLocacao(locacaoModelo);
            }
            
        }

        //Método lista os itens da locação na tabela
        private void carregarItens()
        {
            dataGridViewLocao.DataSource = locacaoBLL.listarItensLocacao(textBoxCodigo.Text);
            configurarDataGridView();
        }

        //Método configura as colunas e header da tabela de itens
        public void configurarDataGridView()
        {
            float somadoGrid,valorDesconto;
            int qtdRegistros;

            //Renomeando as colunas
            dataGridViewLocao.Columns[0].HeaderText = "Código";
            dataGridViewLocao.Columns[2].HeaderText = "Descrição";
            dataGridViewLocao.Columns[3].HeaderText = "UN";
            dataGridViewLocao.Columns[4].HeaderText = "Qtd";
            dataGridViewLocao.Columns[5].HeaderText = "R$ Unit.";
            dataGridViewLocao.Columns[6].HeaderText = "R$ Total";
            dataGridViewLocao.Columns[7].HeaderText = "Marca";
            dataGridViewLocao.Columns[8].HeaderText = "Categoria";
            dataGridViewLocao.Columns[9].HeaderText = "Sub-Categoria";
            dataGridViewLocao.Columns[10].HeaderText = "Fornecedor";

            //Configurando o tamanho das colunas
            dataGridViewLocao.Columns[0].Width = 45;
            dataGridViewLocao.Columns[2].Width = 170;
            dataGridViewLocao.Columns[3].Width = 50;
            dataGridViewLocao.Columns[4].Width = 45;
            dataGridViewLocao.Columns[5].Width = 60;
            dataGridViewLocao.Columns[6].Width = 60;
            dataGridViewLocao.Columns[7].Width = 90;
            dataGridViewLocao.Columns[8].Width = 90;
            dataGridViewLocao.Columns[9].Width = 90;
            dataGridViewLocao.Columns[10].Width = 120;

            //Ocultando algumas colunas na tabela
            dataGridViewLocao.Columns["CodigoProdutoVariacao"].Visible = false;
            dataGridViewLocao.Columns["idLocacao_locacaoitens"].Visible = false;
            dataGridViewLocao.Columns["idlocacaoitens"].Visible = false;

            //Convertendo as colunas do dataGridView            
            this.dataGridViewLocao.Columns[5].ValueType = typeof(decimal);
            this.dataGridViewLocao.Columns[5].DefaultCellStyle.Format = "N2";
            this.dataGridViewLocao.Columns[6].ValueType = typeof(decimal);
            this.dataGridViewLocao.Columns[6].DefaultCellStyle.Format = "N2";

            //Método para contar a quantidade de itens na tabela
            textBoxQtdItem.Text = dataGridViewLocao.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["QtdLocada"].Value)).ToString("N2");
            
            //Método para fazer o calculo de desconto e aplicar no campo total
            somadoGrid = dataGridViewLocao.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            valorDesconto = Convert.ToSingle(textBoxDesconto.Text);
            float resultadoTotal = somadoGrid - valorDesconto;
            decimal resultadoTotalConvertido;
            resultadoTotalConvertido = Convert.ToDecimal(resultadoTotal.ToString("N2"));
            textBoxTotal.Text = Convert.ToString(resultadoTotalConvertido);

            //Método para fazer o calculo do total de itens e setar no campo
            float somadoGridTotalItens = dataGridViewLocao.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            decimal resultadoTotalItens;
            resultadoTotalItens = Convert.ToDecimal(somadoGridTotalItens.ToString("N2"));
            textBoxTotalItens.Text = Convert.ToString(resultadoTotalItens);

            //Conta a quantidade de volumes e seta no campo
            qtdRegistros = dataGridViewLocao.Rows.Count;
            textBoxVolume.Text = Convert.ToString(qtdRegistros);            

        }

        //Método buscar locação pelo código
        public void buscarLocacaoPorCodigo()
        {
            LocacaoModelo modLoc = new LocacaoModelo();
            modLoc.idLocacao = Convert.ToInt32(textBoxCodigo.Text);
            locacaoBLL.buscarLocacaoPorCodigo(modLoc);

            idClienteReturn = modLoc.idClienteLocao;
            string nomeCliente = modLoc.nomeCliente;
            textBoxCliente.Text = idClienteReturn + " - " + nomeCliente;

            textBoxDataLancamento.Text = Convert.ToString(modLoc.dataLancamentoLocao);
            textBoxUsuarioLocacao.Text = modLoc.usuarioLocacao;

            DateTime dataPrevEntrega = modLoc.dataPrevisaoEntregaLocao;
            dateTimePickerDataEntrega.Value = dataPrevEntrega;

            float valorRetunDesconto = Convert.ToSingle(modLoc.descontoLocao);
            decimal resultadoDesconto;
            resultadoDesconto = Convert.ToDecimal(valorRetunDesconto.ToString("N2"));
            textBoxDesconto.Text = Convert.ToString(resultadoDesconto);

            carregarItens();
            botaoClicado = "PESQUISAR";
            inativaAtivaCampos();
        }

        
        

    }
}
