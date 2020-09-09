using Centaurus.Dao;
using System;
using System.Windows.Forms;

namespace Centaurus
{
    public partial class FrmConsultaCategoriaSubCategoria : Form
    {
        CategoriaDAO categoriaSubCatDAO = new CategoriaDAO();
        public string categoriaSubCategoriaClicada { get; set; }
        public string idClicada { get; set; }
        public string tipoCategoriaClicada { get; set; }

        //public string returnTipoConsulta;


        public FrmConsultaCategoriaSubCategoria()
        {

            InitializeComponent();
        }

        /* Metodo para receber anteriormente o valor 
        public FrmConsultaCategoria(string valorReturnCategoria)
        {
            InitializeComponent();
            returnTipoConsulta = valorReturnCategoria;
            Console.WriteLine("o valor é " + returnTipoConsulta);
        }
        */


        private void CarregarInformacoes()
        {
            int qtdRegistro;
            dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.SelecionarTodasCategoriaSubCategoria();
            qtdRegistro = dataGridViewCategoriaSubCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;            
            configurarDataGridView();

            //Para remover a linha em branco via propriedades basta marcar AllowUserToAddRows como false
            // se for via código deverá utilizar this.dataGridViewProduto.AllowUserToAddRows = false;
        }

        public void configurarDataGridView()
        {
            //Renomeando as colunas
            dataGridViewCategoriaSubCategoria.Columns[0].HeaderText = "Código";
            dataGridViewCategoriaSubCategoria.Columns[1].HeaderText = "Nome";
            dataGridViewCategoriaSubCategoria.Columns[2].HeaderText = "Data cadastro";
            dataGridViewCategoriaSubCategoria.Columns[4].HeaderText = "Tipo";


            //Configurando o tamanho das colunas
            dataGridViewCategoriaSubCategoria.Columns[0].Width = 45;
            dataGridViewCategoriaSubCategoria.Columns[1].Width = 120;
            dataGridViewCategoriaSubCategoria.Columns[2].Width = 120;
            dataGridViewCategoriaSubCategoria.Columns[4].Width = 55;

            dataGridViewCategoriaSubCategoria.Columns["ativo_categoria"].Visible = false;

        }

        private void dataGridViewCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idClicada = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCategoriaSubCategoriaClicada.Text = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            categoriaSubCategoriaClicada = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            tipoCategoriaClicada = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (textBoxCategoriaSubCategoriaClicada.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dispose();
            }

        }

        private void CarregarInformacoesFiltrando()
        {
            int qtdRegistro;
            if (comboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == "CATEGORIA")
            {
                dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.SelecionarTodasCategoriaSubCategoriaNome(textBoxFiltrarCategoriaSubCategoria.Text);
            }
            else if (comboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == "TODAS")
            {
                dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.SelecionarTodasCategoriaSubCategoria();
            }
            qtdRegistro = dataGridViewCategoriaSubCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;
            configurarDataGridView();
        }

        private void buttonFiltrarCidade_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == null)
            {
                MessageBox.Show("Não foi selecionado nenhum filtro", "Atenção");
            }
            else
            {
                CarregarInformacoesFiltrando();
            }
        }

        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

    }
}
