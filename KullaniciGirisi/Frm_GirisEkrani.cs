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
    public partial class Frm_GirisEkrani : Form
    {
        public Frm_GirisEkrani()
        {
            InitializeComponent();
        }

        ERPEntities db = new ERPEntities();
        private void AnaMenuFormu()
        {
            Form_AnaMenu form_AnaMenu = new Form_AnaMenu();
            form_AnaMenu.Show();
        }
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox3.Text)){
                    string GirilenKullaniciKodu = textBox1.Text;
                    string GirilenSifre = textBox3.Text;

                    var bilgiler = (from x in db.GirisSistemiKullanicilar
                                    where x.KullaniciKodu == GirilenKullaniciKodu
                                    && x.Sifre == GirilenSifre
                                    && x.KullanimdaMi == true
                                    select x).FirstOrDefault();
                    if (bilgiler != null)
                    {
                        switch (bilgiler.YetkiliDuzeyi)
                        {
                            case "0":
                                AnaMenuFormu();
                                this.Hide();
                                break;

                            case "1":
                                AnaMenuFormu();
                                this.Hide();
                                break;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Giriş işlemi başarısız lütfen bilgilerinizi kontrol ediniz");
                    }
                }
                else
                {
                    MessageBox.Show("lütfen bütün alanları doldurunuz");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
