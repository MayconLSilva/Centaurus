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

        private string valorReturnTipoConsulta;

        public FrmConsultaCategoriaSubCategoria(string tipoConsulta)
        {            
            InitializeComponent();
            valorReturnTipoConsulta = tipoConsulta;
        }
               
        private void CarregarInformacoes()
        {
            string tipoConsulta="T";
            if (radioButtonTodos.Checked)
            {
                tipoConsulta = "T";
            }else if (radioButtonCategoria.Checked)
            {
                tipoConsulta = "C";
            }else if (radioButtonSubCategoria.Checked)
            {
                tipoConsulta = "S";
            }

            dataGridViewCategoriaSubCategoria.DataSource = categoriaSubCatDAO.listarCategoriaSubCategoria(tipoConsulta, toolStripComboBoxTipoFiltroCategoriaSubCategoria.Text, toolStripTextBoxFiltroCategoriaSubCategoria.Text);

            configurarDataGridView();
            
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

            int qtdRegistro;
            qtdRegistro = dataGridViewCategoriaSubCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;

        }

        private void dataGridViewCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idClicada = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCategoriaSubCategoriaClicada.Text = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            categoriaSubCategoriaClicada = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            tipoCategoriaClicada = dataGridViewCategoriaSubCategoria.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
        
        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {            
            if(valorReturnTipoConsulta == "T")
            {
                this.Text = "Consulta Categoria e Sub-Categoria";
                toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedIndex = toolStripComboBoxTipoFiltroCategoriaSubCategoria.FindStringExact("TODOS");
                radioButtonTodos.Checked = true;
                
            }else if(valorReturnTipoConsulta == "C")
            {
                this.Text = "Consulta Categoria";
                toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedIndex = toolStripComboBoxTipoFiltroCategoriaSubCategoria.FindStringExact("TODOS");
                radioButtonCategoria.Checked = true;
                radioButtonTodos.Enabled = false;
                radioButtonSubCategoria.Enabled = false;
            }
            else if (valorReturnTipoConsulta == "S")
            {
                this.Text = "Consulta Sub-Categoria";
                toolStripComboBoxTipoFiltroCategoriaSubCategoria.SelectedIndex = toolStripComboBoxTipoFiltroCategoriaSubCategoria.FindStringExact("TODOS");
                radioButtonSubCategoria.Checked = true;
                radioButtonTodos.Enabled = false;
                radioButtonCategoria.Enabled = false;
            }
            CarregarInformacoes();
        }

        private void toolStripButtonFiltrarCategoriaSubCategoria_Click(object sender, EventArgs e)
        {
            CarregarInformacoes();
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
