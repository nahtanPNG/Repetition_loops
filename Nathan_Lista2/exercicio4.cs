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
    public partial class exercicio4 : Form
    {
        public exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double paisA, paisB, tempo;

            paisA = 5000000;
            paisB = 7000000;
            tempo = 0;

            while (paisA <= paisB)
            {
                paisA = paisA + (paisA * 0.03);
                paisB = paisB + (paisB * 0.02);
                tempo++;
            }
            label2.Text = "Tempo necessário: " + tempo + " anos";
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
    }
}
