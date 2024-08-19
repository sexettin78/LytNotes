using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LytNotes
{
    public partial class not_ekle2 : Form
    {
        public not_ekle2()
        {
            InitializeComponent();
        }


        private void kaydet_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kaydet_Click_1(object sender, EventArgs e)
        {
            string baslik = basliktxt.Text;
            string icerik = iceriktxt.Text;

            if (!string.IsNullOrEmpty(baslik) && !string.IsNullOrEmpty(icerik))
            {
                // Uygulamanın çalışma dizini içinde "data" klasörünü kontrol et, yoksa oluştur
                string dataFolder = Path.Combine(Application.StartupPath, "data");
                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }

                // Notun kaydedileceği dosyanın adını oluştur
                string dosyaAdi = $"{baslik}.txt";
                string dosyaYolu = Path.Combine(dataFolder, dosyaAdi);

                // Dosyayı oluştur ve içeriği yaz
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void not_ekle2_Load(object sender, EventArgs e)
        {
            basliktxt.Focus();
        }
    }
}
