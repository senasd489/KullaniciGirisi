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
    public partial class Frm_CariNo : Form
    {
        // ESKİ YÖNTEME (SHOWDİALOG) AİT BİR KOD
        // public string SeciliCariNo { get; private set; }
        // public string SeciliCariAdi {  get; private set; }

        // secim yapıldığını bildiren event :
        public event Action<string, string> CariSecildi;

        public Frm_CariNo()
        {
            InitializeComponent();
            CarileriYukle("");

            // form dışına tıklandığında formu kapat:
            this.Deactivate += Frm_CariNo_Deactivate;

        }

        private void Frm_CariNo_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarileriYukle(string filtre)
        {
            ERPEntities db = new ERPEntities();
            var siparisCariNo = db.SiparisCariNo
                .Where(c => string.IsNullOrEmpty(filtre) || c.CariNo.Contains(filtre))
                .Select(c => new { c.CariAdi, c.CariNo })
                .ToList();
            dgv_CariNoTablosu.DataSource = siparisCariNo;
            dgv_CariNoTablosu.Columns["CariAdi"].HeaderText = "Cari Adı";
            dgv_CariNoTablosu.Columns["CariNo"].HeaderText = "Cari No";
            dgv_CariNoTablosu.ReadOnly = true;
            dgv_CariNoTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CariNoTablosu.AllowUserToAddRows = false;
            dgv_CariNoTablosu.RowHeadersVisible = false;
            dgv_CariNoTablosu.ScrollBars = ScrollBars.Vertical;

            // boyutlandırma
            dgv_CariNoTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int toplamGenislik = 0;
            foreach (DataGridViewColumn col in dgv_CariNoTablosu.Columns)
                toplamGenislik += col.Width;

            // Toplam yüksekliği hesapla: başlık + (satır sayısı * satır yüksekliği)
            int toplamYukseklik = dgv_CariNoTablosu.ColumnHeadersHeight;
            if (siparisCariNo.Count > 0 )
            {
                toplamYukseklik += siparisCariNo.Count * dgv_CariNoTablosu.Rows[0].Height;
            }
            dgv_CariNoTablosu.Location = new Point(0, 0);
            dgv_CariNoTablosu.Size = new Size(toplamGenislik + 2, toplamYukseklik + 2);
            
            // Formu da DataGridView ile BİREBİR aynı boyuta getir
            this.ClientSize = dgv_CariNoTablosu.Size;
        
        }
        // stıra tıklayarak seçme
        private void dgv_Cari_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0) 
                {
                    string cariNo = dgv_CariNoTablosu.Rows[e.RowIndex].Cells["CariNo"].Value.ToString();
                    string cariAdi = dgv_CariNoTablosu.Rows[e.RowIndex].Cells["CariAdi"].Value.ToString();
                    
                    CariSecildi?.Invoke(cariNo, cariAdi);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Yazı yazılırken filtreleme
        public void Filtrele(string metin)
        {
            CarileriYukle(metin);
        }

        private void dgv_CariNoTablosu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string cariNo = dgv_CariNoTablosu.Rows[e.RowIndex].Cells["CariNo"].Value.ToString();
                string cariAdi = dgv_CariNoTablosu.Rows[e.RowIndex].Cells["CariAdi"].Value.ToString();
                
                CariSecildi?.Invoke(cariNo, cariAdi);
                this.Deactivate -= Frm_CariNo_Deactivate;
                this.Close();            
            }

            /*  Eski kod yani show dialoga göre yaptığımız şuan show ile yapıyoz
            if(e.RowIndex >= 0)
            {
                SeciliCariNo = dgv_CariNoTablosu.Rows[e.RowIndex].Cells["CariNo"].Value.ToString();
                SeciliCariAdi = dgv_CariNoTablosu.Rows[e.RowIndex].Cells["CariAdi"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            */
        }

        private void Frm_CariNo_Load(object sender, EventArgs e)
        {

        }
    }
    
    
}

