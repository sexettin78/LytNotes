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
                // Dosya listesini alma ve en son deðiþtirilme tarihine göre sýralama
                var dosyalar = new DirectoryInfo(dataFolder).GetFiles("*.txt")
                                                             .OrderByDescending(f => f.LastWriteTime);

                foreach (var dosya in dosyalar)
                {
                    string dosyaAdi = Path.GetFileNameWithoutExtension(dosya.Name);
                    Button btnDosya = new Button();
                    btnDosya.Name = dosyaAdi; // Butonun adýný dosya adýyla ayarlayýn
                    btnDosya.Text = dosyaAdi;

                    // Button yüksekliðini artýrýn
                    AyarDosyasiniOku();
                    btnDosya.ForeColor = Color.White; // Yazý rengini beyaz yapmak için
                   


                    // Buttonlar arasýnda 5 piksel boþluk býrakýn
                    flowLayoutPanelDosyalar.Controls.Add(btnDosya);

                    // Butona týklama olayýný ekle
                    btnDosya.Click += (sender, e) => DosyaButonu_Click(dosya.FullName);
                }

                // FlowLayoutPanel'in düzenini dikey olarak ayarlayýn
                flowLayoutPanelDosyalar.FlowDirection = FlowDirection.TopDown;
                // WrapContents özelliðini true olarak ayarlayarak butonlarýn alt alta geçmesini saðlayýn
                flowLayoutPanelDosyalar.WrapContents = false;
                // Ýçerik sýðmadýðýnda otomatik olarak kaydýrma çubuklarýný görüntüle
                flowLayoutPanelDosyalar.AutoScroll = true;
                AyarDosyasiniOku();
            }
        }


        private void DosyalariListele2()
        {

            string dataFolder = Path.Combine(Application.StartupPath, "data");
            if (Directory.Exists(dataFolder))
            {
                // Dosya listesini alma ve en son deðiþtirilme tarihine göre sýralama
                var dosyalar = new DirectoryInfo(dataFolder).GetFiles("*.txt")
                                                             .OrderByDescending(f => f.LastWriteTime);

                foreach (var dosya in dosyalar)
                {
                    string dosyaAdi = Path.GetFileNameWithoutExtension(dosya.Name);
                    Button btnDosya = new Button();
                    btnDosya.Name = dosyaAdi; // Butonun adýný dosya adýyla ayarlayýn
                    btnDosya.Text = dosyaAdi;

                    // Button yüksekliðini artýrýn

                    AyarDosyasiniOku();
                    btnDosya.ForeColor = Color.White; 

                    flowLayoutPanelDosyalar.Controls.Add(btnDosya);

                    // Butona týklama olayýný ekle
                    btnDosya.Click += (sender, e) => DosyaButonu_Click(dosya.FullName);
                }

                // FlowLayoutPanel'in düzenini dikey olarak ayarlayýn
                flowLayoutPanelDosyalar.FlowDirection = FlowDirection.TopDown;
                // WrapContents özelliðini true olarak ayarlayarak butonlarýn alt alta geçmesini saðlayýn
                flowLayoutPanelDosyalar.WrapContents = false;
                // Ýçerik sýðmadýðýnda otomatik olarak kaydýrma çubuklarýný görüntüle
                flowLayoutPanelDosyalar.AutoScroll = true;

            }
        }

        // Butona týklanýnca çalýþacak metot
        private void DosyaButonu_Click(string dosyaYolu)
        {
            string baslik = Path.GetFileNameWithoutExtension(dosyaYolu);
            string icerik = File.ReadAllText(dosyaYolu);

            not_ekle notEkleForm = new not_ekle();
            notEkleForm.basliktxt.Text = baslik; // Baþlýk alanýný doldur
            notEkleForm.iceriktxt.Text = icerik; // Ýçerik alanýný doldur

            // Not ekleme formunu ana formun önünde göster
            notEkleForm.ShowDialog();

            // Form kapatýldýðýnda dosyalarý yeniden listele
            DosyalariListele();
        }



        private void ekle_Click(object sender, EventArgs e)
        {

        }

        private void NotEkleForm_Load(object sender, EventArgs e)
        {
            DosyalariListele(); // not_ekle formu yüklendiðinde DosyalariListele1 fonksiyonunu çaðýrýn
          
        }

        private void NotEkleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DosyalariListele2();
            AyarDosyasiniOku();
        }

        private void NotEkleForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DosyalariListele(); // not_ekle2 formu kapatýldýðýnda dosyalarý yeniden listele
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
            notEkleForm2.FormClosed += NotEkleForm2_FormClosed; // not_ekle2 formu kapatýldýðýnda
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
                Directory.CreateDirectory(dataFolder); // data klasörünü oluþtur
            }
            string settingsDosyaYolu = Path.Combine(Application.StartupPath, "data", "settings.lyt");
            int height = 100;
            int width = 1250;

            // settings.lyt dosyasýný oku
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
                // Dosya yoksa varsayýlan deðerleri kullan ve dosyayý oluþtur
                File.WriteAllText(settingsDosyaYolu, $"{height}\n{width}");
            }

            // Butonlarý ayarla
            AyarlaButonBoyutu(height, width);
        }

        private void AyarlaButonBoyutu(int height, int width)
        {
            // FlowLayoutPanel içindeki butonlarýn boyutlarýný ayarla
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
