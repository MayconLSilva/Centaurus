using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.DTO;
using Centaurus.DAL;

namespace Centaurus
{
    public partial class FrmLogin : Form
    {
        FrmLogin frmLogin;
        int contador = 0;

        FrmDialogSenhaConfiguracoes frmConfig;
        public string usuarioLogado { get; set; }

        public FrmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            /*
            var result = MessageBox.Show("Tem certeza que deseja encerrar o programa? ", "Exit Centaurus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //frmLogin = new FrmLogin();
                //DialogResult dr = frmLogin.ShowDialog(this);
            }
            */
        }
                
        public void chamaTelaPrincipal_logar()
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal(textBoxNome.Text);
            frmPrincipal.Show();
            this.Hide();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }

        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        public void login()
        {
            LoginModelo loginModelo = new LoginModelo();
            LoginDAO loginDAO = new LoginDAO();

            try
            {   //Se o usuário tentar utilizar senha e usuário geral não será validado, vai entrar direto no sistema
                if(textBoxNome.Text == "GERAL" && textBoxSenha.Text == "123456")
                {
                    chamaTelaPrincipal_logar();
                }
                else
                {
                    //Método envia o nome do textBox para pesquisar usuário no banco de dados
                    loginModelo.usuarioLogin = textBoxNome.Text;
                    loginModelo = loginDAO.login(loginModelo);

                    //Método retorna o valor do usuário
                    string senhaUsuario = loginModelo.senhaLogin;

                    if (String.IsNullOrEmpty(senhaUsuario) == true)
                    {
                        contador = contador + 1;
                        MessageBox.Show("Usuário incorreto ou não existente no banco de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (contador == 3)
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        if (textBoxSenha.Text == senhaUsuario)
                        {
                            chamaTelaPrincipal_logar();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Usuário não encontrado, " + erro.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void buttonConfiguracoes_Click(object sender, EventArgs e)
        {
            frmConfig = new FrmDialogSenhaConfiguracoes();
            DialogResult dr = frmConfig.ShowDialog(this);
        }
    }
}
