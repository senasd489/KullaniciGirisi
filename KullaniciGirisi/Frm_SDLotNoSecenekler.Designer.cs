namespace KullaniciGirisi
{
    partial class Frm_SDLotNoSecenekler
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
            this.panel_ = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_OnDegeriKaldir = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 545);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel_
            // 
            this.panel_.Controls.Add(this.checkBox_OnDegeriKaldir);
            this.panel_.Controls.Add(this.button2);
            this.panel_.Controls.Add(this.button1);
            this.panel_.Location = new System.Drawing.Point(-4, 540);
            this.panel_.Name = "panel_";
            this.panel_.Size = new System.Drawing.Size(754, 36);
            this.panel_.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox_OnDegeriKaldir
            // 
            this.checkBox_OnDegeriKaldir.AutoSize = true;
            this.checkBox_OnDegeriKaldir.Location = new System.Drawing.Point(16, 9);
            this.checkBox_OnDegeriKaldir.Name = "checkBox_OnDegeriKaldir";
            this.checkBox_OnDegeriKaldir.Size = new System.Drawing.Size(95, 20);
            this.checkBox_OnDegeriKaldir.TabIndex = 2;
            this.checkBox_OnDegeriKaldir.Text = "checkBox1";
            this.checkBox_OnDegeriKaldir.UseVisualStyleBackColor = true;
            // 
            // Frm_SDLotNoSecenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 574);
            this.Controls.Add(this.panel_);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_SDLotNoSecenekler";
            this.Text = "Frm_SDLotNoSecenekler";
            this.Load += new System.EventHandler(this.Frm_SDLotNoSecenekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_.ResumeLayout(false);
            this.panel_.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_OnDegeriKaldir;
    }
}