namespace KullaniciGirisi
{
    partial class Form_SiparisNoSecenekler
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
            this.dataGridView_SiparisNoSecenekler = new System.Windows.Forms.DataGridView();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.btn_DizaynKaydet = new System.Windows.Forms.Button();
            this.btn_Sec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SiparisNoSecenekler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SiparisNoSecenekler
            // 
            this.dataGridView_SiparisNoSecenekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SiparisNoSecenekler.Location = new System.Drawing.Point(4, 2);
            this.dataGridView_SiparisNoSecenekler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_SiparisNoSecenekler.Name = "dataGridView_SiparisNoSecenekler";
            this.dataGridView_SiparisNoSecenekler.RowHeadersWidth = 51;
            this.dataGridView_SiparisNoSecenekler.RowTemplate.Height = 24;
            this.dataGridView_SiparisNoSecenekler.Size = new System.Drawing.Size(1194, 478);
            this.dataGridView_SiparisNoSecenekler.TabIndex = 1;
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.Location = new System.Drawing.Point(1086, 490);
            this.btn_Vazgec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(112, 36);
            this.btn_Vazgec.TabIndex = 2;
            this.btn_Vazgec.Text = "Vazgeç";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            // 
            // btn_DizaynKaydet
            // 
            this.btn_DizaynKaydet.Location = new System.Drawing.Point(798, 490);
            this.btn_DizaynKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DizaynKaydet.Name = "btn_DizaynKaydet";
            this.btn_DizaynKaydet.Size = new System.Drawing.Size(160, 36);
            this.btn_DizaynKaydet.TabIndex = 3;
            this.btn_DizaynKaydet.Text = "Dizayn Kaydet";
            this.btn_DizaynKaydet.UseVisualStyleBackColor = true;
            // 
            // btn_Sec
            // 
            this.btn_Sec.Location = new System.Drawing.Point(966, 490);
            this.btn_Sec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sec.Name = "btn_Sec";
            this.btn_Sec.Size = new System.Drawing.Size(112, 36);
            this.btn_Sec.TabIndex = 4;
            this.btn_Sec.Text = "Seç";
            this.btn_Sec.UseVisualStyleBackColor = true;
            // 
            // Form_SiparisNoSecenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 535);
            this.Controls.Add(this.btn_Sec);
            this.Controls.Add(this.btn_DizaynKaydet);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.dataGridView_SiparisNoSecenekler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_SiparisNoSecenekler";
            this.Text = "Sipariş No Seçenekleri";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SiparisNoSecenekler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SiparisNoSecenekler;
        private System.Windows.Forms.Button btn_Vazgec;
        private System.Windows.Forms.Button btn_DizaynKaydet;
        private System.Windows.Forms.Button btn_Sec;
    }
}