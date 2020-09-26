using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.DAL;

namespace Centaurus
{
    public partial class FrmConsultaDevolucaoLocacao : Form
    {
        LocacaoDevolucaoDAO daoLocacaoDev = new LocacaoDevolucaoDAO();

        //Váriaveis para guardar informações do click da tabela e enviar para tela de devolução
        public string idClienteEnvia { get; set; }
        public string NomeClienteEnvia { get; set; }
        public string DataLancamentoEnvia { get; set; }
        public string DataDevolucaoEnvia { get; set; }
        public string UsuarioEnvia { get; set; }
        public string idDevLocacaoEnvia { get; set; }
        public string idLocacaoEnvia { get; set; }

        public FrmConsultaDevolucaoLocacao()
        {
            InitializeComponent();
        }

        private void carregarDevolucaoLocacoes()
        {
            dataGridViewDevLocacao.DataSource = daoLocacaoDev.listarDevLocacao(toolStripComboBoxTipoFiltroDevLocacao.Text, toolStripTextBoxFiltroDevLocacao.Text);
            configurarDataGridView();
        }

        public void configurarDataGridView()
        {
            float valorTotal, valorDesconto;
            int qtdRegistros;

            //Renomeando as colunas
            dataGridViewDevLocacao.Columns[0].HeaderText = "Código";
            dataGridViewDevLocacao.Columns[1].HeaderText = "Cód. Cliente";
            dataGridViewDevLocacao.Columns[2].HeaderText = "Cliente";
            dataGridViewDevLocacao.Columns[3].HeaderText = "Data lançamento";
            dataGridViewDevLocacao.Columns[5].HeaderText = "Data Devolução";
            dataGridViewDevLocacao.Columns[6].HeaderText = "Nº Devolução";
            dataGridViewDevLocacao.Columns[7].HeaderText = "R$";
            dataGridViewDevLocacao.Columns[8].HeaderText = "Usuário";

            //Configurando o tamanho das colunas
            dataGridViewDevLocacao.Columns[0].Width = 45;
            dataGridViewDevLocacao.Columns[1].Width = 50;
            dataGridViewDevLocacao.Columns[2].Width = 170;
            dataGridViewDevLocacao.Columns[3].Width = 90;
            dataGridViewDevLocacao.Columns[5].Width = 90;
            dataGridViewDevLocacao.Columns[6].Width = 70;
            dataGridViewDevLocacao.Columns[7].Width = 60;
            dataGridViewDevLocacao.Columns[8].Width = 80;

            //Ocultando algumas colunas na tabela
            dataGridViewDevLocacao.Columns["DescontoLocacao"].Visible = false;
            dataGridViewDevLocacao.Columns["QtdItensLocacao"].Visible = false;
            dataGridViewDevLocacao.Columns["TipoLocacao"].Visible = false;
            dataGridViewDevLocacao.Columns["DataPrevisaoEntrega"].Visible = false;

            //Convertendo as colunas do dataGridView            
            this.dataGridViewDevLocacao.Columns[7].ValueType = typeof(decimal);
            this.dataGridViewDevLocacao.Columns[7].DefaultCellStyle.Format = "N2";

            /*
            //Conta a quantidade de volumes e seta no campo
            qtdRegistros = dataGridViewDevLocacao.Rows.Count;
            labelQuantidadeDeRegistros.Text = Convert.ToString(qtdRegistros);
            */

        }

        private void toolStripButtonSelecionarDevLocacao_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmConsultaDevolucaoLocacao_Load(object sender, EventArgs e)
        {
            toolStripComboBoxTipoFiltroDevLocacao.SelectedIndex = toolStripComboBoxTipoFiltroDevLocacao.FindStringExact("TODOS");
            carregarDevolucaoLocacoes();
        }

        private void toolStripButtonFiltrarDevLocacao_Click(object sender, EventArgs e)
        {
            carregarDevolucaoLocacoes();
        }

        private void dataGridViewDevLocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDevLocacaoEnvia = dataGridViewDevLocacao.Rows[e.RowIndex].Cells[0].Value.ToString();
            idClienteEnvia = dataGridViewDevLocacao.Rows[e.RowIndex].Cells[1].Value.ToString();
            NomeClienteEnvia = dataGridViewDevLocacao.Rows[e.RowIndex].Cells[2].Value.ToString();
            DataLancamentoEnvia = dataGridViewDevLocacao.Rows[e.RowIndex].Cells[3].Value.ToString();
            DataDevolucaoEnvia = dataGridViewDevLocacao.Rows[e.RowIndex].Cells[5].Value.ToString();            
            UsuarioEnvia = dataGridViewDevLocacao.Rows[e.RowIndex].Cells[8].Value.ToString();

            textBoxNomeClicadoDevLocacao.Text = NomeClienteEnvia;
            textBoxDataLancamentoClicadoDevLocacao.Text = DataLancamentoEnvia;
            textBoxDataDevolucaoClicadoDevLocacao.Text = DataDevolucaoEnvia;
        }
    }
}
