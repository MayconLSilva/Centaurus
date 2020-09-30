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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            popularOpcoesUsuario();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        public void popularOpcoesUsuario()
        {
            treeViewOpcoesUsuario.Nodes.Add("PRODUTO");
            treeViewOpcoesUsuario.Nodes.Add("PARTICIPANTES");
            treeViewOpcoesUsuario.Nodes.Add("USUARIOS");

            treeViewOpcoesUsuario.Nodes[0].Nodes.Add("Produto");
            treeViewOpcoesUsuario.Nodes[0].Nodes.Add("Marca");
            treeViewOpcoesUsuario.Nodes[0].Nodes.Add("Categoria/Sub");
        }

        List<TreeNode> usuariosChecked = new List<TreeNode>();
        void validarChecked(TreeNodeCollection nodes)
        {
            foreach(TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    usuariosChecked.Add(node);
                    MessageBox.Show("foi " + node.Name);
                }
            }
        }

        private void MenuMarcaGravar_Click(object sender, EventArgs e)
        {
            validarChecked(treeViewOpcoesUsuario.Nodes);
        }
    }
}
