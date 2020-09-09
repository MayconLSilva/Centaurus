using Centaurus.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centaurus
{
    public partial class FrmConsultaProduto : Form
    {

        ProdutoDAO produtoDAO = new ProdutoDAO();
        public string idProdutoClicado { get; set; }
        public string idProdutoVariacaoClicado { get; set; }
        public string nomeProdutoClicado { get; set; }
        public string valorProdutoClicado { get; set; }
        public string custoProdutoClicado { get; set; }

        public string tipoConsultaReturn;

        public FrmConsultaProduto(string filtro)
        {
            InitializeComponent();
            tipoConsultaReturn = filtro;
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            //Valido se a consulta está vindo da tela de produto ou locação, e caso seja locação só irá deixar ativo o tipo de pesquisa para produto
            if (tipoConsultaReturn == "PS")
            {
                radioButtonTodos.Checked = true;
                comboBoxTipoFiltroProduto.SelectedIndex = comboBoxTipoFiltroProduto.FindStringExact("TODOS");
            }
            else if (tipoConsultaReturn == "PV")
            {
                radioButtonProduto.Checked = true;
                radioButtonServico.Enabled = false;
                radioButtonTodos.Enabled = false;
                comboBoxTipoFiltroProduto.SelectedIndex = comboBoxTipoFiltroProduto.FindStringExact("TODOS");
            }           
            
            CarregarInformacoes();            
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (textBoxProdutoClicado.Text == string.Empty)
            {
                MessageBox.Show("Selecione um produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dispose();
            }
        }

        private void CarregarInformacoes()
        {
            //Verifico o tipo se é serviço, produto ou ambos
            string tipoProduto = "P", tipoServico = "S";
            if (radioButtonTodos.Checked)
            {
                tipoProduto = "P"; tipoServico = "S";
            }
            else if (radioButtonProduto.Checked)
            {
                tipoProduto = "P"; tipoServico = "";
            }
            else if (radioButtonServico.Checked)
            {
                tipoProduto = ""; tipoServico = "S";
            }

            //Consulta vinda da tela de cadastro do produto
            if(tipoConsultaReturn == "PS")
            {
                dataGridViewProduto.DataSource = produtoDAO.SelecionarTodosProdutosFiltrando(comboBoxTipoFiltroProduto.SelectedItem.ToString(), textBoxFiltrarProduto.Text, tipoProduto, tipoServico);
                configurarDataGridView2();
            }
            else if(tipoConsultaReturn == "PV")
            {
                dataGridViewProduto.DataSource = produtoDAO.SelecionarTodosProdutosVariacaoFiltrando(comboBoxTipoFiltroProduto.SelectedItem.ToString(), textBoxFiltrarProduto.Text, tipoProduto, tipoServico);
                configurarDataGridView();
            }            
        }
                
        public void configurarDataGridView()
        {
            int qtdRegistro;

            //Renomeando as colunas
            dataGridViewProduto.Columns[0].HeaderText = "Código";
            dataGridViewProduto.Columns[1].HeaderText = "Código variação";
            dataGridViewProduto.Columns[2].HeaderText = "Descrição";
            dataGridViewProduto.Columns[3].HeaderText = "Unidade";
            dataGridViewProduto.Columns[4].HeaderText = "R$ Custo";
            dataGridViewProduto.Columns[5].HeaderText = "R$ Venda";
            dataGridViewProduto.Columns[6].HeaderText = "Marca";
            dataGridViewProduto.Columns[7].HeaderText = "Categoria";
            dataGridViewProduto.Columns[8].HeaderText = "Sub-Categoria";
            dataGridViewProduto.Columns[9].HeaderText = "Fornecedor";
            dataGridViewProduto.Columns[10].HeaderText = "Saldo";
            dataGridViewProduto.Columns[11].HeaderText = "Saldo variação";
            dataGridViewProduto.Columns[12].HeaderText = "Cód. Fabricante";            
            dataGridViewProduto.Columns[13].HeaderText = "Cód. Barras";
            dataGridViewProduto.Columns[14].HeaderText = "Cód. Interno";
            dataGridViewProduto.Columns[15].HeaderText = "Tipo Item";

            //Convertendo as colunas do dataGridView            
            this.dataGridViewProduto.Columns[4].ValueType = typeof(decimal);
            this.dataGridViewProduto.Columns[4].DefaultCellStyle.Format = "N2";

            this.dataGridViewProduto.Columns[5].ValueType = typeof(decimal);
            this.dataGridViewProduto.Columns[5].DefaultCellStyle.Format = "N2";

            //Configurando o tamanho das colunas
            dataGridViewProduto.Columns[0].Width = 45;
            dataGridViewProduto.Columns[2].Width = 170;
            dataGridViewProduto.Columns[3].Width = 50;
            dataGridViewProduto.Columns[4].Width = 60;
            dataGridViewProduto.Columns[5].Width = 90;
            dataGridViewProduto.Columns[6].Width = 90;
            dataGridViewProduto.Columns[7].Width = 90;
            dataGridViewProduto.Columns[8].Width = 90;
            dataGridViewProduto.Columns[9].Width = 120;
            dataGridViewProduto.Columns[10].Width = 60;
            dataGridViewProduto.Columns[11].Width = 90;
            dataGridViewProduto.Columns[12].Width = 90;
            dataGridViewProduto.Columns[13].Width = 90;
            dataGridViewProduto.Columns[14].Width = 90;
            dataGridViewProduto.Columns[15].Width = 45;

            //Remover linha em branco da gridView
            this.dataGridViewProduto.AllowUserToAddRows = false;

            //Conta a quantidade de registro e seta no campo
            qtdRegistro = dataGridViewProduto.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros: " + qtdRegistro;

            //Oculta uma coluna no grid
            dataGridViewProduto.Columns["variacaoproduto"].Visible = false;

            //label1.Text = dataGridViewProduto.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["saldo_produto"].Value)).ToString("N2");
        }

        public void configurarDataGridView2()
        {
            int qtdRegistro;

            //Renomeando as colunas
            dataGridViewProduto.Columns[0].HeaderText = "Código";
            dataGridViewProduto.Columns[1].HeaderText = "Descrição";
            dataGridViewProduto.Columns[2].HeaderText = "Unidade";
            dataGridViewProduto.Columns[3].HeaderText = "Categoria";
            dataGridViewProduto.Columns[4].HeaderText = "Sub-Categoria";
            dataGridViewProduto.Columns[5].HeaderText = "Marca";
            dataGridViewProduto.Columns[6].HeaderText = "R$ Venda";
            dataGridViewProduto.Columns[7].HeaderText = "R$ Custo";
            dataGridViewProduto.Columns[8].HeaderText = "Saldo";
            dataGridViewProduto.Columns[9].HeaderText = "Fornecedor";            
            dataGridViewProduto.Columns[10].HeaderText = "Cód. Fabricante";
            dataGridViewProduto.Columns[11].HeaderText = "Cód. Barras";
            dataGridViewProduto.Columns[12].HeaderText = "Cód. Interno";
            dataGridViewProduto.Columns[13].HeaderText = "Tipo Item";

            //Convertendo as colunas do dataGridView            
            this.dataGridViewProduto.Columns[6].ValueType = typeof(decimal);
            this.dataGridViewProduto.Columns[6].DefaultCellStyle.Format = "N2";

            this.dataGridViewProduto.Columns[7].ValueType = typeof(decimal);
            this.dataGridViewProduto.Columns[7].DefaultCellStyle.Format = "N2";

            //Configurando o tamanho das colunas
            dataGridViewProduto.Columns[0].Width = 45;
            dataGridViewProduto.Columns[1].Width = 170;
            dataGridViewProduto.Columns[2].Width = 55;
            dataGridViewProduto.Columns[3].Width = 120;
            dataGridViewProduto.Columns[4].Width = 120;
            dataGridViewProduto.Columns[5].Width = 120;
            dataGridViewProduto.Columns[6].Width = 70;
            dataGridViewProduto.Columns[7].Width = 70;
            dataGridViewProduto.Columns[8].Width = 60;
            dataGridViewProduto.Columns[9].Width = 160;
            dataGridViewProduto.Columns[10].Width = 90;
            dataGridViewProduto.Columns[11].Width = 90;
            dataGridViewProduto.Columns[12].Width = 60;
            dataGridViewProduto.Columns[13].Width = 50;

            //Remover linha em branco da gridView
            this.dataGridViewProduto.AllowUserToAddRows = false;

            //Conta a quantidade de registro e seta no campo
            qtdRegistro = dataGridViewProduto.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros: " + qtdRegistro;

            //Oculta uma coluna no grid
            //dataGridViewProduto.Columns["variacaoproduto"].Visible = false;

            //label1.Text = dataGridViewProduto.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["saldo_produto"].Value)).ToString("N2");
        }

        private void dataGridViewProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Consulta vinda da tela de cadastro do produto
            if (tipoConsultaReturn == "PS")
            {
                idProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxProdutoClicado.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[1].Value.ToString();

                nomeProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                valorProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[6].Value.ToString();
                custoProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (tipoConsultaReturn == "PV")
            {
                idProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxProdutoClicado.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[2].Value.ToString();

                idProdutoVariacaoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[1].Value.ToString();

                nomeProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                valorProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[5].Value.ToString();
                custoProdutoClicado = dataGridViewProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
            }            
        }

        private void buttonFiltrarProduto_Click(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

    }
}
