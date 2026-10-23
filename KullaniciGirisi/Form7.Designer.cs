namespace KullaniciGirisi
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_StokKoduSec = new System.Windows.Forms.Button();
            this.btn_StokKoduIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_StokKoduSec
            // 
            this.btn_StokKoduSec.Location = new System.Drawing.Point(764, 470);
            this.btn_StokKoduSec.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StokKoduSec.Name = "btn_StokKoduSec";
            this.btn_StokKoduSec.Size = new System.Drawing.Size(112, 44);
            this.btn_StokKoduSec.TabIndex = 1;
            this.btn_StokKoduSec.Text = "Seç";
            this.btn_StokKoduSec.UseVisualStyleBackColor = true;
            // 
            // btn_StokKoduIptal
            // 
            this.btn_StokKoduIptal.Location = new System.Drawing.Point(638, 470);
            this.btn_StokKoduIptal.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StokKoduIptal.Name = "btn_StokKoduIptal";
            this.btn_StokKoduIptal.Size = new System.Drawing.Size(116, 45);
            this.btn_StokKoduIptal.TabIndex = 2;
            this.btn_StokKoduIptal.Text = "İptal";
            this.btn_StokKoduIptal.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 526);
            this.Controls.Add(this.btn_StokKoduIptal);
            this.Controls.Add(this.btn_StokKoduSec);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_StokKoduSec;
        private System.Windows.Forms.Button btn_StokKoduIptal;
    }
}