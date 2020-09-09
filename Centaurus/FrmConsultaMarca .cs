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
        public string marcaClicada { get; set; }
        public string idClicada { get; set; }
                
        public FrmConsultaMarca()
        {
            InitializeComponent();
        }

        
        private void CarregarInformacoes() 
        {
            dataGridViewMarca.DataSource = marcaDAO.SelecionarTodasMarcas();
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

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if(textBoxMarcaClicada.Text == string.Empty) 
            {
                MessageBox.Show("Selecione uma marca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                Dispose();
            }
            
        }
                
        private void CarregarInformacoesFiltrando()
        {
            if(comboBoxTipoFiltroMarca.SelectedItem == "MARCA") 
            {
                dataGridViewMarca.DataSource = marcaDAO.SelecionarTodasMarcasNome(textBoxFiltrarMarca.Text);
            }else if(comboBoxTipoFiltroMarca.SelectedItem == "TODAS") 
            {
                dataGridViewMarca.DataSource = marcaDAO.SelecionarTodasMarcas();

            }
            
            configurarDataGridView();
        }
       
        private void buttonFiltrarCidade_Click(object sender, EventArgs e)
        {
            if(comboBoxTipoFiltroMarca.SelectedItem == null) 
            {
                MessageBox.Show("Não foi selecionado nenhum filtro", "Atenção");
            }else  
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
