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
    public partial class FrmConsultaParticipante : Form
    {
        ParticipanteDAO participanteDAO = new ParticipanteDAO();

        public string idClicada { get; set; }
        public string nomeClienteClicado { get; set; }
        public string cpfCnpjClicado { get; set; }
        public string rgIeClicado { get; set; }
        public string enderecoClicado { get; set; }
        public string numeroEnderecoClicado { get; set; }
        public string bairroClicado { get; set; }
        public string cidadeClicada { get; set; }
        public string ufClicada { get; set; }
        public string cepClicado { get; set; }
        public string telefoneClicado { get; set; }
        public string celularClicado { get; set; }
        public string emailClicado { get; set; }
        public string razaoClicada { get; set; }
        public string dataCadatroClicada { get; set; }
        public string usuarioCadastroClicado { get; set; }
        public string dataAlteracaoCadastroClicada { get; set; }
        public string usuarioAlteracaoCadastroClicada { get; set; }
        public string ativoClicado { get; set; }
        public string tipoClienteClicado { get; set; }
        public string tipoFornecedorClicado { get; set; }
        public string tipoFuncionarioClicado { get; set; }

        //Variavel guarda informação do tipo de consulta "Cliente", "Forncedor", "Funcionario", "Todos"
        public string returnTipoParticipanteConsulta;

        public FrmConsultaParticipante()
        {
            InitializeComponent();

        }

        //Método para pegar o return do tipo de pesquisa e posteriormente carregar a lista de participante com seu tipo
        public FrmConsultaParticipante(string valorReturnParticipante) 
        {
            InitializeComponent();
            returnTipoParticipanteConsulta = valorReturnParticipante;
        }

        private void FrmConsultaParticipante_Load(object sender, EventArgs e)
        {
            //Seta o filtro tipo de pesquisa para todos
            toolStripComboBoxTipoFiltroParticipante.SelectedIndex = toolStripComboBoxTipoFiltroParticipante.FindStringExact("TODOS");

            //Seta o tipo de cliente participante
            if (returnTipoParticipanteConsulta == "TODOS")
            {
                radioButtonTodos.Checked = true;
            }
            else if (returnTipoParticipanteConsulta == "FORNECEDOR")
            {
                radioButtonFornecedor.Checked = true;
                radioButtonCliente.Enabled = false;
                radioButtonFuncionario.Enabled = false;
                radioButtonTodos.Enabled = false;
            }   
            else if(returnTipoParticipanteConsulta == "CLIENTE")
            {
                radioButtonCliente.Checked = true;
                radioButtonFornecedor.Enabled = false;
                radioButtonFuncionario.Enabled = false;
                radioButtonTodos.Enabled = false;
            }
            else if(returnTipoParticipanteConsulta == "FUNCIONARIO")
            {
                radioButtonFuncionario.Checked = true;
                radioButtonFornecedor.Enabled = false;
                radioButtonCliente.Enabled = false;
                radioButtonTodos.Enabled = false;
            }

            carregarInformacoes();
        }
              
        //Inicio do código fonte configura a tabela de consulta
        public void configurarDataGridView()
        {
            int qtdRegistros;

            //Renomeia algumas colunas
            dataGridViewParticipantes.Columns[0].HeaderText = "Código";
            dataGridViewParticipantes.Columns[0].Width = 45;

            dataGridViewParticipantes.Columns[1].HeaderText = "Nome/Fantasia";
            dataGridViewParticipantes.Columns[1].Width = 170;

            dataGridViewParticipantes.Columns[2].HeaderText = "Apelido/Razão";
            dataGridViewParticipantes.Columns[2].Width = 160;

            dataGridViewParticipantes.Columns[3].HeaderText = "CPF/CNPJ";
            dataGridViewParticipantes.Columns[3].Width = 110;

            dataGridViewParticipantes.Columns[4].HeaderText = "RG/I.E";
            dataGridViewParticipantes.Columns[4].Width = 90;

            //Inativa algumas colunas
            dataGridViewParticipantes.Columns["endereco_participante"].Visible = false;
            dataGridViewParticipantes.Columns["numeroendereco_participante"].Visible = false;
            dataGridViewParticipantes.Columns["bairro_participante"].Visible = false;
            dataGridViewParticipantes.Columns["cidade_participante"].Visible = false;
            dataGridViewParticipantes.Columns["cep_participante"].Visible = false;
            dataGridViewParticipantes.Columns["telefone_participante"].Visible = false;
            dataGridViewParticipantes.Columns["celular_participante"].Visible = false;
            dataGridViewParticipantes.Columns["uf_partipante"].Visible = false;
            dataGridViewParticipantes.Columns["email_partipante"].Visible = false;
            dataGridViewParticipantes.Columns["datacadastro_participante"].Visible = false;
            dataGridViewParticipantes.Columns["dataalteracao_partipante"].Visible = false;
            dataGridViewParticipantes.Columns["usuariocadastro_partipante"].Visible = false;
            dataGridViewParticipantes.Columns["usuarioalteracao_partipante"].Visible = false;

            dataGridViewParticipantes.Columns["tipocliente_participante"].Visible = false;
            dataGridViewParticipantes.Columns["tipofornecedor_participante"].Visible = false;
            dataGridViewParticipantes.Columns["tipofuncionario_participante"].Visible = false;
            dataGridViewParticipantes.Columns["ativo_participante"].Visible = false;

            //Conta a quantidade de registro e seta no campo
            qtdRegistros = dataGridViewParticipantes.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros: " + qtdRegistros;
        }
                              
        private void dataGridViewParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNomeClicado.Text = dataGridViewParticipantes.Rows[e.RowIndex].Cells[1].Value.ToString();

            textBoxCPFCNPJClicado.Text = dataGridViewParticipantes.Rows[e.RowIndex].Cells[3].Value.ToString();

            textBoxTelefoneClicado.Text = dataGridViewParticipantes.Rows[e.RowIndex].Cells[10].Value.ToString();

            string RuaClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[5].Value.ToString();
            string numeroClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[6].Value.ToString();
            string bairroClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxEnderecoClicado.Text = RuaClicada + " Nº " + numeroClicada + " - " + bairroClicado;

            textBoxCidadeClicada.Text = dataGridViewParticipantes.Rows[e.RowIndex].Cells[8].Value.ToString();

            //Inicio código fonte pega informações para voltar para tela de cadastro do cliente
            idClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomeClienteClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            cpfCnpjClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            rgIeClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[4].Value.ToString();
            enderecoClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[5].Value.ToString();
            numeroEnderecoClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[6].Value.ToString();
            bairroClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[7].Value.ToString();
            cidadeClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[8].Value.ToString();
            ufClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[12].Value.ToString();
            cepClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[9].Value.ToString();
            telefoneClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[10].Value.ToString();
            celularClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[11].Value.ToString();
            emailClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[13].Value.ToString();
            razaoClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            dataCadatroClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[14].Value.ToString();
            usuarioCadastroClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[16].Value.ToString();
            dataAlteracaoCadastroClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[15].Value.ToString();
            usuarioAlteracaoCadastroClicada = dataGridViewParticipantes.Rows[e.RowIndex].Cells[17].Value.ToString();

            ativoClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[21].Value.ToString();
            tipoClienteClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[18].Value.ToString();
            tipoFornecedorClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[19].Value.ToString();
            tipoFuncionarioClicado = dataGridViewParticipantes.Rows[e.RowIndex].Cells[20].Value.ToString();
        }

        private void toolStripButtonFiltrarParticipante_Click(object sender, EventArgs e)
        {
           carregarInformacoes();
        }

        public void carregarInformacoes()
        {
            dataGridViewParticipantes.DataSource = participanteDAO.pesquisarParticipantes(returnTipoParticipanteConsulta, toolStripComboBoxTipoFiltroParticipante.Text, toolStripTextBoxFiltroParticipante.Text);
            configurarDataGridView();
        }

    }
}
