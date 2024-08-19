using System;
using System.IO;
using System.Windows.Forms;

namespace LytNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DosyalariListele();
            AyarDosyasiniOku();
        }


        private void DosyalariListele()
        {

            flowLayoutPanelDosyalar.Controls.Clear(); // Mevcut kontrolleri temizle

            string dataFolder = Path.Combine(Application.StartupPath, "data");
            if (Directory.Exists(dataFolder))
            {
                // Dosya listesini alma ve en son de�i�tirilme tarihine g�re s�ralama
                var dosyalar = new DirectoryInfo(dataFolder).GetFiles("*.txt")
                                                             .OrderByDescending(f => f.LastWriteTime);

                foreach (var dosya in dosyalar)
                {
                    string dosyaAdi = Path.GetFileNameWithoutExtension(dosya.Name);
                    Button btnDosya = new Button();
                    btnDosya.Name = dosyaAdi; // Butonun ad�n� dosya ad�yla ayarlay�n
                    btnDosya.Text = dosyaAdi;

                    // Button y�ksekli�ini art�r�n
                    AyarDosyasiniOku();
                    btnDosya.ForeColor = Color.White; // Yaz� rengini beyaz yapmak i�in
                   


                    // Buttonlar aras�nda 5 piksel bo�luk b�rak�n
                    flowLayoutPanelDosyalar.Controls.Add(btnDosya);

                    // Butona t�klama olay�n� ekle
                    btnDosya.Click += (sender, e) => DosyaButonu_Click(dosya.FullName);
                }

                // FlowLayoutPanel'in d�zenini dikey olarak ayarlay�n
                flowLayoutPanelDosyalar.FlowDirection = FlowDirection.TopDown;
                // WrapContents �zelli�ini true olarak ayarlayarak butonlar�n alt alta ge�mesini sa�lay�n
                flowLayoutPanelDosyalar.WrapContents = false;
                // ��erik s��mad���nda otomatik olarak kayd�rma �ubuklar�n� g�r�nt�le
                flowLayoutPanelDosyalar.AutoScroll = true;
                AyarDosyasiniOku();
            }
        }


        private void DosyalariListele2()
        {

            string dataFolder = Path.Combine(Application.StartupPath, "data");
            if (Directory.Exists(dataFolder))
            {
                // Dosya listesini alma ve en son de�i�tirilme tarihine g�re s�ralama
                var dosyalar = new DirectoryInfo(dataFolder).GetFiles("*.txt")
                                                             .OrderByDescending(f => f.LastWriteTime);

                foreach (var dosya in dosyalar)
                {
                    string dosyaAdi = Path.GetFileNameWithoutExtension(dosya.Name);
                    Button btnDosya = new Button();
                    btnDosya.Name = dosyaAdi; // Butonun ad�n� dosya ad�yla ayarlay�n
                    btnDosya.Text = dosyaAdi;

                    // Button y�ksekli�ini art�r�n

                    AyarDosyasiniOku();
                    btnDosya.ForeColor = Color.White; 

                    flowLayoutPanelDosyalar.Controls.Add(btnDosya);

                    // Butona t�klama olay�n� ekle
                    btnDosya.Click += (sender, e) => DosyaButonu_Click(dosya.FullName);
                }

                // FlowLayoutPanel'in d�zenini dikey olarak ayarlay�n
                flowLayoutPanelDosyalar.FlowDirection = FlowDirection.TopDown;
                // WrapContents �zelli�ini true olarak ayarlayarak butonlar�n alt alta ge�mesini sa�lay�n
                flowLayoutPanelDosyalar.WrapContents = false;
                // ��erik s��mad���nda otomatik olarak kayd�rma �ubuklar�n� g�r�nt�le
                flowLayoutPanelDosyalar.AutoScroll = true;

            }
        }

        // Butona t�klan�nca �al��acak metot
        private void DosyaButonu_Click(string dosyaYolu)
        {
            string baslik = Path.GetFileNameWithoutExtension(dosyaYolu);
            string icerik = File.ReadAllText(dosyaYolu);

            not_ekle notEkleForm = new not_ekle();
            notEkleForm.basliktxt.Text = baslik; // Ba�l�k alan�n� doldur
            notEkleForm.iceriktxt.Text = icerik; // ��erik alan�n� doldur

            // Not ekleme formunu ana formun �n�nde g�ster
            notEkleForm.ShowDialog();

            // Form kapat�ld���nda dosyalar� yeniden listele
            DosyalariListele();
        }



        private void ekle_Click(object sender, EventArgs e)
        {

        }

        private void NotEkleForm_Load(object sender, EventArgs e)
        {
            DosyalariListele(); // not_ekle formu y�klendi�inde DosyalariListele1 fonksiyonunu �a��r�n
          
        }

        private void NotEkleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DosyalariListele2();
            AyarDosyasiniOku();
        }

        private void NotEkleForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DosyalariListele(); // not_ekle2 formu kapat�ld���nda dosyalar� yeniden listele
            AyarDosyasiniOku();
        }

       


        private void ayarlar_Click(object sender, EventArgs e)
        {
            ayarlar ayarlarForm = new ayarlar();
            ayarlarForm.Show();
            AyarDosyasiniOku();
        }

        private void flowLayoutPanelDosyalar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            DosyalariListele();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            not_ekle2 notEkleForm2 = new not_ekle2();
            notEkleForm2.FormClosed += NotEkleForm2_FormClosed; // not_ekle2 formu kapat�ld���nda
            notEkleForm2.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ayarlar ayarlarForm = new ayarlar();
            ayarlarForm.Show();
            AyarDosyasiniOku();
        }
        private void ayarlarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DosyalariListele();
            AyarDosyasiniOku();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void AyarDosyasiniOku()
        {
            string dataFolder = Path.Combine(Application.StartupPath, "data");
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder); // data klas�r�n� olu�tur
            }
            string settingsDosyaYolu = Path.Combine(Application.StartupPath, "data", "settings.lyt");
            int height = 100;
            int width = 1250;

            // settings.lyt dosyas�n� oku
            if (File.Exists(settingsDosyaYolu))
            {
                string[] lines = File.ReadAllLines(settingsDosyaYolu);
                if (lines.Length >= 2)
                {
                    int.TryParse(lines[0], out height);
                    int.TryParse(lines[1], out width);
                }
            }
            else
            {
                // Dosya yoksa varsay�lan de�erleri kullan ve dosyay� olu�tur
                File.WriteAllText(settingsDosyaYolu, $"{height}\n{width}");
            }

            // Butonlar� ayarla
            AyarlaButonBoyutu(height, width);
        }

        private void AyarlaButonBoyutu(int height, int width)
        {
            // FlowLayoutPanel i�indeki butonlar�n boyutlar�n� ayarla
            foreach (Control control in flowLayoutPanelDosyalar.Controls)
            {
                if (control is Button)
                {
                    Button btnDosya = (Button)control;
                    btnDosya.Height = height;
                    btnDosya.Width = width;
                }
            }
        }



    }
}
