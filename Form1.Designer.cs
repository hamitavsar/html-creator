namespace SEO
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dosyaYolu = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dosyaIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metaAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.metaKeyword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metaYonlendirme = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.anahtarKelime = new System.Windows.Forms.TextBox();
            this.titleEK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dosyaAdi = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.firmaAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.indexOlustur = new System.Windows.Forms.Button();
            this.indexItems = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yolu";
            // 
            // dosyaYolu
            // 
            this.dosyaYolu.Location = new System.Drawing.Point(142, 34);
            this.dosyaYolu.Name = "dosyaYolu";
            this.dosyaYolu.Size = new System.Drawing.Size(274, 20);
            this.dosyaYolu.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(183, 550);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 56);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İndex İçeriği";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dosya Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sayfaları Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dosyaIsmi
            // 
            this.dosyaIsmi.Location = new System.Drawing.Point(142, 3);
            this.dosyaIsmi.Name = "dosyaIsmi";
            this.dosyaIsmi.Size = new System.Drawing.Size(142, 20);
            this.dosyaIsmi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dosya Adı";
            // 
            // metaAciklama
            // 
            this.metaAciklama.Location = new System.Drawing.Point(8, 271);
            this.metaAciklama.Multiline = true;
            this.metaAciklama.Name = "metaAciklama";
            this.metaAciklama.Size = new System.Drawing.Size(647, 24);
            this.metaAciklama.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Meta Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1085, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anahtar Kelimeler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Meta Keyword";
            // 
            // metaKeyword
            // 
            this.metaKeyword.Location = new System.Drawing.Point(8, 338);
            this.metaKeyword.Multiline = true;
            this.metaKeyword.Name = "metaKeyword";
            this.metaKeyword.Size = new System.Drawing.Size(647, 24);
            this.metaKeyword.TabIndex = 14;
            this.metaKeyword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = " ";
            // 
            // metaYonlendirme
            // 
            this.metaYonlendirme.Location = new System.Drawing.Point(8, 406);
            this.metaYonlendirme.Multiline = true;
            this.metaYonlendirme.Name = "metaYonlendirme";
            this.metaYonlendirme.Size = new System.Drawing.Size(647, 24);
            this.metaYonlendirme.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(968, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(329, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Anahtar Kelimeleri Girin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(968, 75);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(329, 33);
            this.textBox4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1071, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Anahtar Kelime Girişi";
            // 
            // anahtarKelime
            // 
            this.anahtarKelime.Location = new System.Drawing.Point(141, 92);
            this.anahtarKelime.Name = "anahtarKelime";
            this.anahtarKelime.Size = new System.Drawing.Size(156, 20);
            this.anahtarKelime.TabIndex = 21;
            // 
            // titleEK
            // 
            this.titleEK.Location = new System.Drawing.Point(141, 118);
            this.titleEK.Name = "titleEK";
            this.titleEK.Size = new System.Drawing.Size(156, 20);
            this.titleEK.TabIndex = 22;
            this.titleEK.TextChanged += new System.EventHandler(this.titleEK_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Anahtar Kelime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Dosya Adı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".txt",
            ".html"});
            this.comboBox1.Location = new System.Drawing.Point(467, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(968, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(329, 420);
            this.listBox2.TabIndex = 29;
            // 
            // dosyaAdi
            // 
            this.dosyaAdi.Location = new System.Drawing.Point(141, 144);
            this.dosyaAdi.Name = "dosyaAdi";
            this.dosyaAdi.Size = new System.Drawing.Size(320, 24);
            this.dosyaAdi.TabIndex = 30;
            this.dosyaAdi.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Firma Adı";
            // 
            // firmaAdi
            // 
            this.firmaAdi.Location = new System.Drawing.Point(142, 63);
            this.firmaAdi.Name = "firmaAdi";
            this.firmaAdi.Size = new System.Drawing.Size(155, 20);
            this.firmaAdi.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(294, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Meta Yönlendirme";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "<meta charset=\"UTF-8\">";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "<meta name=\"description\" content=\"";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(217, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "\">";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(221, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "<meta http-equiv=\"refresh\" content=\"0;URL=";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(266, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "\">";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(327, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "<meta name=\"keywords\" content=\"";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(509, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "\">";
            this.label20.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1320, 638);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.dosyaYolu);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dosyaIsmi);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.metaAciklama);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.firmaAdi);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.metaKeyword);
            this.tabPage1.Controls.Add(this.dosyaAdi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.metaYonlendirme);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.titleEK);
            this.tabPage1.Controls.Add(this.anahtarKelime);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1312, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anahtar Kelime ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.indexOlustur);
            this.tabPage2.Controls.Add(this.indexItems);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1312, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İndex Oluşturma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Kodlara müdahale et";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // indexOlustur
            // 
            this.indexOlustur.Location = new System.Drawing.Point(420, 547);
            this.indexOlustur.Name = "indexOlustur";
            this.indexOlustur.Size = new System.Drawing.Size(224, 28);
            this.indexOlustur.TabIndex = 6;
            this.indexOlustur.Text = "İndex Oluştur";
            this.indexOlustur.UseVisualStyleBackColor = true;
            this.indexOlustur.Click += new System.EventHandler(this.indexOlustur_Click);
            // 
            // indexItems
            // 
            this.indexItems.Enabled = false;
            this.indexItems.FormattingEnabled = true;
            this.indexItems.Location = new System.Drawing.Point(420, 82);
            this.indexItems.Name = "indexItems";
            this.indexItems.Size = new System.Drawing.Size(465, 446);
            this.indexItems.TabIndex = 2;
            this.indexItems.SelectedIndexChanged += new System.EventHandler(this.indexItems_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(891, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(403, 540);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(11, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 540);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(420, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "<h2 class=\"mb-4\"> <a href=\"";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(573, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "\">";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(719, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "</a> </h2>";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(421, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(403, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Alt tarafı sırasıyla doldurmayı unutma! 1. kutu  [<a href=\"] 2. kutu  [\">]  3. ku" +
    "tu  [</a>]";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dosyaYolu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox dosyaIsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox metaAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox metaYonlendirme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox metaKeyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox titleEK;
        private System.Windows.Forms.TextBox anahtarKelime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox dosyaAdi;
        private System.Windows.Forms.TextBox firmaAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox indexItems;
        private System.Windows.Forms.Button indexOlustur;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button4;
    }
}

