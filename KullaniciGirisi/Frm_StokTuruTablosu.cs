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
    public partial class Frm_StokTuruTablosu : Form
    {
        public Frm_StokTuruTablosu()
        {
            InitializeComponent();
        }
        ERPEntities db = new ERPEntities();
        private void Form_StokTuruTablosu_Load(object sender, EventArgs e)
        {
            var stokTurleri = from x in db.StokTuruTablosu
                              select new
                              {
                                  x.StokTuru,
                                  x.StokTurAdi,
                                  x.StokTurGrubu
                              };
            DataGridView_StokTuruTablo.DataSource = stokTurleri.ToList();
        }

        private void DataGridView_StokTuruTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string SecilenDeger;
        private void DataGridView_StokTuruTablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                SecilenDeger = DataGridView_StokTuruTablo.Rows[e.RowIndex].Cells["StokTuru"].Value?.ToString() ?? "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btn_StokTuruSec_Click(object sender, EventArgs e)
        {
            if (DataGridView_StokTuruTablo.CurrentRow != null)
            {
                SecilenDeger = DataGridView_StokTuruTablo.CurrentRow.Cells["StokTuru"].Value?.ToString() ?? "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("lütfen bir satır seçiniz");
            }

        }
    }
}
