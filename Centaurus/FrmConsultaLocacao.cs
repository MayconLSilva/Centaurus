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
    public partial class FrmConsultaLocacao : Form
    {
        LocacaoDAO locacaoDAO = new LocacaoDAO();

        public string idClienteEnvia { get; set; }
        public string NomeClienteEnvia { get; set; }
        public string DataLancamentoEnvia { get; set; }
        public string DataDevEntregaEnvia { get; set; }
        public string ValorDescontoEnvia { get; set; }
        public string ValorTotalEnvia { get; set; }
        public string UsuarioEnvia { get; set; }
        public string idLocacaoEnvia { get; set; }

        public FrmConsultaLocacao()
        {
            InitializeComponent();
        }

        private void carregarLocacoes()
        {
            dataGridViewLocacao.DataSource = locacaoDAO.listarLocacao(toolStripComboBoxTipoFiltroLocacao.Text, toolStripTextBoxFiltroLocacao.Text);
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            float valorTotal, valorDesconto;
            int qtdRegistros;

            //Renomeando as colunas
            dataGridViewLocacao.Columns[0].HeaderText = "Código";
            dataGridViewLocacao.Columns[1].HeaderText = "Cód. Cliente";
            dataGridViewLocacao.Columns[2].HeaderText = "Cliente";
            dataGridViewLocacao.Columns[3].HeaderText = "Data lançamento";
            dataGridViewLocacao.Columns[4].HeaderText = "Data Prev. Entrega";
            dataGridViewLocacao.Columns[5].HeaderText = "Data Devolução";
            dataGridViewLocacao.Columns[6].HeaderText = "Nº Devolução";
            dataGridViewLocacao.Columns[7].HeaderText = "R$";
            dataGridViewLocacao.Columns[8].HeaderText = "Usuário";

            //Configurando o tamanho das colunas
            dataGridViewLocacao.Columns[0].Width = 45;
            dataGridViewLocacao.Columns[1].Width = 50;
            dataGridViewLocacao.Columns[2].Width = 170;
            dataGridViewLocacao.Columns[3].Width = 90;
            dataGridViewLocacao.Columns[4].Width = 90;
            dataGridViewLocacao.Columns[5].Width = 90;
            dataGridViewLocacao.Columns[6].Width = 60;
            dataGridViewLocacao.Columns[7].Width = 60;
            dataGridViewLocacao.Columns[8].Width = 80;

            //Ocultando algumas colunas na tabela
            dataGridViewLocacao.Columns["DescontoLocacao"].Visible = false;
            dataGridViewLocacao.Columns["QtdItensLocacao"].Visible = false;
            dataGridViewLocacao.Columns["TipoLocacao"].Visible = false;
            


            //Convertendo as colunas do dataGridView            
            this.dataGridViewLocacao.Columns[7].ValueType = typeof(decimal);
            this.dataGridViewLocacao.Columns[7].DefaultCellStyle.Format = "N2";

            //Conta a quantidade de volumes e seta no campo
            qtdRegistros = dataGridViewLocacao.Rows.Count;
            labelQuantidadeDeRegistros.Text = Convert.ToString(qtdRegistros);

        }

        private void FrmConsultaLocacao_Load(object sender, EventArgs e)
        {
            toolStripComboBoxTipoFiltroLocacao.SelectedIndex = toolStripComboBoxTipoFiltroLocacao.FindStringExact("TODOS");

            carregarLocacoes();
        }

        private void dataGridViewLocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idLocacaoEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[0].Value.ToString();
            idClienteEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[1].Value.ToString();
            NomeClienteEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[2].Value.ToString();
            DataLancamentoEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[3].Value.ToString();
            DataDevEntregaEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[4].Value.ToString();
            ValorDescontoEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[9].Value.ToString();
            ValorTotalEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[7].Value.ToString();
            UsuarioEnvia = dataGridViewLocacao.Rows[e.RowIndex].Cells[8].Value.ToString();

            textBoxNomeClicadoLocacao.Text = NomeClienteEnvia;
            textBoxDataLancamentoClicadoLocacao.Text = DataLancamentoEnvia;
            textBoxDataDevolucaoClicadoLocacao.Text = DataDevEntregaEnvia;
        }

        private void toolStripButtonFiltrarLocacao_Click(object sender, EventArgs e)
        {
            carregarLocacoes();
        }

    }
}
