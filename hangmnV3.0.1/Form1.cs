using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangmnV3._0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] kelimeler = { "VAMPIR", "BEN", "KALEM" };// buarada dizi oluşturup içine kelimeleri atadım.
        String secim;// burada değişkenler atıyorum.
        String kelime;
        int hak = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = String.Empty;
            secim = kelimeler[rnd.Next(0, 3)];// burada "secim" değişkeninin içine random olarak "kelimeler" dizisinden kelime atıyorum.
            label2.Text = secim;// label 2 ye seçilen kelimeyi yazdırıyorum.
            kelime = "";
            for (int i = 0; i < secim.Length; i++)// buarada "kelime" değişkenini seçilen kelimenin harf uzunluğu kadar label a "_" işaretini yazdırıyorum.
            {
                kelime += " _ ";
            }
            label1.Text = kelime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secim == "BEN")
            {
                string kelime = "BEN";
                textBox1.Text = textBox1.Text.ToUpper();

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Harf Girin");
                }
                if (textBox1.Text == "BEN".ToString())
                {
                    MessageBox.Show("TEBRİKLER TAM DOĞRU BİLDİNİZ");
                    label3.Text = "_";
                    label4.Text = "_";
                    label5.Text = "_";
                    label6.Text = "_";
                    label7.Text = "_";
                    label8.Text = "_";
                    textBox1.Text = String.Empty;

                }
                else
                {
                    if (textBox1.Text == kelime[0].ToString())
                    {
                        label3.Text = "B";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[1].ToString())
                        {
                            label4.Text = "E";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[2].ToString())
                            {
                                label5.Text = "N";
                            }
                            else
                            {
                                hak++;
                                if (hak == 1)
                                {
                                    pictureBox1.Visible = true;
                                    MessageBox.Show("KALAN HAK : 5", "Maalesef Yazdığınız Harf Bulunmamakta");
                                }
                                else if (hak == 2)
                                {
                                    pictureBox3.Visible = true;
                                    MessageBox.Show("KALAN HAK :4", "Maalesef Yazdığınız Harf Bulunmamakta");
                                }
                                else if (hak == 3)
                                {
                                    pictureBox2.Visible = true;
                                    MessageBox.Show("KALAN HAK : 3", "Maalesef Yazdığınız Harf Bulunmamakta");
                                }
                                else if (hak == 4)
                                {
                                    pictureBox5.Visible = true;
                                    MessageBox.Show("KALAN HAK : 2", "Maalesef Yazdığınız Harf Bulunmamakta");
                                }
                                else if (hak == 5)
                                {
                                    pictureBox6.Visible = true;
                                    MessageBox.Show("KALAN HAK : 1", "Maalesef Yazdığınız Harf Bulunmamakta");
                                }
                                else if (hak == 6)
                                {
                                    pictureBox4.Visible = true;
                                    button1.Enabled = true;
                                    textBox1.Enabled = true;
                                    MessageBox.Show("KALAN HAK:0!!", "Oyunu Kaybettiniz!");
                                    MessageBox.Show("BEN", "Cevap");
                                    label3.Text = "_";
                                    label4.Text = "_";
                                    label5.Text = "_";
                                    label6.Text = "_";
                                    label7.Text = "_";
                                    label8.Text = "_";
                                    textBox1.Text = String.Empty;
                                }
                            }
                        }
                    }
                }
                if (label3.Text == "B")
                {
                    textBox1.Clear();
                    if (label4.Text == "E")
                    {
                        textBox1.Clear();
                        if (label5.Text == "N")
                        {
                            textBox1.Clear();
                            button1.Enabled = true;
                            textBox1.Enabled = true;
                            MessageBox.Show("Tebrikler Oyunu Kazandınız!");
                            label3.Text = "_";
                            label4.Text = "_";
                            label5.Text = "_";
                            label6.Text = "_";
                            label7.Text = "_";
                            label8.Text = "_";
                            textBox1.Text = String.Empty;

                        }
                    }
                }

            }
            else
            {
                if (secim == "VAMPIR")
                {
                    string kelime1 = "VAMPIR";
                    textBox1.Text = textBox1.Text.ToUpper();
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Lütfen Bir Harf Girin");
                    }
                    if (textBox1.Text == "VAMPIR".ToString())
                    {
                        MessageBox.Show("TEBRİKLER TAM DOĞRU BİLDİNİZ");
                        label3.Text = "_";
                        label4.Text = "_";
                        label5.Text = "_";
                        label6.Text = "_";
                        label7.Text = "_";
                        label8.Text = "_";
                        textBox1.Text = String.Empty;
                    }
                    else
                    {
                        if (textBox1.Text == kelime1[0].ToString())
                        {
                            label3.Text = "V";
                        }
                        else
                        {
                            if (textBox1.Text == kelime1[1].ToString())
                            {
                                label4.Text = "A";
                            }
                            else
                            {
                                if (textBox1.Text == kelime1[2].ToString())
                                {
                                    label5.Text = "M";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime1[3].ToString())
                                    {
                                        label6.Text = "P";
                                    }
                                    else
                                    {
                                        if (textBox1.Text == kelime1[4].ToString())
                                        {
                                            label7.Text = "I";
                                        }
                                        else
                                        {
                                            if (textBox1.Text == kelime1[5].ToString())
                                            {
                                                label8.Text = "R";
                                            }
                                            else
                                            {
                                                hak++;
                                                if (hak == 1)
                                                {
                                                    pictureBox1.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 5", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                }
                                                else if (hak == 2)
                                                {
                                                    pictureBox3.Visible = true;
                                                    MessageBox.Show("KALAN HAK :4", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                }
                                                else if (hak == 3)
                                                {
                                                    pictureBox2.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 3", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                }
                                                else if (hak == 4)
                                                {
                                                    pictureBox5.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 2", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                }
                                                else if (hak == 5)
                                                {
                                                    pictureBox6.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 1", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                }
                                                else if (hak == 6)
                                                {
                                                    pictureBox4.Visible = true;
                                                    button1.Enabled = true;
                                                    textBox1.Enabled = true;
                                                    MessageBox.Show("KALAN HAK:0!!", "Oyunu Kaybettiniz!");
                                                    MessageBox.Show("VAMPIR", "Cevap");
                                                    label3.Text = "_";
                                                    label4.Text = "_";
                                                    label5.Text = "_";
                                                    label6.Text = "_";
                                                    label7.Text = "_";
                                                    label8.Text = "_";
                                                    textBox1.Text = String.Empty;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (label3.Text == "V")
                    {
                        textBox1.Clear();
                        if (label4.Text == "A")
                        {
                            textBox1.Clear();
                            if (label5.Text == "M")
                            {
                                textBox1.Clear();
                                if (label6.Text == "P")
                                {
                                    textBox1.Clear();
                                    if (label7.Text == "I")
                                    {
                                        textBox1.Clear();
                                        if (label8.Text == "R")
                                        {
                                            textBox1.Clear();
                                            button1.Enabled = true;
                                            textBox1.Enabled = true;
                                            MessageBox.Show("Tebrikler Oyunu Kazandınız!");
                                            label3.Text = "_";
                                            label4.Text = "_";
                                            label5.Text = "_";
                                            label6.Text = "_";
                                            label7.Text = "_";
                                            label8.Text = "_";
                                            textBox1.Text = String.Empty;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (secim == "KALEM")
                        {
                            string kelime3 = "KALEM";
                            textBox1.Text = textBox1.Text.ToUpper();
                            if (textBox1.Text == "")
                            {
                                MessageBox.Show("Lütfen Bir Harf Girin");
                            }
                            if (textBox1.Text == "KALEM".ToString())
                            {
                                MessageBox.Show("TEBRİKLER TAM DOĞRU BİLDİNİZ");
                                label3.Text = "_";
                                label4.Text = "_";
                                label5.Text = "_";
                                label6.Text = "_";
                                label7.Text = "_";
                                label8.Text = "_";
                                textBox1.Text = String.Empty;
                            }
                            else
                            {
                                if (textBox1.Text == kelime3[0].ToString())
                                {
                                    label3.Text = "K";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime3[1].ToString())
                                    {
                                        label4.Text = "A";
                                    }
                                    else
                                    {
                                        if (textBox1.Text == kelime3[2].ToString())
                                        {
                                            label5.Text = "L";
                                        }
                                        else
                                        {
                                            if (textBox1.Text == kelime3[3].ToString())
                                            {
                                                label6.Text = "E";
                                            }
                                            else
                                            {
                                                if (textBox1.Text == kelime3[4].ToString())
                                                {
                                                    label7.Text = "M";
                                                }
                                                else
                                                {
                                                    hak++;
                                                    if (hak == 1)
                                                    {
                                                        pictureBox1.Visible = true;
                                                        MessageBox.Show("KALAN HAK : 5", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                    }
                                                    else if (hak == 2)
                                                    {
                                                        pictureBox3.Visible = true;
                                                        MessageBox.Show("KALAN HAK :4", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                    }
                                                    else if (hak == 3)
                                                    {
                                                        pictureBox5.Visible = true;
                                                        MessageBox.Show("KALAN HAK : 3", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                    }
                                                    else if (hak == 4)
                                                    {
                                                        pictureBox2.Visible = true;
                                                        MessageBox.Show("KALAN HAK : 2", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                    }
                                                    else if (hak == 5)
                                                    {
                                                        pictureBox6.Visible = true;
                                                        MessageBox.Show("KALAN HAK : 1", "Maalesef Yazdığınız Harf Bulunmamakta");
                                                    }
                                                    else if (hak == 6)
                                                    {
                                                        pictureBox4.Visible = true;
                                                        button1.Enabled = true;
                                                        textBox1.Enabled = true;
                                                        MessageBox.Show("KALAN HAK:0!!", "Oyunu Kaybettiniz!");
                                                        MessageBox.Show("KALEM", "Cevap");
                                                        label3.Text = "_";
                                                        label4.Text = "_";
                                                        label5.Text = "_";
                                                        label6.Text = "_";
                                                        label7.Text = "_";
                                                        label8.Text = "_";
                                                        textBox1.Text = String.Empty;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (label3.Text == "K")
                            {
                                textBox1.Clear();
                                if (label4.Text == "A")
                                {
                                    textBox1.Clear();
                                    if (label5.Text == "L")
                                    {
                                        textBox1.Clear();
                                        if (label6.Text == "E")
                                        {
                                            textBox1.Clear();
                                            if (label7.Text == "M")
                                            {
                                                textBox1.Clear();
                                                button1.Enabled = true;
                                                textBox1.Enabled = true;
                                                MessageBox.Show("Tebrikler Oyunu Kazandınız!");
                                                label3.Text = "_";
                                                label4.Text = "_";
                                                label5.Text = "_";
                                                label6.Text = "_";
                                                label7.Text = "_";
                                                label8.Text = "_";
                                                textBox1.Text = String.Empty;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void kalem ()
        {

        }
    }
}
