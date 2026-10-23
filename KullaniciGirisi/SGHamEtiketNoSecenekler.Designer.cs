namespace KullaniciGirisi
{
    partial class frm_SGHamEtiketNoSecenekler
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
            this.dgv_HamEtiketNoTablosu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HamEtiketNoTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HamEtiketNoTablosu
            // 
            this.dgv_HamEtiketNoTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HamEtiketNoTablosu.Location = new System.Drawing.Point(-1, -3);
            this.dgv_HamEtiketNoTablosu.Name = "dgv_HamEtiketNoTablosu";
            this.dgv_HamEtiketNoTablosu.RowHeadersWidth = 51;
            this.dgv_HamEtiketNoTablosu.RowTemplate.Height = 24;
            this.dgv_HamEtiketNoTablosu.Size = new System.Drawing.Size(240, 150);
            this.dgv_HamEtiketNoTablosu.TabIndex = 0;
            this.dgv_HamEtiketNoTablosu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HamEtiketNoTablosu_CellClick);
            // 
            // frm_SGHamEtiketNoSecenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 342);
            this.Controls.Add(this.dgv_HamEtiketNoTablosu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SGHamEtiketNoSecenekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SGHamEtiketNoSecenekler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HamEtiketNoTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HamEtiketNoTablosu;
    }
}