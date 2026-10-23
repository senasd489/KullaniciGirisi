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
    public partial class Frm_KullaniciIslemleri : Form
    {
        public Frm_KullaniciIslemleri()
        {
            InitializeComponent();
        }
        ERPEntities db = new ERPEntities();
        private void Listele()
        {
            var kisiler = from x in db.GirisSistemiKullanicilar
                          select new
                          {
                              x.KullaniciID,
                              x.KullaniciKodu,
                              x.KullaniciAdi,
                              x.Sifre,
                              x.KullanimdaMi,
                              x.YetkiliDuzeyi
                          };
            dataGridView_list.DataSource = kisiler.ToList();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonKisiEkle_Click(object sender, EventArgs e)
        {
            GirisSistemiKullanicilar a = new GirisSistemiKullanicilar();
            if(!string.IsNullOrWhiteSpace(textBoxKullaniciKodu.Text))
            {
                a.KullaniciKodu = textBoxKullaniciKodu.Text;
            }
            if(!string.IsNullOrWhiteSpace(textBoxKullaniciAdi.Text))
            {
                a.KullaniciAdi = textBoxKullaniciAdi.Text;
            }
            if (!string.IsNullOrWhiteSpace(textBoxSifre.Text))
            {
                a.Sifre = textBoxSifre.Text;
            }
            a.YetkiliDuzeyi = txt_YetkiliDuzeyi.Text;
            a.KullanimdaMi = checkBoxAktifMi.Checked;
            bool kontrolKullaniciKodu = db.GirisSistemiKullanicilar.Any(x => x.KullaniciKodu == a.KullaniciKodu);
            if (kontrolKullaniciKodu)
            {
                MessageBox.Show("Bu kullanıcı kodu zaten kayıtlı!");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBoxKullaniciKodu.Text) 
                    &&!string.IsNullOrWhiteSpace(textBoxKullaniciAdi.Text) 
                    && !string.IsNullOrWhiteSpace(textBoxSifre.Text))
                {
                    db.GirisSistemiKullanicilar.Add(a);
                    db.SaveChanges();
                    MessageBox.Show("Yeni kişi eklendi");
                    Listele();
                }
                else
                {
                    MessageBox.Show("HAT : lütfen boş alan bırakmayınız!");
                }
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_KullaniciID.Text);
            var x = db.GirisSistemiKullanicilar.Find(id);
            if (x != null)
            {
                
                if (!string.IsNullOrWhiteSpace(textBoxKullaniciKodu.Text)) 
                { 
                    x.KullaniciKodu = textBoxKullaniciKodu.Text; 
                    db.SaveChanges(); 
                }
                
                if (!string.IsNullOrWhiteSpace(textBoxKullaniciAdi.Text)) 
                { 
                    x.KullaniciAdi = textBoxKullaniciAdi.Text; 
                    db.SaveChanges(); 
                }
                
                if (!string.IsNullOrWhiteSpace(textBoxSifre.Text)) 
                {
                    x.Sifre = textBoxSifre.Text;
                    db.SaveChanges(); 
                }
                if (!string.IsNullOrWhiteSpace(txt_YetkiliDuzeyi.Text))
                {
                    x.YetkiliDuzeyi = txt_YetkiliDuzeyi.Text; 
                    db.SaveChanges();
                }
                x.KullanimdaMi = checkBoxAktifMi.Checked;


                if(string.IsNullOrEmpty(textBoxKullaniciKodu.Text) 
                    && string.IsNullOrWhiteSpace(textBoxKullaniciAdi.Text) 
                    && string.IsNullOrWhiteSpace(textBoxSifre.Text)
                    && string.IsNullOrWhiteSpace(txt_YetkiliDuzeyi.Text
                    )) 
                {
                    MessageBox.Show("Hata : bütün alanlar boş");
                }
                else
                {
                    db.SaveChanges();
                    MessageBox.Show("bilgiler başarıyla güncellendi");
                    Listele();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txt_KullaniciID.Text))
                {
                    MessageBox.Show("Hata : id alanı boş bırakılamaz");
                }
                else
                {
                    MessageBox.Show("Hata : geçersiz id");
                }
            }

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_KullaniciID.Text);
            var x = db.GirisSistemiKullanicilar.Find(id);
            if (!string.IsNullOrWhiteSpace(txt_KullaniciID.Text))
            {
                if (x != null)
                {
                    db.GirisSistemiKullanicilar.Remove(x);
                    db.SaveChanges();
                    MessageBox.Show("silme işlemi başarılı");
                    Listele();
                }
                else
                {
                    MessageBox.Show("HATA: ID bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("HATA: ID alanı boş ");
            }
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            Listele();                
        }

        private void dataGridView_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = e.RowIndex;

            if(secilenSatir >= 0)
            {
                txt_KullaniciID.Text = dataGridView_list.Rows[secilenSatir].Cells["KullaniciID"].Value?.ToString() ?? "";
                textBoxKullaniciKodu.Text = dataGridView_list.Rows[secilenSatir].Cells["KullaniciKodu"].Value?.ToString() ?? "";
                textBoxKullaniciAdi.Text = dataGridView_list.Rows[secilenSatir].Cells["KullaniciAdi"].Value?.ToString() ?? "";
                textBoxSifre.Text = dataGridView_list.Rows[secilenSatir].Cells["Sifre"].Value?.ToString() ?? "";
                txt_YetkiliDuzeyi.Text = dataGridView_list.Rows[secilenSatir].Cells["YetkiliDuzeyi"].Value?.ToString() ?? "";
                checkBoxAktifMi.Checked = Convert.ToBoolean(dataGridView_list.Rows[secilenSatir].Cells["kullanimdaMi"].Value);

            }
        }

        private void btn_AnaMenu_Click(object sender, EventArgs e)
        {
            Form_AnaMenu form_AnaMenu = new Form_AnaMenu();
            form_AnaMenu.Show();
        }
    }
}
