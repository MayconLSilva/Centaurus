using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            buttonCriarBD.Enabled = false;
            buttonCriarTabelas.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            //executa o processo de forma assincrona.
            backgroundWorker1.RunWorkerAsync();
            //adapter.criarBD(textBoxNomeBD.Text);			
        }

        private void TarefaLonga(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                // faz a thread dormir por "p" milissegundos a cada passagem do loop
                Thread.Sleep(p);
                labelInformacoesProgresso.BeginInvoke(
                   new Action(() =>
                   {
                       labelInformacoesProgresso.Text = "Tarefa: " + i.ToString() + " comcluída";
                   }
                ));
            }
        }

        private void buttonCriarTabelas_Click(object sender, EventArgs e)
        {
            adapter.criarTables();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)//representa uma tarefa com 100 processos.
            {
                //Executa o método longo 100 vezes.
                TarefaLonga(20);
                //incrementa o progresso do backgroundWorker
                //a cada passagem do loop.
                this.backgroundWorker1.ReportProgress(i);

                //Verifica se houve uma requisição para cancelar a operação.
                if (backgroundWorker1.CancellationPending)
                {
                    //se sim, define a propriedade Cancel para true
                    //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                    e.Cancel = true;

                    //zera o percentual de progresso do backgroundWorker1.
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            //Finalmente, caso tudo esteja ok, finaliza
            //o progresso em 100%.
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            progressBar1.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            labelPorcentagemProcesso.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                labelInformacoesProgresso.Text = "Operação Cancelada pelo Usuário!";

                //habilita o Botao cancelar
                //btnCancelar.Enabled = true;
                //limpa a label
                labelPorcentagemProcesso.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                labelInformacoesProgresso.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                labelInformacoesProgresso.Text = "Tarefa Concluida com sucesso!";
            }
            //habilita os botões.
            buttonCriarBD.Enabled = true;
            buttonCriarTabelas.Enabled = true;
        }
    }
}
