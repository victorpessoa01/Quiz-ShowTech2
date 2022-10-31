using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ShowTech
{
    public partial class FormPgt5 : Form
    {
        public FormPgt5()
        {
            InitializeComponent();
        }

        private void bntProx_Click(object sender, EventArgs e)
        {
            if (radioBntC.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj = new OOP();
                obj.acertos += 1;

                FrmPgt2 pgt2 = new FrmPgt2();
                pgt2.ShowDialog();
                this.Dispose();

            }

            else if (radioBntF.Checked || radioBntF2.Checked || radioBntF3.Checked)
            {
                MessageBox.Show("Resposta Inorreta");

                OOP obj = new OOP();
                obj.erros += 1;

                FrmPgt2 pgt2 = new FrmPgt2();
                pgt2.ShowDialog();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Marque uma alternativa");
            }

        }

        private void FormPgt5_Load(object sender, EventArgs e)
        {
            OOP obj = new OOP();
            obj.acertos = 0;
            obj.erros = 0;
        }

        private void bntProx_Click_1(object sender, EventArgs e)
        {
            if (radioBntC.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj = new OOP();
                obj.acertos ++;

                FormPgt6 Pgt6 = new FormPgt6();
                Pgt6.ShowDialog();
                this.Dispose();

            }

            else if (radioBntF.Checked || radioBntF2.Checked || radioBntF3.Checked)
            {
                MessageBox.Show("Resposta Inorreta");

                OOP obj = new OOP();
                obj.erros ++;

                FormPgt6 Pgt6 = new FormPgt6();
                Pgt6.ShowDialog();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Marque uma alternativa");
            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
