using Centaurus.BLL;
using Centaurus.DTO;
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
    public partial class FrmEmpresa : Form
    {
        EmpresaBLL empresaBLL = new EmpresaBLL();
        EmpresaModelo modEmpresa = new EmpresaModelo();

        public FrmEmpresa()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }

        public string botaoClicado;

        public void inativarAtivarCamposBotoes()
        {
            switch (botaoClicado)
            {
                case "EDITAR":

                    menuEmpresaGravar.Enabled = true;
                    menuEmpresaEditar.Enabled = false;
                    menuEmpresaCancelar.Enabled = true;

                    textBoxNomeFantasia.Enabled = true;
                    textBoxCPFCNPJ.Enabled = false;
                    textBoxRGIE.Enabled = true;
                    textBoxRazaoSocial.Enabled = true;
                    textBoxTelefone.Enabled = true;
                    textBoxCelular.Enabled = true;
                    textBoxEndereco.Enabled = true;
                    textBoxNumeroEndereco.Enabled = true;
                    textBoxBairro.Enabled = true;
                    textBoxCidade.Enabled = true;
                    comboBoxUF.Enabled = true;
                    textBoxCEP.Enabled = true;
                    textBoxEmail.Enabled = true;

                    break;

                case "GRAVAR":

                    menuEmpresaGravar.Enabled = false;
                    menuEmpresaEditar.Enabled = false;
                    menuEmpresaCancelar.Enabled = false;

                    textBoxNomeFantasia.Enabled = false;
                    textBoxCPFCNPJ.Enabled = false;
                    textBoxRGIE.Enabled = false;
                    textBoxRazaoSocial.Enabled = false;
                    textBoxTelefone.Enabled = false;
                    textBoxCelular.Enabled = false;
                    textBoxEndereco.Enabled = false;
                    textBoxNumeroEndereco.Enabled = false;
                    textBoxBairro.Enabled = false;
                    textBoxCidade.Enabled = false;
                    comboBoxUF.Enabled = false;
                    textBoxCEP.Enabled = false;
                    textBoxEmail.Enabled = false;

                    break;

                case "CANCELAR":

                    menuEmpresaGravar.Enabled = false;
                    menuEmpresaEditar.Enabled = false;
                    menuEmpresaCancelar.Enabled = false;

                    textBoxNomeFantasia.Enabled = false;
                    textBoxCPFCNPJ.Enabled = false;
                    textBoxRGIE.Enabled = false;
                    textBoxRazaoSocial.Enabled = false;
                    textBoxTelefone.Enabled = false;
                    textBoxCelular.Enabled = false;
                    textBoxEndereco.Enabled = false;
                    textBoxNumeroEndereco.Enabled = false;
                    textBoxBairro.Enabled = false;
                    textBoxCidade.Enabled = false;
                    comboBoxUF.Enabled = false;
                    textBoxCEP.Enabled = false;
                    textBoxEmail.Enabled = false;

                    break;

            }
        }

        private void menuEmpresaEditar_Click(object sender, EventArgs e)
        {
            botaoClicado = "EDITAR";
            inativarAtivarCamposBotoes();
        }

        private void menuEmpresaGravar_Click(object sender, EventArgs e)
        {
            botaoClicado = "GRAVAR";
            inativarAtivarCamposBotoes();

            salvarAtualizarEmpresa(modEmpresa);
        }

        private void menuEmpresaCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativarAtivarCamposBotoes();
        }

        public void buscarInformacoesEmpresa()
        {
            try
            {
                empresaBLL.buscarInformacoesEmpresa(modEmpresa);

                textBoxNomeFantasia.Text = modEmpresa.nomeFantasiaEmpresa;
                textBoxCPFCNPJ.Text = modEmpresa.cpfCnpjEmpresa;
                textBoxRGIE.Text = modEmpresa.rgIeEmpresa;
                textBoxRazaoSocial.Text = modEmpresa.razaoSocialEmpresa;
                textBoxTelefone.Text = modEmpresa.telefoneEmpresa;
                textBoxCelular.Text = modEmpresa.celularEmpresa;
                textBoxEndereco.Text = modEmpresa.enderecoEmpresa;
                textBoxNumeroEndereco.Text = modEmpresa.numeroEnderecoEmpresa;
                textBoxBairro.Text = modEmpresa.bairroEmpresa;
                textBoxCidade.Text = modEmpresa.cidadeEmpresa;
                comboBoxUF.SelectedIndex = comboBoxUF.FindStringExact(modEmpresa.ufEmpresa);
                textBoxCEP.Text = modEmpresa.cepEmpresa;
                textBoxEmail.Text = modEmpresa.emailEmpresa;

            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar inforações da empresa, view empresa! " + erro.Message);
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            buscarInformacoesEmpresa();
        }

        public void salvarAtualizarEmpresa(EmpresaModelo modEmpresa)
        {
            modEmpresa.nomeFantasiaEmpresa = textBoxNomeFantasia.Text;
            modEmpresa.rgIeEmpresa = textBoxRGIE.Text;
            modEmpresa.razaoSocialEmpresa = textBoxRazaoSocial.Text;
            modEmpresa.telefoneEmpresa = textBoxTelefone.Text;
            modEmpresa.celularEmpresa = textBoxCelular.Text;
            modEmpresa.enderecoEmpresa = textBoxEndereco.Text;
            modEmpresa.numeroEnderecoEmpresa = textBoxNumeroEndereco.Text;
            modEmpresa.bairroEmpresa = textBoxBairro.Text;
            modEmpresa.cidadeEmpresa = textBoxCidade.Text;
            modEmpresa.ufEmpresa = comboBoxUF.Text;
            modEmpresa.cepEmpresa = textBoxCEP.Text;
            modEmpresa.emailEmpresa = textBoxEmail.Text;

            empresaBLL.atualizarSalvar(modEmpresa);

            MessageBox.Show("Informações atualizadas com sucesso!", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
