﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ShowTech
{
    public partial class FrmPgt4 : Form
    {
        public FrmPgt4()
        {
            InitializeComponent();
        }

        private void radioBntF3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntProx_Click_1(object sender, EventArgs e)
        {
            if (radioBntC.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj = new OOP();
                obj.acertos ++;

                FormPgt5 Pgt5 = new FormPgt5();
                Pgt5.ShowDialog();
                this.Dispose();

            }

            else if (radioBntF.Checked || radioBntF2.Checked || radioBntF3.Checked)
            {
                MessageBox.Show("Resposta Inorreta");

                OOP obj = new OOP();
                obj.erros ++;

                FormPgt5 Pgt5 = new FormPgt5();
                Pgt5.ShowDialog();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Marque uma alternativa");
            }
        }
    }
}
