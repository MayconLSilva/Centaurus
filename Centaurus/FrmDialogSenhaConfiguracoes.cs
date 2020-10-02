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
    public partial class FrmDialogSenhaConfiguracoes : Form
    {
        //FrmManutencao formManutencao;

        public FrmDialogSenhaConfiguracoes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            validaLoginManutencao();                       
        }

        public void validaLoginManutencao()
        {
            string dataSenha = DateTime.Now.ToString("MM/yyyy");
            string senha = dataSenha.Substring(0, 2) + dataSenha.Substring(3, 4);
            if (textBoxUsuario.Text == "GERAL" && textBoxSenha.Text == senha)
            {
                var formManutencao = new FrmManutencao();
                this.Hide();
                formManutencao.Show();
            }
            else if (textBoxUsuario.Text == "" || textBoxSenha.Text == "")
            {
                MessageBox.Show("Usuário ou senha não informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxUsuario.Text != "GERAL" || textBoxSenha.Text != senha)
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validaLoginManutencao();
            }            
        }
    }
}
