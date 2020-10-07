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
        string botaoClicado = "INICIAL";
        FrmConsultaMarca frmConsulta;

        public FrmMarca()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            inativaAtivaBotoesCampos();
        }

        public void inativaAtivaBotoesCampos()
        {
            switch (botaoClicado)
            {
                case "INICIAL":

                    MenuMarcaNovo.Enabled = true;
                    MenuMarcaGravar.Enabled = false;
                    MenuMarcaEditar.Enabled = false;
                    MenuMarcaCancelar.Enabled = false;
                    MenuMarcaExcluir.Enabled = false;

                    textBoxCodigoMarca.Enabled = true;
                    textBoxDescricaoMarca.Enabled = false;
                    checkBoxMarcaAtiva.Enabled = false;

                    break;

                case "NOVO":

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

                    break;

                case "SALVAR":

                    MenuMarcaNovo.Enabled = true;
                    MenuMarcaGravar.Enabled = false;
                    MenuMarcaEditar.Enabled = true;
                    MenuMarcaCancelar.Enabled = true;
                    MenuMarcaExcluir.Enabled = true;

                    textBoxCodigoMarca.Enabled = false;
                    textBoxDescricaoMarca.Enabled = false;
                    checkBoxMarcaAtiva.Enabled = false;

                    break;

                case "EDITAR":

                    MenuMarcaNovo.Enabled = false;
                    MenuMarcaGravar.Enabled = true;
                    MenuMarcaEditar.Enabled = false;
                    MenuMarcaCancelar.Enabled = true;
                    MenuMarcaExcluir.Enabled = false;

                    textBoxCodigoMarca.Enabled = false;
                    textBoxDescricaoMarca.Enabled = true;
                    checkBoxMarcaAtiva.Enabled = true;

                    break;

                case "EXCLUIR":

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

                    break;

                case "CANCELAR":

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

                    break;

                case "CONSULTAR":

                    MenuMarcaNovo.Enabled = true;
                    MenuMarcaGravar.Enabled = false;
                    MenuMarcaEditar.Enabled = true;
                    MenuMarcaCancelar.Enabled = false;
                    MenuMarcaExcluir.Enabled = true;

                    textBoxCodigoMarca.Enabled = true;
                    textBoxDescricaoMarca.Enabled = false;
                    checkBoxMarcaAtiva.Enabled = false;
                    checkBoxMarcaAtiva.Checked = false;

                    break;
            }
        }

        private void MenuMarcaNovo_Click(object sender, EventArgs e)
        {
            botaoClicado = "NOVO";
            inativaAtivaBotoesCampos();
            flag = 0;
        }

        private void MenuMarcaGravar_Click(object sender, EventArgs e)
        {
            MarcaModelo marcaModelo = new MarcaModelo();
            salvar(marcaModelo);

        }

        private void salvar(MarcaModelo modMarca) 
        {
            if(flag == 0) 
            {
                MarcaBLL marcaBLL = new MarcaBLL();

                modMarca.nomeMarca = textBoxDescricaoMarca.Text;
                if (checkBoxMarcaAtiva.Checked)
                {
                    modMarca.ativoMarca = true;
                }
                else
                {
                    modMarca.ativoMarca = false;
                }

                marcaBLL.salvar(modMarca);
                MessageBox.Show("Marca incluida com sucesso!!!", "Cadastro Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "SALVAR";
                inativaAtivaBotoesCampos();

                //Método chama o ultimo registro
                marcaBLL.buscarIDMarca(modMarca);
                int idReturn = modMarca.idMarca;
                textBoxCodigoMarca.Text = Convert.ToString(idReturn);
            }
            else if(flag == 1) 
            {
                MarcaBLL marcaBLL = new MarcaBLL();

                modMarca.nomeMarca = textBoxDescricaoMarca.Text;
                if (checkBoxMarcaAtiva.Checked)
                {
                    modMarca.ativoMarca = true;
                }
                else
                {
                    modMarca.ativoMarca = false;
                }
                modMarca.idMarca = Convert.ToInt32(textBoxCodigoMarca.Text);

                marcaBLL.atualizar(modMarca);
                MessageBox.Show("Marca atualizada com sucesso!!!", "Cadastro Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoClicado = "SALVAR";
                inativaAtivaBotoesCampos();
            }
        }

        private void MenuMarcaEditar_Click(object sender, EventArgs e)
        {
            botaoClicado = "EDITAR";
            inativaAtivaBotoesCampos();
            flag = 1;
        }

        private void MenuMarcaExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente excluir o registro? ", "Excluir Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MarcaBLL bllMarca = new MarcaBLL();
                MarcaModelo modMarca = new MarcaModelo();
                modMarca.idMarca = Convert.ToInt32(textBoxCodigoMarca.Text);
                bllMarca.excluirMarca(modMarca);
                botaoClicado = "EXCLUIR";
                inativaAtivaBotoesCampos();
            }
        }

        private void MenuMarcaCancelar_Click(object sender, EventArgs e)
        {
            botaoClicado = "CANCELAR";
            inativaAtivaBotoesCampos();
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

                botaoClicado = "CONSULTAR";
                inativaAtivaBotoesCampos();
            }
        }
    }    
}
