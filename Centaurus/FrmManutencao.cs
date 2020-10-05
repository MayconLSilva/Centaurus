using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centaurus.DAL;

namespace Centaurus
{
    public partial class FrmManutencao : Form
    {
        DataBaseAdapter adapter = new DataBaseAdapter();

        public FrmManutencao()
        {
            InitializeComponent();
        }
                
        private void buttonCriarBD_Click(object sender, EventArgs e)
        {
            adapter.criarBD(textBoxNomeBD.Text);			
		}
                

        private void buttonCriarTabelas_Click(object sender, EventArgs e)
        {

        }
    }
}
