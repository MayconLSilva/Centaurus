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
    public partial class FrmPrincipal : Form
    {
        FrmLogin frmConsulta;
        public string nomeLogado { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;

        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipante janelaCliente = new FrmParticipante();
            janelaCliente.TopLevel = false;
            janelaCliente.Visible = true;
            painelPrincipal.Controls.Add(janelaCliente);


            //Utilizando MDiParent
            //var frmPartipante = new FrmCliente();
            //frmPartipante.MdiParent = this;
            //frmPartipante.Show();
        }
                
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca janelaMarca = new FrmMarca();
            janelaMarca.TopLevel = false;
            janelaMarca.Visible = true;
            painelPrincipal.Controls.Add(janelaMarca);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria janelaCategoria = new FrmCategoria();
            janelaCategoria.TopLevel = false;
            janelaCategoria.Visible = true;
            painelPrincipal.Controls.Add(janelaCategoria);
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto janelaProduto = new FrmProduto();
            janelaProduto.TopLevel = false;
            janelaProduto.Visible = true;
            painelPrincipal.Controls.Add(janelaProduto);

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public FrmPrincipal(string valorReturn)
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;
            nomeLogado = valorReturn;
            labelUsuarioLogado.Text = " Bem vindo: "+ nomeLogado;
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacao janelaLocacao = new FrmLocacao(nomeLogado);
            janelaLocacao.TopLevel = false;
            janelaLocacao.Visible = true;
            painelPrincipal.Controls.Add(janelaLocacao);
        }

        private void devLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacaoDevolucao janelaDevLocacao = new FrmLocacaoDevolucao(null, nomeLogado);
            janelaDevLocacao.TopLevel = false;
            janelaDevLocacao.Visible = true;
            painelPrincipal.Controls.Add(janelaDevLocacao);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.TopLevel = false;
            frmUsuario.Visible = true;
            painelPrincipal.Controls.Add(frmUsuario);
        }


















        /*
            frmConsulta = new FrmLogin();
            DialogResult dr = frmConsulta.ShowDialog(this);
            string teste = frmConsulta.usuarioLogado;
            Console.WriteLine("chamou " + teste);
            */


        /*
        FrmLogin janelaLogin = new FrmLogin();
        janelaLogin.TopLevel = false;
        janelaLogin.Visible = true;
        painelPrincipal.Controls.Add(janelaLogin);
        */

    }
}
