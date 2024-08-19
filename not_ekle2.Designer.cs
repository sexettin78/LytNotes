namespace LytNotes
{
    partial class not_ekle2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(not_ekle2));
            iceriktxt = new RichTextBox();
            basliktxt = new TextBox();
            kaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // iceriktxt
            // 
            iceriktxt.BackColor = Color.IndianRed;
            iceriktxt.Font = new Font("Microsoft Sans Serif", 11F);
            iceriktxt.ForeColor = Color.White;
            iceriktxt.Location = new Point(45, 116);
            iceriktxt.Name = "iceriktxt";
            iceriktxt.Size = new Size(1042, 497);
            iceriktxt.TabIndex = 5;
            iceriktxt.Text = "";
            // 
            // basliktxt
            // 
            basliktxt.BackColor = Color.IndianRed;
            basliktxt.Font = new Font("Microsoft Sans Serif", 13F);
            basliktxt.ForeColor = Color.White;
            basliktxt.Location = new Point(45, 47);
            basliktxt.Name = "basliktxt";
            basliktxt.Size = new Size(1042, 32);
            basliktxt.TabIndex = 4;
            // 
            // kaydet
            // 
            kaydet.BackColor = Color.MistyRose;
            kaydet.Font = new Font("Microsoft Sans Serif", 9F);
            kaydet.ForeColor = Color.Firebrick;
            kaydet.Location = new Point(921, 619);
            kaydet.Name = "kaydet";
            kaydet.Size = new Size(166, 69);
            kaydet.TabIndex = 3;
            kaydet.Text = "kaydet";
            kaydet.UseVisualStyleBackColor = false;
            kaydet.Click += kaydet_Click_1;
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
            label1.TabIndex = 6;
            label1.Text = "Başlık";
            label1.Click += label1_Click;
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
            label2.TabIndex = 7;
            label2.Text = "İçerik";
            label2.Click += label2_Click;
            // 
            // not_ekle2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.degrade11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 697);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iceriktxt);
            Controls.Add(basliktxt);
            Controls.Add(kaydet);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "not_ekle2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Not Ekle";
            TopMost = true;
            Load += not_ekle2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox iceriktxt;
        public TextBox basliktxt;
        private Button kaydet;
        private Label label1;
        private Label label2;
    }
}