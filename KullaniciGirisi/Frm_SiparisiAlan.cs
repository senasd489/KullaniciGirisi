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
    public partial class Frm_SiparisiAlan : Form
    {
        public event Action<string, string> SiparisAlanSecildi;
        public Frm_SiparisiAlan()
        {
            InitializeComponent();

            this.Deactivate += FrmSiparisiAlan_Deactivate;

            SiparisAlanYukle("");
        }

        private void FrmSiparisiAlan_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SiparisAlanYukle(string filtre)
        {
            ERPEntities db = new ERPEntities();
            var siparisSiparisiAlan = db.SiparisSiparisiAlan
                .Where(a => string.IsNullOrEmpty(filtre) || a.SiparisiAlan.Contains(filtre))
                .Select(a => new {a.SiparisiAlan,a.SiparisiAlanAdi})
                .ToList();
            dgv_SiparisiAlanTablosu.DataSource = siparisSiparisiAlan;
            dgv_SiparisiAlanTablosu.Columns["SiparisiAlan"].HeaderText = "SiparisiAlan";
            dgv_SiparisiAlanTablosu.Columns["SiparisiAlanAdi"].HeaderText = "SiparisiAlanAdi";
            dgv_SiparisiAlanTablosu.ReadOnly = true;
            dgv_SiparisiAlanTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SiparisiAlanTablosu.AllowUserToAddRows = false;
            dgv_SiparisiAlanTablosu.RowHeadersVisible = false;
            dgv_SiparisiAlanTablosu.ScrollBars = ScrollBars.Vertical;
            dgv_SiparisiAlanTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // boyutu hesaplama :
            int toplamGenislik = 0;
            foreach (DataGridViewColumn col in dgv_SiparisiAlanTablosu.Columns)
                toplamGenislik += col.Width;

            int toplamYukseklik = dgv_SiparisiAlanTablosu.ColumnHeadersHeight;
            if (siparisSiparisiAlan.Count > 0)
                toplamYukseklik += siparisSiparisiAlan.Count * dgv_SiparisiAlanTablosu.Rows[0].Height;

            dgv_SiparisiAlanTablosu.Location = new Point(0, 0);
            dgv_SiparisiAlanTablosu.Size = new Size(toplamGenislik + 2, toplamYukseklik + 2);

            this.ClientSize = dgv_SiparisiAlanTablosu.Size;
        }

        private void Frm_SiparisiAlan_Load(object sender, EventArgs e)
        {

        }

        private void dgv_SiparisiAlanTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string siparisAlan = dgv_SiparisiAlanTablosu.Rows[e.RowIndex].Cells["SiparisiAlan"].Value?.ToString() ?? "";
                string siparisAlanAdi = dgv_SiparisiAlanTablosu.Rows[e.RowIndex].Cells["SiparisiAlanAdi"].Value?.ToString() ?? "";

                SiparisAlanSecildi?.Invoke(siparisAlan, siparisAlanAdi);
                this.Deactivate -= FrmSiparisiAlan_Deactivate;
                this.Close();
            }

        }

        public void Filtrele(string metin)
        {
            SiparisAlanYukle(metin);
        }
    }
}
