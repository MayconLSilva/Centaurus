﻿using System;
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

        LocacaoBLL locacaoBLL = new LocacaoBLL();
        LocacaoDAO locacaoDAO = new LocacaoDAO();

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

                    dataGridViewLocao.Enabled = false;

                    break;

                case "PESQUISAR":
                                        
                    menuLocacaoEditar.Enabled = true;

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
                    buttonExcluirItem.Enabled = true;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = true;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;

                    menuLocacaoNovo.Enabled = false;
                    menuLocacaoGravar.Enabled = true;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = true;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = true;

                    toolStripDropDownButtonFuncoes.Enabled = true;

                    dataGridViewLocao.Enabled = true;

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
                    buttonExcluirItem.Enabled = true;
                    textBoxDataLancamento.Enabled = false;
                    textBoxQtdItem.Enabled = false;
                    textBoxDesconto.Enabled = false;
                    textBoxTotal.Enabled = false;
                    textBoxQuantidadeItem.Enabled = true;
                    textBoxUsuarioLocacao.Enabled = false;
                    textBoxVolume.Enabled = false;

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

                    menuLocacaoNovo.Enabled = true;
                    menuLocacaoGravar.Enabled = false;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = false;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = false;

                    toolStripDropDownButtonFuncoes.Enabled = false;

                    dataGridViewLocao.Enabled = false;

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

                    menuLocacaoNovo.Enabled = true;
                    menuLocacaoGravar.Enabled = false;
                    menuLocacaoEditar.Enabled = false;
                    menuLocacaoCancelar.Enabled = false;
                    menuLocacaoExcluir.Enabled = false;
                    buttonCalcularDesconto.Enabled = false;

                    toolStripDropDownButtonFuncoes.Enabled = false;

                    dataGridViewLocao.Enabled = false;

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
            botaoClicado = "EXCLUIR";
            inativaAtivaCampos();
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
                    locacaoBLL.gerarIdLocacao(locacaoModelo);

                    //Método chama o ultimo registro
                    string data = textBoxDataLancamento.Text;                    
                    var dataConvertida = DateTime.Parse(data).ToString("yyyy-MM-dd HH:mm:ss");

                    locacaoDAO.pegarIdGerada(dataConvertida);
                    string idReturn = locacaoDAO.numeroIncluido;
                    textBoxCodigo.Text = idReturn;

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

                    locacaoBLL.salvarLoca(locacaoModelo);
                    MessageBox.Show("Locação incluida com sucesso!!!", "Cadastro Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botaoClicado = "GRAVAR";
                    inativaAtivaCampos();

                    //Método chama o ultimo registro
                    locacaoDAO.UltimoRegistro(idClienteReturn);
                    string idReturn = locacaoDAO.numeroIncluido;
                    textBoxCodigo.Text = idReturn;
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

                    locacaoBLL.finalizarLoca(locacaoModelo);
                    MessageBox.Show("Locação incluida com sucesso!!!", "Cadastro Locação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botaoClicado = "GRAVAR";
                    inativaAtivaCampos();
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

        private void buttonExcluirItem_Click(object sender, EventArgs e)
        {
            

            
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

        
        private void buttonCalcularDesconto_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            object myValue;

            //Set prompt.
            message = "Pleaase input your Full name.";

            //Set title.
            title = "testesss";

            //Set default value.
            defaultValue = "valor padrão";

            //Display message, title, and default value.
            myValue = Interaction.InputBox(message, title, defaultValue);

            //if user has clicked cancel, set myvalue to defaultValue
            if((string)myValue == "")
            {
                myValue = defaultValue;
                Microsoft.VisualBasic.Interaction.MsgBox("myValue = " + myValue.ToString(),
                    MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "C# msgBox Demonstration");
            }
            else
            {
                Interaction.MsgBox("Hello, " + myValue.ToString() + "!"
                    + Environment.NewLine + "Nice to meet you!",
                    MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "C# MsgBox Demonstration");
            }



            
            /*
            float valorTotal, valorDesconto;

            //Método para fazer o calculo de desconto e aplicar no campo total
            valorTotal = dataGridViewLocao.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            if (String.IsNullOrEmpty(textBoxDesconto.Text) == true)
            {
                valorDesconto = 0;
            }
            else
            {
                valorDesconto = Convert.ToSingle(textBoxDesconto.Text);
            }
            float total = valorTotal - valorDesconto;
            decimal resultado;
            resultado = Convert.ToDecimal(total.ToString("N2"));
            textBoxTotal.Text = Convert.ToString(resultado);
            */
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
                //dateTimePickerDataEntrega.sele
                textBoxDesconto.Text = frmConsultaLocacao.ValorDescontoEnvia;
                textBoxTotal.Text = frmConsultaLocacao.ValorTotalEnvia;

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

        public void salvarItens(LocacaoModelo locacaoModelo)
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
                salvarItens(locacaoModelo);
            }
            
        }

        private void carregarItens()
        {
            dataGridViewLocao.DataSource = locacaoDAO.listarItens(textBoxCodigo.Text);
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            float valorTotal,valorDesconto;
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

            //Convertendo as colunas do dataGridView            
            this.dataGridViewLocao.Columns[5].ValueType = typeof(decimal);
            this.dataGridViewLocao.Columns[5].DefaultCellStyle.Format = "N2";
            this.dataGridViewLocao.Columns[6].ValueType = typeof(decimal);
            this.dataGridViewLocao.Columns[6].DefaultCellStyle.Format = "N2";

            //Método para contar a quantidade de itens na tabela
            textBoxQtdItem.Text = dataGridViewLocao.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["QtdLocada"].Value)).ToString("N2");
            //Método para fazer o calculo de desconto e aplicar no campo total
            valorTotal = dataGridViewLocao.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToSingle(i.Cells["ValorTotal"].Value));
            valorDesconto = Convert.ToSingle(textBoxDesconto.Text);
            float total = valorTotal - valorDesconto;
            decimal resultado;
            resultado = Convert.ToDecimal(total.ToString("N2"));
            textBoxTotal.Text = Convert.ToString(resultado);

            //Conta a quantidade de volumes e seta no campo
            qtdRegistros = dataGridViewLocao.Rows.Count;
            textBoxVolume.Text = Convert.ToString(qtdRegistros);            

        }



        

    }
}
