using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            /*
            if (soruno == 0)
            {
                MessageBox.Show("Lütfen sonraki tuşuna basarak oyuna başlayınız!");
            }
            return;
            */

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            /*
            if (soruno == 0)
            {
                MessageBox.Show("Lütfen sonraki tuşuna basarak oyuna başlayınız!");
            }
            return;
            */

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            /*
            if (soruno == 0)
            {
                MessageBox.Show("Lütfen sonraki tuşuna basarak oyuna başlayınız!");
            }
            return;
            */

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;



            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            /*
            if (soruno == 0)
            {
                MessageBox.Show("Lütfen sonraki tuşuna basarak oyuna başlayınız!");
            }
            return;
            */

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {


            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;

            soruno++;
            LblSoruno.Text = soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1921";
                btnB.Text = "1922";
                btnC.Text = "1923";
                btnD.Text = "1924";
                label4.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgemizde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "İstanbul";
                btnC.Text = "Aydın";
                btnD.Text = "Uşak";
                label4.Text = "İstanbul";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Atatürk sırasıyla kaç yılında doğmuş ve ölmüştür?";
                btnA.Text = "1881 - 1928";
                btnB.Text = "1891 - 1938";
                btnC.Text = "1891 - 1928";
                btnD.Text = "1881 - 1938";
                label4.Text = "1881 - 1938";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                MessageBox.Show("Doğru Sayınız: " + dogru + "\nYanlış Sayınız: " + yanlis, "Oyun Bitti");
                richTextBox1.Text = ("Oyun bitti. :)");
                btnA.Text = "Oynadığınız";
                btnB.Text = "İçin";
                btnC.Text = "Teşekkürler";
                btnD.Text = ":)";

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;



                soruno = 3;
            }
            return;
        }
    }
}
