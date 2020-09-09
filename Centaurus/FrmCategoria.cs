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
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        FrmConsultaCategoriaSubCategoria frmConsulta;

        public FrmCategoria()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            inativaAtivaInicial();
        }

        public void inativaAtivaInicial()
        {
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
        }

        public void inativaAtivaBotoesNovo()
        {
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
        }

        public void inativaAtivaBotoesSalvar()
        {
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

        }

        public void inativaAtivaBotoesEditar()
        {
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

        }

        public void inativaAtivaBotoesExcluir()
        {
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
        }

        public void inativaAtivaBotoesCancelar()
        {
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
        }

        public void inativaAtivaBotoesConsultar()
        {
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
        }

        private void MenuMarcaNovo_Click(object sender, EventArgs e)
        {
            inativaAtivaBotoesNovo();
            flag = 0;
        }

        private void MenuMarcaGravar_Click(object sender, EventArgs e)
        {
            CategoriaModelo categoriaModelo = new CategoriaModelo();
            salvar(categoriaModelo);

        }

        private void salvar(CategoriaModelo categoria) 
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
                    categoria.nomeCategoria = textBoxDescricaoCategoria.Text;
                    if (checkBoxCategoriaAtiva.Checked)
                    {
                        categoria.ativoCategoria = true;
                    }
                    else
                    {
                        categoria.ativoCategoria = false;
                    }
                    if (radioButtonCategoria.Checked)
                    {
                        categoria.tipoCategoria = 'C';
                    }else if (radioButtonSubCategoria.Checked)
                    {
                        categoria.tipoCategoria = 'S';
                    }
                    categoriaBLL.salvar(categoria);
                    MessageBox.Show("Categoria incluida com sucesso!!!", "Cadastro Categorias", MessageBoxButtons.OK, MessageBoxIcon.None);
                    inativaAtivaBotoesSalvar();

                    //Método chama o ultimo registro
                    categoriaDAO.UltimoRegistro(textBoxDescricaoCategoria.Text);
                    string idReturn = categoriaDAO.numeroIncluido;
                    textBoxCodigoCategoria.Text = idReturn;
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
                    categoria.nomeCategoria = textBoxDescricaoCategoria.Text;
                    if (checkBoxCategoriaAtiva.Checked)
                    {
                        categoria.ativoCategoria = true;
                    }
                    else
                    {
                        categoria.ativoCategoria = false;
                    }
                    if (radioButtonCategoria.Checked)
                    {
                        categoria.tipoCategoria = 'C';
                    }
                    else if (radioButtonSubCategoria.Checked)
                    {
                        categoria.tipoCategoria = 'S';
                    }
                    categoria.idCategoria = Convert.ToInt32(textBoxCodigoCategoria.Text);

                    categoriaBLL.atualizar(categoria);
                    MessageBox.Show("Categoria atualizada com sucesso!!!", "Cadastro Categorias", MessageBoxButtons.OK, MessageBoxIcon.None);
                    inativaAtivaBotoesSalvar();
                }                
            }
        }

        private void MenuMarcaEditar_Click(object sender, EventArgs e)
        {
            inativaAtivaBotoesEditar();
            flag = 1;
        }

        private void MenuMarcaExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                categoriaDAO.ExcluirCategoria(textBoxCodigoCategoria.Text);
                inativaAtivaBotoesExcluir();
            }
        }

        private void MenuMarcaCancelar_Click(object sender, EventArgs e)
        {
            inativaAtivaBotoesCancelar();
        }

        private void buttonBuscarParticipante_Click(object sender, EventArgs e)
        {
            //string passaTipoConsulta="Todas";
            //frmConsulta = new FrmConsultaCategoriaSubCategoria(passaTipoConsulta); Método utilizado anteriormente para enviar dados para tela de consulta categoria
            frmConsulta = new FrmConsultaCategoriaSubCategoria();
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

                if(tipoCategoriaReturn == "C")
                {
                    radioButtonCategoria.Checked = true;
                }else if(tipoCategoriaReturn == "S")
                {
                    radioButtonSubCategoria.Checked = true;
                }

                inativaAtivaBotoesConsultar();
            }
        }
    }    
}
