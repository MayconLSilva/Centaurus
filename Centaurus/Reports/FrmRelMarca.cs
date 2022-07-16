using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.Model;
using Microsoft.Reporting.WinForms;
using Centaurus.Dao;

namespace Centaurus.Reports
{
    public partial class FrmRelMarca : Form
    {
        MarcaDAO marcaDAO = new MarcaDAO();

        public FrmRelMarca()
        {
            InitializeComponent();
        }

        private void FrmRelMarca_Load(object sender, EventArgs e)
        {

            //var produtos = new List<MarcaModelo>
            //{
            //    new MarcaModelo { idMarca = 1, nomeMarca = "Produto 1" },
            //    new MarcaModelo { idMarca = 1, nomeMarca = "Produto 2" }
            //};

            //reportViewerMarca.LocalReport.DataSources.Clear();
            //reportViewerMarca.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelMarca", produtos));
            //this.reportViewerMarca.RefreshReport();

            var listaMarcas = marcaDAO.listarProdutosRelatorio();

            reportViewerMarca.LocalReport.DataSources.Clear();
            reportViewerMarca.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelMarca", listaMarcas));
            this.reportViewerMarca.RefreshReport();
        }
    }
}
