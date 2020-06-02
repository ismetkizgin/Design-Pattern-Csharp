using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPictures();
            Buttons(false);
            radioButton2.Checked = true;
        }
        int[] sayilar = new int[3];
        string[] hayvanTurkish = new string[] { "at", "ayi", "esek", "karinca", "kedi", "kopek", "kus", "maymun", "ordek", "sincap", "tavsan", "tavuk", "yilan", "zurafa" };
        string[] hayvanEnglish = new string[] { "horse", "bear", "donkey", "ant", "cat", "dog", "bird", "monkey", "duck", "squirrel", "rabbit", "chicken", "snake", "giraffe" };
        string[] OrginalAnimals = new string[3];
        private void LoadPictures()
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                sayilar[i] = random.Next(14);
                for (int k = 0; k < i; k++)
                {
                    if (sayilar[k] == sayilar[i])
                        i--;
                }
                
            }
            for (int i = 0; i < 3; i++)
            {
                string imageLocation = "";
                imageLocation= Application.StartupPath + "\\Resimler\\"+hayvanTurkish[sayilar[i]]+".png";
                OrginalAnimals[i]=hayvanEnglish[sayilar[i]];
                if (i + 1 == 1)
                {
                    pictureBox2.ImageLocation = imageLocation;
                }
                else if (i + 1 == 2)
                {
                    pictureBox3.ImageLocation = imageLocation;
                }
                else
                {
                    pictureBox4.ImageLocation = imageLocation;
                }
            }
        }

        private void tbxEnable(bool kontrol)
        {
            textEdit1.Enabled = kontrol;
            textEdit2.Enabled = kontrol;
            textEdit3.Enabled = kontrol;
        }

        private void cbxEnable(bool kontrol)
        {
            comboBoxEdit1.Enabled = kontrol;
            comboBoxEdit2.Enabled = kontrol;
            comboBoxEdit3.Enabled = kontrol;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            cbxEnable(false);
            tbxEnable(true);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            cbxEnable(true);
            tbxEnable(false);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int dogruSayisi = 0;
            if (radioButton1.Checked==true)
            {
                string[] setHayvanlar = new string[] { textEdit1.Text, textEdit2.Text, textEdit3.Text };
                dogruSayisi=kontrol.CokluKontrol(setHayvanlar, OrginalAnimals);
            }
            else
            {
                string[] setHayvanlar = new string[] { comboBoxEdit1.SelectedItem.ToString(), comboBoxEdit2.SelectedItem.ToString(), comboBoxEdit3.SelectedItem.ToString() };
                dogruSayisi = kontrol.CokluKontrol(setHayvanlar, OrginalAnimals);
            }
            lblPuan.Text = ""+(Convert.ToInt32(lblPuan.Text)+ (dogruSayisi * 10));
            LoadPictures();
            Temizle();
            int ToplamPuan = Convert.ToInt32(lblPuan.Text);
            if (ToplamPuan>=50)
            {
                MessageBox.Show("TEBRİKLER!!!\n"+ToplamPuan+" puana ulaştınız!\nİsterseniz eğitime devam edebilirsiniz!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Temizle()
        {
            comboBoxEdit1.Text = "";
            comboBoxEdit2.Text = "";
            comboBoxEdit3.Text = "";
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            pictureBoxKontrol1.Image = null;
            pictureBoxKontrol2.Image = null;
            pictureBoxKontrol3.Image = null;
            if (radioButton1.Checked==true)
            {
                textEdit1.Enabled = true;
                textEdit2.Enabled = true;
                textEdit3.Enabled = true;
            }
            else
            {
                comboBoxEdit1.Enabled = true;
                comboBoxEdit2.Enabled = true;
                comboBoxEdit3.Enabled = true;
            }
        }

        Kontrol kontrol = new Kontrol();
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                if (kontrol.TekliKontrol(textEdit1.Text, OrginalAnimals[0]) == "dogru")
                  pictureBoxKontrol1.ImageLocation= Application.StartupPath + "\\Resimler\\dogru.png";
                else
                    pictureBoxKontrol1.ImageLocation = Application.StartupPath + "\\Resimler\\Yanlis.png";
            }
            else
            {
                if (kontrol.TekliKontrol(comboBoxEdit1.SelectedItem.ToString(), OrginalAnimals[0]) == "dogru")
                    pictureBoxKontrol1.ImageLocation = Application.StartupPath + "\\Resimler\\dogru.png";
                else
                    pictureBoxKontrol1.ImageLocation = Application.StartupPath + "\\Resimler\\Yanlis.png";
            }
            comboBoxEdit1.Enabled = false;
            textEdit1.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (kontrol.TekliKontrol(textEdit2.Text, OrginalAnimals[1]) == "dogru")
                    pictureBoxKontrol2.ImageLocation = Application.StartupPath + "\\Resimler\\dogru.png";
                else
                    pictureBoxKontrol2.ImageLocation = Application.StartupPath + "\\Resimler\\Yanlis.png";
            }
            else
            {
                if (kontrol.TekliKontrol(comboBoxEdit2.SelectedItem.ToString(), OrginalAnimals[1]) == "dogru")
                    pictureBoxKontrol2.ImageLocation = Application.StartupPath + "\\Resimler\\dogru.png";
                else
                    pictureBoxKontrol2.ImageLocation = Application.StartupPath + "\\Resimler\\Yanlis.png";
            }
            comboBoxEdit2.Enabled = false;
            textEdit2.Enabled = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (kontrol.TekliKontrol(textEdit3.Text, OrginalAnimals[2]) == "dogru")
                    pictureBoxKontrol3.ImageLocation = Application.StartupPath + "\\Resimler\\dogru.png";
                else
                    pictureBoxKontrol3.ImageLocation = Application.StartupPath + "\\Resimler\\Yanlis.png";
            }
            else
            {
                if (kontrol.TekliKontrol(comboBoxEdit3.SelectedItem.ToString(), OrginalAnimals[2]) == "dogru")
                    pictureBoxKontrol3.ImageLocation = Application.StartupPath + "\\Resimler\\dogru.png";
                else
                    pictureBoxKontrol3.ImageLocation = Application.StartupPath + "\\Resimler\\Yanlis.png";
            }
            comboBoxEdit3.Enabled = false;
            textEdit3.Enabled = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oyun Esnasında Seçiminizi Değiştiremeyeceksiniz! \nOnaylıyor musunuz?", "Bilgi Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Buttons(true);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                pictureBox10.Enabled = false;
            }
        }

        private void Buttons(bool kontrol)
        {
            pictureBox6.Enabled = kontrol;
            pictureBox7.Enabled = kontrol;
            pictureBox8.Enabled = kontrol;
            pictureBox9.Enabled = kontrol;
        }
    }
}
