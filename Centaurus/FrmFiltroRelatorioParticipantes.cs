﻿using System;
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
    public partial class FrmFiltroRelatorioParticipantes : Form
    {
        FrmConsultaParticipante frm2;
        
        public FrmFiltroRelatorioParticipantes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                        
            radioButtonTodosParticipantes.Checked = true;
        }

        private void toolStripButtonVisualizar_Click(object sender, EventArgs e)
        {
            string tipoCli = null, tipoFun = null, tipoFor = null;
            
            if(String.IsNullOrEmpty(textBoxNome.Text) == true)
            {
                //Tipo cliente
                if (radioButtonCliente.Checked)
                {
                    tipoCli = "1";
                }
                //Tipo funcionário
                if (radioButtonFuncionario.Checked)
                {
                    tipoFun = "1";
                }
                //Tipo fornecedor
                if (radioButtonFornecedor.Checked)
                {
                    tipoFor = "1";
                }
                //Tipo todos
                if (radioButtonTodosParticipantes.Checked)
                {
                    tipoCli = "1";
                    tipoFun = "1";
                    tipoFor = "1";
                }
            }
            else
            {
                tipoCli = null;
                tipoFun = null;
                tipoFor = null;
            }

            Reports.FrmRelParticipante relParticipante = new Reports.FrmRelParticipante(tipoCli,tipoFor,tipoFun, textBoxNome.Text);
            relParticipante.Show();            
        }

        private void buttonBuscarParticipante_Click(object sender, EventArgs e)
        {
            string passaTipoConsulta = "TODOS";
            frm2 = new FrmConsultaParticipante(passaTipoConsulta);
            DialogResult dr = frm2.ShowDialog(this);

            textBoxNome.Text = frm2.nomeClienteClicado;
        }

        private void buttonLimparNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
        }
    }
}
