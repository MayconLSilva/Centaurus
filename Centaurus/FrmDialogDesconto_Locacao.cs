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
    public partial class FrmDialogDesconto_Locacao : Form
    {
        public float descontoDadoEnvia { get; set; }
        public float valorFinalEnvia { get; set; }

        private float valorRecebido;

        public FrmDialogDesconto_Locacao(float valorRetornado)
        {
            InitializeComponent();
            textBoxDescontoDadoPorcentagem_dialogDesconto.Text = "0";
            textBoxDescontoDadoValor_dialogDesconto.Text = "0";

            valorRecebido = valorRetornado;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(textBoxDescontoDadoPorcentagem_dialogDesconto.Text != "0" && textBoxDescontoDadoValor_dialogDesconto.Text != "0")
            {
                MessageBox.Show("Escolha o desconto em porcentagem ou valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }else if (textBoxDescontoDadoPorcentagem_dialogDesconto.Text == "0" && textBoxDescontoDadoValor_dialogDesconto.Text != "0")
            {
                double descontoConcedido = Convert.ToSingle(textBoxDescontoDadoValor_dialogDesconto.Text);//Preciso enviar o desconto
                float resultado = valorRecebido - Convert.ToSingle(descontoConcedido);
                
                descontoDadoEnvia = Convert.ToSingle(descontoConcedido);
                valorFinalEnvia = resultado;
                Dispose();
                
            }
            else if(textBoxDescontoDadoPorcentagem_dialogDesconto.Text != "0" && textBoxDescontoDadoValor_dialogDesconto.Text == "0")
            {
                float descontoInformado = Convert.ToSingle(textBoxDescontoDadoPorcentagem_dialogDesconto.Text);
                float resultDesconto = (descontoInformado / 100 ) * valorRecebido;//Preciso enviar o desconto 
                float resultFinal = valorRecebido - resultDesconto;
                
                descontoDadoEnvia = resultDesconto;
                valorFinalEnvia = resultFinal;
                
                Dispose();
            }
            else if (textBoxDescontoDadoPorcentagem_dialogDesconto.Text == "0" && textBoxDescontoDadoValor_dialogDesconto.Text == "0")
            {                
                Dispose();
            }
        }

        private void textBoxDescontoDadoValor_dialogDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDescontoDadoPorcentagem_dialogDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
