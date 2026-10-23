using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class frm_SGHamEtiketNoSecenekler : Form
    {
        public event Action<string, string, string> HamEtiketNoSecildi;
        public frm_SGHamEtiketNoSecenekler()
        {
            InitializeComponent();

            this.Deactivate += frm_SGHamEtiketNoSecenekler_Deactivate;

            HamEtiketNoYukle("");
        }

        private void frm_SGHamEtiketNoSecenekler_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HamEtiketNoYukle(string filtre)
        {
            ERPEntities db = new ERPEntities();

            var siparisHamEtiketNo = db.SiparisHamEtiketNo
                .Where(x => string.IsNullOrEmpty(filtre) || x.HamEtiketNo.Contains(filtre))
                .Select(x => new { x.HamEtiketNo,x.HamRaporAdi,x.HamRaporModulAdi})
                .ToList();
            dgv_HamEtiketNoTablosu.DataSource = siparisHamEtiketNo;
            dgv_HamEtiketNoTablosu.Columns["HamEtiketNo"].HeaderText = "Rapor No";
            dgv_HamEtiketNoTablosu.Columns["HamRaporAdi"].HeaderText = "Rapor Adı";
            dgv_HamEtiketNoTablosu.Columns["HamRaporModulAdi"].HeaderText = "Rapor Modul Adı";
            dgv_HamEtiketNoTablosu.ReadOnly = true;
            dgv_HamEtiketNoTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HamEtiketNoTablosu.AllowUserToAddRows = false;
            dgv_HamEtiketNoTablosu.RowHeadersVisible = false;
            dgv_HamEtiketNoTablosu.ScrollBars = ScrollBars.Vertical;
            dgv_HamEtiketNoTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Boyut hesaplama
            int toplamGenislik = 0;
            foreach (DataGridViewColumn col in dgv_HamEtiketNoTablosu.Columns)
                toplamGenislik += col.Width;

            int toplamYukseklik = dgv_HamEtiketNoTablosu.ColumnHeadersHeight;
            if (siparisHamEtiketNo.Count > 0)
                toplamYukseklik += siparisHamEtiketNo.Count * dgv_HamEtiketNoTablosu.Rows[0].Height;
            dgv_HamEtiketNoTablosu.Location = new Point(0, 0);
            dgv_HamEtiketNoTablosu.Size = new Size(toplamGenislik + 2, toplamYukseklik + 2);
            
            this.ClientSize = dgv_HamEtiketNoTablosu.Size;
            
        }


        private void dgv_HamEtiketNoTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string hamEtiketNo = dgv_HamEtiketNoTablosu.Rows[e.RowIndex].Cells["HamEtiketNo"].Value?.ToString() ?? "";
                string hamRaporAdi = dgv_HamEtiketNoTablosu.Rows[e.RowIndex].Cells["HamRaporAdi"].Value?.ToString() ?? "";
                string hamRaporModulAdi = dgv_HamEtiketNoTablosu.Rows[e.RowIndex].Cells["HamRaporModulAdi"].Value?.ToString() ?? "";

                HamEtiketNoSecildi?.Invoke(hamEtiketNo, hamRaporAdi, hamRaporModulAdi);
                this.Deactivate -= frm_SGHamEtiketNoSecenekler_Deactivate;
                this.Close();
            }

        }

        public void Filtrele(string metin)
        {
            HamEtiketNoYukle(metin);
        }
    }
}
