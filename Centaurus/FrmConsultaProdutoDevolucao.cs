using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.DAL;

namespace Centaurus
{
    public partial class FrmConsultaProdutoDevolucao : Form
    {
        LocacaoDevolucaoDAO daoLocaDev = new LocacaoDevolucaoDAO();

        public string returnNumeroLocacao;

        //Referencias dos itens clicados na tabela de itens a devolver
        public string idProdutoEnvia { get; set; }
        public string idVariacaoProdutoEnvia { get; set; }
        public string valorLocadoProdutoEnvia { get; set; }
        public string qtdRestanteProdutoEnvia { get; set; }
        public string nomeProdutoEnvia { get; set; }

        string numeroItem;

        public FrmConsultaProdutoDevolucao(string numLocacao,string numItem)
        {
            returnNumeroLocacao = numLocacao;
            if(String.IsNullOrEmpty(numItem) == true)
            {
                numeroItem = null;
            }
            InitializeComponent();

            carregarInformacoes();
        }

        private void toolStripButtonSelecionar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void carregarInformacoes()
        {
            dataGridViewProdutosDevLocacao.DataSource = daoLocaDev.listarItensParaDevolucao(returnNumeroLocacao, numeroItem);
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            int qtdRegistros;

            //Renomeia algumas colunas
            dataGridViewProdutosDevLocacao.Columns[0].HeaderText = "Código";
            dataGridViewProdutosDevLocacao.Columns[0].Width = 45;

            dataGridViewProdutosDevLocacao.Columns[2].HeaderText = "Descrição";
            dataGridViewProdutosDevLocacao.Columns[2].Width = 170;

            dataGridViewProdutosDevLocacao.Columns[3].HeaderText = "UN";
            dataGridViewProdutosDevLocacao.Columns[3].Width = 50;

            dataGridViewProdutosDevLocacao.Columns[4].HeaderText = "R$ locado";
            dataGridViewProdutosDevLocacao.Columns[4].Width = 60;

            dataGridViewProdutosDevLocacao.Columns[5].HeaderText = "Qtd. locada";
            dataGridViewProdutosDevLocacao.Columns[5].Width = 65;

            dataGridViewProdutosDevLocacao.Columns[6].HeaderText = "Qtd. devolvida";
            dataGridViewProdutosDevLocacao.Columns[6].Width = 65;

            dataGridViewProdutosDevLocacao.Columns[7].HeaderText = "Qtd. restante";
            dataGridViewProdutosDevLocacao.Columns[7].Width = 65;

            dataGridViewProdutosDevLocacao.Columns[8].HeaderText = "Marca";
            dataGridViewProdutosDevLocacao.Columns[8].Width = 80;

            dataGridViewProdutosDevLocacao.Columns[9].HeaderText = "Categoria";
            dataGridViewProdutosDevLocacao.Columns[9].Width = 80;

            dataGridViewProdutosDevLocacao.Columns[10].HeaderText = "Sub-categoria";
            dataGridViewProdutosDevLocacao.Columns[10].Width = 80;

            dataGridViewProdutosDevLocacao.Columns[11].HeaderText = "Fornecedor";
            dataGridViewProdutosDevLocacao.Columns[11].Width = 120;

            dataGridViewProdutosDevLocacao.Columns[12].HeaderText = "Cód. fabricante";
            dataGridViewProdutosDevLocacao.Columns[12].Width = 60;

            dataGridViewProdutosDevLocacao.Columns[13].HeaderText = "Cód. interno";
            dataGridViewProdutosDevLocacao.Columns[13].Width = 55;

            //Inativa algumas colunas
            dataGridViewProdutosDevLocacao.Columns["IDProdutoVariacao"].Visible = false;//1
            dataGridViewProdutosDevLocacao.Columns["IDLocacao"].Visible = false;

            //Conta a quantidade de registro e seta no campo
            qtdRegistros = dataGridViewProdutosDevLocacao.Rows.Count;
            dataGridViewProdutosDevLocacao.Text = "Qtd. registros: " + qtdRegistros;

            //Convertendo as colunas do dataGridView            
            this.dataGridViewProdutosDevLocacao.Columns[4].ValueType = typeof(decimal);
            this.dataGridViewProdutosDevLocacao.Columns[4].DefaultCellStyle.Format = "N2";
        }

        private void dataGridViewProdutosDevLocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeProdutoEnvia = dataGridViewProdutosDevLocacao.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxProdutoClicado.Text = nomeProdutoEnvia;

            idProdutoEnvia = dataGridViewProdutosDevLocacao.Rows[e.RowIndex].Cells[0].Value.ToString();
            idVariacaoProdutoEnvia = dataGridViewProdutosDevLocacao.Rows[e.RowIndex].Cells[1].Value.ToString();
            valorLocadoProdutoEnvia = dataGridViewProdutosDevLocacao.Rows[e.RowIndex].Cells[4].Value.ToString();
            qtdRestanteProdutoEnvia = dataGridViewProdutosDevLocacao.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
