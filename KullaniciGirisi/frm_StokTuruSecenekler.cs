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
    public partial class frm_StokTuruSecenekler : Form
    {
        public event Action<string, string, string> StokTuruSecildi;
        public frm_StokTuruSecenekler()
        {
            InitializeComponent();

            this.Deactivate += frm_StokTuruSecenekler_Deactivate;

            StokTuruYukle("");
        }

        private void frm_StokTuruSecenekler_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StokTuruYukle(string filtre)
        {
            ERPEntities db = new ERPEntities();

            var stokTuru = db.StokTuruTablosu
                .Where(a => string.IsNullOrEmpty(filtre) || a.StokTuru.Contains(filtre))
                .Select(a  => new {a.StokTuru, a.StokTurAdi, a.StokTurGrubu})
                .ToList();

            dgv_StokTuruSecenekler.DataSource = stokTuru;
            dgv_StokTuruSecenekler.Columns["StokTuru"].HeaderText = "Stok Türü";
            dgv_StokTuruSecenekler.Columns["StokTurAdi"].HeaderText = "Stok Tür Adı";
            dgv_StokTuruSecenekler.Columns["StokTurGrubu"].HeaderText = "Stok Tür Grubu";
            dgv_StokTuruSecenekler.ReadOnly = true;
            dgv_StokTuruSecenekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_StokTuruSecenekler.AllowUserToAddRows = false;
            dgv_StokTuruSecenekler.RowHeadersVisible = false;
            dgv_StokTuruSecenekler.ScrollBars = ScrollBars.Vertical;
            dgv_StokTuruSecenekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int toplamGenislik = 0;
            foreach (DataGridViewColumn col in dgv_StokTuruSecenekler.Columns)
                toplamGenislik += col.Width;

            int toplamYukseklik = dgv_StokTuruSecenekler.ColumnHeadersHeight;
            if (stokTuru.Count > 0)
                toplamYukseklik += stokTuru.Count * dgv_StokTuruSecenekler.Rows[0].Height;

            dgv_StokTuruSecenekler.Location = new Point(0, 0);
            dgv_StokTuruSecenekler.Size = new Size(toplamGenislik + 2, toplamYukseklik + 2);

            this.ClientSize = dgv_StokTuruSecenekler.Size;
        }
        private void frm_StokTuruSecenekler_Load(object sender, EventArgs e)
        {

        }

        private void dgv_StokTuruSecenekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0)
            {
                string stokTuru = dgv_StokTuruSecenekler.Rows[e.RowIndex].Cells["StokTuru"].Value?.ToString() ?? "";
                string stokTurAdi = dgv_StokTuruSecenekler.Rows[e.RowIndex].Cells["StokTurAdi"].Value?.ToString() ?? "";
                string stokTurGrubu = dgv_StokTuruSecenekler.Rows[e.RowIndex].Cells["StokTurGrubu"].Value?.ToString() ?? "";

                StokTuruSecildi?.Invoke(stokTuru, stokTurAdi, stokTurGrubu);
                this.Deactivate -= frm_StokTuruSecenekler_Deactivate;
                this.Close();

            }

        }

        public void Filtrele(string metin)
        {
            StokTuruYukle(metin);
        }

















































































































    }
}
