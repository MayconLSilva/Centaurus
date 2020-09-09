using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.Model;
using Centaurus.Bll;
using Centaurus.Dao;
using MySql.Data.MySqlClient;

namespace Centaurus
{
    public partial class FrmParticipante : Form
    {
        int flag = 0;
        FrmConsultaParticipante frm2;
        FrmConsultaCidade frm3;

        ParticipanteDAO participanteDAO = new ParticipanteDAO();

        public FrmParticipante()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterParent;

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            inativaBotaoIniciar();

        }

        private void salvar(ParticipanteModelo participante)
        {
            if (flag == 0)
            {
                ParticipanteBLL participanteBLL = new ParticipanteBLL();

                participante.nomeParticipante = textBoxNome.Text;
                participante.cpfcnpjParticipante = textBoxCpfCnpj.Text;
                participante.rgieParticipante = textBoxRgIe.Text;
                participante.enderecoParticipante = textBoxEndereco.Text;
                participante.numeroEnderecoParticipante = textBoxNumero.Text;
                participante.bairoParticipante = textBoxBairro.Text;
                participante.cidadeParticipante = textBoxCidade.Text;
                participante.ufParticipante = comboBoxUF.Text;//validar
                participante.cepParticipante = textBoxCep.Text;
                participante.telefoneParticipante = textBoxTelefone.Text;
                participante.celularParticipante = textBoxCelular.Text;
                participante.emailParticipante = textBoxEmail.Text;
                participante.razaosocialapelidoParticipante = textBoxRazaoSocialApelido.Text;
                participante.dataCadastroParticipante = textBoxDataCadastro.Text;
                if (checkBoxCliente.Checked)
                {
                    participante.tipoclienteParticipante = true;
                }
                else
                {
                    participante.tipoclienteParticipante = false;
                }

                if (checkBoxFornecedor.Checked)
                {
                    participante.tipofornecedorParticipante = true;
                }
                else
                {
                    participante.tipofornecedorParticipante = false;
                }

                if (checkBoxFuncionario.Checked)
                {
                    participante.tipofuncionarioParticipante = true;
                }
                else
                {
                    participante.tipofuncionarioParticipante = false;
                }

                if (checkBoxAtivo.Checked)
                {
                    participante.ativoParticipante = true;
                }
                else
                {
                    participante.ativoParticipante = false;
                }

                participanteBLL.salvar(participante);
                MessageBox.Show("Participante incluido com sucesso!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.None);
                desativaBotaoSalvar();

                //Método chama o ultimo registro
                participanteDAO.UltimoRegistro(textBoxNome.Text);
                string idReturn = participanteDAO.numeroIncluido;
                textBoxCodigo.Text = idReturn;

            }
            else if (flag == 1)
            {
                ParticipanteBLL participanteBLL = new ParticipanteBLL();
                participante.nomeParticipante = textBoxNome.Text;
                participante.cpfcnpjParticipante = textBoxCpfCnpj.Text;
                participante.rgieParticipante = textBoxRgIe.Text;
                participante.enderecoParticipante = textBoxEndereco.Text;
                participante.numeroEnderecoParticipante = textBoxNumero.Text;
                participante.bairoParticipante = textBoxBairro.Text;
                participante.cidadeParticipante = textBoxCidade.Text;
                participante.ufParticipante = comboBoxUF.Text;//validar
                participante.cepParticipante = textBoxCep.Text;
                participante.telefoneParticipante = textBoxTelefone.Text;
                participante.celularParticipante = textBoxCelular.Text;
                participante.emailParticipante = textBoxEmail.Text;
                participante.razaosocialapelidoParticipante = textBoxRazaoSocialApelido.Text;
                participante.dataAlteracaoParticipante = textBoxDataAlteracao.Text;

                int id = Convert.ToInt32(textBoxCodigo.Text);
                participante.idParticipante = id;
                if (checkBoxCliente.Checked)
                {
                    participante.tipoclienteParticipante = true;
                }
                else
                {
                    participante.tipoclienteParticipante = false;
                }

                if (checkBoxFornecedor.Checked)
                {
                    participante.tipofornecedorParticipante = true;
                }
                else
                {
                    participante.tipofornecedorParticipante = false;
                }

                if (checkBoxFuncionario.Checked)
                {
                    participante.tipofuncionarioParticipante = true;
                }
                else
                {
                    participante.tipofuncionarioParticipante = false;
                }

                if (checkBoxAtivo.Checked)
                {
                    participante.ativoParticipante = true;
                }
                else
                {
                    participante.ativoParticipante = false;
                }

                participanteBLL.alterar(participante);

                MessageBox.Show("Participante alterado com sucesso!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.None);
                desativaBotaoSalvar();
            }
        }

        private void menuClienteNovo_Click(object sender, EventArgs e)
        {
            ativaBotaoNovo();

            //Inicio código fonte seto a data no campo de cadastro
            DateTime thisDay = DateTime.Today;
            textBoxDataCadastro.Text = thisDay.ToString("d");

            flag = 0;



        }

        private void menuClienteGravar_Click(object sender, EventArgs e)
        {
            ParticipanteModelo participanteModelo = new ParticipanteModelo();
            salvar(participanteModelo);
        }

        private void desativaBotaoSalvar()
        {
            textBoxCodigo.Enabled = false;
            textBoxNome.Enabled = false;
            textBoxCpfCnpj.Enabled = false;
            textBoxRgIe.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            comboBoxUF.Enabled = false;
            textBoxCep.Enabled = false;
            textBoxTelefone.Enabled = false;
            textBoxCelular.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxRazaoSocialApelido.Enabled = false;

            menuClienteNovo.Enabled = true;
            menuClienteGravar.Enabled = false;
            menuClienteEditar.Enabled = true;
            menuClienteCancelar.Enabled = false;
            menuClienteExcluir.Enabled = true;
            buttonBuscarParticipante.Enabled = true;
            buttonBuscarCidade.Enabled = false;

            checkBoxAtivo.Enabled = false;
            checkBoxCliente.Enabled = false;
            checkBoxFornecedor.Enabled = false;
            checkBoxFuncionario.Enabled = false;
        }

        private void ativaBotaoNovo()
        {
            textBoxCodigo.Enabled = false;
            textBoxNome.Enabled = true;
            textBoxCpfCnpj.Enabled = true;
            textBoxRgIe.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxNumero.Enabled = true;
            textBoxBairro.Enabled = true;
            textBoxCidade.Enabled = true;
            comboBoxUF.Enabled = true;
            textBoxCep.Enabled = true;
            textBoxTelefone.Enabled = true;
            textBoxCelular.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxRazaoSocialApelido.Enabled = true;

            menuClienteNovo.Enabled = false;
            menuClienteGravar.Enabled = true;
            menuClienteEditar.Enabled = false;
            menuClienteCancelar.Enabled = true;
            menuClienteExcluir.Enabled = false;
            buttonBuscarParticipante.Enabled = false;
            buttonBuscarCidade.Enabled = true;

            checkBoxAtivo.Enabled = true;
            checkBoxCliente.Enabled = true;
            checkBoxFornecedor.Enabled = true;
            checkBoxFuncionario.Enabled = true;

            //Limpa campos
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            textBoxCpfCnpj.Text = "";
            textBoxRgIe.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            comboBoxUF.Text = "";
            textBoxCep.Text = "";
            textBoxTelefone.Text = "";
            textBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxRazaoSocialApelido.Text = "";
            textBoxUsuarioCadastro.Text = "";
            textBoxUsuarioAlteracao.Text = "";
            textBoxDataCadastro.Text = "";
            textBoxDataAlteracao.Text = "";

            checkBoxAtivo.Checked = false;
            checkBoxCliente.Checked = false;
            checkBoxFornecedor.Checked = false;
            checkBoxFuncionario.Checked = false;
        }

        private void ativaDesativaBotaoEditar()
        {
            textBoxCodigo.Enabled = false;
            textBoxNome.Enabled = true;
            textBoxCpfCnpj.Enabled = true;
            textBoxRgIe.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxNumero.Enabled = true;
            textBoxBairro.Enabled = true;
            textBoxCidade.Enabled = true;
            comboBoxUF.Enabled = true;
            textBoxCep.Enabled = true;
            textBoxTelefone.Enabled = true;
            textBoxCelular.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxRazaoSocialApelido.Enabled = true;

            menuClienteNovo.Enabled = false;
            menuClienteGravar.Enabled = true;
            menuClienteEditar.Enabled = false;
            menuClienteCancelar.Enabled = true;
            menuClienteExcluir.Enabled = false;
            buttonBuscarParticipante.Enabled = false;
            buttonBuscarCidade.Enabled = true;

            checkBoxAtivo.Enabled = true;
            checkBoxCliente.Enabled = true;
            checkBoxFornecedor.Enabled = true;
            checkBoxFuncionario.Enabled = true;            
        }

        private void inativaBotaoIniciar()
        {
            textBoxCodigo.Enabled = true;
            textBoxNome.Enabled = false;
            textBoxCpfCnpj.Enabled = false;
            textBoxRgIe.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            comboBoxUF.Enabled = false;
            textBoxCep.Enabled = false;
            textBoxTelefone.Enabled = false;
            textBoxCelular.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxRazaoSocialApelido.Enabled = false;

            textBoxDataCadastro.Enabled = false;
            textBoxDataAlteracao.Enabled = false;

            menuClienteNovo.Enabled = true;
            menuClienteGravar.Enabled = false;
            menuClienteEditar.Enabled = false;
            menuClienteCancelar.Enabled = false;
            menuClienteExcluir.Enabled = false;
            buttonBuscarParticipante.Enabled = true;
            buttonBuscarCidade.Enabled = false;

            checkBoxAtivo.Enabled = false;
            checkBoxCliente.Enabled = false;
            checkBoxFornecedor.Enabled = false;
            checkBoxFuncionario.Enabled = false;
        }

        //Inicio código fonte máscara CPF/CNPJ
        public static string MascaraCnpjCpf(string pCnpjCpf)
        {
            string result = "";
            if (pCnpjCpf.Length == 14)
            {
                result = pCnpjCpf.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
            }
            if (pCnpjCpf.Length == 11)
            {
                result = pCnpjCpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            if ((pCnpjCpf.Length != 11) && (pCnpjCpf.Length != 14))
            {
                result = pCnpjCpf;
            }
            return result;
        }

        private void textBoxCpfCnpj_Validated(object sender, EventArgs e)
        {
            textBoxCpfCnpj.Text = MascaraCnpjCpf(textBoxCpfCnpj.Text);

        }
        //Fim código fonte máscara CPF/CNPJ

        private void menuClienteCancelar_Click(object sender, EventArgs e)
        {
            limparCamposCancelar();
        }

        private void limparCamposCancelar()
        {
            textBoxCodigo.Enabled = true;
            textBoxNome.Enabled = false;
            textBoxCpfCnpj.Enabled = false;
            textBoxRgIe.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            comboBoxUF.Enabled = false;
            textBoxCep.Enabled = false;
            textBoxTelefone.Enabled = false;
            textBoxCelular.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxRazaoSocialApelido.Enabled = false;

            //Limpa campos
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            textBoxCpfCnpj.Text = "";
            textBoxRgIe.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            comboBoxUF.Text = "";
            textBoxCep.Text = "";
            textBoxTelefone.Text = "";
            textBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxRazaoSocialApelido.Text = "";
            textBoxUsuarioCadastro.Text = "";
            textBoxUsuarioAlteracao.Text = "";
            textBoxDataCadastro.Text = "";
            textBoxDataAlteracao.Text = "";

            //Desmarca as checkbox
            checkBoxAtivo.Checked = false;
            checkBoxCliente.Checked = false;
            checkBoxFornecedor.Checked = false;
            checkBoxFuncionario.Checked = false;

            menuClienteNovo.Enabled = true;
            menuClienteGravar.Enabled = false;
            menuClienteEditar.Enabled = false;
            menuClienteCancelar.Enabled = false;
            menuClienteExcluir.Enabled = false;
            buttonBuscarParticipante.Enabled = true;
            buttonBuscarCidade.Enabled = false;

            checkBoxAtivo.Enabled = false;
            checkBoxCliente.Enabled = false;
            checkBoxFornecedor.Enabled = false;
            checkBoxFuncionario.Enabled = false;
        }

        //Inicio código fonte incluir máscara no campo telefone
        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxTelefone.TextLength)
                {
                    case 0:
                        textBoxTelefone.Text = "(";
                        textBoxTelefone.SelectionStart = 2;
                        break;
                    case 3:
                        textBoxTelefone.Text = textBoxTelefone.Text + ")";
                        textBoxTelefone.SelectionStart = 4;
                        break;
                    case 8:
                        textBoxTelefone.Text = textBoxTelefone.Text + "-";
                        textBoxTelefone.SelectionStart = 9;
                        break;
                }
            }
        }
        //Fim código fonte incluir másca no campo telefone

