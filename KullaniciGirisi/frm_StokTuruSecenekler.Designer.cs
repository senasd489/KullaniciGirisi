namespace KullaniciGirisi
{
    partial class frm_StokTuruSecenekler
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
            this.dgv_StokTuruSecenekler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StokTuruSecenekler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_StokTuruSecenekler
            // 
            this.dgv_StokTuruSecenekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StokTuruSecenekler.Location = new System.Drawing.Point(-3, -1);
            this.dgv_StokTuruSecenekler.Name = "dgv_StokTuruSecenekler";
            this.dgv_StokTuruSecenekler.RowHeadersWidth = 51;
            this.dgv_StokTuruSecenekler.RowTemplate.Height = 24;
            this.dgv_StokTuruSecenekler.Size = new System.Drawing.Size(739, 454);
            this.dgv_StokTuruSecenekler.TabIndex = 1;
            this.dgv_StokTuruSecenekler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StokTuruSecenekler_CellClick);
            // 
            // frm_StokTuruSecenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_StokTuruSecenekler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_StokTuruSecenekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_StokTuruSecenekler";
            this.Load += new System.EventHandler(this.frm_StokTuruSecenekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StokTuruSecenekler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_StokTuruSecenekler;
    }
}