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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            botaoClicado = "INICIAL";
            inativarAtivarBotoesCampos();

        }

        string botaoClicado;
        FrmConsultaParticipante frmConsultaParticipante;
        string codigoReturParticipante;
        int flag = 0;

        public void inativarAtivarBotoesCampos()
        {
            switch (botaoClicado)
            {
                case "INICIAL":
                    MenuUsuarioNovo.Enabled = true;
                    MenuUsuarioGravar.Enabled = false;
                    MenuUsuarioEditar.Enabled = false;
                    MenuUsuarioCancelar.Enabled = false;
                    MenuUsuarioExcluir.Enabled = false;

                    buttonBuscarUsuario.Enabled = true;
                    buttonBuscarNomeUsuario.Enabled = false;

                    checkBoxUsuarioAtiva.Enabled = false;

                    textBoxCodigoUsuario.Enabled = true;
                    textBoxNomeUsuario.Enabled = false;
                    textBoxLoginUsuario.Enabled = false;
                    textBoxSenhaUsuario.Enabled = false;

                    treeViewOpcoesUsuario.Enabled = false;

                    break;

                case "NOVO":

                    MenuUsuarioNovo.Enabled = false;
                    MenuUsuarioGravar.Enabled = true;
                    MenuUsuarioEditar.Enabled = false;
                    MenuUsuarioCancelar.Enabled = true;
                    MenuUsuarioExcluir.Enabled = false;

                    buttonBuscarUsuario.Enabled = false;
                    buttonBuscarNomeUsuario.Enabled = true;

                    checkBoxUsuarioAtiva.Enabled = true;

                    textBoxCodigoUsuario.Enabled = false;
                    textBoxNomeUsuario.Enabled = false;
                    textBoxLoginUsuario.Enabled = true;
                    textBoxSenhaUsuario.Enabled = true;

                    //Limpar campos
                    textBoxCodigoUsuario.Clear();
                    textBoxNomeUsuario.Clear();
                    textBoxLoginUsuario.Clear();
                    textBoxSenhaUsuario.Clear();

                    treeViewOpcoesUsuario.Enabled = true;

                    break;

                case "GRAVAR":

                    MenuUsuarioNovo.Enabled = true;
                    MenuUsuarioGravar.Enabled = false;
                    MenuUsuarioEditar.Enabled = true;
                    MenuUsuarioCancelar.Enabled = false;
                    MenuUsuarioExcluir.Enabled = true;

                    buttonBuscarUsuario.Enabled = true;
                    buttonBuscarNomeUsuario.Enabled = false;

                    checkBoxUsuarioAtiva.Enabled = false;

                    textBoxCodigoUsuario.Enabled = true;
                    textBoxNomeUsuario.Enabled = false;
                    textBoxLoginUsuario.Enabled = false;
                    textBoxSenhaUsuario.Enabled = false;

                    treeViewOpcoesUsuario.Enabled = false;

                    break;

                case "EDITAR":

                    MenuUsuarioNovo.Enabled = false;
                    MenuUsuarioGravar.Enabled = true;
                    MenuUsuarioEditar.Enabled = false;
                    MenuUsuarioCancelar.Enabled = true;
                    MenuUsuarioExcluir.Enabled = false;

                    buttonBuscarUsuario.Enabled = false;
                    buttonBuscarNomeUsuario.Enabled = true;

                    checkBoxUsuarioAtiva.Enabled = true;

                    textBoxCodigoUsuario.Enabled = false;
                    textBoxNomeUsuario.Enabled = false;
                    textBoxLoginUsuario.Enabled = true;
                    textBoxSenhaUsuario.Enabled = true;

                    treeViewOpcoesUsuario.Enabled = true;

                    break;

                case "CANCELAR":

                    MenuUsuarioNovo.Enabled = true;
                    MenuUsuarioGravar.Enabled = false;
                    MenuUsuarioEditar.Enabled = false;
                    MenuUsuarioCancelar.Enabled = false;
                    MenuUsuarioExcluir.Enabled = false;

                    buttonBuscarUsuario.Enabled = true;
                    buttonBuscarNomeUsuario.Enabled = false;

                    checkBoxUsuarioAtiva.Enabled = false;

                    textBoxCodigoUsuario.Enabled = true;
                    textBoxNomeUsuario.Enabled = false;
                    textBoxLoginUsuario.Enabled = true;
                    textBoxSenhaUsuario.Enabled = true;

                    //Limpar campos
                    textBoxCodigoUsuario.Clear();
                    textBoxNomeUsuario.Clear();
                    textBoxLoginUsuario.Clear();
                    textBoxSenhaUsuario.Clear();
                    checkBoxUsuarioAtiva.Checked = false;

                    treeViewOpcoesUsuario.Enabled = false;

                    break;

                case "EXCLUIR":

                    MenuUsuarioNovo.Enabled = true;
                    MenuUsuarioGravar.Enabled = false;
                    MenuUsuarioEditar.Enabled = false;
                    MenuUsuarioCancelar.Enabled = false;
                    MenuUsuarioExcluir.Enabled = false;

                    buttonBuscarUsuario.Enabled = true;
                    buttonBuscarNomeUsuario.Enabled = false;

                    checkBoxUsuarioAtiva.Enabled = false;

                    textBoxCodigoUsuario.Enabled = true;
                    textBoxNomeUsuario.Enabled = false;
                    textBoxLoginUsuario.Enabled = true;
                    textBoxSenhaUsuario.Enabled = true;

                    //Limpar campos
                    textBoxCodigoUsuario.Clear();
                    textBoxNomeUsuario.Clear();
                    textBoxLoginUsuario.Clear();
                    textBoxSenhaUsuario.Clear();
                    checkBoxUsuarioAtiva.Checked = false;

                    treeViewOpcoesUsuario.Enabled = false;

                    break;

                case "PESQUISAR":

                    MenuUsuarioNovo.Enabled = true;
                    MenuUsuarioGravar.Enabled = false;
                    MenuUsuarioEditar.Enabled = true;
                    MenuUsuarioCancelar.Enabled = false;
                    MenuUsuarioExcluir.Enabled = true;

                    treeViewOpcoesUsuario.Enabled = false;

                    break;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
        
        private void MenuMarcaGravar_Click(object sender, EventArgs e)
        {
            
        }

       


        private void textBoxCodigoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipPesquisarPorCodigo.SetToolTip(textBoxCodigoUsuario, "Você pode informar um código e clicar em enter, ou clicar na lupa de consulta!");
        }

        private void buttonBuscarNomeUsuario_Click(object sender, EventArgs e)
        {
            string passaTipoConsulta = "FUNCIONARIO";
            frmConsultaParticipante = new FrmConsultaParticipante(passaTipoConsulta);
            DialogResult dr = frmConsultaParticipante.ShowDialog(this);

            string nomeParticipanteReturn = frmConsultaParticipante.nomeClienteClicado;
            if (String.IsNullOrEmpty(nomeParticipanteReturn) == true)
            {
                Console.WriteLine("chamou aqui");
                MessageBox.Show("Você não selecionou nenhum funcionário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
            else
            {
                codigoReturParticipante = frmConsultaParticipante.idClicada;
                textBoxNomeUsuario.Text = codigoReturParticipante + " - " + nomeParticipanteReturn;
            }
        }

        private void MenuUsuarioNovo_Click(object sender, EventArgs e)
        {
            flag = 0;
            botaoClicado = "NOVO";
            inativarAtivarBotoesCampos();
        }

        private void MenuUsuarioCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativarAtivarBotoesCampos();
        }

        private void MenuUsuarioEditar_Click(object sender, EventArgs e)
        {
            flag = 1;
            botaoClicado = "EDITAR";
            inativarAtivarBotoesCampos();

        }

        public void salvarMenus(bool btnParticipante, bool btnGrupoProduto, bool btnProduto, bool btnMarca, bool btnCatSub, bool btnUsuarios)
        {
            Console.WriteLine("salvar " + "part " + btnParticipante + " grupo " + btnGrupoProduto + " produto " + btnProduto + " marca " + btnMarca + " cat " + btnCatSub + " grupo " + btnUsuarios);
        }


    }
}
