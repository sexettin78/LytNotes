using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LytNotes
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            // Ayarları dosyadan oku ve textbox'lara yaz
            AyarlariOkuVeYaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki verileri settings.lyt dosyasına yaz
            AyarlariKaydet();
        }

        private void AyarlariOkuVeYaz()
        {
            string settingsDosyaYolu = Path.Combine(Application.StartupPath, "data", "settings.lyt");

            // settings.lyt dosyasını oku
            if (File.Exists(settingsDosyaYolu))
            {
                string[] lines = File.ReadAllLines(settingsDosyaYolu);
                if (lines.Length >= 2)
                {
                    height_txt.Text = lines[0]; // İlk satır yükseklik
                    width_txt.Text = lines[1]; // İkinci satır genişlik
                }
            }
        }

        private void AyarlariKaydet()
        {
            if (width_txt.Text==""||height_txt.Text=="") {
                MessageBox.Show("Veri giriş yerleri boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else { 
            string settingsDosyaYolu = Path.Combine(Application.StartupPath, "data", "settings.lyt");

            // TextBox'lardaki verileri settings.lyt dosyasına yaz
            string[] lines = { height_txt.Text, width_txt.Text };
            File.WriteAllLines(settingsDosyaYolu, lines);

            MessageBox.Show("Ayarlar başarıyla kaydedildi.\nAyarların uygulanması için ana ekranda herhangi bir eylem gerçekleştiriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
        }

        private void width_txt_TextChanged(object sender, EventArgs e)
        {
            int widthAyari;
            if (!int.TryParse(width_txt.Text, out widthAyari))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                width_txt.Text = "";
            }
            else if (widthAyari == 0)
            {
                MessageBox.Show("Genişlik değeri sıfır olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                width_txt.Text = "";
            }


        }

        private void height_txt_TextChanged(object sender, EventArgs e)
        {
            int heightAyari;
            if (!int.TryParse(height_txt.Text, out heightAyari))
            {
                MessageBox.Show("Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                height_txt.Text = "";
            }

            else if (heightAyari == 0)
            {
                MessageBox.Show("Genişlik değeri sıfır olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                height_txt.Text = "";
            }
        }
    }
}
