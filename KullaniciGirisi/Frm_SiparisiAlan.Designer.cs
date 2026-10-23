namespace KullaniciGirisi
{
    partial class Frm_SiparisiAlan
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
            this.dgv_SiparisiAlanTablosu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SiparisiAlanTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SiparisiAlanTablosu
            // 
            this.dgv_SiparisiAlanTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SiparisiAlanTablosu.Location = new System.Drawing.Point(0, 0);
            this.dgv_SiparisiAlanTablosu.Name = "dgv_SiparisiAlanTablosu";
            this.dgv_SiparisiAlanTablosu.RowHeadersWidth = 51;
            this.dgv_SiparisiAlanTablosu.RowTemplate.Height = 24;
            this.dgv_SiparisiAlanTablosu.Size = new System.Drawing.Size(686, 452);
            this.dgv_SiparisiAlanTablosu.TabIndex = 0;
            this.dgv_SiparisiAlanTablosu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SiparisiAlanTablosu_CellClick);
            // 
            // Frm_SiparisiAlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_SiparisiAlanTablosu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SiparisiAlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm_SiparisiAlan";
            this.Load += new System.EventHandler(this.Frm_SiparisiAlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SiparisiAlanTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SiparisiAlanTablosu;
    }
}