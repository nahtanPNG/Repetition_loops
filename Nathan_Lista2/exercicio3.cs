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
    public partial class exercicio3 : Form
    {
        public exercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome, sexo;
            double idade, quantidade;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Digite um valor válido", "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                nome = textBox1.Text;
                sexo = textBox2.Text;
                idade = Double.Parse(textBox3.Text);
                

                for (quantidade = 0; quantidade <= 20; quantidade++)
                {

                    if (sexo == "masculino" && idade > 21)
                    {
                        listBox1.Items.Add(nome);
                        break;
                       
                    }
                    else
                    {
                        
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";

                    }
                    
                }
                label5.Text = "quantidade" + quantidade;

            }
        }

        private void exercicio3_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
