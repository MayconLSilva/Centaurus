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
    public partial class FrmConsultaCategoria : Form        
    {

        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public string idCategoria { get; set; }
        public string nomeCategoria { get; set; }

        public FrmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void CarregarInformacoes()
        {
            int qtdRegistro;
            dataGridViewCategoria.DataSource = categoriaDAO.SelecionarTodasCategoria();
            qtdRegistro = dataGridViewCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            //Renomeando as colunas
            dataGridViewCategoria.Columns[0].HeaderText = "Código";
            dataGridViewCategoria.Columns[1].HeaderText = "Nome";
            dataGridViewCategoria.Columns[2].HeaderText = "Data cadastro";


            //Configurando o tamanho das colunas
            dataGridViewCategoria.Columns[0].Width = 45;
            dataGridViewCategoria.Columns[1].Width = 120;
            dataGridViewCategoria.Columns[2].Width = 120;

            dataGridViewCategoria.Columns["ativo_categoria"].Visible = false;
            dataGridViewCategoria.Columns["tipo_categoria"].Visible = false;

        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (textBoxCategoriaClicada.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dispose();
            }
        }

        private void dataGridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCategoria = dataGridViewCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCategoriaClicada.Text = dataGridViewCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            nomeCategoria = dataGridViewCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void FrmConsultaCategoria_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void buttonFiltrarCategoria_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoFiltroCategoria.SelectedItem == null)
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
            int qtdRegistro;
            if (comboBoxTipoFiltroCategoria.SelectedItem == "CATEGORIA")
            {
                dataGridViewCategoria.DataSource = categoriaDAO.SelecionarTodasCategoriaNome(textBoxFiltrarCategoria.Text);
            }
            else if (comboBoxTipoFiltroCategoria.SelectedItem == "TODAS")
            {
                dataGridViewCategoria.DataSource = categoriaDAO.SelecionarTodasCategoria();

            }

            qtdRegistro = dataGridViewCategoria.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;
            configurarDataGridView();
        }

        private void comboBoxTipoFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFiltrarCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCategoriaClicada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
