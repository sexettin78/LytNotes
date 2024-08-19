namespace LytNotes
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            label2 = new Label();
            width_txt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            height_txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(191, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 1;
            label2.Text = "Tuş Genişliği:";
            // 
            // width_txt
            // 
            width_txt.Cursor = Cursors.IBeam;
            width_txt.Location = new Point(322, 97);
            width_txt.MaxLength = 4;
            width_txt.Name = "width_txt";
            width_txt.Size = new Size(238, 27);
            width_txt.TabIndex = 2;
            width_txt.TextChanged += width_txt_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14.5F);
            button1.Location = new Point(317, 593);
            button1.Name = "button1";
            button1.Size = new Size(159, 59);
            button1.TabIndex = 3;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(230, 31);
            label1.Name = "label1";
            label1.Size = new Size(319, 39);
            label1.TabIndex = 4;
            label1.Text = "Ana Ekran Ayarları";
            // 
            // height_txt
            // 
            height_txt.Location = new Point(322, 147);
            height_txt.MaxLength = 4;
            height_txt.Name = "height_txt";
            height_txt.Size = new Size(238, 27);
            height_txt.TabIndex = 6;
            height_txt.TextChanged += height_txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(175, 147);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 5;
            label3.Text = "Tuş Yüksekliği:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(104, 525);
            label4.Name = "label4";
            label4.Size = new Size(609, 50);
            label4.TabIndex = 7;
            label4.Text = "Yazı yazarken ctrl tuşuna basılı tutarken ve fare tekerleğini kullanarak \r\nyakınlaştırma veya uzaklaştırma yapabilirsiniz.";
            // 
            // ayarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.degrade11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 702);
            Controls.Add(label4);
            Controls.Add(height_txt);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(width_txt);
            Controls.Add(label2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ayarlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayarlar";
            TopMost = true;
            Load += ayarlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox width_txt;
        private Button button1;
        private Label label1;
        private TextBox height_txt;
        private Label label3;
        private Label label4;
    }
}