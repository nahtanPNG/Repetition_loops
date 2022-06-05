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
    public partial class exercicio2 : Form
    {
        public exercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal f;

            f = 50;
            
            while (f <= 150)
            {
                listBox1.Items.Add(f + "°Fahrenheit = " + (5*(f-32)/9).ToString("F") + " °Celsius");
                f++;
              
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
    }
}
