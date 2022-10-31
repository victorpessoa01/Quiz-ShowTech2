using System;
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
    public partial class FormPgt6 : Form
    {
        public FormPgt6()
        {
            InitializeComponent();
        }

        private void bntProx_Click(object sender, EventArgs e)
        {
        }

        private void FormPgt6_Load(object sender, EventArgs e)
        {
           
        }

        private void bntProx_Click_1(object sender, EventArgs e)
        {
            if (radioBntC.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj = new OOP();
                obj.acertos ++;

                FormPgt7 Pgt7 = new FormPgt7();
                Pgt7.ShowDialog();
                this.Dispose();

            }

            else if (radioBntF.Checked || radioBntF2.Checked || radioBntF3.Checked)
            {
                MessageBox.Show("Resposta Inorreta");

                OOP obj = new OOP();
                obj.erros ++;

                FormPgt7 Pgt7 = new FormPgt7();
                Pgt7.ShowDialog();
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
