using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.BLL;

namespace Centaurus
{
    public partial class FrmConsultaUsuarios : Form
    {
        UsuarioBLL bllUsuario = new UsuarioBLL();
        public string idUsuarioEnvia { get; set; }

        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        public void carregarInformacoes()
        {
            dataGridViewUsuarios.DataSource = bllUsuario.listarUsuarios();
            configuraDataGridView();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            carregarInformacoes();
        }

        public void configuraDataGridView()
        {
            //Renomeando as colunas
            dataGridViewUsuarios.Columns[0].HeaderText = "Código";
            dataGridViewUsuarios.Columns[1].HeaderText = "Nome";
            dataGridViewUsuarios.Columns[2].HeaderText = "Login";
            dataGridViewUsuarios.Columns[3].HeaderText = "Data Cadastro";


            //Configurando o tamanho das colunas
            dataGridViewUsuarios.Columns[0].Width = 45;
            dataGridViewUsuarios.Columns[1].Width = 120;
            dataGridViewUsuarios.Columns[2].Width = 120;
            dataGridViewUsuarios.Columns[3].Width = 90;

            int qtdRegistro;
            qtdRegistro = dataGridViewUsuarios.Rows.Count;
            labelQuantidadeDeRegistros.Text = "Qtd. registros " + qtdRegistro;
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuarioEnvia = dataGridViewUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nomeUsuario = dataGridViewUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxUsuarioClicado.Text = nomeUsuario;
        }

        private void toolStripButtonSelecionarUsuario_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
