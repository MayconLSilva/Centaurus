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
            Reports.FrmRelParticipante relParticipante = new Reports.FrmRelParticipante();
            relParticipante.Show();            
        }

        private void buttonBuscarParticipante_Click(object sender, EventArgs e)
        {
            string passaTipoConsulta = "TODOS";
            frm2 = new FrmConsultaParticipante(passaTipoConsulta);
            DialogResult dr = frm2.ShowDialog(this);

            textBoxNome.Text = frm2.nomeClienteClicado;
        }
    }
}
