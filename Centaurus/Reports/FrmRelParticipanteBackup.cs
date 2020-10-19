using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.Reports;

namespace Centaurus.Reports
{
    public partial class FrmRelParticipanteBackup : Form
    {
        public FrmRelParticipanteBackup()
        {
            InitializeComponent();
        }

        private void FrmRelParticipante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'centaurusDataSet.participante'. Você pode movê-la ou removê-la conforme necessário.
            this.participanteTableAdapter.Fill(this.centaurusDataSet.participante);

            this.reportViewer1.RefreshReport();
        }
    }
}
