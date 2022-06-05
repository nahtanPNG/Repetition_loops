using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nathan_Lista2
{
    public partial class exercicio5 : Form
    {
        public exercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alturajoao, alturamaria, tempo;

            alturajoao = 1.50;
            alturamaria = 1.10;
            tempo = 0;

            while (alturamaria <= alturajoao)
            {
                alturamaria = alturamaria +  0.03;
                alturajoao = alturajoao +  0.02;
                tempo++;
            }
            label2.Text = "Tempo necessário: " + tempo + " anos para maria alcançar joão";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Tempo necessário:";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var form1 = new Form1();
            form1.Show();

        }

        private void exercicio5_Load(object sender, EventArgs e)
        {

        }
    }
}
