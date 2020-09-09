using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centaurus
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        [STAThread]
        static void Main()
        {

            //opção 1
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);             
            Application.Run(new FrmLogin());  

            //Opção 2 NÃO FUNCIONOU
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (FrmLogin frmLogin = new FrmLogin())
            {
                if(frmLogin.ShowDialog() == DialogResult.OK)
                {
                    //pega usuario logado
                   
                }
                else
                {
                    return;
                }
            }
            Application.Run(new FrmPrincipal());
            */


            /* Opção 3
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin login = new FrmLogin();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("classe main");
                Application.Run(new FrmPrincipal());
            }
            */



            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if(result == DialogResult.OK)
            { 
                Application.Run(new FrmPrincipal());
                //frmLogin.Close();
            }
            */

            //Opção 4
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPrincipal());

        }
    }
}
