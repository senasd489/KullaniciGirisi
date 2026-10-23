namespace KullaniciGirisi
{
    partial class Frm_SiparisRaporlari
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
            this.splitContainer_SiparisRaporlari = new System.Windows.Forms.SplitContainer();
            this.treeView_SRRaporlar = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox_SRFiltreler = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_FiltreDegerleri = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Rapor = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SiparisRaporlari)).BeginInit();
            this.splitContainer_SiparisRaporlari.Panel1.SuspendLayout();
            this.splitContainer_SiparisRaporlari.Panel2.SuspendLayout();
            this.splitContainer_SiparisRaporlari.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FiltreDegerleri)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_SiparisRaporlari
            // 
            this.splitContainer_SiparisRaporlari.Location = new System.Drawing.Point(1, 2);
            this.splitContainer_SiparisRaporlari.Name = "splitContainer_SiparisRaporlari";
            // 
            // splitContainer_SiparisRaporlari.Panel1
            // 
            this.splitContainer_SiparisRaporlari.Panel1.Controls.Add(this.treeView_SRRaporlar);
            this.splitContainer_SiparisRaporlari.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer_SiparisRaporlari.Panel2
            // 
            this.splitContainer_SiparisRaporlari.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer_SiparisRaporlari.Size = new System.Drawing.Size(1184, 674);
            this.splitContainer_SiparisRaporlari.SplitterDistance = 344;
            this.splitContainer_SiparisRaporlari.TabIndex = 0;
            // 
            // treeView_SRRaporlar
            // 
            this.treeView_SRRaporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_SRRaporlar.Location = new System.Drawing.Point(0, 36);
            this.treeView_SRRaporlar.Name = "treeView_SRRaporlar";
            this.treeView_SRRaporlar.Size = new System.Drawing.Size(344, 638);
            this.treeView_SRRaporlar.TabIndex = 1;
            this.treeView_SRRaporlar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_SRRaporlar_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 36);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raporlar";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox_SRFiltreler);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_FiltreDegerleri);
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(836, 674);
            this.splitContainer2.SplitterDistance = 421;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox_SRFiltreler
            // 
            this.listBox_SRFiltreler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_SRFiltreler.FormattingEnabled = true;
            this.listBox_SRFiltreler.ItemHeight = 16;
            this.listBox_SRFiltreler.Location = new System.Drawing.Point(0, 36);
            this.listBox_SRFiltreler.Name = "listBox_SRFiltreler";
            this.listBox_SRFiltreler.Size = new System.Drawing.Size(421, 638);
            this.listBox_SRFiltreler.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 36);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtreler";
            // 
            // dataGridView_FiltreDegerleri
            // 
            this.dataGridView_FiltreDegerleri.AllowUserToOrderColumns = true;
            this.dataGridView_FiltreDegerleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FiltreDegerleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_FiltreDegerleri.Location = new System.Drawing.Point(0, 36);
            this.dataGridView_FiltreDegerleri.Name = "dataGridView_FiltreDegerleri";
            this.dataGridView_FiltreDegerleri.RowHeadersWidth = 51;
            this.dataGridView_FiltreDegerleri.RowTemplate.Height = 24;
            this.dataGridView_FiltreDegerleri.Size = new System.Drawing.Size(411, 638);
            this.dataGridView_FiltreDegerleri.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 36);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Filtre Değerleri";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Kaydet);
            this.panel1.Controls.Add(this.btn_Rapor);
            this.panel1.Controls.Add(this.btn_Vazgec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 699);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 36);
            this.panel1.TabIndex = 1;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kaydet.Location = new System.Drawing.Point(884, 3);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(103, 28);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            // 
            // btn_Rapor
            // 
            this.btn_Rapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rapor.Location = new System.Drawing.Point(993, 3);
            this.btn_Rapor.Name = "btn_Rapor";
            this.btn_Rapor.Size = new System.Drawing.Size(103, 28);
            this.btn_Rapor.TabIndex = 1;
            this.btn_Rapor.Text = "Rapor";
            this.btn_Rapor.UseVisualStyleBackColor = true;
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Vazgec.Location = new System.Drawing.Point(1102, 3);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(103, 28);
            this.btn_Vazgec.TabIndex = 0;
            this.btn_Vazgec.Text = "Vazgeç";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // Frm_SiparisRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer_SiparisRaporlari);
            this.Name = "Frm_SiparisRaporlari";
            this.Text = "Frm_SiparisRaporlari";
            this.Load += new System.EventHandler(this.Frm_SiparisRaporlari_Load);
            this.splitContainer_SiparisRaporlari.Panel1.ResumeLayout(false);
            this.splitContainer_SiparisRaporlari.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SiparisRaporlari)).EndInit();
            this.splitContainer_SiparisRaporlari.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FiltreDegerleri)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_SiparisRaporlari;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Rapor;
        private System.Windows.Forms.Button btn_Vazgec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView_SRRaporlar;
        private System.Windows.Forms.ListBox listBox_SRFiltreler;
        private System.Windows.Forms.DataGridView dataGridView_FiltreDegerleri;
    }
}