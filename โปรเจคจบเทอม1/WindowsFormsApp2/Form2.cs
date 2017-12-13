using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public string a="",b="",c="",d="",et="",f="";
        double Cash;


        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash = double.Parse(textBox2.Text) - double.Parse(label4.Text);
            if (Cash >= 0)
            {
                textBox1.Text = "รองเท้าแตะ  ใส่สบายสไตน์ของคุณ" + "\r\n" + "\r\n";
                if (a != "")
                    textBox1.Text += a + "\r\n";
                if (b != "")
                    textBox1.Text += b + "\r\n";
                if (c != "")
                    textBox1.Text += c + "\r\n";
                if (d != "")
                    textBox1.Text += d + "\r\n";
                if (et != "")
                    textBox1.Text += et + "\r\n";
                if (f != "")
                    textBox1.Text += f + "\r\n";

                textBox1.Text += "เงินสด " + Cash + " บาท\r\n";
                textBox1.Text += "เงินทอน " + Cash.ToString() + " บาท\r\n";
            }
            else
            {
                MessageBox.Show("เงินที่รับมาไม่เพียงพอ");
            }
           





        }
    }
}
