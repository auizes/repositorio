﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedico
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPorcentagem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCarregando_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
                lblPorcentagem.Text = progressBar1.Value.ToString() + " %";
                lblCarregando.Visible = true;
            }
            else
            {
                tmrSplash.Enabled = false;
                FrmLogin abrir = new FrmLogin();
                abrir.Show();
                this.Hide();
            }
            

            
        }
    }
}
