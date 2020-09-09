using Centaurus.Bll;
using Centaurus.Dao;
using Centaurus.Model;
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
    public partial class FrmMarca : Form
    {

        int flag = 0;
        MarcaDAO marcaDAO = new MarcaDAO();

        FrmConsultaMarca frmConsulta;

        public FrmMarca()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            inativaAtivaInicial();
        }

        public void inativaAtivaInicial()
        {
            MenuMarcaNovo.Enabled = true;
            MenuMarcaGravar.Enabled = false;
            MenuMarcaEditar.Enabled = false;
            MenuMarcaCancelar.Enabled = false;
            MenuMarcaExcluir.Enabled = false;

            textBoxCodigoMarca.Enabled = true;
            textBoxDescricaoMarca.Enabled = false;
            checkBoxMarcaAtiva.Enabled = false;
        }

        public void inativaAtivaBotoesNovo()
        {
            MenuMarcaNovo.Enabled = false;
            MenuMarcaGravar.Enabled = true;
            MenuMarcaEditar.Enabled = false;
            MenuMarcaCancelar.Enabled = true;
            MenuMarcaExcluir.Enabled = false;

            textBoxCodigoMarca.Enabled = false;
            textBoxDescricaoMarca.Enabled = true;
            checkBoxMarcaAtiva.Enabled = true;

            textBoxCodigoMarca.Text = "";
            textBoxDescricaoMarca.Text = "";
            checkBoxMarcaAtiva.Checked = false;
        }

        public void inativaAtivaBotoesSalvar()
        {
            MenuMarcaNovo.Enabled = true;
            MenuMarcaGravar.Enabled = false;
            MenuMarcaEditar.Enabled = true;
            MenuMarcaCancelar.Enabled = true;
            MenuMarcaExcluir.Enabled = true;

            textBoxCodigoMarca.Enabled = false;
            textBoxDescricaoMarca.Enabled = false;
            checkBoxMarcaAtiva.Enabled = false;

        }

        public void inativaAtivaBotoesEditar()
        {
            MenuMarcaNovo.Enabled = false;
            MenuMarcaGravar.Enabled = true;
            MenuMarcaEditar.Enabled = false;
            MenuMarcaCancelar.Enabled = true;
            MenuMarcaExcluir.Enabled = false;

            textBoxCodigoMarca.Enabled = false;
            textBoxDescricaoMarca.Enabled = true;
            checkBoxMarcaAtiva.Enabled = true;

        }

        public void inativaAtivaBotoesExcluir()
        {
            MenuMarcaNovo.Enabled = true;
            MenuMarcaGravar.Enabled = false;
            MenuMarcaEditar.Enabled = false;
            MenuMarcaCancelar.Enabled = false;
            MenuMarcaExcluir.Enabled = false;

            textBoxCodigoMarca.Enabled = true;
            textBoxDescricaoMarca.Enabled = false;
            checkBoxMarcaAtiva.Enabled = false;

            textBoxCodigoMarca.Text = "";
            textBoxDescricaoMarca.Text = "";
            checkBoxMarcaAtiva.Checked = false;
        }

        public void inativaAtivaBotoesCancelar()
        {
            MenuMarcaNovo.Enabled = true;
            MenuMarcaGravar.Enabled = false;
            MenuMarcaEditar.Enabled = false;
            MenuMarcaCancelar.Enabled = false;
            MenuMarcaExcluir.Enabled = false;

            textBoxCodigoMarca.Enabled = true;
            textBoxDescricaoMarca.Enabled = false;
            checkBoxMarcaAtiva.Enabled = false;

            textBoxCodigoMarca.Text = "";
            textBoxDescricaoMarca.Text = "";
            checkBoxMarcaAtiva.Checked = false;
        }

        public void inativaAtivaBotoesConsultar()
        {
            MenuMarcaNovo.Enabled = true;
            MenuMarcaGravar.Enabled = false;
            MenuMarcaEditar.Enabled = true;
            MenuMarcaCancelar.Enabled = false;
            MenuMarcaExcluir.Enabled = true;

            textBoxCodigoMarca.Enabled = true;
            textBoxDescricaoMarca.Enabled = false;
            checkBoxMarcaAtiva.Enabled = false;
            checkBoxMarcaAtiva.Checked = false;
        }

        private void MenuMarcaNovo_Click(object sender, EventArgs e)
        {
            inativaAtivaBotoesNovo();
            flag = 0;
        }

        private void MenuMarcaGravar_Click(object sender, EventArgs e)
        {
            MarcaModelo marcaModelo = new MarcaModelo();
            salvar(marcaModelo);

        }

        private void salvar(MarcaModelo marca) 
        {
            if(flag == 0) 
            {
                MarcaBLL marcaBLL = new MarcaBLL();

                marca.nomeMarca = textBoxDescricaoMarca.Text;
                if (checkBoxMarcaAtiva.Checked)
                {
                    marca.ativoMarca = true;
                }
                else
                {
                    marca.ativoMarca = false;
                }

                marcaBLL.salvar(marca);
                MessageBox.Show("Marca incluida com sucesso!!!", "Cadastro Marca", MessageBoxButtons.OK, MessageBoxIcon.None);
                inativaAtivaBotoesSalvar();

                //Método chama o ultimo registro
                marcaDAO.UltimoRegistro(textBoxDescricaoMarca.Text);
                string idReturn = marcaDAO.numeroIncluido;
                textBoxCodigoMarca.Text = idReturn;
            }
            else if(flag == 1) 
            {
                MarcaBLL marcaBLL = new MarcaBLL();

                marca.nomeMarca = textBoxDescricaoMarca.Text;
                if (checkBoxMarcaAtiva.Checked)
                {
                    marca.ativoMarca = true;
                }
                else
                {
                    marca.ativoMarca = false;
                }
                marca.idMarca = Convert.ToInt32(textBoxCodigoMarca.Text);

                marcaBLL.atualizar(marca);
                MessageBox.Show("Marca atualizada com sucesso!!!", "Cadastro Marca", MessageBoxButtons.OK, MessageBoxIcon.None);
                inativaAtivaBotoesSalvar();
            }
        }

        private void MenuMarcaEditar_Click(object sender, EventArgs e)
        {
            inativaAtivaBotoesEditar();
            flag = 1;
        }

        private void MenuMarcaExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                marcaDAO.ExcluirMarca(textBoxCodigoMarca.Text);
                inativaAtivaBotoesExcluir();
            }
        }

        private void MenuMarcaCancelar_Click(object sender, EventArgs e)
        {
            inativaAtivaBotoesCancelar();
        }

        private void buttonBuscarParticipante_Click(object sender, EventArgs e)
        {
            frmConsulta = new FrmConsultaMarca();
            DialogResult dr = frmConsulta.ShowDialog(this);

            string nomeMarcaReturn = frmConsulta.marcaClicada;
            if (String.IsNullOrEmpty(nomeMarcaReturn) == true)
            {
                MessageBox.Show("Você não selecionou a marca!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBoxDescricaoMarca.Text = nomeMarcaReturn;
                string codigoMarcaReturn = frmConsulta.idClicada;
                textBoxCodigoMarca.Text = codigoMarcaReturn;

                inativaAtivaBotoesConsultar();
            }
        }
    }    
}
