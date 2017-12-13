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
    public partial class Form1 : Form
    {
        double[] Foot1 = { 229, 120, 98, 315, 100, 259 };
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] check = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
            TextBox[] text = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            double[] value = new double[check.Length];

            double allsum = 0;
                for (int i = 0; i < check.Length; i++)
                {
                    if (check[i].Checked)
                    {
                        value[i] = double.Parse(text[i].Text) * Foot1[i];
                    allsum += double.Parse(text[i].Text) * Foot1[i];
                }
                }
            Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            f2.label4.Text = allsum.ToString();
            if (checkBox1.Checked == true)
            {
                f2.a = "รองเท้าปลา ขนาด " + comboBox1.Text + " จำนวน " + textBox1.Text + " คู่ " + double.Parse(text[0].Text) * Foot1[0] + " บาท";
                
            }
            if (checkBox2.Checked == true)
            {
                f2.b = "Nike Solarsoft Thong ขนาด " + comboBox2.Text + " จำนวน " + textBox2.Text + " คู่ " + double.Parse(text[1].Text) * Foot1[1] + " บาท";
               
            }
            if (checkBox3.Checked == true)
            {
                f2.c = "Mixstar ขนาด " + comboBox3.Text + " จำนวน " + textBox3.Text + " คู่ " + double.Parse(text[2].Text) * Foot1[2] + " บาท";
            }
            if (checkBox4.Checked == true)
            {
                f2.d = "GAMBOL แกมโบล ขนาด " + comboBox4.Text + " จำนวน " + textBox4.Text + " คู่ " + double.Parse(text[3].Text) * Foot1[3] + " บาท";
            }
            if (checkBox5.Checked == true)
            {
                f2.et = "นันยาง ขนาด " + comboBox5.Text + " จำนวน " + textBox5.Text + " คู่ " + (double.Parse(textBox5.Text) * Foot1[4]).ToString() + " บาท";
            }
            if (checkBox6.Checked == true)
            {
                f2.f = "Kito AA10M ขนาด " + comboBox6.Text + " จำนวน " + textBox6.Text + " คู่ " + double.Parse(text[5].Text) * Foot1[5] + " บาท";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                textBox1.Visible = true;
                comboBox1.Visible = true;
                label3.Visible = true;
                label14.Visible = true;
                
            }

           else if (checkBox1.Checked == false)
            {
                textBox1.Visible = false;
                comboBox1.Visible = false;
                label3.Visible = false;
                label14.Visible = false;
               
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                
                textBox2.Visible = true;
                comboBox2.Visible = true;
                label9.Visible = true;
                label15.Visible = true;
            }
            else if (checkBox2.Checked == false)
            {
                textBox2.Visible = false;
                comboBox2.Visible = false;
                label9.Visible = false;
                label15.Visible = false;
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                
                textBox3.Visible = true;
                comboBox3.Visible = true;
                label10.Visible = true;
                label16.Visible = true;
            }
            else if (checkBox3.Checked == false)
            {
                textBox3.Visible = false;
                comboBox3.Visible = false;
                label10.Visible = false;
                label16.Visible = false;
                
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                
                textBox4.Visible = true;
                comboBox4.Visible = true;
                label11.Visible = true;
                label19.Visible = true;
            }
            else if (checkBox4.Checked == false)
            {
                textBox4.Visible = false;
                comboBox4.Visible = false;
                label11.Visible = false;
                label19.Visible = false;
                
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Visible = true;
                comboBox5.Visible = true;
                label12.Visible = true;
                label18.Visible = true;
            }
            else if (checkBox5.Checked == false)
            {
                textBox5.Visible = false;
                comboBox5.Visible = false;
                label12.Visible = false;
                label18.Visible = false;
               
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                
                textBox6.Visible = true;
                comboBox6.Visible = true;
                label13.Visible = true;
                label17.Visible = true;
            }
            else if (checkBox6.Checked == false)
            {
                textBox6.Visible = false;
                comboBox6.Visible = false;
                label13.Visible = false;
                label17.Visible = false;
                
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
