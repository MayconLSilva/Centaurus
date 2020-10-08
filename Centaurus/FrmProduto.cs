using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Centaurus.Model;
using Centaurus.Bll;
using Centaurus.Dao;
using System.Diagnostics;

namespace Centaurus
{
    public partial class FrmProduto : Form
    {
        string botaoClicado = "INICIAR";
        int flag = 0;
        FrmConsultaMarca frmConsultaMarca;
        string codigoReturMarcaProduto;

        FrmConsultaCategoriaSubCategoria formCatSub;
        string codigoReturCategoriaProduto;
        string codigoReturSubCategoriaProduto;

        FrmConsultaParticipante frmConsultaParticipante;
        string codigoReturParticipante;

        FrmConsultaProduto frmConsultaProduto;

        ProdutoDAO produtoDAO = new ProdutoDAO();

        string codigoReturnProduto;
        string idProdutoVariacao="0",unidadeVariacao,multiploVariacao;

        string usuarioLogado;
        
        public FrmProduto(string returnUsuario)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            usuarioLogado = returnUsuario;

            inativarAtivarCampos();    

        }
                
        private void menuProdutoNovo_Click(object sender, EventArgs e)
        {
            botaoClicado = "NOVO";
            inativarAtivarCampos();

            //Inicio código fonte seto a data no campo de cadastro
            DateTime thisDay = DateTime.Today;
            textBoxDataCadastro.Text = thisDay.ToString("d");

            textBoxUsuarioCadastro.Text = usuarioLogado;

            flag = 0;
        }

