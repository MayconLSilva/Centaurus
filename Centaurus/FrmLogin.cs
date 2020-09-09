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

namespace Centaurus
{
    public partial class FrmLogin : Form
    {
        FrmLogin frmLogin;
        int contador = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "MAYCON" && textBoxSenha.Text == "123")
            {
                //this.DialogResult = DialogResult.OK;
                //this.Close();
                //Dispose();
                usuarioLogado = "aaaaa";

                //this.Hide();


                /* Funcionou opção 1
                if(frmLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run();
                }
                */

                chamaTelaPrincipal_logar();





            }
            else
            {
                contador = contador + 1;
                MessageBox.Show("Senha e/ou Usuário incorreto! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (contador == 3)
                {
                    Application.Exit();
                }
            }

        }

        public void chamaTelaPrincipal_logar()
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal(textBoxNome.Text);
            frmPrincipal.Show();
            this.Hide();
            Console.WriteLine("chamou aqui ");
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                chamaTelaPrincipal_logar();
            }
           
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chamaTelaPrincipal_logar();
            }
        }
    }
}
