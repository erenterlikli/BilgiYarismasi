using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;
        int sure = 20;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 20;
            label9.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Text = "İleri";
            soruno++;
            label2.Text = soruno.ToString();
            label7.Text = " ";
            

            if(soruno==1)
            {
                richTextBox1.Text = "Hangisi bilgisayarı oluşturan temel parçalardan değildir?";
                button1.Text = "MİB";
                button2.Text = "Giriş/Çıkış";
                button3.Text = "Ana Bellek";
                button4.Text = "Ekran Kartı";
                label9.Text = "Ekran Kartı";

            }
            if(soruno==2)
            {
                richTextBox1.Text = "Hangisi bir programlama dili değildir?";
                button1.Text = "C++";
                button2.Text = "PHP";
                button3.Text = "HTML";
                button4.Text = "Java";
                label9.Text = "HTML";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Hangisi Nesneye Yönelik Programlama dilidir?";
                button1.Text = "PHP";
                button2.Text = "Java";
                button3.Text = "Fortran";
                button4.Text = "Basic";
                label9.Text = "Java";
            }
            if(soruno==4)
            {
                richTextBox1.Text = "Son çıkış router'ına ne ad verilir?";
                button1.Text = "Gateway";
                button2.Text = "Switch";
                button3.Text = "Router";
                button4.Text = "Network";
                label9.Text = "Gateway";
            }
            if(soruno==5)
            {
                richTextBox1.Text = "Hangisi Arduino özelliklerinden değildir?";
                button1.Text = "C/C++ dilleri";
                button2.Text = "Kurulum kolay";
                button3.Text = "Gömülü sistemdir";
                button4.Text = "Sadece web programlar";
                label9.Text = "Sadece web programlar";
            }
            if(soruno==6)
            {
                richTextBox1.Text = " ";
                button1.Text = " ";
                button2.Text = "  ";
                button3.Text = " ";
                button4.Text = " ";
                label9.Text = " ";
                label2.Text = " ";

                timer1.Enabled = false;
                MessageBox.Show("Tebrikler,yarışma bitti.");
                
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label9.Visible = true;
            timer1.Enabled = false;

            label7.Text = button1.Text;
            if(label9.Text==label7.Text)
            {
                dogru++;
                label4.Text = dogru.ToString();

            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label9.Visible = true;
            timer1.Enabled = false;

            label7.Text = button2.Text;
            if(label9.Text==label7.Text)
            {
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label9.Visible = true;
            timer1.Enabled = false;

            label7.Text = button3.Text;
            if(label9.Text==label7.Text)
            {
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label9.Visible = true;
            timer1.Enabled = false;

            label7.Text = button4.Text;
            if(label9.Text==label7.Text)
            {
                dogru++;
                label4.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label5.Text = yanlis.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sure--;
            label11.Text = sure.ToString();
          if(sure==0)
            {
                timer1.Stop();
                MessageBox.Show("Süre doldu!");
                Application.Exit();
            }
        }
    }
}