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
            toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedIndex = toolStripComboBoxTipoFiltroCategoriaSubCategoria.FindStringExact("TODOS");
            radioButtonTodos.Checked = true;
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
            if(toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == "TODOS" && radioButtonTodos.Checked)
            {
                int qtdRegistro;
                dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.SelecionarTodasCategoriaSubCategoria();
                qtdRegistro = dataGridViewCategoriaSubCategoria.Rows.Count;
                labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;
                configurarDataGridView();
            }
            
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
        
        private void CarregarInformacoesFiltrando()
        {
            int qtdRegistro;
            if (toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == "CATEGORIA")
            {
                dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.SelecionarTodasCategoriaSubCategoriaNome(toolStripTextBoxFiltroCategoriaSubCategoria.Text);
            }
            else if (toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == "TODOS")
            {
                dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.SelecionarTodasCategoriaSubCategoria();
            }
            qtdRegistro = dataGridViewCategoriaSubCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;
            configurarDataGridView();
        }
        
        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void toolStripButtonFiltrarCategoriaSubCategoria_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedItem == null)
            {
                MessageBox.Show("Não foi selecionado nenhum filtro", "Atenção");
            }
            else
            {
                CarregarInformacoesFiltrando();
            }
        }

        private void toolStripButtonSelecionarCategoriaSubCategoria_Click(object sender, EventArgs e)
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

    }
}
