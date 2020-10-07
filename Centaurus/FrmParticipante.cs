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
        string botaoClicado = "INICIAL";

        public FrmParticipante()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterParent;

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            inativaAtivaCamposBotoes();

        }

        public void inativaAtivaCamposBotoes()
        {
            switch (botaoClicado)
            {
                case "INICIAL":

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

                    break;

                case "NOVO":

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

                    break;

                case "SALVAR":

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

                    break;

                case "EDITAR":

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

                    break;

                case "CANCELAR":

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

                    break;

                case "PESQUISAR":

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

                    break;
            }
        }

        private void salvar(ParticipanteModelo modParticipante)
        {
            if (flag == 0)
            {
                ParticipanteBLL participanteBLL = new ParticipanteBLL();

                modParticipante.nomeParticipante = textBoxNome.Text;
                modParticipante.cpfcnpjParticipante = textBoxCpfCnpj.Text;
                modParticipante.rgieParticipante = textBoxRgIe.Text;
                modParticipante.enderecoParticipante = textBoxEndereco.Text;
                modParticipante.numeroEnderecoParticipante = textBoxNumero.Text;
                modParticipante.bairoParticipante = textBoxBairro.Text;
                modParticipante.cidadeParticipante = textBoxCidade.Text;
                modParticipante.ufParticipante = comboBoxUF.Text;//validar
                modParticipante.cepParticipante = textBoxCep.Text;
                modParticipante.telefoneParticipante = textBoxTelefone.Text;
                modParticipante.celularParticipante = textBoxCelular.Text;
                modParticipante.emailParticipante = textBoxEmail.Text;
                modParticipante.razaosocialapelidoParticipante = textBoxRazaoSocialApelido.Text;
                modParticipante.dataCadastroParticipante = textBoxDataCadastro.Text;
                if (checkBoxCliente.Checked)
                {
                    modParticipante.tipoclienteParticipante = true;
                }
                else
                {
                    modParticipante.tipoclienteParticipante = false;
                }

                if (checkBoxFornecedor.Checked)
                {
                    modParticipante.tipofornecedorParticipante = true;
                }
                else
                {
                    modParticipante.tipofornecedorParticipante = false;
                }

                if (checkBoxFuncionario.Checked)
                {
                    modParticipante.tipofuncionarioParticipante = true;
                }
                else
                {
                    modParticipante.tipofuncionarioParticipante = false;
                }

                if (checkBoxAtivo.Checked)
                {
                    modParticipante.ativoParticipante = true;
                }
                else
                {
                    modParticipante.ativoParticipante = false;
                }

                participanteBLL.salvar(modParticipante);
                MessageBox.Show("Participante incluido com sucesso!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "SALVAR";
                inativaAtivaCamposBotoes();

                //Método chama o ultimo registro
                participanteBLL.buscarUltimoRegistro(modParticipante);
                int idReturn = modParticipante.idParticipante;
                textBoxCodigo.Text = Convert.ToString(idReturn);

            }
            else if (flag == 1)
            {
                ParticipanteBLL participanteBLL = new ParticipanteBLL();
                modParticipante.nomeParticipante = textBoxNome.Text;
                modParticipante.cpfcnpjParticipante = textBoxCpfCnpj.Text;
                modParticipante.rgieParticipante = textBoxRgIe.Text;
                modParticipante.enderecoParticipante = textBoxEndereco.Text;
                modParticipante.numeroEnderecoParticipante = textBoxNumero.Text;
                modParticipante.bairoParticipante = textBoxBairro.Text;
                modParticipante.cidadeParticipante = textBoxCidade.Text;
                modParticipante.ufParticipante = comboBoxUF.Text;//validar
                modParticipante.cepParticipante = textBoxCep.Text;
                modParticipante.telefoneParticipante = textBoxTelefone.Text;
                modParticipante.celularParticipante = textBoxCelular.Text;
                modParticipante.emailParticipante = textBoxEmail.Text;
                modParticipante.razaosocialapelidoParticipante = textBoxRazaoSocialApelido.Text;
                modParticipante.dataAlteracaoParticipante = textBoxDataAlteracao.Text;

                int id = Convert.ToInt32(textBoxCodigo.Text);
                modParticipante.idParticipante = id;
                if (checkBoxCliente.Checked)
                {
                    modParticipante.tipoclienteParticipante = true;
                }
                else
                {
                    modParticipante.tipoclienteParticipante = false;
                }

                if (checkBoxFornecedor.Checked)
                {
                    modParticipante.tipofornecedorParticipante = true;
                }
                else
                {
                    modParticipante.tipofornecedorParticipante = false;
                }

                if (checkBoxFuncionario.Checked)
                {
                    modParticipante.tipofuncionarioParticipante = true;
                }
                else
                {
                    modParticipante.tipofuncionarioParticipante = false;
                }

                if (checkBoxAtivo.Checked)
                {
                    modParticipante.ativoParticipante = true;
                }
                else
                {
                    modParticipante.ativoParticipante = false;
                }

                participanteBLL.alterar(modParticipante);

                MessageBox.Show("Participante alterado com sucesso!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "SALVAR";
                inativaAtivaCamposBotoes();
            }
        }

        private void menuClienteNovo_Click(object sender, EventArgs e)
        {
            botaoClicado = "NOVO";
            inativaAtivaCamposBotoes();

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
        
        private void menuClienteCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativaAtivaCamposBotoes();
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
        
        private void menuClienteEditar_Click(object sender, EventArgs e)
        {
            flag = 1;
            botaoClicado = "EDITAR";
            inativaAtivaCamposBotoes();

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

            botaoClicado = "PESQUISAR";
            inativaAtivaCamposBotoes();


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
                        
        //Inicio do código fonte excluir participante
        private void menuClienteExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Participante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ParticipanteModelo modParticipante = new ParticipanteModelo();
                ParticipanteBLL bllParticipante = new ParticipanteBLL();

                modParticipante.idParticipante = Convert.ToInt32(textBoxCodigo.Text);
                bllParticipante.excluir(modParticipante);
                botaoClicado = "EXCLUIR";
                inativaAtivaCamposBotoes();
            }
        }

        //Método valida somente caractér numerico
        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarParticipantePorCodigo();
            }
        }

        private void textBoxCodigo_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipParticipante.SetToolTip(textBoxCodigo, "Você pode informar um código e clicar em enter, ou clicar na lupa de consulta!");
        }

        public void buscarParticipantePorCodigo()
        {
            ParticipanteModelo modParticipante = new ParticipanteModelo();
            ParticipanteBLL bllParticipante = new ParticipanteBLL();

            try
            {
                modParticipante.idParticipante = Convert.ToInt32(textBoxCodigo.Text);
                bllParticipante.buscarParticipantePorID(modParticipante);

                if(modParticipante.nomeParticipante == null)
                {
                    MessageBox.Show("Participante não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    botaoClicado = "CANCELAR";
                    inativaAtivaCamposBotoes();
                }

                string nomeFantasia = modParticipante.nomeParticipante;
                string cpfCnpj = modParticipante.cpfcnpjParticipante;
                string rg = modParticipante.rgieParticipante;
                string endereco = modParticipante.enderecoParticipante;
                string numero = modParticipante.numeroEnderecoParticipante;
                string bairro = modParticipante.bairoParticipante;
                string cidade = modParticipante.cidadeParticipante;
                string uf = modParticipante.ufParticipante;
                string cep = modParticipante.cepParticipante;
                string telefone = modParticipante.telefoneParticipante;
                string celular = modParticipante.celularParticipante;
                string email = modParticipante.emailParticipante;
                string razaoapelido = modParticipante.razaosocialapelidoParticipante;
                string datacad = modParticipante.dataCadastroParticipante;
                string dataalt = modParticipante.dataAlteracaoParticipante;
                string usuariocad = modParticipante.usuarioCadastroParticipante;
                string usuarioalt = modParticipante.usuarioAlteracaoParticipante;
                bool ativo = modParticipante.ativoParticipante;
                bool cli = modParticipante.tipoclienteParticipante;
                bool forne = modParticipante.tipofornecedorParticipante;
                bool funci = modParticipante.tipofuncionarioParticipante;

                textBoxNome.Text = nomeFantasia;
                textBoxCpfCnpj.Text = cpfCnpj;
                textBoxRgIe.Text = rg;
                textBoxEndereco.Text = endereco;
                textBoxNumero.Text = numero;
                textBoxBairro.Text = bairro;
                textBoxCidade.Text = cidade;
                comboBoxUF.SelectedIndex = comboBoxUF.FindStringExact(uf);
                textBoxCep.Text = cep;
                textBoxTelefone.Text = telefone;
                textBoxCelular.Text = celular;
                textBoxEmail.Text = email;
                textBoxRazaoSocialApelido.Text = razaoapelido;
                textBoxDataCadastro.Text = datacad;
                textBoxDataAlteracao.Text = dataalt;
                textBoxUsuarioCadastro.Text = usuariocad;
                textBoxUsuarioAlteracao.Text = usuarioalt;
                if(ativo == true)
                {
                    checkBoxAtivo.Checked = true;
                }
                else
                {
                    checkBoxAtivo.Checked = false;
                }
                if(cli == true)
                {
                    checkBoxCliente.Checked = true;
                }
                else
                {
                    checkBoxCliente.Checked = false;
                }
                if (forne == true)
                {
                    checkBoxFornecedor.Checked = true;
                }
                else
                {
                    checkBoxFornecedor.Checked = false;
                }
                if (funci == true)
                {
                    checkBoxFuncionario.Checked = true;
                }
                else
                {
                    checkBoxFuncionario.Checked = false;
                }


            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o participante pelo código, form participante! " + erro.Message);
            }
        }

    }
}
