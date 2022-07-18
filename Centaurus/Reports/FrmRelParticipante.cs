using Centaurus.Dao;
using Microsoft.Reporting.WinForms;
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
        private string _tipoConsulta = "";
        private string _tipoFiltro = "";
        private string _nomeCliente = "";

        ParticipanteDAO participanteDAO = new ParticipanteDAO();

        public FrmRelParticipante(string tipoConsulta, string tipoFiltro, string nomeCliente)
        {
            InitializeComponent();
            _tipoConsulta = tipoConsulta;
            _tipoFiltro = tipoFiltro;
            _nomeCliente = nomeCliente;
        }

        private void FrmTestecs_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            // TODO: esta linha de código carrega dados na tabela 'centaurusDataSet.listarParticipanteEmpresa'. Você pode movê-la ou removê-la conforme necessário.
            //this.listarParticipanteEmpresaTableAdapter.Fill(this.centaurusDataSet.listarParticipanteEmpresa, filtroCli,filtroFor,filtroFun, filtroNome);
            //this.reportViewerParticipantes.RefreshReport();

            var listaParticipante = participanteDAO.listarParticipanteRelatorio(_tipoConsulta,_tipoFiltro,_nomeCliente);

            reportViewerParticipantes.LocalReport.DataSources.Clear();
            reportViewerParticipantes.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelParticipante", listaParticipante));
            this.reportViewerParticipantes.RefreshReport();
        }
    }
}
