using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centaurus.Reports
{
    public partial class FrmRelParticipante : Form
    {
        public FrmRelParticipante()
        {
            InitializeComponent();
        }

        private void FrmTestecs_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'centaurusDataSet.listarParticipanteEmpresa'. Você pode movê-la ou removê-la conforme necessário.
            this.listarParticipanteEmpresaTableAdapter.Fill(this.centaurusDataSet.listarParticipanteEmpresa);

            this.reportViewer1.RefreshReport();
        }
    }
}
