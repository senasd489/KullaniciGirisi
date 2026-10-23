namespace KullaniciGirisi
{
    partial class frm_SiparisListesiBasitRapor
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
            this.btn_SiparisListeRaporuOlustur = new System.Windows.Forms.Button();
            this.dgv_SiparisListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SiparisListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SiparisListeRaporuOlustur
            // 
            this.btn_SiparisListeRaporuOlustur.Location = new System.Drawing.Point(539, 403);
            this.btn_SiparisListeRaporuOlustur.Name = "btn_SiparisListeRaporuOlustur";
            this.btn_SiparisListeRaporuOlustur.Size = new System.Drawing.Size(249, 35);
            this.btn_SiparisListeRaporuOlustur.TabIndex = 0;
            this.btn_SiparisListeRaporuOlustur.Text = "Sipariş Listesi Raporu Oluştur";
            this.btn_SiparisListeRaporuOlustur.UseVisualStyleBackColor = true;
            this.btn_SiparisListeRaporuOlustur.Click += new System.EventHandler(this.btn_SiparisListeRaporuOlustur_Click);
            // 
            // dgv_SiparisListesi
            // 
            this.dgv_SiparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SiparisListesi.Location = new System.Drawing.Point(4, 0);
            this.dgv_SiparisListesi.Name = "dgv_SiparisListesi";
            this.dgv_SiparisListesi.RowHeadersWidth = 51;
            this.dgv_SiparisListesi.RowTemplate.Height = 24;
            this.dgv_SiparisListesi.Size = new System.Drawing.Size(783, 382);
            this.dgv_SiparisListesi.TabIndex = 1;
            // 
            // frm_SiparisListesiBasitRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_SiparisListesi);
            this.Controls.Add(this.btn_SiparisListeRaporuOlustur);
            this.Name = "frm_SiparisListesiBasitRapor";
            this.Text = "frm_SiparisListesiBasitRapor";
            this.Load += new System.EventHandler(this.frm_SiparisListesiBasitRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SiparisListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SiparisListeRaporuOlustur;
        private System.Windows.Forms.DataGridView dgv_SiparisListesi;
    }
}