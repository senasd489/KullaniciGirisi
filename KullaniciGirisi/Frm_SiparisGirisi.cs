using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class Form_SiparisGirisi : Form
    {
        public Form_SiparisGirisi()
        {
            InitializeComponent();
        }
        ERPEntities db = new ERPEntities();
        
        
        public void SiparisEkle()
        {
            
            if (!string.IsNullOrWhiteSpace(txt_SiparisNo.Text))
            {
                string GirilenSiparisNo = txt_SiparisNo.Text;
                var MevcutSiparisNo = db.Siparis.FirstOrDefault(x => x.SiparisNo == GirilenSiparisNo);

                if (!string.IsNullOrWhiteSpace(txt_SiparisNo.Text))
                {
                    KaydetSiparisTablosu();
                    KaydetSiparisDetay();
                }
                else
                {
                    MessageBox.Show("Sipariş no boş bırakılamaz.");

                }
            }
            else
            { MessageBox.Show("Sipariş no boş bırakılamaz."); }

        }

        public void KaydetSiparisTablosu()
        {
           
            if (!string.IsNullOrWhiteSpace(txt_SiparisNo.Text))
            {
                string GirilenSiparisNo = txt_SiparisNo.Text;
                var YeniSiparis = db.Siparis.FirstOrDefault(x => x.SiparisNo == GirilenSiparisNo);
                bool YeniKayit = false;
                if (YeniSiparis == null)
                {
                    YeniSiparis = new Siparis();
                    YeniKayit = true;
                }

                if (!string.IsNullOrWhiteSpace(txt_SiparisNo.Text))
                {
                    YeniSiparis.SiparisNo = txt_SiparisNo.Text;
                }

                // boş olabilir olan alanlar

                // combo booxlar :
                if (comboBox_SiparisTuruSecenekler.SelectedIndex != -1)
                {
                    YeniSiparis.SiparisTuru = comboBox_SiparisTuruSecenekler.SelectedItem.ToString();
                }
                else
                { YeniSiparis.SiparisTuru = null; }
                // comboboxlar/ tablolu textboxlar eksik en son  tamamlancak
                if (!string.IsNullOrWhiteSpace(txt_CariNo.Text))
                {
                    YeniSiparis.CariNo = txt_CariNo.Text;
                }
                else
                { YeniSiparis.CariNo = null; }
                if (!string.IsNullOrWhiteSpace(txt_SiparisiAlan.Text))
                {
                    YeniSiparis.SiparisiAlan = txt_SiparisiAlan.Text;
                }
                else
                { YeniSiparis.SiparisiAlan = null; }
                if (!string.IsNullOrWhiteSpace(txt_EtiketNo.Text))
                {
                    YeniSiparis.EtiketNo = txt_EtiketNo.Text;
                }
                else
                {
                    YeniSiparis.EtiketNo = null;
                }
                if (!string.IsNullOrWhiteSpace(txt_HamEtiketNo.Text))
                    YeniSiparis.HamEtiketNo = txt_HamEtiketNo.Text;
                else
                    YeniSiparis.HamEtiketNo = null;

                //kalanalar
                if (!string.IsNullOrWhiteSpace(txt_SiparisiVeren.Text))
                {
                    YeniSiparis.SiparisiVeren = txt_SiparisiVeren.Text;
                }
                else
                { YeniSiparis.SiparisiVeren = null; }
                if (!string.IsNullOrWhiteSpace(txt_StnSiparisNo.Text))
                {
                    YeniSiparis.StnSiparisNo = txt_StnSiparisNo.Text;
                }
                else
                { YeniSiparis.StnSiparisNo = null; }
                if (!string.IsNullOrWhiteSpace(txt_FiyatListeNo.Text))
                { // seçenekler menüsünden dolayı burası tekrar düzenleme gerektirebilir !!!
                    YeniSiparis.FiyatListeNo = txt_FiyatListeNo.Text;
                }
                else
                { YeniSiparis.FiyatListeNo = null; }
                if (!string.IsNullOrWhiteSpace(txt_Aciklama.Text))
                {
                    YeniSiparis.Aciklama = txt_Aciklama.Text;
                }
                else
                { YeniSiparis.Aciklama = null; }
                if (!string.IsNullOrWhiteSpace(txt_AkreditifNo.Text))
                {
                    YeniSiparis.AkreditifNo = txt_AkreditifNo.Text;
                }
                else
                { YeniSiparis.AkreditifNo = null; }
                if (!string.IsNullOrWhiteSpace(txt_OzelKod.Text))
                {
                    YeniSiparis.OzelKod = txt_OzelKod.Text;
                }
                else
                {
                    YeniSiparis.OzelKod = null;
                }
                if (!string.IsNullOrWhiteSpace(txt_VadeGunu.Text))
                {
                    // int değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_VadeGunu.Text, out int VadeGunuDegeri))
                    {
                        YeniSiparis.VadeGunu = VadeGunuDegeri;
                    }
                    else if (txt_VadeGunu.Text == null || txt_VadeGunu.Text == "")
                    {
                        YeniSiparis.VadeGunu = null;
                    }
                    else
                    {
                        MessageBox.Show("Vade günü sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparis.VadeGunu = null; }

                YeniSiparis.DisSiparis = checkBox_DisSiparis.Checked;
                // tarihleri kaydetme :
                YeniSiparis.DuzenlemeTarihi = dateTimePicker_SipDuzenlemeTarihi.Value;
                YeniSiparis.AlinmaTarihi = dateTimePicker_SipAlinmaTarihi.Value;

                // kaydetme işlemi :
                // db.Siparis.Add(YeniSiparis); burayı güncelleme ve kaydetme işlemi arasında ayrım yapabilmek için sonradan ekliycez

                if (YeniKayit)
                {
                    db.Siparis.Add(YeniSiparis);
                }

                db.SaveChanges();

            }
        }

        public void KaydetSiparisDetay()
        {
            if (!string.IsNullOrWhiteSpace(txt_SiparisNo.Text))
            {
                string GirilenSiparisNo = txt_SiparisNo.Text;
                var YeniSiparisDetay = db.SiparisDetay.FirstOrDefault(x => x.SiparisNo == GirilenSiparisNo);

                bool YeniKayit = false;
                if (YeniSiparisDetay == null)
                {
                    YeniSiparisDetay = new SiparisDetay();

                    
                    YeniKayit = true;
                }

                //SiparisDetay YeniSiparisDetay = new SiparisDetay();
                // boş olamaz olan alanlar : 
                if (!string.IsNullOrWhiteSpace(txt_StokTuru.Text))
                {
                    YeniSiparisDetay.StokTuru = txt_StokTuru.Text;
                }
                else
                {
                    MessageBox.Show("Stok türü boş olamaz!");
                }
                // BOŞ OLAMAZ + SEÇENEKLER TABLOLU 
                if (!string.IsNullOrWhiteSpace(txt_StokKodu.Text))
                {
                    YeniSiparisDetay.StokKodu = txt_StokKodu.Text;
                }
                //boş olabilir olan alanlar :
                // SEÇENEK TABLOLU ALANLAR
                if (!string.IsNullOrWhiteSpace(txt_StokAdi.Text))
                {
                    YeniSiparisDetay.StokAdi = txt_StokAdi.Text;
                }
                else
                { YeniSiparisDetay.StokAdi = null; }

                if (!string.IsNullOrWhiteSpace(txt_LotNo.Text))
                {
                    YeniSiparisDetay.LotNo = txt_LotNo.Text;
                }
                else
                { YeniSiparisDetay.LotNo = null; }

                // BOŞ OLABİLİR + TABLOSUZZ + Decimal/int:
                if (!string.IsNullOrWhiteSpace(txt_Miktar1.Text))
                {
                    // int değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Miktar1.Text, out decimal Miktar1))
                    {
                        YeniSiparisDetay.Miktar1 = Miktar1;
                    }
                    else if (txt_Miktar1.Text == null || txt_Miktar1.Text == "")
                    {
                        YeniSiparisDetay.Miktar1 = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Miktar1 = null; }

                if (!string.IsNullOrWhiteSpace(txt_Miktar2.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Miktar2.Text, out decimal Miktar2))
                    {
                        YeniSiparisDetay.Miktar2 = Miktar2;
                    }
                    else if (txt_Miktar2.Text == null || txt_Miktar2.Text == "")
                    {
                        YeniSiparisDetay.Miktar2 = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Miktar2 = null; }

                if (!string.IsNullOrWhiteSpace(txt_Miktar3.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Miktar3.Text, out decimal Miktar3))
                    {
                        YeniSiparisDetay.Miktar3 = Miktar3;
                    }
                    else if (txt_Miktar3.Text == null || txt_Miktar3.Text == "")
                    {
                        YeniSiparisDetay.Miktar3 = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Miktar3 = null; }

                if (!string.IsNullOrWhiteSpace(txt_Fiyat1.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Fiyat1.Text, out decimal Fiyat1))
                    {
                        YeniSiparisDetay.Fiyat1 = Fiyat1;
                    }
                    else if (txt_Fiyat1.Text == null || txt_Fiyat1.Text == "")
                    {
                        YeniSiparisDetay.Fiyat1 = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Fiyat1 = null; }

                if (!string.IsNullOrWhiteSpace(txt_Fiyat2.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Fiyat2.Text, out decimal Fiyat2))
                    {
                        YeniSiparisDetay.Fiyat2 = Fiyat2;
                    }
                    else if (txt_Fiyat2.Text == null || txt_Fiyat2.Text == "")
                    {
                        YeniSiparisDetay.Fiyat2 = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Fiyat2 = null; }

                if (!string.IsNullOrWhiteSpace(txt_Fiyat3.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Fiyat3.Text, out decimal Fiyat3))
                    {
                        YeniSiparisDetay.Fiyat3 = Fiyat3;
                    }
                    else if (txt_Fiyat3.Text == null || txt_Fiyat3.Text == "")
                    {
                        YeniSiparisDetay.Fiyat3 = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Fiyat3 = null; }

                if (!string.IsNullOrWhiteSpace(txt_Tutar.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Tutar.Text, out decimal Tutar))
                    {
                        YeniSiparisDetay.Tutar = Tutar;
                    }
                    else if (txt_Tutar.Text == null || txt_Tutar.Text == "")
                    {
                        YeniSiparisDetay.Tutar = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Tutar = null; }

                if (!string.IsNullOrWhiteSpace(txt_Kdv.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (decimal.TryParse(txt_Kdv.Text, out decimal Kdv))
                    {
                        YeniSiparisDetay.Kdv = Kdv;
                    }
                    else if (txt_Kdv.Text == null || txt_Kdv.Text == "")
                    {
                        YeniSiparisDetay.Kdv = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Kdv = null; }

                if (!string.IsNullOrWhiteSpace(txt_SKarMik.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_SKarMik.Text, out int SKarMik))
                    {
                        YeniSiparisDetay.SKarMik = SKarMik;
                    }
                    else if (txt_SKarMik.Text == null || txt_SKarMik.Text == "")
                    {
                        YeniSiparisDetay.SKarMik = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.SKarMik = null; }

                if (!string.IsNullOrWhiteSpace(txt_Tol.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_Tol.Text, out int Tol))
                    {
                        YeniSiparisDetay.Tol = Tol;
                    }
                    else if (txt_Tol.Text == null || txt_Tol.Text == "")
                    {
                        YeniSiparisDetay.Tol = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Tol = null; }

                if (!string.IsNullOrWhiteSpace(txt_STol.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_STol.Text, out int STol))
                    {
                        YeniSiparisDetay.STol = STol;
                    }
                    else if (txt_STol.Text == null || txt_STol.Text == "")
                    {
                        YeniSiparisDetay.STol = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.STol = null; }

                if (!string.IsNullOrWhiteSpace(txt_Isk.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_Isk.Text, out int Isk))
                    {
                        YeniSiparisDetay.Isk = Isk;
                    }
                    else if (txt_Isk.Text == null || txt_Isk.Text == "")
                    {
                        YeniSiparisDetay.Isk = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.Isk = null; }

                // Olçü  ve kur Birimleri combo boxlar:
                if (comboBox_Miktar1.SelectedIndex != -1)
                {
                    YeniSiparisDetay.MiktarBirimi1 = comboBox_Miktar1.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.MiktarBirimi1 = null; }

                if (comboBox_Miktar2.SelectedIndex != -1)
                {
                    YeniSiparisDetay.MiktarBirimi2 = comboBox_Miktar2.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.MiktarBirimi2 = null; }

                if (comboBox_Miktar3.SelectedIndex != -1)
                {
                    YeniSiparisDetay.MiktarBirimi3 = comboBox_Miktar3.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.MiktarBirimi3 = null; }

                if (comboBox_Fiyat1.SelectedIndex != -1)
                {
                    YeniSiparisDetay.FiyatKuru1 = comboBox_Fiyat1.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.FiyatKuru1 = null; }

                if (comboBox_Fiyat2.SelectedIndex != -1)
                {
                    YeniSiparisDetay.FiyatKuru2 = comboBox_Fiyat2.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.FiyatKuru2 = null; }

                if (comboBox_Fiyat3.SelectedIndex != -1)
                {
                    YeniSiparisDetay.FiyatKuru3 = comboBox_Fiyat3.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.FiyatKuru3 = null; }

                if (comboBox_FiyatOB.SelectedIndex != -1)
                {
                    YeniSiparisDetay.FiyatOB = comboBox_FiyatOB.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.FiyatOB = null; }

                // check box :
                YeniSiparisDetay.PLGormesin = checkBox_PLGormesin.Checked;

                // text boxlar - tablosuz:
                if (!string.IsNullOrWhiteSpace(txt_Barkod.Text))
                {
                    YeniSiparisDetay.Barkod = txt_Barkod.Text;
                }
                else
                { YeniSiparisDetay.Barkod = null; }

                if (!string.IsNullOrWhiteSpace(txt_UreticiKodu.Text))
                {
                    YeniSiparisDetay.UreticiKodu = txt_UreticiKodu.Text;
                }
                else
                { YeniSiparisDetay.UreticiKodu = null; }

                if (!string.IsNullOrWhiteSpace(txt_KoleksiyonKodu.Text))
                {
                    YeniSiparisDetay.KoleksiyonKodu = txt_KoleksiyonKodu.Text;
                }
                else
                { YeniSiparisDetay.KoleksiyonKodu = null; }

                if (!string.IsNullOrWhiteSpace(txt_UreticiAdi.Text))
                {
                    YeniSiparisDetay.UreticiAdi = txt_UreticiAdi.Text;
                }
                else
                { YeniSiparisDetay.UreticiAdi = null; }

                if (!string.IsNullOrWhiteSpace(txt_SDAciklama.Text))
                {
                    YeniSiparisDetay.Aciklama = txt_SDAciklama.Text;
                }
                else
                { YeniSiparisDetay.Aciklama = null; }

                if (!string.IsNullOrWhiteSpace(txt_PlanlamaUyari.Text))
                {
                    YeniSiparisDetay.PlanlamaUyari = txt_PlanlamaUyari.Text;
                }
                else
                { YeniSiparisDetay.PlanlamaUyari = null; }

                // Combo  boxlar:
                if (comboBox_IslemGrubu.SelectedIndex != -1)
                {
                    YeniSiparisDetay.IslemGrubu = comboBox_IslemGrubu.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.IslemGrubu = null; }

                if (comboBox_PaketlemeSekli.SelectedIndex != -1)
                {
                    YeniSiparisDetay.PaketlemeSekli = comboBox_PaketlemeSekli.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.PaketlemeSekli = null; }

                if (comboBox_TebdilNedeni.SelectedIndex != -1)
                {
                    YeniSiparisDetay.TebdilNedeni = comboBox_TebdilNedeni.SelectedItem.ToString();
                }
                else
                { YeniSiparisDetay.TebdilNedeni = null; }

                // textboxlar seçenek tablolu olanlar :

                if (!string.IsNullOrWhiteSpace(txt_OdemeSekli.Text))
                {
                    YeniSiparisDetay.OdemeSekli = txt_OdemeSekli.Text;
                }
                else
                { YeniSiparisDetay.OdemeSekli = null; }

                if (!string.IsNullOrWhiteSpace(txt_IliskiliSipNo.Text))
                {
                    YeniSiparisDetay.IlıskiliSipNo = txt_IliskiliSipNo.Text;
                }
                else
                { YeniSiparisDetay.IlıskiliSipNo = null; }

                if (!string.IsNullOrWhiteSpace(txt_NakliyeSekli.Text))
                {
                    YeniSiparisDetay.NakliyeSekli = txt_NakliyeSekli.Text;
                }
                else
                { YeniSiparisDetay.NakliyeSekli = null; }

                if (!string.IsNullOrWhiteSpace(txt_TeslimSekli.Text))
                {
                    YeniSiparisDetay.TeslimSekli = txt_TeslimSekli.Text;
                }
                else
                { YeniSiparisDetay.TeslimSekli = null; }

                if (!string.IsNullOrWhiteSpace(txt_TebdilPartiNo.Text))
                {
                    YeniSiparisDetay.TebdilPartiNo = txt_TebdilPartiNo.Text;
                }
                else
                { YeniSiparisDetay.TebdilPartiNo = null; }

                if (!string.IsNullOrWhiteSpace(txt_IliskiliSipSNo.Text))
                {
                    YeniSiparisDetay.IliskiliSipSNo = txt_IliskiliSipSNo.Text;
                }
                else
                { YeniSiparisDetay.IliskiliSipSNo = null; }

                // DateTime :
                YeniSiparisDetay.Termin = dateTimePicker_Termin.Value;
                YeniSiparisDetay.PlTermini = dateTimePicker_PITermin.Value;

                // Numeric Up Down
                YeniSiparisDetay.Hafta1 = (int?)numericUpDown_Hafta.Value;
                YeniSiparisDetay.Hafta2 = (int?)numericUpDown_Hafta2.Value;

                // Check boxlar :
                YeniSiparisDetay.Ilave = checkBox_Ilave.Checked;
                YeniSiparisDetay.Tebdil = checkBox_Tebdil.Checked;

                // text boxlarr :
                if (!string.IsNullOrWhiteSpace(txt_EtiketBilgi1.Text))
                {
                    YeniSiparisDetay.EtiketBilgi1 = txt_EtiketBilgi1.Text;
                }
                else
                { YeniSiparisDetay.EtiketBilgi1 = null; }

                if (!string.IsNullOrWhiteSpace(txt_EtiketBilgi2.Text))
                {
                    YeniSiparisDetay.EtiketBilgi2 = txt_EtiketBilgi2.Text;
                }
                else
                { YeniSiparisDetay.EtiketBilgi2 = null; }

                if (!string.IsNullOrWhiteSpace(txt_EtiketBilgi3.Text))
                {
                    YeniSiparisDetay.EtiketBilgi3 = txt_EtiketBilgi3.Text;
                }
                else
                { YeniSiparisDetay.EtiketBilgi3 = null; }

                if (!string.IsNullOrWhiteSpace(txt_EtiketBilgi4.Text))
                {
                    YeniSiparisDetay.EtiketBilgi4 = txt_EtiketBilgi4.Text;
                }
                else
                { YeniSiparisDetay.EtiketBilgi4 = null; }

                if (!string.IsNullOrWhiteSpace(txt_EtiketBilgi5.Text))
                {
                    YeniSiparisDetay.EtiketBilgi5 = txt_EtiketBilgi5.Text;
                }
                else
                { YeniSiparisDetay.EtiketBilgi5 = null; }

                // combo box
                if (comboBox_HPS.SelectedIndex != -1)
                {
                    if (int.TryParse(comboBox_HPS.SelectedItem.ToString(), out int hps))
                    {
                        YeniSiparisDetay.HPS = hps;
                    }
                    else
                    {
                        MessageBox.Show("HPS değeri sayısal olmalıdır!");
                        return;
                    }
                    //YeniSiparisDetay.HPS = (int?)comboBox_HPS.SelectedItem; // YANLIŞ
                }
                else
                { YeniSiparisDetay.HPS = null; }

                // Textboxlar (Tablosuzz) + int dönüşümlüüü :
                if (!string.IsNullOrWhiteSpace(txt_AgirlikTol.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_AgirlikTol.Text, out int AgirlikTol))
                    {
                        YeniSiparisDetay.AgirlikTol = AgirlikTol;
                    }
                    else if (txt_AgirlikTol.Text == null || txt_AgirlikTol.Text == "")
                    {
                        YeniSiparisDetay.AgirlikTol = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.AgirlikTol = null; }

                if (!string.IsNullOrWhiteSpace(txt_SDVadeGunu.Text))
                {
                    // int/decimal değer için veri girişinde dönüşüm işlemleri
                    if (int.TryParse(txt_SDVadeGunu.Text, out int VadeGunu))
                    {
                        YeniSiparisDetay.VadeGunu = VadeGunu;
                    }
                    else if (txt_SDVadeGunu.Text == null || txt_SDVadeGunu.Text == "")
                    {
                        YeniSiparisDetay.VadeGunu = null;
                    }
                    else
                    {
                        MessageBox.Show("sadece sayı değeri olmalıdır");
                        return;
                    }
                }
                else
                { YeniSiparisDetay.VadeGunu = null; }

                // textboxlar tablolu olabnlar :
                if (!string.IsNullOrWhiteSpace(txt_UretimRotaNo.Text))
                {
                    YeniSiparisDetay.UretimRotaNo = txt_UretimRotaNo.Text;
                }
                else
                { YeniSiparisDetay.UretimRotaNo = null; }

                // textboxlar - Özel Alanlarr : 
                // Ozel alanlar için ayrı metod oluşturulduu !!

                /*
                if (!string.IsNullOrWhiteSpace())
                {
                    YeniSiparisDetay.
                }
                else
                { YeniSiparisDetay. }
                */

                // db.SiparisDetay.Add(YeniSiparisDetay); burayı güncelleme ve kaydetme işlemi arasında ayrım yapabilmek için sonradan ekliycez
                //db.SaveChanges();

                if (YeniKayit)
                {
                    db.SiparisDetay.Add(YeniSiparisDetay);
                }
                db.SaveChanges();

            }
        }

        private void DGV_SiparisTablosuGoster()
        {
            var siparisView = db.View_SiparisListesi.ToList();
            dataGridView_Siparisler.DataSource = siparisView;
        }
        public void KaydetSiparisDetayOzelAlanlar()
        {


        }

        private void OzelAlanlariTanimla()
        {
            string girilenStokTuru = txt_StokTuru.Text;
            var stokTuru = db.SiparisozelAlanTanimlari
                .Where(x => x.StokTuru == girilenStokTuru)
                .FirstOrDefault();
            if (stokTuru != null)
            {
                if (stokTuru.ozelAlan1adi != null)
                {
                    lbl_OzelAlanTanimi1.Text = stokTuru.ozelAlan1adi.ToString();
                    txt_OzelAlan1.Visible = true;
                    lbl_OzelAlanTanimi1.Visible = true;
                }
                else
                {
                    txt_OzelAlan1.Visible = false;
                    lbl_OzelAlanTanimi1.Visible = false;
                }

                if (stokTuru.ozelAlan2Adi != null)
                {
                    lbl_OzelAlanTanimi2.Text = stokTuru.ozelAlan2Adi.ToString();
                    txt_OzelAlan2.Visible = true;
                    lbl_OzelAlanTanimi2.Visible = true;
                }
                else
                {
                    txt_OzelAlan2.Visible = false;
                    lbl_OzelAlanTanimi2.Visible = false;
                }

                if (stokTuru.ozelAlan3Adi != null)
                {
                    lbl_OzelAlanTanimi3.Text = stokTuru.ozelAlan3Adi.ToString();
                    txt_OzelAlan3.Visible = true;
                    lbl_OzelAlanTanimi3.Visible = true;
                }
                else
                {
                    txt_OzelAlan3.Visible = false;
                    lbl_OzelAlanTanimi3.Visible = false;
                }

                if (stokTuru.ozelAlan4Adi != null)
                {
                    lbl_OzelAlanTanimi4.Text = stokTuru.ozelAlan4Adi.ToString();
                    txt_OzelAlan4.Visible = true;
                    lbl_OzelAlanTanimi4.Visible = true;
                }
                else
                {
                    txt_OzelAlan4.Visible = false;
                    lbl_OzelAlanTanimi4.Visible = false;
                }

                if (stokTuru.ozelAlan5Adi != null)
                {
                    lbl_OzelAlanTanimi5.Text = stokTuru.ozelAlan5Adi.ToString();
                    txt_OzelAlan5.Visible = true;
                    lbl_OzelAlanTanimi5.Visible = true;
                }
                else
                {
                    txt_OzelAlan5.Visible = false;
                    lbl_OzelAlanTanimi5.Visible = false;
                }

                if (stokTuru.ozelAlan6Adi != null)
                {
                    lbl_OzelAlanTanimi6.Text = stokTuru.ozelAlan6Adi.ToString();
                    txt_OzelAlan6.Visible = true;
                    lbl_OzelAlanTanimi6.Visible = true;
                }
                else
                {
                    txt_OzelAlan6.Visible = false;
                    lbl_OzelAlanTanimi6.Visible = false;
                }

                if (stokTuru.ozelAlan7Adi != null)
                {
                    lbl_OzelAlanTanimi7.Text = stokTuru.ozelAlan7Adi.ToString();
                    txt_OzelAlan7.Visible = true;
                    lbl_OzelAlanTanimi7.Visible = true;
                }
                else
                {
                    txt_OzelAlan7.Visible = false;
                    lbl_OzelAlanTanimi7.Visible = false;
                }

                if (stokTuru.ozelAlan8Adi != null)
                {
                    lbl_OzelAlanTanimi8.Text = stokTuru.ozelAlan8Adi.ToString();
                    txt_OzelAlan8.Visible = true;
                    lbl_OzelAlanTanimi8.Visible = true;
                }
                else
                {
                    txt_OzelAlan8.Visible = false;
                    lbl_OzelAlanTanimi8.Visible = false;
                }

                if (stokTuru.ozelAlan9Adi != null)
                {
                    lbl_OzelAlanTanimi9.Text = stokTuru.ozelAlan9Adi.ToString();
                    txt_OzelAlan9.Visible = true;
                    lbl_OzelAlanTanimi9.Visible = true;
                }
                else
                {
                    txt_OzelAlan9.Visible = false;
                    lbl_OzelAlanTanimi9.Visible = false;
                }

                if (stokTuru.ozelAlan10Adi != null)
                {
                    lbl_OzelAlanTanimi10.Text = stokTuru.ozelAlan10Adi.ToString();
                    txt_OzelAlan10.Visible = true;
                    lbl_OzelAlanTanimi10.Visible = true;
                }
                else
                {
                    txt_OzelAlan10.Visible = false;
                    lbl_OzelAlanTanimi10.Visible = false;
                }

                if (stokTuru.ozelAlan11Adi != null)
                {
                    lbl_OzelAlanTanimi11.Text = stokTuru.ozelAlan11Adi.ToString();
                    txt_OzelAlan11.Visible = true;
                    lbl_OzelAlanTanimi11.Visible = true;
                }
                else
                {
                    txt_OzelAlan11.Visible = false;
                    lbl_OzelAlanTanimi11.Visible = false;
                }

                if (stokTuru.ozelAlan12Adi != null)
                {
                    lbl_OzelAlanTanimi12.Text = stokTuru.ozelAlan12Adi.ToString();
                    txt_OzelAlan12.Visible = true;
                    lbl_OzelAlanTanimi12.Visible = true;
                }
                else
                {
                    txt_OzelAlan12.Visible = false;
                    lbl_OzelAlanTanimi12.Visible = false;
                }


            }
        }
        private void btn_SiparisNoSecenekler_Click(object sender, EventArgs e)
        {
            Form_SiparisNoSecenekler form_SiparisNoSecenekler = new Form_SiparisNoSecenekler();
            form_SiparisNoSecenekler.Show();

        }
        private void Form_SiparisGirisi_Load(object sender, EventArgs e)
        {
            DGV_SiparisTablosuGoster();
            this.Controls.Remove(splitContainer1);
            panel3.Controls.Add(splitContainer1);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Enabled = false;

            // combobox'ların işlemleri( combo box değilmiş)<
            /*
            var siparisCariNo = db.SiparisCariNo.ToList();
            comboBox_CariNo.DataSource = siparisCariNo;
            comboBox_CariNo.DisplayMember = "CariNo";
            comboBox_CariNo.DisplayMember = "CariAdi";
            comboBox_CariNo.ValueMember = "CariNoID";

            comboBox_CariNo.SelectedIndex = -1;
            */

            lbl_OzelAlanTanimi1.Visible = false;
            txt_OzelAlan1.Visible = false;
            lbl_OzelAlanTanimi2.Visible = false;
            txt_OzelAlan2.Visible = false;
            lbl_OzelAlanTanimi3.Visible = false;
            txt_OzelAlan3.Visible = false;
            lbl_OzelAlanTanimi4.Visible = false;
            txt_OzelAlan4.Visible = false;
            lbl_OzelAlanTanimi5.Visible = false;
            txt_OzelAlan5.Visible = false;
            lbl_OzelAlanTanimi6.Visible = false;
            txt_OzelAlan6.Visible = false;
            lbl_OzelAlanTanimi7.Visible = false;
            txt_OzelAlan7.Visible = false;
            lbl_OzelAlanTanimi8.Visible = false;
            txt_OzelAlan8.Visible = false;
            lbl_OzelAlanTanimi9.Visible = false;
            txt_OzelAlan9.Visible = false;
            lbl_OzelAlanTanimi10.Visible = false;
            txt_OzelAlan10.Visible = false;
            lbl_OzelAlanTanimi11.Visible = false;
            txt_OzelAlan11.Visible = false;
            lbl_OzelAlanTanimi12.Visible = false;
            txt_OzelAlan12.Visible = false;

        }

        // CariNo text boxun tablo işlemleri vs.
        Frm_CariNo frm_CariNo;
        private void txt_CariNo_TextChanged(object sender, EventArgs e)
        {
            if (frm_CariNo == null || frm_CariNo.IsDisposed)
            {
                frm_CariNo = new Frm_CariNo();
                frm_CariNo.StartPosition = FormStartPosition.Manual;
                frm_CariNo.Location = txt_CariNo.PointToScreen(new Point(0, txt_CariNo.Height));
                frm_CariNo.Size = new Size(txt_CariNo.Width + 200, 250);
                frm_CariNo.Show(this);
            }
            frm_CariNo.Filtrele(txt_CariNo.Text);
        }
        private void txt_CariNo_Leave(object sender, EventArgs e)
        {
            // çıkılınca popup'ı kapat (Gecikmeli) :
            Task.Delay(150).ContinueWith(_ =>
            {
                if (frm_CariNo != null && !frm_CariNo.IsDisposed)
                {
                    this.Invoke((MethodInvoker)(() => frm_CariNo.Close()));
                }
            });
        }

        // Seçim yapıldığında ana formu güncelle 
        private void txt_CariNo_Click(object sender, EventArgs e)
        {
            // bunu butonla yapıyoruz burda gerek kalmadı .
            //using (Frm_CariNo frm = new Frm_CariNo())
            //{
            //    frm.StartPosition = FormStartPosition.Manual;
            //    frm.Location = txt_CariNo.PointToScreen(new Point(0, txt_CariNo.Height));

            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        txt_CariNo.Text = frm.SeciliCariNo;
            //    }
            //}
        }
        private void lbl_HametiketNo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_VadeGunu_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = true;
        }

        private void btn_KaydetSiparis_Click(object sender, EventArgs e)
        {
            //KaydetSiparisTablosu();
            //KaydetSiparisDetay();


            SiparisEkle();
            MessageBox.Show("Kayıt İşlemi Başarılı");
            dataGridView_Siparisler.Enabled = true;
            panel1.Enabled = false;

        }

        private void btn_VazgecSiparis_Click(object sender, EventArgs e)
        {
            dataGridView_Siparisler.Enabled = true;
            panel1.Enabled = false;

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // fiyat liste no formu(tablo) açılcak
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_CariNo frm = new Frm_CariNo();

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = txt_CariNo.PointToScreen(new Point(0, txt_CariNo.Height));

            frm.CariSecildi += (cariNo, cariAdi) =>
            {
                txt_CariNo.Text = cariNo;
            };

            frm.Show(this);

        }

        private void btn_SiparisiAlanSecenekler_Click(object sender, EventArgs e)
        {
            Frm_SiparisiAlan frm = new Frm_SiparisiAlan();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = txt_SiparisiAlan.PointToScreen(new Point(0, txt_SiparisiAlan.Height));

            frm.SiparisAlanSecildi += (siparisAlan, siparisAlanAdi) =>
            {
                txt_SiparisiAlan.Text = siparisAlan;
            };

            frm.Show(this);
        }

        private void txt_SiparisiAlan_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_CariNo_TextChanged_1(object sender, EventArgs e)
        {
            Frm_CariNo frm = new Frm_CariNo();

            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = txt_CariNo.PointToScreen(new Point(0, txt_CariNo.Height));

            frm.CariSecildi += (cariNo, cariAdi) =>
            {
                txt_CariNo.Text = cariNo;
            };

            frm.Show(this);
        }

        private void btn_EtiketNoSecenekler_Click(object sender, EventArgs e)
        {
            frm_SGEtiketNoSecenekler frm = new frm_SGEtiketNoSecenekler();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = txt_EtiketNo.PointToScreen(new Point(0, txt_EtiketNo.Height));

            frm.EtiketNoSecildi += (etiketNo, raporAdi, raporModulAdi) =>
            {
                txt_EtiketNo.Text = etiketNo;
            };
            frm.Show(this);
        }

        private void btn_HamEtiketNoSecenekler_Click(object sender, EventArgs e)
        {
            frm_SGHamEtiketNoSecenekler frm = new frm_SGHamEtiketNoSecenekler();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = txt_HamEtiketNo.PointToScreen(new Point(0, txt_HamEtiketNo.Height));

            frm.HamEtiketNoSecildi += (hamEtiketNo, hamRaporAdi, hamRaporModulAdi) =>
            {
                txt_HamEtiketNo.Text = hamEtiketNo;
            };
            frm.Show(this);

        }

        private void btn_StokKoduSecenekler_Click(object sender, EventArgs e)
        {
            cms_StokKoduSecenekleri.Show(btn_StokKoduSecenekler, new Point(0, btn_StokKoduSecenekler.Height));
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm_StokTuruSecenekler frm = new frm_StokTuruSecenekler();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = txt_StokTuru.PointToScreen(new Point(0, txt_StokTuru.Height));

            frm.StokTuruSecildi += (StokTuru, StokTurAdi, StokTurGrubu) =>
            {
                txt_StokTuru.Text = StokTuru;
            };

            frm.Show(this);

        }
        // TEXBOXA SADECE SAYI GİRİŞİ SINIRLAMASI
        private void txt_Fiyat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Fiyat2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Fiyat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Miktar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Miktar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Miktar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Tol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Isk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbl_AgirlikTol_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbl_PITermini_Click(object sender, EventArgs e)
        {

        }

        private void btn_StokAdiSecenekler_Click(object sender, EventArgs e)
        {

        }

        private void btn_LotNoSecenekler_Click(object sender, EventArgs e)
        {
            Frm_SDLotNoSecenekler form_SDLotNoSecenekler = new Frm_SDLotNoSecenekler();
            form_SDLotNoSecenekler.Show();

            txt_LotNo.Text = form_SDLotNoSecenekler.SecilenLotNo;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_Siparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = e.RowIndex;
            if (secilenSatir >= 0)
            {
                txt_SiparisNo.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["SiparisNo"].Value?.ToString() ?? "";
                txt_StokTuru.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["StokTuru"].Value?.ToString() ?? "";
                txt_StokKodu.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["StokKodu"].Value?.ToString() ?? "";
                txt_StokAdi.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["StokAdi"].Value?.ToString() ?? "";
                txt_Miktar1.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["Miktar1"].Value?.ToString() ?? "";
                comboBox_Miktar1.SelectedItem = dataGridView_Siparisler.Rows[secilenSatir].Cells["MiktarBirimi1"].Value?.ToString() ?? "";
                txt_TeslimSekli.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["TeslimSekli"].Value?.ToString() ?? "";
                // date time picker
                var hucreDegeri = dataGridView_Siparisler.Rows[secilenSatir].Cells["PlTermini"].Value;
                if (DateTime.TryParse(hucreDegeri?.ToString(), out DateTime tarih))
                {
                    dateTimePicker_PITermin.Value = tarih;
                }
                else
                {
                    dateTimePicker_PITermin.Value = DateTime.Now;
                }

                txt_PlanlamaUyari.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["PlanlamaUyari"].Value?.ToString() ?? "";
                txt_UreticiAdi.Text = dataGridView_Siparisler.Rows[secilenSatir].Cells["UreticiAdi"].Value?.ToString() ?? "";
                checkBox_Tebdil.Checked = Convert.ToBoolean(dataGridView_Siparisler.Rows[secilenSatir].Cells["Tebdil"].Value);


                string siparisNo = txt_SiparisNo.Text;
                var siparis = db.Siparis.FirstOrDefault(x => x.SiparisNo == siparisNo);

                if (siparis != null)
                {
                    comboBox_SiparisTuruSecenekler.SelectedItem = siparis.SiparisTuru?.ToString();
                    txt_CariNo.Text = siparis.CariNo?.ToString();
                    txt_SiparisiAlan.Text = siparis.SiparisiAlan?.ToString();
                    if (siparis.DuzenlemeTarihi.HasValue)
                    {
                        dateTimePicker_SipDuzenlemeTarihi.Value = siparis.DuzenlemeTarihi.Value;
                    }
                    else
                    {
                        dateTimePicker_SipDuzenlemeTarihi.Value = DateTime.Now;
                    }
                    txt_StnSiparisNo.Text = siparis.StnSiparisNo?.ToString();
                    txt_FiyatListeNo.Text = siparis.FiyatListeNo?.ToString();
                    txt_Aciklama.Text = siparis.Aciklama?.ToString();
                    if (siparis.AlinmaTarihi.HasValue)
                    {
                        dateTimePicker_SipAlinmaTarihi.Value = siparis.AlinmaTarihi.Value;
                    }
                    else
                    {
                        dateTimePicker_SipAlinmaTarihi.Value = DateTime.Now;
                    }
                    txt_AkreditifNo.Text = siparis.AkreditifNo?.ToString();
                    txt_OzelKod.Text = siparis.OzelKod?.ToString();
                    txt_EtiketNo.Text = siparis.EtiketNo?.ToString();
                    txt_HamEtiketNo.Text = siparis.HamEtiketNo?.ToString();
                    txt_VadeGunu.Text = siparis.VadeGunu?.ToString();
                    checkBox_DisSiparis.Checked = siparis.DisSiparis ?? false;


                }
                else
                {
                    comboBox_SiparisTuruSecenekler.SelectedItem = null;
                    txt_CariNo.Text = null;
                    txt_SiparisiAlan.Text = null;
                    dateTimePicker_SipDuzenlemeTarihi.Value = DateTime.Now;
                    dateTimePicker_SipAlinmaTarihi.Value = DateTime.Now;
                    txt_StnSiparisNo.Text = null;
                    txt_FiyatListeNo.Text = null;
                    txt_Aciklama.Text = null;
                    txt_AkreditifNo.Text = null;
                    txt_OzelKod.Text = null;
                    txt_EtiketNo.Text = null;
                    txt_HamEtiketNo.Text = null;
                    txt_VadeGunu.Text = null;
                    checkBox_DisSiparis.Checked = false;
                }
                var siparisDetay = db.SiparisDetay.FirstOrDefault(x => x.SiparisNo == siparisNo);

                if (siparisDetay != null)
                {
                    txt_LotNo.Text = siparisDetay.LotNo?.ToString();
                    txt_Miktar2.Text = siparisDetay.Miktar2?.ToString();
                    txt_Miktar3.Text = siparisDetay.Miktar3?.ToString();
                    txt_Fiyat1.Text = siparisDetay.Fiyat1?.ToString();
                    txt_Fiyat2.Text = siparisDetay.Fiyat2?.ToString();
                    txt_Fiyat3.Text = siparisDetay.Fiyat3?.ToString();
                    comboBox_Miktar1.SelectedItem = siparisDetay.Miktar1?.ToString();
                    comboBox_Miktar2.SelectedItem = siparisDetay.Miktar2?.ToString();
                    comboBox_Miktar3.SelectedItem = siparisDetay.Miktar3?.ToString();
                    comboBox_Fiyat1.SelectedItem = siparisDetay.FiyatKuru1?.ToString();
                    comboBox_Fiyat2.SelectedItem = siparisDetay.FiyatKuru2?.ToString();
                    comboBox_Fiyat3.SelectedItem = siparisDetay.FiyatKuru3?.ToString();
                    txt_Tutar.Text = siparisDetay.Tutar?.ToString();
                    txt_Kdv.Text = siparisDetay.Kdv?.ToString();
                    comboBox_FiyatOB.SelectedItem = siparisDetay.FiyatOB?.ToString();
                    checkBox_PLGormesin.Checked = siparisDetay.PLGormesin ?? false;
                    txt_SKarMik.Text = siparisDetay.SKarMik?.ToString();
                    txt_STol.Text = siparisDetay.STol?.ToString();
                    txt_Tol.Text = siparisDetay.Tol?.ToString();
                    txt_Isk.Text = siparisDetay.Isk?.ToString();
                    txt_Barkod.Text = siparisDetay?.Barkod?.ToString();
                    comboBox_IslemGrubu.SelectedItem = siparisDetay.IslemGrubu?.ToString();
                    txt_UreticiKodu.Text = siparisDetay?.UreticiKodu?.ToString();
                    txt_KoleksiyonKodu.Text = siparisDetay.KoleksiyonKodu?.ToString();
                    txt_OdemeSekli.Text = siparisDetay?.OdemeSekli?.ToString();
                    comboBox_PaketlemeSekli.Text = siparisDetay?.PaketlemeSekli?.ToString();
                    txt_IliskiliSipNo.Text = siparisDetay?.IlıskiliSipNo?.ToString();
                    txt_Aciklama.Text = siparisDetay?.Aciklama?.ToString();
                    txt_PlanlamaUyari.Text = siparisDetay?.PlanlamaUyari?.ToString();

                    txt_UreticiAdi.Text = siparisDetay.UreticiAdi?.ToString();

                    txt_TeslimSekli.Text = siparisDetay.TeslimSekli?.ToString();
                }
                else   // ✅ EKLENEN BLOK — detay hiç oluşturulmamışsa tüm alanları temizle
                {
                    txt_LotNo.Text = null;
                    txt_Miktar2.Text = null;
                    txt_Miktar3.Text = null;
                    txt_Fiyat1.Text = null;
                    txt_Fiyat2.Text = null;
                    txt_Fiyat3.Text = null;
                    comboBox_Miktar1.SelectedItem = null;
                    comboBox_Miktar2.SelectedItem = null;
                    comboBox_Miktar3.SelectedItem = null;
                    comboBox_Fiyat1.SelectedItem = null;
                    comboBox_Fiyat2.SelectedItem = null;
                    comboBox_Fiyat3.SelectedItem = null;
                    txt_Tutar.Text = null;
                    txt_Kdv.Text = null;
                    comboBox_FiyatOB.SelectedItem = null;
                    checkBox_PLGormesin.Checked = false;
                    txt_SKarMik.Text = null;
                    txt_STol.Text = null;
                    txt_Tol.Text = null;
                    txt_Isk.Text = null;
                    txt_Barkod.Text = null;
                    comboBox_IslemGrubu.SelectedItem = null;
                    txt_UreticiKodu.Text = null;
                    txt_KoleksiyonKodu.Text = null;
                    txt_OdemeSekli.Text = null;
                    comboBox_PaketlemeSekli.Text = null;
                    txt_IliskiliSipNo.Text = null;
                    txt_Aciklama.Text = null;
                    txt_PlanlamaUyari.Text = null;
                    txt_UreticiAdi.Text = null;
                    txt_TeslimSekli.Text = null;
                }
            }

        }

        private void dataGridView_Siparisler_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView_Siparisler.ClearSelection();
                dataGridView_Siparisler.Rows[e.RowIndex].Selected = true;
                dataGridView_Siparisler.CurrentCell = dataGridView_Siparisler.Rows[e.RowIndex].Cells[e.ColumnIndex];


                Point ekranKonumu = dataGridView_Siparisler.PointToClient(Cursor.Position);
                contextMenuStrip1.Show(dataGridView_Siparisler, ekranKonumu);

            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            dataGridView_Siparisler.Enabled = false;
            panel1.Enabled = true;
            //panel1.Visible = true;

            /* Biz bunu farklı bi yöntemle yaptık : 
            İstersen seçili satırın verilerini panel içindeki alanlara doldur:
            var row = dgv.Rows[dgv.CurrentCell.RowIndex];
            txtStokKodu.Text = row.Cells["StokKodu"].Value?.ToString();
            ... diğer alanlar
            */

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
   
    
}
