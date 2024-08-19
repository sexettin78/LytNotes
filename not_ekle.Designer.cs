namespace LytNotes
{
    partial class not_ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(not_ekle));
            kaydet = new Button();
            basliktxt = new TextBox();
            iceriktxt = new RichTextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kaydet
            // 
            kaydet.BackColor = Color.MistyRose;
            kaydet.Font = new Font("Microsoft Sans Serif", 9F);
            kaydet.ForeColor = Color.Firebrick;
            kaydet.Location = new Point(921, 619);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(166, 69);
            kaydet.TabIndex = 0;
            kaydet.Text = "kaydet";
            kaydet.UseVisualStyleBackColor = false;
            kaydet.Click += kaydet_Click;
            // 
            // basliktxt
            // 
            basliktxt.BackColor = Color.IndianRed;
            basliktxt.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            basliktxt.ForeColor = Color.White;
            basliktxt.Location = new Point(45, 47);
            basliktxt.Name = "basliktxt";
            basliktxt.Size = new Size(1042, 32);
            basliktxt.TabIndex = 1;
            // 
            // iceriktxt
            // 
            iceriktxt.BackColor = Color.IndianRed;
            iceriktxt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            iceriktxt.ForeColor = Color.White;
            iceriktxt.Location = new Point(45, 116);
            iceriktxt.Name = "iceriktxt";
            iceriktxt.Size = new Size(1042, 497);
            iceriktxt.TabIndex = 2;
            iceriktxt.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.copkutusu_lytnotes;
            pictureBox1.Location = new Point(845, 619);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 85);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 9;
            label2.Text = "İçerik";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 11);
            label1.Name = "label1";
            label1.Size = new Size(78, 29);
            label1.TabIndex = 8;
            label1.Text = "Başlık";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 622);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 10;
            label3.Text = "Değiştirilme Tarihi:";
            // 
            // not_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.degrade11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 697);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(iceriktxt);
            Controls.Add(basliktxt);
            Controls.Add(kaydet);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "not_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Not Düzenle";
            TopMost = true;
            Load += not_ekle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kaydet;
        public TextBox basliktxt;
        public RichTextBox iceriktxt;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}