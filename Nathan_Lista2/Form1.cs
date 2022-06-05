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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exercicio = new exercicio1();
            exercicio.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exercicio = new exercicio2();
            exercicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exercicio = new exercicio3();
            exercicio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exercicio = new exercicio4();
            exercicio.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exercicio = new exercicio5();
            exercicio.Show();
        }
    }
}
