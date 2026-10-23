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
    public partial class Form_AnaMenu : Form
    {
        public Form_AnaMenu()
        {
            InitializeComponent();
        }

        ERPEntities db = new ERPEntities();

        private void Form_AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_SiparisIslemleri_Click(object sender, EventArgs e)
        {
            Form_SiparisGirisi form_SiparisIslemleri = new Form_SiparisGirisi();
            form_SiparisIslemleri.Show();
        }

        private void btn_StokIslemleri_Click(object sender, EventArgs e)
        {
            Form_StokIslemleri form_StokIslemleri = new Form_StokIslemleri();
            form_StokIslemleri .Show();
        }

        private void btn_KullaniciIslemleri_Click(object sender, EventArgs e)
        {
            // yetkili girişi 
            Frm_KullaniciIslemleri frm_KullaniciIslemleri = new Frm_KullaniciIslemleri();
            frm_KullaniciIslemleri.Show();
        }

        private void btn_SiparisRaporlari_Click(object sender, EventArgs e)
        {
            Frm_SiparisRaporlari frm_SiparisRaporlari = new Frm_SiparisRaporlari();
            frm_SiparisRaporlari .Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_SiparisListesiBasitRapor FRM_SiparisListesiBasitRapor = new frm_SiparisListesiBasitRapor();
            FRM_SiparisListesiBasitRapor.Show();
        }
    }
}
