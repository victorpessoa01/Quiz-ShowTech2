using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ShowTech
{
    public partial class FrmFim : Form
    {

        public FrmFim()
        {
            InitializeComponent();

        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            Form1Inicio FrmInicio = new Form1Inicio();

            FrmInicio.ShowDialog();
            this.Dispose();
        }

        private void FrmFim_Load(object sender, EventArgs e)
        {
        }

        private void labelAcer_Click(object sender, EventArgs e)
        {
           
        }

        private void labelErr_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNome_Click(object sender, EventArgs e)
        {
            OOP obj = new OOP();

            labelPontos.Text = Convert.ToString(obj.acertos - obj.erros);
            
        }
    }
}
