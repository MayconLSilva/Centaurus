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
        private string filtroNome = "";
        private string filtroCli = null;
        private string filtroFor = null;
        private string filtroFun = null;

        public FrmRelParticipante(string tipoCli, string tipoFor, string tipoFun,string filtroParti)
        {
            InitializeComponent();
            filtroNome = filtroParti;
            filtroCli = tipoCli;
            filtroFor = tipoFor;
            filtroFun = tipoFun;
        }

        private void FrmTestecs_Load(object sender, EventArgs e)
        {            
            // TODO: esta linha de código carrega dados na tabela 'centaurusDataSet.listarParticipanteEmpresa'. Você pode movê-la ou removê-la conforme necessário.
            this.listarParticipanteEmpresaTableAdapter.Fill(this.centaurusDataSet.listarParticipanteEmpresa, filtroCli,filtroFor,filtroFun, filtroNome);
            this.reportViewer1.RefreshReport();
        }
    }
}
