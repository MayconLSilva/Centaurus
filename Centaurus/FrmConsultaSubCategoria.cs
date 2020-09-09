using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.Dao;

namespace Centaurus
{
    public partial class FrmConsultaSubCategoria : Form
    {
        CategoriaDAO SubcategoriaDAO = new CategoriaDAO();
        public string idSubCat { get; set; }
        public string nomeSubCat { get; set; }

        public FrmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void CarregarInformacoes()
        {
            dataGridViewSubCategoria.DataSource = SubcategoriaDAO.SelecionarTodasSubCategoria();
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            int qtdRegistro;

            //Renomeando as colunas
            dataGridViewSubCategoria.Columns[0].HeaderText = "Código";
            dataGridViewSubCategoria.Columns[1].HeaderText = "Nome";
            dataGridViewSubCategoria.Columns[2].HeaderText = "Data cadastro";


            //Configurando o tamanho das colunas
            dataGridViewSubCategoria.Columns[0].Width = 45;
            dataGridViewSubCategoria.Columns[1].Width = 120;
            dataGridViewSubCategoria.Columns[2].Width = 120;

            dataGridViewSubCategoria.Columns["ativo_categoria"].Visible = false;
            dataGridViewSubCategoria.Columns["tipo_categoria"].Visible = false;

            qtdRegistro = dataGridViewSubCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. de registros: " + qtdRegistro;



        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (textBoxSubCategoriaClicada.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dispose();
            }
        }

        private void dataGridViewSubCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idSubCat = dataGridViewSubCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxSubCategoriaClicada.Text = dataGridViewSubCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            nomeSubCat = dataGridViewSubCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void FrmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void buttonFiltrarSubCategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoFiltroSubCategoria.SelectedItem == null)
            {
                MessageBox.Show("Não foi selecionado nenhum filtro", "Atenção");
            }
            else
            {
                CarregarInformacoesFiltrando();
            }
        }

        private void CarregarInformacoesFiltrando()
        {
            if (comboBoxTipoFiltroSubCategoria.SelectedItem == "CATEGORIA")
            {
                dataGridViewSubCategoria.DataSource = SubcategoriaDAO.SelecionarTodasSubCategoriaNome(textBoxFiltrarSubCategoria.Text);
            }
            else if (comboBoxTipoFiltroSubCategoria.SelectedItem == "TODAS")
            {
                dataGridViewSubCategoria.DataSource = SubcategoriaDAO.SelecionarTodasSubCategoria();

            }

            configurarDataGridView();
        }

    }


}

