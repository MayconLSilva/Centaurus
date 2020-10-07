using Centaurus.Bll;
using Centaurus.Dao;
using Centaurus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centaurus
{
    public partial class FrmCategoria : Form
    {

        int flag = 0;
        string botaoClicado;
        CategoriaDAO daoCatSub = new CategoriaDAO();
        
        FrmConsultaCategoriaSubCategoria frmConsulta;

        public FrmCategoria()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            botaoClicado = "INICIAL";
            inativarAtivarCamposBotoes();
        }

        //Método inativa e ativa os botões, campos de acordo com o botão clicado
        public void inativarAtivarCamposBotoes()
        {
            switch (botaoClicado)
            {
                case "INICIAL":

                    MenuCategoriaNovo.Enabled = true;
                    MenuCategoriaGravar.Enabled = false;
                    MenuCategoriaEditar.Enabled = false;
                    MenuCategoriaCancelar.Enabled = false;
                    MenuCategoriaExcluir.Enabled = false;

                    textBoxCodigoCategoria.Enabled = true;
                    textBoxDescricaoCategoria.Enabled = false;
                    checkBoxCategoriaAtiva.Enabled = false;
                    radioButtonCategoria.Enabled = false;
                    radioButtonSubCategoria.Enabled = false;

                    break;

                case "NOVO":

                    MenuCategoriaNovo.Enabled = false;
                    MenuCategoriaGravar.Enabled = true;
                    MenuCategoriaEditar.Enabled = false;
                    MenuCategoriaCancelar.Enabled = true;
                    MenuCategoriaExcluir.Enabled = false;

                    textBoxCodigoCategoria.Enabled = false;
                    textBoxDescricaoCategoria.Enabled = true;
                    checkBoxCategoriaAtiva.Enabled = true;

                    radioButtonCategoria.Enabled = true;
                    radioButtonSubCategoria.Enabled = true;

                    textBoxCodigoCategoria.Text = "";
                    textBoxDescricaoCategoria.Text = "";
                    checkBoxCategoriaAtiva.Checked = false;
                    radioButtonCategoria.Checked = false;
                    radioButtonSubCategoria.Checked = false;

                    break;

                case "EDITAR":

                    MenuCategoriaNovo.Enabled = false;
                    MenuCategoriaGravar.Enabled = true;
                    MenuCategoriaEditar.Enabled = false;
                    MenuCategoriaCancelar.Enabled = true;
                    MenuCategoriaExcluir.Enabled = false;

                    textBoxCodigoCategoria.Enabled = false;
                    textBoxDescricaoCategoria.Enabled = true;
                    checkBoxCategoriaAtiva.Enabled = true;
                    radioButtonCategoria.Enabled = true;
                    radioButtonSubCategoria.Enabled = true;

                    break;

                case "SALVAR":

                    MenuCategoriaNovo.Enabled = true;
                    MenuCategoriaGravar.Enabled = false;
                    MenuCategoriaEditar.Enabled = true;
                    MenuCategoriaCancelar.Enabled = true;
                    MenuCategoriaExcluir.Enabled = true;

                    textBoxCodigoCategoria.Enabled = false;
                    textBoxDescricaoCategoria.Enabled = false;
                    checkBoxCategoriaAtiva.Enabled = false;

                    radioButtonCategoria.Enabled = false;
                    radioButtonSubCategoria.Enabled = false;

                    break;

                case "CANCELAR":

                    MenuCategoriaNovo.Enabled = true;
                    MenuCategoriaGravar.Enabled = false;
                    MenuCategoriaEditar.Enabled = false;
                    MenuCategoriaCancelar.Enabled = false;
                    MenuCategoriaExcluir.Enabled = false;

                    textBoxCodigoCategoria.Enabled = true;
                    textBoxDescricaoCategoria.Enabled = false;
                    checkBoxCategoriaAtiva.Enabled = false;
                    radioButtonCategoria.Enabled = false;
                    radioButtonSubCategoria.Enabled = false;

                    textBoxCodigoCategoria.Text = "";
                    textBoxDescricaoCategoria.Text = "";
                    checkBoxCategoriaAtiva.Checked = false;
                    radioButtonCategoria.Checked = false;
                    radioButtonSubCategoria.Checked = false;

                    break;

                case "EXCLUIR":

                    MenuCategoriaNovo.Enabled = true;
                    MenuCategoriaGravar.Enabled = false;
                    MenuCategoriaEditar.Enabled = false;
                    MenuCategoriaCancelar.Enabled = false;
                    MenuCategoriaExcluir.Enabled = false;

                    textBoxCodigoCategoria.Enabled = true;
                    textBoxDescricaoCategoria.Enabled = false;
                    checkBoxCategoriaAtiva.Enabled = false;
                    radioButtonCategoria.Enabled = false;
                    radioButtonSubCategoria.Enabled = false;

                    textBoxCodigoCategoria.Text = "";
                    textBoxDescricaoCategoria.Text = "";
                    checkBoxCategoriaAtiva.Checked = false;
                    radioButtonCategoria.Checked = false;
                    radioButtonSubCategoria.Checked = false;

                    break;

                case "PESQUISAR":

                    MenuCategoriaNovo.Enabled = true;
                    MenuCategoriaGravar.Enabled = false;
                    MenuCategoriaEditar.Enabled = true;
                    MenuCategoriaCancelar.Enabled = false;
                    MenuCategoriaExcluir.Enabled = true;

                    textBoxCodigoCategoria.Enabled = true;
                    textBoxDescricaoCategoria.Enabled = false;
                    checkBoxCategoriaAtiva.Enabled = false;
                    checkBoxCategoriaAtiva.Checked = false;
                    radioButtonCategoria.Enabled = false;
                    radioButtonSubCategoria.Enabled = false;

                    break;
            }
        }      

        private void MenuMarcaNovo_Click(object sender, EventArgs e)
        {
            botaoClicado = "NOVO";
            inativarAtivarCamposBotoes();
            flag = 0;
        }

        private void MenuMarcaGravar_Click(object sender, EventArgs e)
        {
            CategoriaModelo categoriaModelo = new CategoriaModelo();
            salvar(categoriaModelo);

        }

        //Método salvar categoria e/ou sub-categoria
        private void salvar(CategoriaModelo modCategoria) 
        {
            if(flag == 0) 
            {
                CategoriaBLL categoriaBLL = new CategoriaBLL();

                if(radioButtonCategoria.Checked == false && radioButtonSubCategoria.Checked == false)
                {
                    MessageBox.Show("Selecione o tipo!!!", "Categoria/Sub-Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    modCategoria.nomeCategoria = textBoxDescricaoCategoria.Text;
                    if (checkBoxCategoriaAtiva.Checked)
                    {
                        modCategoria.ativoCategoria = true;
                    }
                    else
                    {
                        modCategoria.ativoCategoria = false;
                    }
                    if (radioButtonCategoria.Checked)
                    {
                        modCategoria.tipoCategoria = 'C';
                    }else if (radioButtonSubCategoria.Checked)
                    {
                        modCategoria.tipoCategoria = 'S';
                    }
                    categoriaBLL.salvar(modCategoria);
                    MessageBox.Show("Categoria incluida com sucesso!!!", "Cadastro Categorias", MessageBoxButtons.OK, MessageBoxIcon.None);
                    botaoClicado = "SALVAR";
                    inativarAtivarCamposBotoes();

                    //Método chama o ultimo registro
                    categoriaBLL.buscarIDCategoriaSubCategoria(modCategoria);
                    int idReturn = modCategoria.idCategoria;
                    textBoxCodigoCategoria.Text = Convert.ToString(idReturn);
                }                
            }
            else if(flag == 1) 
            {
                CategoriaBLL categoriaBLL = new CategoriaBLL();

                if (radioButtonCategoria.Checked == false && radioButtonSubCategoria.Checked == false)
                {
                    MessageBox.Show("Selecione o tipo!!!", "Categoria/Sub-Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    modCategoria.nomeCategoria = textBoxDescricaoCategoria.Text;
                    if (checkBoxCategoriaAtiva.Checked)
                    {
                        modCategoria.ativoCategoria = true;
                    }
                    else
                    {
                        modCategoria.ativoCategoria = false;
                    }
                    if (radioButtonCategoria.Checked)
                    {
                        modCategoria.tipoCategoria = 'C';
                    }
                    else if (radioButtonSubCategoria.Checked)
                    {
                        modCategoria.tipoCategoria = 'S';
                    }
                    modCategoria.idCategoria = Convert.ToInt32(textBoxCodigoCategoria.Text);

                    categoriaBLL.atualizar(modCategoria);
                    MessageBox.Show("Categoria atualizada com sucesso!!!", "Cadastro Categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botaoClicado = "SALVAR";
                    inativarAtivarCamposBotoes();
                }                
            }
        }

        private void MenuMarcaEditar_Click(object sender, EventArgs e)
        {
            botaoClicado = "EDITAR";
            inativarAtivarCamposBotoes();
            flag = 1;
        }

        private void MenuMarcaExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                CategoriaBLL bllCategoria = new CategoriaBLL();
                CategoriaModelo modCategoria = new CategoriaModelo();
                modCategoria.idCategoria = Convert.ToInt32(textBoxCodigoCategoria.Text);
                bllCategoria.excluir(modCategoria);
                botaoClicado = "EXCLUIR";
                inativarAtivarCamposBotoes();
            }
        }

        private void MenuMarcaCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativarAtivarCamposBotoes();
        }

        //Método buscar categoria e/ou sub-categoria, chama tela de consulta
        private void buttonBuscarParticipante_Click(object sender, EventArgs e)
        {            
                frmConsulta = new FrmConsultaCategoriaSubCategoria("T");
                DialogResult dr = frmConsulta.ShowDialog(this);

                string nomeCategoriaReturn = frmConsulta.categoriaSubCategoriaClicada;
                if (String.IsNullOrEmpty(nomeCategoriaReturn) == true)
                {
                    MessageBox.Show("Você não selecionou a categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBoxDescricaoCategoria.Text = nomeCategoriaReturn;
                    string codigoCategoriaReturn = frmConsulta.idClicada;
                    textBoxCodigoCategoria.Text = codigoCategoriaReturn;
                    string tipoCategoriaReturn = frmConsulta.tipoCategoriaClicada;

                    if (tipoCategoriaReturn == "C")
                    {
                        radioButtonCategoria.Checked = true;
                    }
                    else if (tipoCategoriaReturn == "S")
                    {
                        radioButtonSubCategoria.Checked = true;
                    }

                    botaoClicado = "PESQUISAR";
                    inativarAtivarCamposBotoes();
                }                       
        }

        //Método validada o textBoxCodigo para aceitar somente números
        private void textBoxCodigoCategoria_KeyPress(object sender, KeyPressEventArgs e)
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

        //Método buscar a categoria e/ou sub-categoria atráves do código informado no campo
        public void buscarCatSubPorCodigo()
        {
            CategoriaModelo modCatSub = new CategoriaModelo();
            CategoriaBLL bllCatSub = new CategoriaBLL();

            try
            {
                modCatSub.idCategoria = Convert.ToInt32(textBoxCodigoCategoria.Text);
                bllCatSub.buscarCatSubPorCodigo(modCatSub);

                //Váido caso ñ encontro a categoria e/ou sub-categoria informo o usuário
                if(modCatSub.nomeCategoria == null)
                {
                    MessageBox.Show("Categoria e/ou Sub-Categoria ñ encontrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    radioButtonCategoria.Checked = false;
                    radioButtonSubCategoria.Checked = false;
                    checkBoxCategoriaAtiva.Checked = false;
                    textBoxCodigoCategoria.Clear();
                }

                string nomeCatSub = modCatSub.nomeCategoria;
                char tipoCatSub = modCatSub.tipoCategoria;
                bool ativoCatSub = modCatSub.ativoCategoria;

                textBoxDescricaoCategoria.Text = nomeCatSub;
                if(Convert.ToString(tipoCatSub) == "C")
                {
                    radioButtonCategoria.Checked = true;
                    radioButtonSubCategoria.Checked = false;
                }
                else
                {
                    radioButtonCategoria.Checked = false;
                    radioButtonSubCategoria.Checked = true;
                }
                if(ativoCatSub == true)
                {
                    checkBoxCategoriaAtiva.Checked = true;
                }
                else
                {
                    checkBoxCategoriaAtiva.Checked = false;
                }

            }catch(Exception erro)
            {
                throw new Exception("Erro ao buscar categoria e/ou sub-categoria, frm!" + erro.Message);
            }
        }

        //Método click do campo textBoxCodigoCategoria
        private void textBoxCodigoCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buscarCatSubPorCodigo();
            }
        }
        
        private void textBoxCodigoCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipPesquisarPorCodigo.SetToolTip(textBoxCodigoCategoria, "Você pode informar um código e clicar em enter, ou clicar na lupa de consulta!");
        }
    }    
}
