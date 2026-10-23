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
    public partial class frm_SGEtiketNoSecenekler : Form
    {
        public event Action<string, string, string> EtiketNoSecildi;
        public frm_SGEtiketNoSecenekler()
        {
            InitializeComponent();

            // diğer alanlara tıklanınca kapat:
            this.Deactivate += frm_SGEtiketNoSecenekler_Deactivate;

            EtiketNoYukle("");
        }

        

        private void frm_SGEtiketNoSecenekler_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EtiketNoYukle(string filtre)
        {
            ERPEntities db = new ERPEntities();
            var siparisEtiketNo = db.SiparisEtiketNo
                .Where(x => string.IsNullOrEmpty(filtre) || x.EtiketNo.Contains(filtre))
                .Select(x => new { x.EtiketNo, x.RaporAdi, x.RaporModulAdi })
                .ToList();

            dgv_EtiketNoTablosu.DataSource = siparisEtiketNo;
            dgv_EtiketNoTablosu.Columns["EtiketNo"].HeaderText = "Rapor No";
            dgv_EtiketNoTablosu.Columns["RaporAdi"].HeaderText = "Rapor Adı";
            dgv_EtiketNoTablosu.Columns["RaporModulAdi"].HeaderText = "Rapor Modul Adı";
            dgv_EtiketNoTablosu.ReadOnly = true;
            dgv_EtiketNoTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_EtiketNoTablosu.AllowUserToAddRows = false;
            dgv_EtiketNoTablosu.RowHeadersVisible = false;
            dgv_EtiketNoTablosu.ScrollBars = ScrollBars.Vertical;
            dgv_EtiketNoTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Boyut hesaplamaa :
            int toplamGenislik = 0;
            foreach (DataGridViewColumn col in dgv_EtiketNoTablosu.Columns)
            {
                toplamGenislik += col.Width;
            }

            int toplamYukseklik = dgv_EtiketNoTablosu.ColumnHeadersHeight;
            if (siparisEtiketNo.Count > 0)
                toplamYukseklik += siparisEtiketNo.Count * dgv_EtiketNoTablosu.Rows[0].Height;
            dgv_EtiketNoTablosu.Location = new Point(0, 0);
            dgv_EtiketNoTablosu.Size = new Size(toplamGenislik +2, toplamYukseklik +2);

            this.ClientSize = dgv_EtiketNoTablosu.Size;
        }


        private void dgv_EtiketNoTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string etiketNo = dgv_EtiketNoTablosu.Rows[e.RowIndex].Cells["EtiketNo"].Value?.ToString() ?? "";
                string raporAdi = dgv_EtiketNoTablosu.Rows[e.RowIndex].Cells["RaporAdi"].Value?.ToString() ?? "";
                string raporModulAdi = dgv_EtiketNoTablosu.Rows[e.RowIndex].Cells["RaporModulAdi"].Value?.ToString() ?? "";

                EtiketNoSecildi?.Invoke(etiketNo, raporAdi, raporModulAdi);
                this.Deactivate -= frm_SGEtiketNoSecenekler_Deactivate;
                this.Close();
            }
        }
        public void Filtrele(string metin)
        {
            EtiketNoYukle(metin);
        }
    }
}
