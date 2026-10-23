namespace KullaniciGirisi
{
    partial class Frm_GirisEkrani
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
            this.labelKullaniciKodu = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKullaniciKodu
            // 
            this.labelKullaniciKodu.AutoSize = true;
            this.labelKullaniciKodu.Location = new System.Drawing.Point(59, 100);
            this.labelKullaniciKodu.Name = "labelKullaniciKodu";
            this.labelKullaniciKodu.Size = new System.Drawing.Size(129, 25);
            this.labelKullaniciKodu.TabIndex = 0;
            this.labelKullaniciKodu.Text = "kullanıcı kodu";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(140, 145);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(48, 25);
            this.labelSifre.TabIndex = 2;
            this.labelSifre.Text = "şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 30);
            this.textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(187, 30);
            this.textBox3.TabIndex = 6;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(124, 227);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(187, 42);
            this.buttonGirisYap.TabIndex = 8;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // Frm_GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 380);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciKodu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullaniciKodu;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonGirisYap;
    }
}