        private void menuProdutoCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativarAtivarCampos();
        }

        private void buttonBuscarMarca_Click(object sender, EventArgs e)
        {
            frmConsultaMarca = new FrmConsultaMarca();
            DialogResult dr = frmConsultaMarca.ShowDialog(this);

            string nomeMarcaReturn = frmConsultaMarca.marcaClicada;
            if (String.IsNullOrEmpty(nomeMarcaReturn) == true)
            {
                MessageBox.Show("Você não selecionou a marca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                codigoReturMarcaProduto = frmConsultaMarca.idClicada;
                textBoxMarca.Text = codigoReturMarcaProduto + " - "+ nomeMarcaReturn;
            }
        }

        private void buttonBuscarCategoria_Click(object sender, EventArgs e)
        {
            formCatSub = new FrmConsultaCategoriaSubCategoria("C");
            DialogResult dr = formCatSub.ShowDialog(this);

            string nomeCategoriaReturn = formCatSub.categoriaSubCategoriaClicada;
            if (String.IsNullOrEmpty(nomeCategoriaReturn) == true)
            {
                MessageBox.Show("Você não selecionou a categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                codigoReturCategoriaProduto = formCatSub.idClicada;
                textBoxCategoria.Text = codigoReturCategoriaProduto + " - " + nomeCategoriaReturn;
            }
        }

        private void buttonBuscarSubCategoria_Click(object sender, EventArgs e)
        {
            formCatSub = new FrmConsultaCategoriaSubCategoria("S");
            DialogResult dr = formCatSub.ShowDialog(this);

            string nomeSubCategoriaReturn = formCatSub.categoriaSubCategoriaClicada;
            if (String.IsNullOrEmpty(nomeSubCategoriaReturn) == true)
            {
                MessageBox.Show("Você não selecionou a categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                codigoReturSubCategoriaProduto = formCatSub.idClicada;
                textBoxSubCategoria.Text = codigoReturSubCategoriaProduto + " - " + nomeSubCategoriaReturn;
            }
        }

        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            string passaTipoConsulta = "FORNECEDOR";
            frmConsultaParticipante = new FrmConsultaParticipante(passaTipoConsulta);
            DialogResult dr = frmConsultaParticipante.ShowDialog(this);

            string nomeParticipanteReturn = frmConsultaParticipante.nomeClienteClicado;
            if (String.IsNullOrEmpty(nomeParticipanteReturn) == true)
            {
                MessageBox.Show("Você não selecionou o fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                codigoReturParticipante = frmConsultaParticipante.idClicada;
                textBoxFornecedor.Text = codigoReturParticipante + " - " + nomeParticipanteReturn;
            }
        }

        private void menuProdutoGravar_Click(object sender, EventArgs e)
        {
            ProdutoModelo produtoModelo = new ProdutoModelo();
            salvaratualizar(produtoModelo);
        }

        private void salvaratualizar(ProdutoModelo produto)
        {
            botaoClicado = "SALVAR";
            ProdutoBLL produtoBLL = new ProdutoBLL();
            if (flag == 0)
            {                
                string codigoBarras;

                if (comboBoxTipoItem.SelectedItem == null || comboBoxUnidade == null)
                {
                    MessageBox.Show("Selecione o tipo de item", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    //textBoxDescricao.BackColor = Color.FromArgb(100, 250, 0, 100);
                    //textBoxDescricao.BackColor = Color.Red;                    
                }
                else
                {
                    //Ativo e/ou inativo
                    if (checkBoxAtivo.Checked)
                    {
                        produto.ativoProduto = true;
                    }
                    else
                    {
                        produto.ativoProduto = false;
                    }

                    //Descontinuado e/ou Continuado
                    if (checkBoxDescontinuado.Checked)
                    {
                        produto.descontinuadoProduto = true;
                    }
                    else
                    {
                        produto.descontinuadoProduto = false;
                    }

                    //Tipo de item
                    if (comboBoxTipoItem.SelectedItem == "PRODUTO")
                    {
                        produto.tipoProduto = Convert.ToChar('P');
                        
                    }
                    else if (comboBoxTipoItem.SelectedItem == "SERVIÇO")
                    {
                        produto.tipoProduto = Convert.ToChar('S');                  
                    }

                    produto.descricaoProduto = textBoxDescricao.Text;
                    produto.unidadeProduto = comboBoxUnidade.Text; 
                    if(textBoxVenda.Text == "")
                    {
                        produto.vendaProduto = 0;
                        textBoxVenda.Text = "0";
                        textBoxValorVenda.Text = "0";
                    }
                    else
                    {
                        produto.vendaProduto = float.Parse(textBoxVenda.Text);
                    }                    
                    produto.marcaProduto = codigoReturMarcaProduto;
                    produto.categoriaProduto = codigoReturCategoriaProduto;
                    produto.subCategoriaProduto = codigoReturSubCategoriaProduto;
                    produto.fornecedorProduto = codigoReturParticipante;
                    produto.codFabricanteProduto = textBoxCodigoFabricante.Text;
                    
                    codigoBarras = textBoxCodigoBarras.Text;                    
                    if (codigoBarras == "")
                    {
                        codigoBarras = null;
                    }
                    produto.codBarrasProduto = codigoBarras;
                    produto.codInternoProduto = textBoxCodigoInterno.Text;
                    produto.dataCadastroProduto = textBoxDataCadastro.Text;
                    produto.usuarioCadastroProduto = textBoxUsuarioCadastro.Text;
                    if(textBoxCustoFinal.Text == "")
                    {
                        produto.custoFinalProduto = 0;
                        textBoxCustoFinal.Text = "0";
                    }
                    else
                    {
                        produto.custoFinalProduto = Convert.ToSingle(textBoxCustoFinal.Text);
                    }
                    produtoBLL.salvar(produto);
                    MessageBox.Show("Produto incluido com sucesso!!!", "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    inativarAtivarCampos();

                    //Método chama o ultimo registro
                    //produtoDAO.UltimoRegistro(textBoxDescricao.Text);
                    //string idReturn = produtoDAO.numeroIncluido;
                    produtoBLL.buscarUltimoRegistro(produto);
                    int idRetun = produto.idProduto;
                    textBoxCodigo.Text = Convert.ToString(idRetun);
                }
            }
            else
            {
                string codigoBarras;

                if (comboBoxTipoItem.SelectedItem == null || comboBoxUnidade == null)
                {
                    MessageBox.Show("Selecione o tipo de item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //textBoxDescricao.BackColor = Color.FromArgb(100, 250, 0, 100);
                    //textBoxDescricao.BackColor = Color.Red;

                }
                else
                {
                    //Ativo e/ou inativo
                    if (checkBoxAtivo.Checked)
                    {
                        produto.ativoProduto = true;
                    }
                    else
                    {
                        produto.ativoProduto = false;
                    }

                    //Descontinuado e/ou Continuado
                    if (checkBoxDescontinuado.Checked)
                    {
                        produto.descontinuadoProduto = true;
                    }
                    else
                    {
                        produto.descontinuadoProduto = false;
                    }

                    //Tipo de item
                    if (comboBoxTipoItem.SelectedItem == "PRODUTO")
                    {
                        produto.tipoProduto = Convert.ToChar('P');

                    }
                    else if (comboBoxTipoItem.SelectedItem == "SERVIÇO")
                    {
                        produto.tipoProduto = Convert.ToChar('S');
                    }

                    produto.descricaoProduto = textBoxDescricao.Text;
                    produto.unidadeProduto = comboBoxUnidade.Text;
                    if (textBoxVenda.Text == "")
                    {
                        produto.vendaProduto = 0;
                        textBoxVenda.Text = "0";
                        textBoxValorVenda.Text = "0";
                    }
                    else
                    {
                        produto.vendaProduto = float.Parse(textBoxVenda.Text);
                    }
                    produto.marcaProduto = codigoReturMarcaProduto;
                    produto.categoriaProduto = codigoReturCategoriaProduto;
                    produto.subCategoriaProduto = codigoReturSubCategoriaProduto;
                    produto.fornecedorProduto = codigoReturParticipante;
                    produto.codFabricanteProduto = textBoxCodigoFabricante.Text;

                    codigoBarras = textBoxCodigoBarras.Text;
                    if (codigoBarras == "")
                    {
                        codigoBarras = null;
                    }
                    produto.codBarrasProduto = codigoBarras;
                    produto.codInternoProduto = textBoxCodigoInterno.Text;
                    produto.dataAlteracaoProduto = textBoxDataAlteracao.Text;
                    produto.usuarioAlteracaoProduto = textBoxUsuarioAlteracao.Text;
                    if (textBoxCustoFinal.Text == "")
                    {
                        produto.custoFinalProduto = 0;
                        textBoxCustoFinal.Text = "0";
                    }
                    else
                    {
                        produto.custoFinalProduto = Convert.ToSingle(textBoxCustoFinal.Text);
                    }
                    produto.idProduto = Convert.ToInt32(textBoxCodigo.Text);
                    produtoBLL.atualizar(produto);
                    MessageBox.Show("Produto atualizado com sucesso!!!", "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    inativarAtivarCampos();
                }
            }
        }

        //Método pega o valor digitiado e joga para o campo da aba principal
        private void textBoxVenda_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxValorVenda.Text = textBoxVenda.Text;
        }

        //Método formata campo para aceitar somente valor númerico
        private void textBoxVenda_KeyPress(object sender, KeyPressEventArgs e)
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

        //Método formata o campo para aceitar somente valor númerico
        private void textBoxCustoFinal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonAdicionarVariacao_Click(object sender, EventArgs e)
        {
            if(textBoxCodigo.Text == "")
            {
                MessageBox.Show("Salve e/o pesquise um produto primeiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else 
            {
                if(comboBoxUnidade.SelectedItem == comboBoxUnidadeVariacao.SelectedItem)
                {
                    MessageBox.Show("A unidade da variação precisa ser diferente da unidade principal", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(comboBoxUnidadeVariacao.SelectedItem == null || comboBoxFatorVariacao.SelectedItem == null || textBoxQtdVariacao.Text == "")
                    {
                        MessageBox.Show("Todos campos precisam estar devidamente preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        ProdutoBLL produtoBLL = new ProdutoBLL();
                        ProdutoModelo produtoModelo = new ProdutoModelo();
                        produtoModelo.idProdVariacao = Convert.ToInt32(textBoxCodigo.Text);
                        produtoModelo.qtdProdVariacao = Convert.ToDouble(textBoxQtdVariacao.Text);
                        produtoModelo.fatorProdVariacao = Convert.ToChar(comboBoxFatorVariacao.Text);
                        produtoModelo.unProdVariacao = comboBoxUnidadeVariacao.Text;
                        produtoBLL.salvarVariacao(produtoModelo);
                        MessageBox.Show("Variação incluida com sucesso", "Cadastro de Variação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        carregarVariacoes();
                    }
                }
            }
        }

        private void menuProdutoEditar_Click(object sender, EventArgs e)
        {
            flag = 1;
            botaoClicado = "EDITAR";
            inativarAtivarCampos();

            //Inicio código fonte seto a data no campo de cadastro
            DateTime thisDay = DateTime.Today;
            textBoxDataAlteracao.Text = thisDay.ToString("d");

            textBoxUsuarioAlteracao.Text = usuarioLogado;
        }

        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            string tipoConsulta = "PS";
            frmConsultaProduto = new FrmConsultaProduto(tipoConsulta);
            DialogResult dr = frmConsultaProduto.ShowDialog(this);

            codigoReturnProduto = frmConsultaProduto.idProdutoClicado;
            if (String.IsNullOrEmpty(codigoReturnProduto) == true)
            {
                MessageBox.Show("Você não selecionou nenhum produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                botaoClicado = "PESQUISAR";
                textBoxCodigo.Text = codigoReturnProduto;
                buscarProdutoPorCodigo();
                inativarAtivarCampos();
            }
        }

        public void buscarProdutoPorCodigo()
        {
            ProdutoModelo modeloProduto = new ProdutoModelo();
            ProdutoBLL bllProduto = new ProdutoBLL();

            try
            {
                //Método enviar a id do produto para pesquisar as informações
                modeloProduto.idProduto = Convert.ToInt32(textBoxCodigo.Text);
                bllProduto.buscarProdutoPorCodigo(modeloProduto);
                //modeloProduto = produtoDAO.buscarInformacoesProdutoPorCodigo(modeloProduto);

                //Método retornar com informações e seta nos respectivos campos
                if(modeloProduto.ativoProduto == true)
                {
                    checkBoxAtivo.Checked = true;
                }
                else
                {
                    checkBoxAtivo.Checked = false;
                }
                if(modeloProduto.descontinuadoProduto == true)
                {
                    checkBoxDescontinuado.Checked = true;
                }
                else
                {
                    checkBoxDescontinuado.Checked = false;
                }

                if(Convert.ToString(modeloProduto.tipoProduto) == "P")
                {
                    comboBoxTipoItem.SelectedIndex = comboBoxTipoItem.FindStringExact("PRODUTO");
                }
                else
                {
                    comboBoxTipoItem.SelectedIndex = comboBoxTipoItem.FindStringExact("SERVIÇO");
                }
                textBoxDescricao.Text = modeloProduto.descricaoProduto;
                comboBoxUnidade.SelectedIndex = comboBoxUnidade.FindStringExact(modeloProduto.unidadeProduto);
                textBoxValorVenda.Text = Convert.ToString(modeloProduto.vendaProduto);
                textBoxVenda.Text = Convert.ToString(modeloProduto.vendaProduto);
                textBoxSaldoEstoque.Text = Convert.ToString(modeloProduto.saldoProduto);
                
                codigoReturMarcaProduto = modeloProduto.marcaProduto;
                string nomeMarca = modeloProduto.nomeMarca;
                textBoxMarca.Text = codigoReturMarcaProduto + " - " + nomeMarca;

                codigoReturCategoriaProduto = modeloProduto.categoriaProduto;
                string nomeCategoria = modeloProduto.nomeCategoria;
                textBoxCategoria.Text = codigoReturCategoriaProduto + " - " + nomeCategoria;

                codigoReturSubCategoriaProduto = modeloProduto.subCategoriaProduto;
                string nomeSubCategoria = modeloProduto.nomeSubCategoria;
                textBoxSubCategoria.Text = codigoReturSubCategoriaProduto + " - " + nomeSubCategoria;

                codigoReturParticipante = modeloProduto.fornecedorProduto;
                string nomeForne = modeloProduto.nomeFornecedor;
                textBoxFornecedor.Text = codigoReturParticipante + " - " + nomeForne;

                textBoxCodigoFabricante.Text = modeloProduto.codFabricanteProduto;
                textBoxCodigoBarras.Text = modeloProduto.codBarrasProduto;
                textBoxCodigoInterno.Text = modeloProduto.codInternoProduto;
                textBoxDataCadastro.Text = modeloProduto.dataCadastroProduto;
                textBoxDataAlteracao.Text = modeloProduto.dataAlteracaoProduto;
                textBoxUsuarioCadastro.Text = modeloProduto.usuarioCadastroProduto;
                textBoxUsuarioAlteracao.Text = modeloProduto.usuarioAlteracaoProduto;
                textBoxUltimoCustoCompra.Text = Convert.ToString(modeloProduto.ultimoCustoCompraProduto);
                textBoxCustoAnterior.Text = Convert.ToString(modeloProduto.custoAnteriorProduto);
                textBoxCustoFinal.Text = Convert.ToString(modeloProduto.custoFinalProduto);

                carregarVariacoes();
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        private void menuProdutoExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? \n"+ textBoxDescricao.Text, "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                botaoClicado = "EXCLUIR";
                ProdutoBLL produtoBLL = new ProdutoBLL();
                ProdutoModelo produtoModelo = new ProdutoModelo();

                produtoModelo.idProduto = Convert.ToInt32(textBoxCodigo.Text);
                produtoBLL.excluir(produtoModelo);
                inativarAtivarCampos();
            }
        }

        private void carregarVariacoes()
        {
            dataGridViewVariacoes.DataSource = produtoDAO.listarVariacao(textBoxCodigo.Text);
            configurarGridViewVariacao();
        }

        public void configurarGridViewVariacao()
        {
            //Renomeando as colunas
            dataGridViewVariacoes.Columns[0].HeaderText = "Código";
            dataGridViewVariacoes.Columns[1].HeaderText = "Unidade Principal";
            dataGridViewVariacoes.Columns[2].HeaderText = "Saldo Principal";
            dataGridViewVariacoes.Columns[3].HeaderText = "Fator Variação";
            dataGridViewVariacoes.Columns[4].HeaderText = "Multiplo Variação";
            dataGridViewVariacoes.Columns[5].HeaderText = "Unidade Variação";
            dataGridViewVariacoes.Columns[6].HeaderText = "Saldo Variação";


            //Configurando o tamanho das colunas
            dataGridViewVariacoes.Columns[0].Width = 45;
            dataGridViewVariacoes.Columns[1].Width = 100;
            dataGridViewVariacoes.Columns[2].Width = 90;
            dataGridViewVariacoes.Columns[3].Width = 100;
            dataGridViewVariacoes.Columns[4].Width = 80;
            dataGridViewVariacoes.Columns[5].Width = 90;
            dataGridViewVariacoes.Columns[6].Width = 120;

            //Ocultar coluna do gridView
            dataGridViewVariacoes.Columns["codVariacao"].Visible = false;            

        }

        private void buttonLimparMarca_Click(object sender, EventArgs e)
        {
            codigoReturMarcaProduto = null;
            textBoxMarca.Clear();
        }

        private void buttonLimpaSubCategoria_Click(object sender, EventArgs e)
        {
            codigoReturSubCategoriaProduto = null;
            textBoxSubCategoria.Clear();
        }

        private void buttonLimparFornecedor_Click(object sender, EventArgs e)
        {
            codigoReturParticipante = null;
            textBoxFornecedor.Clear();
        }

        private void buttonLimparCategoria_Click(object sender, EventArgs e)
        {
            codigoReturCategoriaProduto = null;
            textBoxCategoria.Clear();
        }

        private void buttonExcluirVariacao_Click(object sender, EventArgs e)
        {
            if(idProdutoVariacao == "0")
            {
                MessageBox.Show("Você não selecionou nenhuma variação ainda! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro? \n" + unidadeVariacao + " de multiplo " + multiploVariacao, "Excluir Variação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ProdutoBLL produtoBLL = new ProdutoBLL();
                    ProdutoModelo produtoModelo = new ProdutoModelo();

                    produtoModelo.idProdVariacao = Convert.ToInt32(idProdutoVariacao);
                    produtoBLL.excluirVariacao(produtoModelo);
                    carregarVariacoes();
                    MessageBox.Show("Variação excluida com sucesso! ", "Excluir Variação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        }

        private void textBoxCodigo_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipProduto.SetToolTip(textBoxCodigo, "Você pode informar um código e clicar em enter, ou clicar na lupa de consulta!");
        }

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarProdutoPorCodigo();
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

        private void dataGridViewVariacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdutoVariacao = dataGridViewVariacoes.Rows[e.RowIndex].Cells[7].Value.ToString();
            unidadeVariacao = dataGridViewVariacoes.Rows[e.RowIndex].Cells[5].Value.ToString();
            multiploVariacao = dataGridViewVariacoes.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        public void inativarAtivarCampos()
        {
            switch (botaoClicado)
            {
                case "INICIAR":

                    menuProdutoNovo.Enabled = true;
                    menuProdutoGravar.Enabled = false;
                    menuProdutoEditar.Enabled = false;
                    menuProdutoCancelar.Enabled = false;
                    menuProdutoExcluir.Enabled = false;

                    //Ativa e/ou Inativa campos aba principal
                    checkBoxAtivo.Enabled = false;
                    checkBoxDescontinuado.Enabled = false;
                    comboBoxTipoItem.Enabled = false;
                    textBoxCodigo.Enabled = true;
                    buttonBuscarProduto.Enabled = true;
                    textBoxDescricao.Enabled = false;
                    comboBoxUnidade.Enabled = false;
                    textBoxValorVenda.Enabled = false;
                    textBoxSaldoEstoque.Enabled = false;
                    buttonVerEstoque.Enabled = false;
                    textBoxMarca.Enabled = false;
                    buttonBuscarMarca.Enabled = false;
                    buttonLimparMarca.Enabled = false;
                    textBoxCategoria.Enabled = false;
                    buttonBuscarCategoria.Enabled = false;
                    buttonLimparCategoria.Enabled = false;
                    textBoxSubCategoria.Enabled = false;
                    buttonBuscarSubCategoria.Enabled = false;
                    buttonLimpaSubCategoria.Enabled = false;
                    textBoxFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = false;
                    buttonLimparFornecedor.Enabled = false;
                    textBoxCodigoFabricante.Enabled = false;
                    textBoxCodigoBarras.Enabled = false;
                    textBoxCodigoInterno.Enabled = false;

                    textBoxDataCadastro.Enabled = false;
                    textBoxUsuarioCadastro.Enabled = false;
                    textBoxDataAlteracao.Enabled = false;
                    textBoxUsuarioAlteracao.Enabled = false;

                    //Ativa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Enabled = false;
                    textBoxCustoAnterior.Enabled = false;
                    textBoxCustoFinal.Enabled = false;
                    textBoxVenda.Enabled = false;
                    buttonCalculoCustoVenda.Enabled = false;

                    //Ativa e/ou Inativa campos aba variações
                    comboBoxUnidadeVariacao.Enabled = false;
                    textBoxQtdVariacao.Enabled = false;
                    comboBoxFatorVariacao.Enabled = false;
                    buttonAdicionarVariacao.Enabled = false;
                    buttonExcluirVariacao.Enabled = false;
                    textBoxCodBarrasVariacao.Enabled = false;

                    break;

                case "NOVO":

                    menuProdutoNovo.Enabled = false;
                    menuProdutoGravar.Enabled = true;
                    menuProdutoEditar.Enabled = false;
                    menuProdutoCancelar.Enabled = true;
                    menuProdutoExcluir.Enabled = false;

                    //Ativa e/ou Inativa campos aba principal
                    checkBoxAtivo.Enabled = true;
                    checkBoxDescontinuado.Enabled = true;
                    comboBoxTipoItem.Enabled = true;
                    textBoxCodigo.Enabled = false;
                    buttonBuscarProduto.Enabled = false;
                    textBoxDescricao.Enabled = true;
                    comboBoxUnidade.Enabled = true;
                    textBoxValorVenda.Enabled = false;
                    textBoxSaldoEstoque.Enabled = false;
                    buttonVerEstoque.Enabled = false;
                    textBoxMarca.Enabled = false;
                    buttonBuscarMarca.Enabled = true;
                    buttonLimparMarca.Enabled = true;
                    textBoxCategoria.Enabled = false;
                    buttonBuscarCategoria.Enabled = true;
                    buttonLimparCategoria.Enabled = true;
                    textBoxSubCategoria.Enabled = false;
                    buttonBuscarSubCategoria.Enabled = true;
                    buttonLimpaSubCategoria.Enabled = true;
                    textBoxFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = true;
                    buttonLimparFornecedor.Enabled = true;
                    textBoxCodigoFabricante.Enabled = true;
                    textBoxCodigoBarras.Enabled = true;
                    textBoxCodigoInterno.Enabled = true;

                    textBoxDataCadastro.Enabled = false;
                    textBoxUsuarioCadastro.Enabled = false;
                    textBoxDataAlteracao.Enabled = false;
                    textBoxUsuarioAlteracao.Enabled = false;

                    //Limpa campos aba principal
                    checkBoxAtivo.Checked = false;
                    checkBoxDescontinuado.Checked = false;
                    textBoxCodigo.Text = "";
                    textBoxDescricao.Text = "";
                    textBoxValorVenda.Text = "";
                    textBoxSaldoEstoque.Text = "";
                    textBoxMarca.Text = "";
                    textBoxCategoria.Text = "";
                    textBoxSubCategoria.Text = "";
                    textBoxFornecedor.Text = "";
                    textBoxCodigoFabricante.Text = "";
                    textBoxCodigoBarras.Text = "";
                    textBoxCodigoInterno.Text = "";
                    textBoxDataCadastro.Text = "";
                    textBoxDataAlteracao.Text = "";
                    textBoxUsuarioCadastro.Text = "";
                    textBoxUsuarioAlteracao.Text = "";

                    //Ativa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Enabled = false;
                    textBoxCustoAnterior.Enabled = false;
                    textBoxCustoFinal.Enabled = true;
                    textBoxVenda.Enabled = true;
                    buttonCalculoCustoVenda.Enabled = true;

                    //Ativa e/ou Inativa campos aba variações
                    comboBoxUnidadeVariacao.Enabled = true;
                    textBoxQtdVariacao.Enabled = true;
                    comboBoxFatorVariacao.Enabled = true;
                    buttonAdicionarVariacao.Enabled = true;
                    buttonExcluirVariacao.Enabled = true;
                    textBoxCodBarrasVariacao.Enabled = true;

                    //Limpa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Text = "";
                    textBoxCustoAnterior.Text = "";
                    textBoxCustoFinal.Text = "";
                    textBoxVenda.Text = "";

                    //Limpa e/ou Inativa campos aba variações
                    textBoxQtdVariacao.Text = "";
                    textBoxCodBarrasVariacao.Text = "";

                    comboBoxUnidadeVariacao.SelectedIndex = comboBoxUnidadeVariacao.FindStringExact("CX");
                    comboBoxUnidade.SelectedIndex = comboBoxUnidade.FindStringExact("UN");
                    comboBoxFatorVariacao.SelectedIndex = comboBoxFatorVariacao.FindStringExact("X");

                    textBoxDescricao.Focus();

                    break;

                case "SALVAR":

                    menuProdutoNovo.Enabled = true;
                    menuProdutoGravar.Enabled = false;
                    menuProdutoEditar.Enabled = true;
                    menuProdutoCancelar.Enabled = true;
                    menuProdutoExcluir.Enabled = true;

                    //Ativa e/ou Inativa campos aba principal
                    checkBoxAtivo.Enabled = false;
                    checkBoxDescontinuado.Enabled = false;
                    comboBoxTipoItem.Enabled = false;
                    textBoxCodigo.Enabled = false;
                    buttonBuscarProduto.Enabled = false;
                    textBoxDescricao.Enabled = false;
                    comboBoxUnidade.Enabled = false;
                    textBoxValorVenda.Enabled = false;
                    textBoxSaldoEstoque.Enabled = false;
                    buttonVerEstoque.Enabled = false;
                    textBoxMarca.Enabled = false;
                    buttonBuscarMarca.Enabled = false;
                    buttonLimparMarca.Enabled = false;
                    textBoxCategoria.Enabled = false;
                    buttonBuscarCategoria.Enabled = false;
                    buttonLimparCategoria.Enabled = false;
                    textBoxSubCategoria.Enabled = false;
                    buttonBuscarSubCategoria.Enabled = false;
                    buttonLimpaSubCategoria.Enabled = false;
                    textBoxFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = false;
                    buttonLimparFornecedor.Enabled = false;
                    textBoxCodigoFabricante.Enabled = false;
                    textBoxCodigoBarras.Enabled = false;
                    textBoxCodigoInterno.Enabled = false;

                    textBoxDataCadastro.Enabled = false;
                    textBoxUsuarioCadastro.Enabled = false;
                    textBoxDataAlteracao.Enabled = false;
                    textBoxUsuarioAlteracao.Enabled = false;

                    //Ativa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Enabled = false;
                    textBoxCustoAnterior.Enabled = false;
                    textBoxCustoFinal.Enabled = false;
                    textBoxVenda.Enabled = false;
                    buttonCalculoCustoVenda.Enabled = false;

                    //Ativa e/ou Inativa campos aba variações
                    comboBoxUnidadeVariacao.Enabled = false;
                    textBoxQtdVariacao.Enabled = false;
                    comboBoxFatorVariacao.Enabled = false;
                    buttonAdicionarVariacao.Enabled = false;
                    buttonExcluirVariacao.Enabled = false;
                    textBoxCodBarrasVariacao.Enabled = false;

                    break;

                case "EDITAR":

                    menuProdutoNovo.Enabled = false;
                    menuProdutoGravar.Enabled = true;
                    menuProdutoEditar.Enabled = false;
                    menuProdutoCancelar.Enabled = true;
                    menuProdutoExcluir.Enabled = false;

                    //Ativa e/ou Inativa campos aba principal
                    checkBoxAtivo.Enabled = true;
                    checkBoxDescontinuado.Enabled = true;
                    comboBoxTipoItem.Enabled = true;
                    textBoxCodigo.Enabled = false;
                    buttonBuscarProduto.Enabled = true;
                    textBoxDescricao.Enabled = true;
                    comboBoxUnidade.Enabled = true;
                    textBoxValorVenda.Enabled = false;
                    textBoxSaldoEstoque.Enabled = false;
                    buttonVerEstoque.Enabled = false;
                    textBoxMarca.Enabled = false;
                    buttonBuscarMarca.Enabled = true;
                    buttonLimparMarca.Enabled = true;
                    textBoxCategoria.Enabled = false;
                    buttonBuscarCategoria.Enabled = true;
                    buttonLimparCategoria.Enabled = true;
                    textBoxSubCategoria.Enabled = false;
                    buttonBuscarSubCategoria.Enabled = true;
                    buttonLimpaSubCategoria.Enabled = true;
                    textBoxFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = true;
                    buttonLimparFornecedor.Enabled = true;
                    textBoxCodigoFabricante.Enabled = true;
                    textBoxCodigoBarras.Enabled = true;
                    textBoxCodigoInterno.Enabled = true;

                    textBoxDataCadastro.Enabled = false;
                    textBoxUsuarioCadastro.Enabled = false;
                    textBoxDataAlteracao.Enabled = false;
                    textBoxUsuarioAlteracao.Enabled = false;

                    //Ativa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Enabled = false;
                    textBoxCustoAnterior.Enabled = false;
                    textBoxCustoFinal.Enabled = true;
                    textBoxVenda.Enabled = true;
                    buttonCalculoCustoVenda.Enabled = true;

                    //Ativa e/ou Inativa campos aba variações
                    comboBoxUnidadeVariacao.Enabled = true;
                    textBoxQtdVariacao.Enabled = true;
                    comboBoxFatorVariacao.Enabled = true;
                    buttonAdicionarVariacao.Enabled = true;
                    buttonExcluirVariacao.Enabled = true;
                    textBoxCodBarrasVariacao.Enabled = false;

                    textBoxDescricao.Focus();

                    break;

                case "CANCELAR":

                    menuProdutoNovo.Enabled = true;
                    menuProdutoGravar.Enabled = false;
                    menuProdutoEditar.Enabled = false;
                    menuProdutoCancelar.Enabled = false;
                    menuProdutoExcluir.Enabled = false;

                    //Ativa e/ou Inativa campos aba principal
                    checkBoxAtivo.Enabled = false;
                    checkBoxDescontinuado.Enabled = false;
                    comboBoxTipoItem.Enabled = false;
                    textBoxCodigo.Enabled = true;
                    buttonBuscarProduto.Enabled = true;
                    textBoxDescricao.Enabled = false;
                    comboBoxUnidade.Enabled = false;
                    textBoxValorVenda.Enabled = false;
                    textBoxSaldoEstoque.Enabled = false;
                    buttonVerEstoque.Enabled = false;
                    textBoxMarca.Enabled = false;
                    buttonBuscarMarca.Enabled = false;
                    buttonLimparMarca.Enabled = false;
                    textBoxCategoria.Enabled = false;
                    buttonBuscarCategoria.Enabled = false;
                    buttonLimparCategoria.Enabled = false;
                    textBoxSubCategoria.Enabled = false;
                    buttonBuscarSubCategoria.Enabled = false;
                    buttonLimpaSubCategoria.Enabled = false;
                    textBoxFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = false;
                    buttonLimparFornecedor.Enabled = false;
                    textBoxCodigoFabricante.Enabled = false;
                    textBoxCodigoBarras.Enabled = false;
                    textBoxCodigoInterno.Enabled = false;

                    textBoxDataCadastro.Enabled = false;
                    textBoxUsuarioCadastro.Enabled = false;
                    textBoxDataAlteracao.Enabled = false;
                    textBoxUsuarioAlteracao.Enabled = false;

                    //Limpa campos aba principal
                    checkBoxAtivo.Checked = false;
                    checkBoxDescontinuado.Checked = false;
                    textBoxCodigo.Text = "";
                    textBoxDescricao.Text = "";
                    textBoxValorVenda.Text = "";
                    textBoxSaldoEstoque.Text = "";
                    textBoxMarca.Text = "";
                    textBoxCategoria.Text = "";
                    textBoxSubCategoria.Text = "";
                    textBoxFornecedor.Text = "";
                    textBoxCodigoFabricante.Text = "";
                    textBoxCodigoBarras.Text = "";
                    textBoxCodigoInterno.Text = "";
                    textBoxDataCadastro.Text = "";
                    textBoxDataAlteracao.Text = "";
                    textBoxUsuarioCadastro.Text = "";
                    textBoxUsuarioAlteracao.Text = "";

                    //Ativa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Enabled = false;
                    textBoxCustoAnterior.Enabled = false;
                    textBoxCustoFinal.Enabled = false;
                    textBoxVenda.Enabled = false;
                    buttonCalculoCustoVenda.Enabled = false;

                    //Ativa e/ou Inativa campos aba variações
                    comboBoxUnidadeVariacao.Enabled = false;
                    textBoxQtdVariacao.Enabled = false;
                    comboBoxFatorVariacao.Enabled = false;
                    buttonAdicionarVariacao.Enabled = false;
                    buttonExcluirVariacao.Enabled = false;
                    textBoxCodBarrasVariacao.Enabled = false;

                    //Limpa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Text = "";
                    textBoxCustoAnterior.Text = "";
                    textBoxCustoFinal.Text = "";
                    textBoxVenda.Text = "";

                    //Limpa e/ou Inativa campos aba variações
                    textBoxQtdVariacao.Text = "";
                    textBoxCodBarrasVariacao.Text = "";

                    break;

                case "EXCLUIR":

                    menuProdutoNovo.Enabled = true;
                    menuProdutoGravar.Enabled = false;
                    menuProdutoEditar.Enabled = false;
                    menuProdutoCancelar.Enabled = false;
                    menuProdutoExcluir.Enabled = false;

                    //Ativa e/ou Inativa campos aba principal
                    checkBoxAtivo.Enabled = false;
                    checkBoxDescontinuado.Enabled = false;
                    comboBoxTipoItem.Enabled = false;
                    textBoxCodigo.Enabled = true;
                    buttonBuscarProduto.Enabled = true;
                    textBoxDescricao.Enabled = false;
                    comboBoxUnidade.Enabled = false;
                    textBoxValorVenda.Enabled = false;
                    textBoxSaldoEstoque.Enabled = false;
                    buttonVerEstoque.Enabled = false;
                    textBoxMarca.Enabled = false;
                    buttonBuscarMarca.Enabled = false;
                    buttonLimparMarca.Enabled = false;
                    textBoxCategoria.Enabled = false;
                    buttonBuscarCategoria.Enabled = false;
                    buttonLimparCategoria.Enabled = false;
                    textBoxSubCategoria.Enabled = false;
                    buttonBuscarSubCategoria.Enabled = false;
                    buttonLimpaSubCategoria.Enabled = false;
                    textBoxFornecedor.Enabled = false;
                    buttonBuscarFornecedor.Enabled = false;
                    buttonLimparFornecedor.Enabled = false;
                    textBoxCodigoFabricante.Enabled = false;
                    textBoxCodigoBarras.Enabled = false;
                    textBoxCodigoInterno.Enabled = false;

                    textBoxDataCadastro.Enabled = false;
                    textBoxUsuarioCadastro.Enabled = false;
                    textBoxDataAlteracao.Enabled = false;
                    textBoxUsuarioAlteracao.Enabled = false;

                    //Limpa campos aba principal
                    checkBoxAtivo.Checked = false;
                    checkBoxDescontinuado.Checked = false;
                    textBoxCodigo.Text = "";
                    textBoxDescricao.Text = "";
                    textBoxValorVenda.Text = "";
                    textBoxSaldoEstoque.Text = "";
                    textBoxMarca.Text = "";
                    textBoxCategoria.Text = "";
                    textBoxSubCategoria.Text = "";
                    textBoxFornecedor.Text = "";
                    textBoxCodigoFabricante.Text = "";
                    textBoxCodigoBarras.Text = "";
                    textBoxCodigoInterno.Text = "";
                    textBoxDataCadastro.Text = "";
                    textBoxDataAlteracao.Text = "";
                    textBoxUsuarioCadastro.Text = "";
                    textBoxUsuarioAlteracao.Text = "";
                    comboBoxTipoItem.SelectedIndex = 0;
                    comboBoxUnidade.SelectedIndex = 0;

                    //Ativa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Enabled = false;
                    textBoxCustoAnterior.Enabled = false;
                    textBoxCustoFinal.Enabled = false;
                    textBoxVenda.Enabled = false;
                    buttonCalculoCustoVenda.Enabled = false;

                    //Ativa e/ou Inativa campos aba variações
                    comboBoxUnidadeVariacao.Enabled = false;
                    textBoxQtdVariacao.Enabled = false;
                    comboBoxFatorVariacao.Enabled = false;
                    buttonAdicionarVariacao.Enabled = false;
                    buttonExcluirVariacao.Enabled = false;
                    textBoxCodBarrasVariacao.Enabled = false;

                    //Limpa e/ou Inativa campos aba valores
                    textBoxUltimoCustoCompra.Text = "";
                    textBoxCustoAnterior.Text = "";
                    textBoxCustoFinal.Text = "";
                    textBoxVenda.Text = "";

                    //Limpa e/ou Inativa campos aba variações
                    textBoxQtdVariacao.Text = "";
                    comboBoxUnidadeVariacao.SelectedIndex = 0;
                    comboBoxFatorVariacao.SelectedIndex = 0;
                    textBoxCodBarrasVariacao.Text = "";

                    break;

                case "PESQUISAR":

                    menuProdutoNovo.Enabled = true;
                    menuProdutoGravar.Enabled = false;
                    menuProdutoEditar.Enabled = true;
                    menuProdutoCancelar.Enabled = true;
                    menuProdutoExcluir.Enabled = true;

                    break;

            }

        }

    }
}
