namespace KullaniciGirisi
{
    partial class frm_StokKoduSeçenekler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Vaazgec = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTamam);
            this.panel1.Controls.Add(this.btn_Vaazgec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 32);
            this.panel1.TabIndex = 0;
            // 
            // btn_Vaazgec
            // 
            this.btn_Vaazgec.Location = new System.Drawing.Point(701, 0);
            this.btn_Vaazgec.Name = "btn_Vaazgec";
            this.btn_Vaazgec.Size = new System.Drawing.Size(96, 32);
            this.btn_Vaazgec.TabIndex = 0;
            this.btn_Vaazgec.Text = "Vazgeç";
            this.btn_Vaazgec.UseVisualStyleBackColor = true;
            this.btn_Vaazgec.Click += new System.EventHandler(this.btn_Vaazgec_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(599, 0);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(96, 32);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Goster);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 592);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 358);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 189);
            this.panel4.TabIndex = 1;
            // 
            // btn_Goster
            // 
            this.btn_Goster.Location = new System.Drawing.Point(12, 199);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(106, 29);
            this.btn_Goster.TabIndex = 2;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            // 
            // frm_StokKoduSeçenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_StokKoduSeçenekler";
            this.Text = "frm_StokKoduSeçenekler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btn_Vaazgec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Goster;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}