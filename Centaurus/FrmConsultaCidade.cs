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
    public partial class FrmConsultaCidade : Form        
    {
        CidadeDAO cidadeDAO = new CidadeDAO();
        public string cidadeClicada { get; set; }
        public string ufClicada { get; set; }

        public FrmConsultaCidade()
        {
            InitializeComponent();
        }

        private void CarregarInformacoes() 
        {
            dataGridViewCidade.DataSource = cidadeDAO.SelecionarTodasCidades();
            configurarDataGridView();
        }

        public void configurarDataGridView() 
        {
            //Renomeando as colunas
            dataGridViewCidade.Columns[0].HeaderText = "Código";
            dataGridViewCidade.Columns[1].HeaderText = "Nome";
            dataGridViewCidade.Columns[2].HeaderText = "UF";

            //Configurando o tamanho das colunas
            dataGridViewCidade.Columns[0].Width = 45;
            dataGridViewCidade.Columns[1].Width = 120;
            dataGridViewCidade.Columns[2].Width = 60;

        }

        private void FrmConsultaCidade_Load(object sender, EventArgs e)
        {
            CarregarInformacoes();
        }

        private void dataGridViewCidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCidadeClicada.Text = dataGridViewCidade.Rows[e.RowIndex].Cells[1].Value.ToString();
            cidadeClicada = dataGridViewCidade.Rows[e.RowIndex].Cells[1].Value.ToString();

            ufClicada = dataGridViewCidade.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if(textBoxCidadeClicada.Text == string.Empty) 
            {
                MessageBox.Show("Selecione uma cidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                Dispose();
            }
            
        }

        private void CarregarInformacoesFiltrando()
        {
            if(comboBoxTipoFiltroCidade.SelectedItem == "CIDADE") 
            {
                dataGridViewCidade.DataSource = cidadeDAO.SelecionarTodasCidadesFiltrandoNome(textBoxFiltrarCidade.Text);
            }else if(comboBoxTipoFiltroCidade.SelectedItem == "UF") 
            {
                string valor = textBoxFiltrarCidade.Text;
                int contador = valor.Length;
                if(contador != 2) 
                {
                    MessageBox.Show("UF inválida", "Atenção");
                }
                else 
                {
                    dataGridViewCidade.DataSource = cidadeDAO.SelecionarTodasCidadesFiltrandoUF(textBoxFiltrarCidade.Text);
                }
                
            }else if(comboBoxTipoFiltroCidade.SelectedItem == "TODAS") 
            {
                dataGridViewCidade.DataSource = cidadeDAO.SelecionarTodasCidades();
            }
            
            configurarDataGridView();
        }

        private void buttonFiltrarCidade_Click(object sender, EventArgs e)
        {
            if(comboBoxTipoFiltroCidade.SelectedItem == null) 
            {
                MessageBox.Show("Não foi selecionado nenhum filtro", "Atenção");
            }else  
            {
                CarregarInformacoesFiltrando();
            }
        }
    }
}
