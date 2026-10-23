namespace KullaniciGirisi
{
    partial class frm_SGEtiketNoSecenekler
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
            this.dgv_EtiketNoTablosu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EtiketNoTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_EtiketNoTablosu
            // 
            this.dgv_EtiketNoTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EtiketNoTablosu.Location = new System.Drawing.Point(-2, -6);
            this.dgv_EtiketNoTablosu.Name = "dgv_EtiketNoTablosu";
            this.dgv_EtiketNoTablosu.RowHeadersWidth = 51;
            this.dgv_EtiketNoTablosu.RowTemplate.Height = 24;
            this.dgv_EtiketNoTablosu.Size = new System.Drawing.Size(404, 263);
            this.dgv_EtiketNoTablosu.TabIndex = 0;
            this.dgv_EtiketNoTablosu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EtiketNoTablosu_CellClick);
            // 
            // frm_SGEtiketNoSecenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 482);
            this.Controls.Add(this.dgv_EtiketNoTablosu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SGEtiketNoSecenekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SGEtiketNoSecenekler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EtiketNoTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_EtiketNoTablosu;
    }
}