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
        FrmConsultaUsuarios frmUsuario;
        int flag = 0;
        UsuarioBLL bllUsuario = new UsuarioBLL();

        int contador = 0;
        bool btnParticipante=false, btnGrupoProduto = false, btnProduto = false, btnMarca = false, btnCatSub = false, btnUsuario = false,btnLocacao=false,btnDevLocacao=false;

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
                    codigoReturParticipante = null;

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
                    textBoxLoginUsuario.Enabled = false;
                    textBoxSenhaUsuario.Enabled = false;

                    //Limpar campos
                    textBoxCodigoUsuario.Clear();
                    textBoxNomeUsuario.Clear();
                    textBoxLoginUsuario.Clear();
                    textBoxSenhaUsuario.Clear();
                    checkBoxUsuarioAtiva.Checked = false;
                    codigoReturParticipante = null;

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
                    codigoReturParticipante = null;

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
            if(textBoxNomeUsuario.Text == ""){
                MessageBox.Show("É necessário vincular o funcionário/nome usuário!", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                NodesSelecionados(treeViewOpcoesUsuario.Nodes);
            }
            
        }

        public List<string> NodesSelecionados(TreeNodeCollection ColecaoNodes)
        {
            List<String> ListaNodes = new List<String>();

            if (ColecaoNodes != null)
            {
                foreach (TreeNode node in ColecaoNodes)
                {
                    if (node.Checked)
                    {
                        ListaNodes.Add(node.Text);
                        //listView1.Items.Add(node.Text); //Console.WriteLine("1 chamou " + node.Text);  Console.WriteLine("2 chamou " + node.Name);
                        if(node.Name == "btnParticipante" && node.Checked == true)
                        {
                            btnParticipante = true;
                        }
                        if (node.Name == "btnGrupoProduto" && node.Checked == true)
                        {
                            btnGrupoProduto = true;
                        }
                        if (node.Name == "btnProduto" && node.Checked == true)
                        {
                            btnProduto = true;
                        }
                        if (node.Name == "btnMarca" && node.Checked == true)
                        {
                            btnMarca = true;
                        }
                        if (node.Name == "btnCategoriaSubCategoria" && node.Checked == true)
                        {
                            btnCatSub = true;
                        }
                        if (node.Name == "btnUsuarios" && node.Checked == true)
                        {
                            btnUsuario = true;
                        }
                        if (node.Name == "btnLocacao" && node.Checked == true)
                        {
                            btnLocacao = true;
                        }
                        if (node.Name == "btnDevLocacao" && node.Checked == true)
                        {
                            btnDevLocacao = true;
                        }
                    }

                    ListaNodes.AddRange(NodesSelecionados(node.Nodes));
                }
                //Aqui eu só vou chamar o método salvar após passar em todos nós, como são 6 opções acrescento mais uma totalizando 7, caso seja igual a 7 chamo o método salvar
                contador = contador + 1;
                if(contador == 7)
                {
                    salvarAtualizarUsuario();
                }
                
            }            
            return ListaNodes;
            

        }

        public void salvarAtualizarUsuario()
        {
            UsuarioModelo modUsuario = new UsuarioModelo();
            if(flag == 0)
            {
                if(checkBoxUsuarioAtiva.Checked = true)
                {
                    modUsuario.ativoUsuario = true;
                }
                else if(checkBoxUsuarioAtiva.Checked = false)
                {
                    modUsuario.ativoUsuario = false;
                }
                modUsuario.idNomeUsuario = codigoReturParticipante;
                modUsuario.loginUsuario = textBoxLoginUsuario.Text;
                modUsuario.senhaUsuario = textBoxSenhaUsuario.Text;
                modUsuario.botaoParticipanteUsuario = btnParticipante;
                modUsuario.botaoGrupoProdutoUsuario = btnGrupoProduto;
                modUsuario.botaoProdutoUsuario = btnProduto;
                modUsuario.botaoMarcaUsuario = btnMarca;
                modUsuario.botaoCategoriaSubCategoriaUsuario = btnCatSub;
                modUsuario.botaoUsuariosUsuario = btnUsuario;
                modUsuario.botaoLocacaoUsuario = btnLocacao;
                modUsuario.botaoDevLocacaoUsuario = btnDevLocacao;
                bllUsuario.salvar(modUsuario);
                
                //Método busca o ultimo registro
                bllUsuario.buscarUltimoRegistro(modUsuario);
                textBoxCodigoUsuario.Text = Convert.ToString(modUsuario.idUsuario);

                MessageBox.Show("Usuário salvo com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "GRAVAR";
                inativarAtivarBotoesCampos();
            }
            else if(flag == 1)
            {
                if (checkBoxUsuarioAtiva.Checked = true)
                {
                    modUsuario.ativoUsuario = true;
                }
                else if (checkBoxUsuarioAtiva.Checked = false)
                {
                    modUsuario.ativoUsuario = false;
                }
                modUsuario.idNomeUsuario = codigoReturParticipante;
                modUsuario.loginUsuario = textBoxLoginUsuario.Text;
                modUsuario.senhaUsuario = textBoxSenhaUsuario.Text;
                modUsuario.botaoParticipanteUsuario = btnParticipante;
                modUsuario.botaoGrupoProdutoUsuario = btnGrupoProduto;
                modUsuario.botaoProdutoUsuario = btnProduto;
                modUsuario.botaoMarcaUsuario = btnMarca;
                modUsuario.botaoCategoriaSubCategoriaUsuario = btnCatSub;
                modUsuario.botaoUsuariosUsuario = btnUsuario;
                modUsuario.botaoLocacaoUsuario = btnLocacao;
                modUsuario.botaoDevLocacaoUsuario = btnDevLocacao;
                modUsuario.idUsuario = Convert.ToInt32(textBoxCodigoUsuario.Text);
                bllUsuario.atualizar(modUsuario);
                MessageBox.Show("Usuário atualizado com sucesso!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "GRAVAR";
                inativarAtivarBotoesCampos();
            }
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

        private void MenuUsuarioExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UsuarioModelo modUsuario = new UsuarioModelo();
                modUsuario.idUsuario = Convert.ToInt32(textBoxCodigoUsuario.Text);
                bllUsuario.excluir(modUsuario);
                botaoClicado = "EXCLUIR";
                inativarAtivarBotoesCampos();
            }
        }

        private void MenuUsuarioEditar_Click(object sender, EventArgs e)
        {
            flag = 1;
            botaoClicado = "EDITAR";
            inativarAtivarBotoesCampos();

        }
        
        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario = new FrmConsultaUsuarios();
            DialogResult dr = frmUsuario.ShowDialog(this);

            string idUsuario = frmUsuario.idUsuarioEnvia;
            if (String.IsNullOrEmpty(idUsuario) == true)
            {
                MessageBox.Show("Você não selecionou nenhum usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                botaoClicado = "PESQUISAR";
                inativarAtivarBotoesCampos();
                UsuarioModelo modUsuario = new UsuarioModelo();
                textBoxCodigoUsuario.Text = idUsuario;

                buscarInforcoes(modUsuario);
                
            }
        }

        public void buscarInforcoes(UsuarioModelo modUsuario)
        {
            modUsuario.idUsuario = Convert.ToInt32(textBoxCodigoUsuario.Text);
            bllUsuario.buscarInformacoesUsuarioID(modUsuario);
            
            codigoReturParticipante = modUsuario.idNomeUsuario;
            string nomeUsuario = modUsuario.nomeUsuario;
            string login = modUsuario.loginUsuario;
            string senha = modUsuario.senhaUsuario;
            bool ativo = modUsuario.ativoUsuario;
            textBoxNomeUsuario.Text = codigoReturParticipante + " - " + nomeUsuario;
            textBoxLoginUsuario.Text = login;
            textBoxSenhaUsuario.Text = senha;
            if (ativo = true)
            {
                checkBoxUsuarioAtiva.Checked = true;
            }
            else
            {
                checkBoxUsuarioAtiva.Checked = false;
            }
        }

        private void textBoxCodigoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UsuarioModelo modUsuario = new UsuarioModelo();
                buscarInforcoes(modUsuario);

                if(textBoxLoginUsuario.Text != null || textBoxLoginUsuario.Text != "")
                {
                    botaoClicado = "PESQUISAR";
                    inativarAtivarBotoesCampos();
                }
            }
        }

        private void textBoxCodigoUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
