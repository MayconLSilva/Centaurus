using Centaurus.BLL;
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
        CidadeBLL bllCidade = new CidadeBLL();

        public string cidadeClicada { get; set; }
        public string ufClicada { get; set; }

        public FrmConsultaCidade()
        {
            InitializeComponent();
        }

        private void CarregarInformacoes() 
        {
            dataGridViewCidade.DataSource = bllCidade.listarCidades(toolStripComboBoxTipoFiltroCidade.Text, toolStripTextBoxFiltroCidade.Text);
            configurarDataGridView();
        }

        public void configurarDataGridView() 
        {
            //Renomeando as colunas
            dataGridViewCidade.Columns[0].HeaderText = "Código";
            dataGridViewCidade.Columns[1].HeaderText = "Nome";
            dataGridViewCidade.Columns[2].HeaderText = "UF";
            dataGridViewCidade.Columns[3].HeaderText = "Cód. IBGE";

            //Configurando o tamanho das colunas
            dataGridViewCidade.Columns[0].Width = 45;
            dataGridViewCidade.Columns[1].Width = 120;
            dataGridViewCidade.Columns[2].Width = 60;
            dataGridViewCidade.Columns[3].Width = 60;

        }

        private void FrmConsultaCidade_Load(object sender, EventArgs e)
        {
            toolStripComboBoxTipoFiltroCidade.SelectedIndex = toolStripComboBoxTipoFiltroCidade.FindStringExact("TODAS");            
            CarregarInformacoes();
        }

        private void toolStripButtonSelecionarCidade_Click(object sender, EventArgs e)
        {
            if (textBoxCidadeClicada.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma cidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dispose();
            }
        }

        private void toolStripButtonFiltrarCidade_Click(object sender, EventArgs e)
        {
            if (toolStripComboBoxTipoFiltroCidade.SelectedItem == "UF")
            {
                string valor = toolStripTextBoxFiltroCidade.Text;
                int contador = valor.Length;
                if (contador != 2)
                {
                    MessageBox.Show("UF inválida", "Atenção");
                }
                else
                {
                    CarregarInformacoes();
                }

            }
            else
            {
                CarregarInformacoes();
            }
        }

        private void dataGridViewCidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCidadeClicada.Text = dataGridViewCidade.Rows[e.RowIndex].Cells[1].Value.ToString();
            cidadeClicada = dataGridViewCidade.Rows[e.RowIndex].Cells[1].Value.ToString();

            ufClicada = dataGridViewCidade.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
