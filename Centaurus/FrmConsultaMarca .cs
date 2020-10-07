using Centaurus.Bll;
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
    public partial class FrmConsultaMarca : Form        
    {
        MarcaDAO marcaDAO = new MarcaDAO();
        MarcaBLL bllMarca = new MarcaBLL();
        public string marcaClicada { get; set; }
        public string idClicada { get; set; }
                
        public FrmConsultaMarca()
        {
            InitializeComponent();
        }

        
        private void CarregarInformacoes() 
        {
            dataGridViewMarca.DataSource = bllMarca.listarMarcas(toolStripComboBoxTipoFiltroMarca.Text, toolStripTextBoxFiltroMarca.Text);
            configurarDataGridView();
        }
        
        public void configurarDataGridView() 
        {
            int qtdRegistros;

            //Renomeando as colunas
            dataGridViewMarca.Columns[0].HeaderText = "Código";
            dataGridViewMarca.Columns[1].HeaderText = "Nome";
            dataGridViewMarca.Columns[2].HeaderText = "Data cadastro";

            //Configurando o tamanho das colunas
            dataGridViewMarca.Columns[0].Width = 45;
            dataGridViewMarca.Columns[1].Width = 120;
            dataGridViewMarca.Columns[2].Width = 120;

            //Inativa uma das colunas
            dataGridViewMarca.Columns["ativo_marca"].Visible = false;

            //Conta a quantidade de registro e seta na label
            qtdRegistros = dataGridViewMarca.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros: " + qtdRegistros;
        }

        private void dataGridViewCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMarcaClicada.Text = dataGridViewMarca.Rows[e.RowIndex].Cells[1].Value.ToString();
            marcaClicada = dataGridViewMarca.Rows[e.RowIndex].Cells[1].Value.ToString();

            idClicada = dataGridViewMarca.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        
        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {
            toolStripComboBoxTipoFiltroMarca.SelectedIndex = toolStripComboBoxTipoFiltroMarca.FindStringExact("TODAS");
            CarregarInformacoes();
        }

        private void toolStripButtonFiltrarCategoriaSubCategoria_Click(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void toolStripButtonSelecionarCategoriaSubCategoria_Click(object sender, EventArgs e)
        {
            if (textBoxMarcaClicada.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma marca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dispose();
            }
        }
    }
}
