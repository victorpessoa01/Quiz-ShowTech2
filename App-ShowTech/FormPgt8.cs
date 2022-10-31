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
    public partial class FormPgt8 : Form
    {
        public FormPgt8()
        {
            InitializeComponent();
        }

        private void bntProx_Click(object sender, EventArgs e)
        {
            if (radioBntF.Checked == true)
            {
                MessageBox.Show("Resposta Correta");

                OOP obj = new OOP();
                obj.acertos ++;


                FrmFim fim = new FrmFim();
                fim.ShowDialog();
                this.Dispose();

            }

            else if (radioBntC.Checked || radioBntF2.Checked || radioBntF3.Checked)
            {
                MessageBox.Show("Resposta Inorreta");

                OOP obj = new OOP();
                obj.erros ++;

                FrmFim fim = new FrmFim();
                fim.ShowDialog();
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
