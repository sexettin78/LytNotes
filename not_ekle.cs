using System;
using System.IO;
using System.Windows.Forms;

namespace LytNotes
{
    public partial class not_ekle : Form
    {
        public not_ekle()
        {
            InitializeComponent();
        }
      
        // Dosyanın değiştirilme tarihini Label3'e yazdıran metot
        private void DosyaDegistirmeTarihiniYazdir(string dosyaAdi)
        {
            string dosyaYolu = Path.Combine(Application.StartupPath, "data", $"{dosyaAdi}.txt");

            if (File.Exists(dosyaYolu))
            {
                DateTime degisimTarihi = File.GetLastWriteTime(dosyaYolu);
                label3.Text = $"Dosya Değiştirme Tarihi: {degisimTarihi}";
            }
            else
            {
                label3.Text = "Dosya bulunamadı.";
            }
        }

        // Kaydet butonunun tıklanma olayı
        private void kaydet_Click(object sender, EventArgs e)
        {
            string baslik = basliktxt.Text;
            string icerik = iceriktxt.Text;

            if (!string.IsNullOrEmpty(baslik) && !string.IsNullOrEmpty(icerik))
            {
                string dataFolder = Path.Combine(Application.StartupPath, "data");
                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }

                string dosyaAdi = $"{baslik}.txt";
                string dosyaYolu = Path.Combine(dataFolder, dosyaAdi);

                using (StreamWriter writer = new StreamWriter(dosyaYolu))
                {
                    writer.Write(icerik);
                }

                MessageBox.Show("Not başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen başlık ve içerik alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sil butonunun tıklanma olayı
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu notu silmek istediğinizden emin misiniz?", "Notu Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string dosyaAdi = basliktxt.Text;
                string dosyaYolu = Path.Combine(Application.StartupPath, "data", $"{dosyaAdi}.txt");

                try
                {
                    File.Delete(dosyaYolu);
                    MessageBox.Show("Not başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Form yüklendiğinde
        private void not_ekle_Load(object sender, EventArgs e)
        {
            iceriktxt.Focus();
            // Dosyanın değiştirilme tarihini Label3'e yazdır
            DosyaDegistirmeTarihiniYazdir(basliktxt.Text);
            
        }
    }
}
