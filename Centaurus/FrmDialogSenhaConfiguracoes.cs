﻿using System;
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
    public partial class FrmDialogSenhaConfiguracoes : Form
    {
        //FrmManutencao formManutencao;

        public FrmDialogSenhaConfiguracoes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var formManutencao = new FrmManutencao();
            this.Hide();
            formManutencao.Show();
            
        }
    }
}
