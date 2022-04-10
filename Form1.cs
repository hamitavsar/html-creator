using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SEO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Klasor =dosyaIsmi.Text;
            string klasor_yolu= dosyaYolu.Text;
            
            if (Klasor == "")
            {
                MessageBox.Show("Klasör ismi boş bırakılamaz");
            }
            else
            {
               Directory.CreateDirectory(klasor_yolu + Klasor );
                MessageBox.Show(Klasor +";"+ "Başarılı bir şekilde oluşturuldu");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firmaAdi.Text == "" && anahtarKelime.Text == "" && titleEK.Text == "" && metaAciklama.Text == "" && metaKeyword.Text == "" && metaYonlendirme.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ VE DOĞRU DOLDURUNUZ");

            }
            else if (comboBox1.Text =="")
            {
                MessageBox.Show("KAYIT DOSYA UZANTISINI SEÇİN!");
            }
            else
            {
                kelimeDizesi();
            }
        }

        public  void dosyayaYaz()
        {
            string dosya_yolu = dosyaYolu.Text + dosyaIsmi.Text + dosyaAdi.Text + comboBox1.Text;

            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //string iceAktar;
            //  iceAktar = Convert.ToString(listBox1.Text);
            foreach (var iceAktar in listBox1.Items)
            {

                sw.WriteLine(iceAktar);
            }
            sw.Flush();
            sw.Close();
            fs.Close();

          
        }

        public void indexKayit()
        {
            dosyaAdi.Text = "";
            dosyaAdi.Text = "index";
            string dosya_yolu = dosyaYolu.Text + dosyaIsmi.Text + dosyaAdi.Text +comboBox1.Text;

            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //string iceAktar;
            //  iceAktar = Convert.ToString(listBox1.Text);
            foreach (var iceAktar in indexItems.Items)
            {

                sw.WriteLine(iceAktar);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            dosyaAdi.Text = "";
        }

        public void kelimeDizesi()
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            { 
                string yazi = listBox2.Items[i].ToString() + "-" + anahtarKelime.Text;
                yazi = yazi.ToLower();

                yazi = yazi.Replace('ö', 'o');
                yazi = yazi.Replace('ü', 'u');
                yazi = yazi.Replace('ğ', 'g');
                yazi = yazi.Replace('ş', 's');
                yazi = yazi.Replace('ı', 'i');

                // listBox1.Items.Add(listBox2.Items[i].ToString() + "-" + anahtarKelime.Text);
                dosyaAdi.Text = yazi;
                listBox1.Items.Add("<HTML>"+"<head>"+"<title>" +listBox2.Items[i].ToString() + " "+ titleEK.Text + " "+"|" + " " + firmaAdi.Text +"</title>");
                listBox1.Items.Add(label14.Text);
                listBox1.Items.Add(label15.Text + " "+ metaAciklama.Text + " " + listBox2.Items[i].ToString() + " " + titleEK.Text + "  " + "|" + " " + firmaAdi.Text + label16.Text);
                listBox1.Items.Add(label19.Text + "," + metaKeyword.Text + "," + listBox2.Items[i].ToString() + " " + titleEK.Text + " " + "," + firmaAdi.Text + label20.Text);
                listBox1.Items.Add(label17.Text + metaYonlendirme.Text + label18.Text+"</head>"+"</HTML>" );
                dosyayaYaz();

                listBox1.Items.Clear();
            
            }
            MessageBox.Show("İşlem Başarılı " + dosyaYolu.Text + dosyaIsmi.Text + "Klasörden Alabilirsin.");

        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            /*
            if(openFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                string directory = "C:\\Folder";
                DirectoryInfo dInfo = new DirectoryInfo(directory);
                string dFullName = dInfo.FullName;
                textBox1.Text = Convert.ToString(dFullName);
            } */


            /*  saveFileDialog1.InitialDirectory = "C:\\";
              saveFileDialog1.ShowDialog();
              StreamWriter yol = new StreamWriter(saveFileDialog1.FileName);
              textBox1.Text = Convert.ToString(yol);
              yol.Close(); */



            
            /*  if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 StreamWriter dosyaYolu = new StreamWriter(saveFileDialog1.FileName);
                 dosyaYolu.WriteLine(textBox1.Text);
                 dosyaYolu.Close();
                  string yol = openFileDialog1.FileName.ToString();
                   Path.GetDirectoryName(yol);
                   textBox1.Text = yol; 
             } */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                {

                MessageBox.Show("Sayfa Kelimlerini Boş Bırakamazsın!");
               
            }
            else {
                anahtarKelimeGiris();
            }

        }

        public void anahtarKelimeGiris()
        {
            string[] kelimeler;

            kelimeler = textBox4.Text.Split();

            for (int i = 0; i < kelimeler.Length; i++)
            {
                listBox2.Items.Add(kelimeler[i]);

            }
            

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleEK_TextChanged(object sender, EventArgs e)
        {

        } 

        private void indexOlustur_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                indexItems.Items.Add(textBox1.Text);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    string yazi = listBox2.Items[i].ToString() + "-" + anahtarKelime.Text;
                    yazi = yazi.ToLower();
                    yazi = yazi.Replace('ö', 'o');
                    yazi = yazi.Replace('ü', 'u');
                    yazi = yazi.Replace('ğ', 'g');
                    yazi = yazi.Replace('ş', 's');
                    yazi = yazi.Replace('ı', 'i');
                    yazi = yazi.Replace('ç', 'c');
                    indexItems.Items.Add(textBox3.Text + yazi + comboBox1.Text + textBox5.Text + " " + listBox2.Items[i].ToString() + " " + titleEK.Text + " " + "|" + " " + firmaAdi.Text + textBox6.Text);

                }
                indexItems.Items.Add(textBox2.Text);
                indexKayit();

                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Dosya Uzantısını belirleyin!");
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult secenek = MessageBox.Show("HTML Kodlara müdahele etmek istediğine emin misin?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox5.Enabled = true;
                    textBox6.Enabled = true;
                    indexItems.Enabled = true;
                }
            }
        }

        private void indexItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            indexItems.Items.Clear();
        }
    }
}
