namespace KullaniciGirisi
{
    partial class Frm_KullaniciIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KisiEkle = new System.Windows.Forms.Button();
            this.txt_KullaniciID = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.checkBoxAktifMi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.txt_YetkiliDuzeyi = new System.Windows.Forms.TextBox();
            this.labelYetkiliDuzeyi = new System.Windows.Forms.Label();
            this.btn_AnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KullaniciID";
            this.label1.Visible = false;
            // 
            // btn_KisiEkle
            // 
            this.btn_KisiEkle.Location = new System.Drawing.Point(818, 257);
            this.btn_KisiEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_KisiEkle.Name = "btn_KisiEkle";
            this.btn_KisiEkle.Size = new System.Drawing.Size(189, 36);
            this.btn_KisiEkle.TabIndex = 1;
            this.btn_KisiEkle.Text = "Kişi ekle";
            this.btn_KisiEkle.UseVisualStyleBackColor = true;
            this.btn_KisiEkle.Click += new System.EventHandler(this.buttonKisiEkle_Click);
            // 
            // txt_KullaniciID
            // 
            this.txt_KullaniciID.Enabled = false;
            this.txt_KullaniciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullaniciID.Location = new System.Drawing.Point(818, 0);
            this.txt_KullaniciID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_KullaniciID.Name = "txt_KullaniciID";
            this.txt_KullaniciID.Size = new System.Drawing.Size(175, 30);
            this.txt_KullaniciID.TabIndex = 2;
            this.txt_KullaniciID.Visible = false;
            // 
            // textBoxKullaniciKodu
            // 
            this.textBoxKullaniciKodu.Location = new System.Drawing.Point(818, 40);
            this.textBoxKullaniciKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKullaniciKodu.Name = "textBoxKullaniciKodu";
            this.textBoxKullaniciKodu.Size = new System.Drawing.Size(175, 30);
            this.textBoxKullaniciKodu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "KullaniciKodu";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(818, 80);
            this.textBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(175, 30);
            this.textBoxKullaniciAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "KullaniciAdi";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(818, 120);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(175, 30);
            this.textBoxSifre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sifre";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(818, 303);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(189, 36);
            this.buttonGuncelle.TabIndex = 9;
            this.buttonGuncelle.Text = "Guncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // checkBoxAktifMi
            // 
            this.checkBoxAktifMi.AutoSize = true;
            this.checkBoxAktifMi.Location = new System.Drawing.Point(835, 205);
            this.checkBoxAktifMi.Name = "checkBoxAktifMi";
            this.checkBoxAktifMi.Size = new System.Drawing.Size(18, 17);
            this.checkBoxAktifMi.TabIndex = 10;
            this.checkBoxAktifMi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aktif mi?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(818, 349);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(189, 36);
            this.buttonSil.TabIndex = 12;
            this.buttonSil.Text = "sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(818, 395);
            this.buttonListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(189, 36);
            this.buttonListele.TabIndex = 13;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.AllowUserToOrderColumns = true;
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.RowHeadersWidth = 51;
            this.dataGridView_list.RowTemplate.Height = 24;
            this.dataGridView_list.Size = new System.Drawing.Size(661, 339);
            this.dataGridView_list.TabIndex = 14;
            this.dataGridView_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_CellClick);
            this.dataGridView_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_CellContentClick);
            // 
            // txt_YetkiliDuzeyi
            // 
            this.txt_YetkiliDuzeyi.Location = new System.Drawing.Point(818, 160);
            this.txt_YetkiliDuzeyi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_YetkiliDuzeyi.Name = "txt_YetkiliDuzeyi";
            this.txt_YetkiliDuzeyi.Size = new System.Drawing.Size(175, 30);
            this.txt_YetkiliDuzeyi.TabIndex = 16;
            // 
            // labelYetkiliDuzeyi
            // 
            this.labelYetkiliDuzeyi.AutoSize = true;
            this.labelYetkiliDuzeyi.Location = new System.Drawing.Point(677, 160);
            this.labelYetkiliDuzeyi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYetkiliDuzeyi.Name = "labelYetkiliDuzeyi";
            this.labelYetkiliDuzeyi.Size = new System.Drawing.Size(123, 25);
            this.labelYetkiliDuzeyi.TabIndex = 15;
            this.labelYetkiliDuzeyi.Text = "YetkiliDuzeyi";
            // 
            // btn_AnaMenu
            // 
            this.btn_AnaMenu.Location = new System.Drawing.Point(818, 445);
            this.btn_AnaMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AnaMenu.Name = "btn_AnaMenu";
            this.btn_AnaMenu.Size = new System.Drawing.Size(189, 36);
            this.btn_AnaMenu.TabIndex = 17;
            this.btn_AnaMenu.Text = "Ana Menu";
            this.btn_AnaMenu.UseVisualStyleBackColor = true;
            this.btn_AnaMenu.Click += new System.EventHandler(this.btn_AnaMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 495);
            this.Controls.Add(this.btn_AnaMenu);
            this.Controls.Add(this.txt_YetkiliDuzeyi);
            this.Controls.Add(this.labelYetkiliDuzeyi);
            this.Controls.Add(this.dataGridView_list);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxAktifMi);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKullaniciKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_KullaniciID);
            this.Controls.Add(this.btn_KisiEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KisiEkle;
        private System.Windows.Forms.TextBox txt_KullaniciID;
        private System.Windows.Forms.TextBox textBoxKullaniciKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.CheckBox checkBoxAktifMi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.DataGridView dataGridView_list;
        private System.Windows.Forms.TextBox txt_YetkiliDuzeyi;
        private System.Windows.Forms.Label labelYetkiliDuzeyi;
        private System.Windows.Forms.Button btn_AnaMenu;
    }
}