namespace KullaniciGirisi
{
    partial class frm_StokGrubuSecenekler
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
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sec = new System.Windows.Forms.Button();
            this.checkBox_OnDegeriKaldir = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.Location = new System.Drawing.Point(612, 3);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(117, 33);
            this.btn_Vazgec.TabIndex = 0;
            this.btn_Vazgec.Text = "Vazgeç";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 660);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_OnDegeriKaldir);
            this.panel2.Controls.Add(this.btn_Sec);
            this.panel2.Controls.Add(this.btn_Vazgec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 37);
            this.panel2.TabIndex = 4;
            // 
            // btn_Sec
            // 
            this.btn_Sec.Location = new System.Drawing.Point(489, 3);
            this.btn_Sec.Name = "btn_Sec";
            this.btn_Sec.Size = new System.Drawing.Size(117, 33);
            this.btn_Sec.TabIndex = 1;
            this.btn_Sec.Text = "Seç";
            this.btn_Sec.UseVisualStyleBackColor = true;
            // 
            // checkBox_OnDegeriKaldir
            // 
            this.checkBox_OnDegeriKaldir.AutoSize = true;
            this.checkBox_OnDegeriKaldir.Location = new System.Drawing.Point(12, 10);
            this.checkBox_OnDegeriKaldir.Name = "checkBox_OnDegeriKaldir";
            this.checkBox_OnDegeriKaldir.Size = new System.Drawing.Size(127, 20);
            this.checkBox_OnDegeriKaldir.TabIndex = 2;
            this.checkBox_OnDegeriKaldir.Text = "Ön Değeri Kaldır";
            this.checkBox_OnDegeriKaldir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 657);
            this.dataGridView1.TabIndex = 0;
            // 
            // StokGrubuSecenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StokGrubuSecenekler";
            this.Text = "Stok Grubu Seçenekler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Vazgec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Sec;
        private System.Windows.Forms.CheckBox checkBox_OnDegeriKaldir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}