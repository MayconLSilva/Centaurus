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
using Centaurus.DTO;
using Centaurus.Reports;

namespace Centaurus
{
    public partial class FrmPrincipal : Form
    {
        FrmLogin frmConsulta;
        public string loginLogado { get; set; }

        UsuarioBLL bllUsuario = new UsuarioBLL();

        public FrmPrincipal()
        {
            InitializeComponent();

            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.TopMost = true;

        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipante janelaCliente = new FrmParticipante(loginLogado);
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
            FrmProduto janelaProduto = new FrmProduto(loginLogado);
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
            loginLogado = valorReturn;
            labelUsuarioLogado.Text = " Bem vindo: "+ loginLogado;
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacao janelaLocacao = new FrmLocacao(loginLogado);
            janelaLocacao.TopLevel = false;
            janelaLocacao.Visible = true;
            painelPrincipal.Controls.Add(janelaLocacao);
        }

        private void devLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacaoDevolucao janelaDevLocacao = new FrmLocacaoDevolucao(null, loginLogado);
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            validaUsuario();
        }

        public void validaUsuario()
        {
            if(loginLogado == "GERAL")
            {
                participantesToolStripMenuItem.Enabled = true;
                produtoToolStripMenuItem.Enabled = true;
                produtoToolStripMenuItemProduto.Enabled = true;
                marcaToolStripMenuItemMarca.Enabled = true;
                categoriaToolStripMenuItemCategoriaSubCategoria.Enabled = true;
                usuarioToolStripMenuItemUsuario.Enabled = true;
                locaçãoToolStripMenuItemLocacao.Enabled = true;
                devLocaçãoToolStripMenuItemDevLocacao.Enabled = true;
            }
            else
            {
                //Envio o login para carregar as opções do usuário
                UsuarioModelo modUsuario = new UsuarioModelo();
                modUsuario.loginUsuario = loginLogado;
                bllUsuario.buscarInformacoesUsuarioLogin(modUsuario);

                bool btnParticipante = modUsuario.botaoParticipanteUsuario;
                bool btnGrupoProduto = modUsuario.botaoGrupoProdutoUsuario;
                bool btnProduto = modUsuario.botaoProdutoUsuario;
                bool btnMaca = modUsuario.botaoMarcaUsuario;
                bool btnCatSub = modUsuario.botaoCategoriaSubCategoriaUsuario;
                bool btnUsuario = modUsuario.botaoUsuariosUsuario;
                bool btnLocacao = modUsuario.botaoLocacaoUsuario;
                bool btnDevLocacao = modUsuario.botaoDevLocacaoUsuario;
                if (btnParticipante == true)
                {
                    participantesToolStripMenuItem.Enabled = true;
                }
                if (btnGrupoProduto == true)
                {
                    produtoToolStripMenuItem.Enabled = true;
                }
                if (btnProduto == true)
                {
                    produtoToolStripMenuItemProduto.Enabled = true;
                }
                if (btnMaca == true)
                {
                    marcaToolStripMenuItemMarca.Enabled = true;
                }
                if (btnCatSub == true)
                {
                    categoriaToolStripMenuItemCategoriaSubCategoria.Enabled = true;
                }
                if (btnUsuario == true)
                {
                    usuarioToolStripMenuItemUsuario.Enabled = true;
                }
                if (btnLocacao == true)
                {
                    locaçãoToolStripMenuItemLocacao.Enabled = true;
                }
                if (btnDevLocacao == true)
                {
                    devLocaçãoToolStripMenuItemDevLocacao.Enabled = true;
                }
            }            
        }

        private void participantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFiltroRelatorioParticipantes frmParticipante = new FrmFiltroRelatorioParticipantes();
            frmParticipante.TopLevel = false;
            frmParticipante.Visible = true;
            painelPrincipal.Controls.Add(frmParticipante);
            
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            frmEmpresa.TopLevel = false;
            frmEmpresa.Visible = true;
            painelPrincipal.Controls.Add(frmEmpresa);
        }

        private void marcaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRelMarca frmRelMarca = new FrmRelMarca();
            frmRelMarca.TopLevel = false;
            frmRelMarca.Visible = true;
            painelPrincipal.Controls.Add(frmRelMarca);
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
