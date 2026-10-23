namespace KullaniciGirisi
{
    partial class Frm_StokTuruTablosu
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
            this.DataGridView_StokTuruTablo = new System.Windows.Forms.DataGridView();
            this.btn_StokTuruSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_StokTuruTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_StokTuruTablo
            // 
            this.DataGridView_StokTuruTablo.AllowUserToOrderColumns = true;
            this.DataGridView_StokTuruTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_StokTuruTablo.Location = new System.Drawing.Point(2, 0);
            this.DataGridView_StokTuruTablo.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView_StokTuruTablo.Name = "DataGridView_StokTuruTablo";
            this.DataGridView_StokTuruTablo.RowHeadersWidth = 51;
            this.DataGridView_StokTuruTablo.RowTemplate.Height = 24;
            this.DataGridView_StokTuruTablo.Size = new System.Drawing.Size(769, 334);
            this.DataGridView_StokTuruTablo.TabIndex = 0;
            this.DataGridView_StokTuruTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_StokTuruTablo_CellContentClick);
            this.DataGridView_StokTuruTablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_StokTuruTablo_CellDoubleClick);
            // 
            // btn_StokTuruSec
            // 
            this.btn_StokTuruSec.Location = new System.Drawing.Point(598, 344);
            this.btn_StokTuruSec.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StokTuruSec.Name = "btn_StokTuruSec";
            this.btn_StokTuruSec.Size = new System.Drawing.Size(173, 41);
            this.btn_StokTuruSec.TabIndex = 1;
            this.btn_StokTuruSec.Text = "Seç";
            this.btn_StokTuruSec.UseVisualStyleBackColor = true;
            this.btn_StokTuruSec.Click += new System.EventHandler(this.btn_StokTuruSec_Click);
            // 
            // Frm_StokTuruTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 388);
            this.Controls.Add(this.btn_StokTuruSec);
            this.Controls.Add(this.DataGridView_StokTuruTablo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_StokTuruTablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokTuruTablosu";
            this.Load += new System.EventHandler(this.Form_StokTuruTablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_StokTuruTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_StokTuruTablo;
        private System.Windows.Forms.Button btn_StokTuruSec;
    }
}