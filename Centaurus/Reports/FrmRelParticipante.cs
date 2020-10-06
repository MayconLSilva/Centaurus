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
    public partial class FrmRelParticipante : Form
    {
        public FrmRelParticipante()
        {
            InitializeComponent();
        }

        private void FrmRelParticipante_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
