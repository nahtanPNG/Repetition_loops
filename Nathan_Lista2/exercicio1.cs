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
    public partial class exercicio1 : Form
    {
        public exercicio1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double polegada;

                polegada = 0;

                while (polegada <= 20)
                {
                    listBox1.Items.Add(polegada + " polegadas = " + (polegada * 2.54) + " Centímetros" );
                    polegada++;
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void exercicio1_Load(object sender, EventArgs e)
        {

        }
    }
}
