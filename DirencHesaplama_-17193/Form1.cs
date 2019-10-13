using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirencHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;



            double renk1, renk2, renk3, renk4, sonuc;
            

                renk1 = comboBox1.SelectedIndex;
                renk2 = comboBox2.SelectedIndex;
                renk3 = comboBox3.SelectedIndex;
                renk4 = comboBox4.SelectedIndex;
                string top = renk1 + renk2.ToString();
                sonuc = (Convert.ToDouble(top) * Math.Pow(10, renk3));

            


            if (sonuc < 1000)
                 label5.Text = sonuc + " Ohm".ToString();
                else if (sonuc < 1000000)
                    label5.Text = (sonuc / 1000) + " Kilo Ohm".ToString();
                else if (sonuc < 1000000000)
                    label5.Text = (sonuc / 1000000) + " Mega Ohm".ToString();
                else if (sonuc < 1000000000000)
                    label5.Text = (sonuc / 1000000000) + " Giga Ohm".ToString();
                else
                    label5.Text = "Hata";

                if (renk4 == 0)
                    label6.Text = " %1";
                else if (renk4 == 1)
                    label6.Text = " %2";
                else if (renk4 == 2)
                    label6.Text = " %5";
                else
                    label6.Text = " %10";
            
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Direnç Hesaplama uygulamasından çıkmak ister misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                
               Environment.Exit(0);

            }
            else if (x == DialogResult.No)
            {
                
                e.Cancel = true; 
            }
            
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            



            progressBar1.Increment(6);

            label9.Text = "%" + progressBar1.Value.ToString();
            
            if (progressBar1.Value == 100)
            {
               
                timer1.Stop();
                MessageBox.Show("Hesaplama Tamamlandı!");


                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

                progressBar1.Visible = false;
                label9.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz. Umarım program işinize yarar :=)");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Siyah")
            {
                button2.BackColor = Color.Black;
            }
            else if (comboBox1.Text == "Kahverengi")
            {
                button2.BackColor = Color.SaddleBrown;
            }
            else if (comboBox1.Text == "Kırmızı")
            {
                button2.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "Turuncu")
            {
                button2.BackColor = Color.Orange;
            }
            else if (comboBox1.Text == "Sarı")
            {
                button2.BackColor = Color.Yellow;
            }
            else if (comboBox1.Text == "Yeşil")
            {
                button2.BackColor = Color.Green;
            }
            else if (comboBox1.Text == "Mavi")
            {
                button2.BackColor = Color.Blue;
            }
            else if (comboBox1.Text == "Mor")
            {
                button2.BackColor = Color.Purple;
            }
            else if (comboBox1.Text == "Gri")
            {
                button2.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "Beyaz")
            {
                button2.BackColor = Color.White;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Siyah")
            {
                button3.BackColor = Color.Black;
            }
            else if (comboBox2.Text == "Kahverengi")
            {
                button3.BackColor = Color.SaddleBrown;
            }
            else if (comboBox2.Text == "Kırmızı")
            {
                button3.BackColor = Color.Red;
            }
            else if (comboBox2.Text == "Turuncu")
            {
                button3.BackColor = Color.Orange;
            }
            else if (comboBox2.Text == "Sarı")
            {
                button3.BackColor = Color.Yellow;
            }
            else if (comboBox2.Text == "Yeşil")
            {
                button3.BackColor = Color.Green;
            }
            else if (comboBox2.Text == "Mavi")
            {
                button3.BackColor = Color.Blue;
            }
            else if (comboBox2.Text == "Mor")
            {
                button3.BackColor = Color.Purple;
            }
            else if (comboBox2.Text == "Gri")
            {
                button3.BackColor = Color.Gray;
            }
            else if (comboBox2.Text == "Beyaz")
            {
                button3.BackColor = Color.White;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Siyah")
            {
                button4.BackColor = Color.Black;
            }
            else if (comboBox3.Text == "Kahverengi")
            {
                button4.BackColor = Color.SaddleBrown;
            }
            else if (comboBox3.Text == "Kırmızı")
            {
                button4.BackColor = Color.Red;
            }
            else if (comboBox3.Text == "Turuncu")
            {
                button4.BackColor = Color.Orange;
            }
            else if (comboBox3.Text == "Sarı")
            {
                button4.BackColor = Color.Yellow;
            }
            else if (comboBox3.Text == "Yeşil")
            {
                button4.BackColor = Color.Green;
            }
            else if (comboBox3.Text == "Mavi")
            {
                button4.BackColor = Color.Blue;
            }
            else if (comboBox3.Text == "Mor")
            {
                button4.BackColor = Color.Purple;
            }
            else if (comboBox3.Text == "Gri")
            {
                button4.BackColor = Color.Gray;
            }
            else if (comboBox3.Text == "Beyaz")
            {
                button4.BackColor = Color.White;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Kahverengi")
            {
                button5.BackColor = Color.SaddleBrown;
            }
            else if (comboBox4.Text == "Kırmızı")
            {
                button5.BackColor = Color.Red;
            }
            else if (comboBox4.Text == "Altın")
            {
                button5.BackColor = Color.Gold;
            }
            else if (comboBox4.Text == "Gümüş")
            {
                button5.BackColor = Color.Silver;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