        //Inicio código fonte incluir máscara no campo CEP
        private void textBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxCep.TextLength)
                {
                    case 0:
                        textBoxCep.Text = "";
                        //textBoxCep.SelectionStart = 2;
                        break;
                    case 2:
                        textBoxCep.Text = textBoxCep.Text + ".";
                        textBoxCep.SelectionStart = 3;
                        break;
                    case 6:
                        textBoxCep.Text = textBoxCep.Text + "-";
                        textBoxCep.SelectionStart = 7;
                        break;
                }
            }

        }
        //Fim código fonte incluir máscara no campo CEP

        //Inicio código fonte máscara celular
        private void textBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxCelular.TextLength)
                {
                    case 0:
                        textBoxCelular.Text = "(";
                        textBoxCelular.SelectionStart = 2;
                        break;
                    case 3:
                        textBoxCelular.Text = textBoxCelular.Text + ")";
                        textBoxCelular.SelectionStart = 4;
                        break;
                    case 5:
                        textBoxCelular.Text = textBoxCelular.Text + ".";
                        textBoxCelular.SelectionStart = 6;
                        break;
                    case 10:
                        textBoxCelular.Text = textBoxCelular.Text + "-";
                        textBoxCelular.SelectionStart = 11;
                        break;

                }
            }
        }
        //Fim código fonte máscara celular

        private void menuClienteEditar_Click(object sender, EventArgs e)
        {
            flag = 1;
            ativaDesativaBotaoEditar();

            //Inicio código fonte seto a data no campo de cadastro
            DateTime thisDay = DateTime.Today;
            textBoxDataAlteracao.Text = thisDay.ToString("d");
        }

        private void buttonBuscarParticipante_Click(object sender, EventArgs e)
        {

            //FrmConsultaParticipante frmConsultaParticipante = new FrmConsultaParticipante();
            //frmConsultaParticipante.Visible = true;
            ///frmConsultaParticipante.Show();
            //frmConsultaParticipante.ShowDialog();

            string passaTipoConsulta = "TODOS";
            frm2 = new FrmConsultaParticipante(passaTipoConsulta);
            DialogResult dr = frm2.ShowDialog(this);

            camposPesquisaParticipante();


            string idReturn = frm2.idClicada;
            textBoxCodigo.Text = idReturn;
            string nomeClienteReturn = frm2.nomeClienteClicado;
            textBoxNome.Text = nomeClienteReturn;
            string cpfCnpjReturn = frm2.cpfCnpjClicado;
            textBoxCpfCnpj.Text = cpfCnpjReturn;
            string rgIeReturn = frm2.rgIeClicado;
            textBoxRgIe.Text = rgIeReturn;
            string enderecoReturn = frm2.enderecoClicado;
            textBoxEndereco.Text = enderecoReturn;
            string numeroEnderecoReturn = frm2.numeroEnderecoClicado;
            textBoxNumero.Text = numeroEnderecoReturn;
            string bairroReturn = frm2.bairroClicado;
            textBoxBairro.Text = bairroReturn;
            string cidadeReturn = frm2.cidadeClicada;
            textBoxCidade.Text = cidadeReturn;
            string ufReturn = frm2.ufClicada;
            comboBoxUF.SelectedItem = ufReturn;
            string cepReturn = frm2.ufClicada;
            textBoxCep.Text = cepReturn;
            string telefoneReturn = frm2.telefoneClicado;
            textBoxTelefone.Text = telefoneReturn;
            string celularReturn = frm2.celularClicado;
            textBoxCelular.Text = celularReturn;
            string emailReturn = frm2.emailClicado;
            textBoxEmail.Text = emailReturn;
            string razaoReturn = frm2.razaoClicada;
            textBoxRazaoSocialApelido.Text = razaoReturn;
            string dataCadastroReturn = frm2.dataCadatroClicada;
            textBoxDataCadastro.Text = dataCadastroReturn;
            string usuarioCadastroReturn = frm2.usuarioCadastroClicado;
            textBoxUsuarioCadastro.Text = usuarioCadastroReturn;
            string dataAlteracaoReturn = frm2.dataAlteracaoCadastroClicada;
            textBoxDataAlteracao.Text = dataAlteracaoReturn;
            string usuarioAlteracaoReturn = frm2.usuarioAlteracaoCadastroClicada;
            textBoxUsuarioAlteracao.Text = usuarioAlteracaoReturn;

            string ativoReturn = frm2.ativoClicado;
            if (ativoReturn == "True")
            {
                checkBoxAtivo.Checked = true;
            }

            string ClienteReturn = frm2.tipoClienteClicado;
            if (ClienteReturn == "True")
            {
                checkBoxCliente.Checked = true;
            }

            string FornecedorReturn = frm2.tipoFornecedorClicado;
            if (FornecedorReturn == "True")
            {
                checkBoxFornecedor.Checked = true;
            }

            string funcionarioReturn = frm2.tipoFuncionarioClicado;
            if (funcionarioReturn == "True")
            {
                checkBoxFuncionario.Checked = true;
            }




            //Utilizando MDiParent
            //var frmPartipante = new FrmConsultaParticipante();
            //frmPartipante.MdiParent = this;
            //frmPartipante.Show();
        }

        //Inicio código fonte buscar cidade
        private void buttonBuscarCidade_Click(object sender, EventArgs e)
        {
            frm3 = new FrmConsultaCidade();
            DialogResult dr = frm3.ShowDialog(this);

            string nomeCidadeReturn = frm3.cidadeClicada;
            if (String.IsNullOrEmpty(nomeCidadeReturn) == true)
            {
                MessageBox.Show("Você não selecionou a cidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBoxCidade.Text = nomeCidadeReturn;
                string nomeUfReturn = frm3.ufClicada;
                comboBoxUF.SelectedItem = nomeUfReturn;
            }

        }
        //Fim código fonte buscar cidade

        //Inicio código fonte habilita e desabilita campos e menus após pesquisar participante
        private void camposPesquisaParticipante()
        {
            textBoxCodigo.Enabled = true;
            textBoxNome.Enabled = false;
            textBoxCpfCnpj.Enabled = false;
            textBoxRgIe.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            comboBoxUF.Enabled = false;
            textBoxCep.Enabled = false;
            textBoxTelefone.Enabled = false;
            textBoxCelular.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxRazaoSocialApelido.Enabled = false;

            //Limpa campos
            textBoxCodigo.Text = "";
            textBoxNome.Text = "";
            textBoxCpfCnpj.Text = "";
            textBoxRgIe.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            comboBoxUF.Text = "";
            textBoxCep.Text = "";
            textBoxTelefone.Text = "";
            textBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxRazaoSocialApelido.Text = "";
            textBoxUsuarioCadastro.Text = "";
            textBoxUsuarioAlteracao.Text = "";
            textBoxDataCadastro.Text = "";
            textBoxDataAlteracao.Text = "";

            //Desmarca as checkbox
            checkBoxAtivo.Checked = false;
            checkBoxCliente.Checked = false;
            checkBoxFornecedor.Checked = false;
            checkBoxFuncionario.Checked = false;

            menuClienteNovo.Enabled = true;
            menuClienteGravar.Enabled = false;
            menuClienteEditar.Enabled = true;
            menuClienteCancelar.Enabled = false;
            menuClienteExcluir.Enabled = true;
            buttonBuscarParticipante.Enabled = true;
            buttonBuscarCidade.Enabled = false;

            checkBoxAtivo.Enabled = false;
            checkBoxCliente.Enabled = false;
            checkBoxFornecedor.Enabled = false;
            checkBoxFuncionario.Enabled = false;
        }

        //Inicio do código fonte excluir participante
        private void menuClienteExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Participante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                participanteDAO.ExcluirParticipante(textBoxCodigo.Text);
                limparCamposCancelar();
            }
        }
        //Fim do código fonte excluir participante

        
    }
}
