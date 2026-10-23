using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisi
{
    public partial class Form_StokIslemleri : Form
    {
        public Form_StokIslemleri()
        {
            InitializeComponent();
        }
        ERPEntities db = new ERPEntities();
        private void OzelAlanTanimla()
        {
            string girilenStokTuru = txt_StokTuru.Text;
            string girilenStokKodu = txt_StokKodu.Text;

            var stokTuru = db.StokOzelAlanTanimlariTablosu
                .Where(x=> x.StokTuru == girilenStokTuru)
                .FirstOrDefault();

            var stokDegerleri = db.StokOzelAlanDegerleriTablosu
                .Where(x => x.StokKodu == girilenStokKodu)
                .FirstOrDefault();


            if (stokTuru != null)
            {
                if (stokTuru.StokOzelAlanTanimi1 != null)
                {
                    OzelAlanTanimi1.Text = stokTuru.StokOzelAlanTanimi1.ToString();
                    txt_OzelAlanTanimi1.Visible = true;
                    OzelAlanTanimi1.Visible = true;

                    if (stokDegerleri != null && stokDegerleri.StokOzelAlanDegeri1 != null)
                    {
                        txt_OzelAlanTanimi1.Text = stokDegerleri.StokOzelAlanDegeri1.ToString();
                    }
                    else
                    {
                        txt_OzelAlanTanimi1.Text = string.Empty; 
                    }

                }
                else 
                {
                    OzelAlanTanimi1.Visible = false;
                    txt_OzelAlanTanimi1.Visible = false;
                }


                if (stokTuru.StokOzelAlanTanimi2 != null)
                {
                    OzelAlanTanimi2.Text = stokTuru.StokOzelAlanTanimi2.ToString();
                    OzelAlanTanimi2.Visible = true;
                    txt_OzelAlanTanimi2.Visible = true;
                    if (stokDegerleri != null && stokDegerleri.StokOzelAlanDegeri2 != null)
                    {
                        txt_OzelAlanTanimi2.Text = stokDegerleri.StokOzelAlanDegeri2.ToString();
                    }
                    else
                    {
                        txt_OzelAlanTanimi2.Text = string.Empty;
                    }
                }
                else 
                {
                    OzelAlanTanimi2.Visible = false;
                    txt_OzelAlanTanimi2.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi3 != null)
                {
                    OzelAlanTanimi3.Text = stokTuru.StokOzelAlanTanimi3.ToString();
                    OzelAlanTanimi3.Visible = true;
                    txt_OzelAlanTanimi3.Visible = true;
                }
                else 
                {
                    OzelAlanTanimi3.Visible = false;
                    txt_OzelAlanTanimi3.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi4 != null)
                {
                    OzelAlanTanimi4.Text = stokTuru.StokOzelAlanTanimi4.ToString();
                    OzelAlanTanimi4.Visible = true;
                    txt_OzelAlanTanimi4.Visible = true;
                }
                else 
                {
                    OzelAlanTanimi4.Visible = false;
                    txt_OzelAlanTanimi4.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi5 != null)
                {
                    OzelAlanTanimi5.Text = stokTuru.StokOzelAlanTanimi5.ToString();
                    OzelAlanTanimi5.Visible = true;
                    txt_OzelAlanTanimi5.Visible = true;
                }
                else 
                { 
                    OzelAlanTanimi5.Visible = false;
                    txt_OzelAlanTanimi5.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi6 != null)
                {
                    OzelAlanTanimi6.Text = stokTuru.StokOzelAlanTanimi6.ToString();
                    OzelAlanTanimi6.Visible = true;
                    txt_OzelAlanTanimi6.Visible = true;

                }
                else 
                { 
                    OzelAlanTanimi6.Visible = false;
                    txt_OzelAlanTanimi6.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi7 != null)
                {
                    OzelAlanTanimi7.Text = stokTuru.StokOzelAlanTanimi7.ToString();
                    OzelAlanTanimi7.Visible = true;
                    txt_OzelAlanTanimi7.Visible = true;

                }
                else 
                {
                    OzelAlanTanimi7.Visible = false;
                    txt_OzelAlanTanimi7.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi8 != null)
                {
                    OzelAlanTanimi8.Text = stokTuru.StokOzelAlanTanimi8.ToString();
                    OzelAlanTanimi8.Visible = true;
                    txt_OzelAlanTanimi8.Visible = true;
                }
                else
                {
                    OzelAlanTanimi8.Visible = false;
                    txt_OzelAlanTanimi8.Visible = false;
                }

                if (stokTuru.StokOzelAlanTanimi9 != null)
                {
                    OzelAlanTanimi9.Text = stokTuru.StokOzelAlanTanimi9.ToString();
                    OzelAlanTanimi9.Visible = true;
                    txt_OzelAlanTanimi9.Visible = true;
                }
                else 
                { 
                    OzelAlanTanimi9.Visible=false; 
                    txt_OzelAlanTanimi9.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi10 != null)
                {
                    OzelAlanTanimi10.Text = stokTuru.StokOzelAlanTanimi10.ToString();
                    OzelAlanTanimi10.Visible= true;
                    txt_OzelAlanTanimi10.Visible = true;
                }
                else 
                { 
                    OzelAlanTanimi10.Visible = false;
                    txt_OzelAlanTanimi10.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi11 != null)
                {
                    OzelAlanTanimi11.Text = stokTuru.StokOzelAlanTanimi11.ToString();
                    OzelAlanTanimi11.Visible= true;
                    txt_OzelAlanTanimi11.Visible = true;
                }
                else 
                {
                    OzelAlanTanimi11.Visible = false;
                    txt_OzelAlanTanimi11.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi12 != null)
                {
                    OzelAlanTanimi12.Text = stokTuru.StokOzelAlanTanimi12.ToString();
                    OzelAlanTanimi12.Visible = true;
                    txt_OzelAlanTanimi12.Visible = true;
                }
                else 
                { 
                    OzelAlanTanimi12.Visible=false;
                    txt_OzelAlanTanimi12.Visible= false;
                }
                if (stokTuru.StokOzelAlanTanimi13 != null)
                {
                    OzelAlanTanimi13.Text = stokTuru.StokOzelAlanTanimi13.ToString();
                    OzelAlanTanimi13.Visible= true;
                    txt_OzelAlanTanimi13.Visible = true;
                }
                else 
                {
                    OzelAlanTanimi13.Visible=false;
                    txt_OzelAlanTanimi13.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi14 != null)
                {
                    OzelAlanTanimi14.Text = stokTuru.StokOzelAlanTanimi14.ToString();
                    OzelAlanTanimi14.Visible = true;
                    txt_OzelAlanTanimi14.Visible = true;
                }
                else 
                { 
                    OzelAlanTanimi14.Visible=false;
                    txt_OzelAlanTanimi14.Visible = false;
                }
                if (stokTuru.StokOzelAlanTanimi15 != null)
                {
                    OzelAlanTanimi15.Text = stokTuru.StokOzelAlanTanimi15.ToString();
                    OzelAlanTanimi15.Visible = true;
                    txt_OzelAlanTanimi15.Visible = true;
                }
                else
                {
                    OzelAlanTanimi15.Visible = false; 
                    txt_OzelAlanTanimi15.Visible= false;
                }
            }
            else
            {
                OzelAlanTanimi1.Visible = false;
                txt_OzelAlanTanimi1.Visible = false;
                OzelAlanTanimi2.Visible = false;
                txt_OzelAlanTanimi2.Visible = false;
                OzelAlanTanimi3.Visible = false;
                txt_OzelAlanTanimi3.Visible = false;
                OzelAlanTanimi4.Visible = false;
                txt_OzelAlanTanimi4.Visible = false;
                OzelAlanTanimi5.Visible = false;
                txt_OzelAlanTanimi5.Visible = false;
                OzelAlanTanimi6.Visible = false;
                txt_OzelAlanTanimi6.Visible = false;
                OzelAlanTanimi7.Visible = false;
                txt_OzelAlanTanimi7.Visible = false;
                OzelAlanTanimi8.Visible = false;
                txt_OzelAlanTanimi8.Visible = false;
                OzelAlanTanimi9.Visible = false;
                txt_OzelAlanTanimi9.Visible = false;
                OzelAlanTanimi10.Visible = false;
                txt_OzelAlanTanimi10.Visible = false;
                OzelAlanTanimi11.Visible = false;
                txt_OzelAlanTanimi11.Visible = false;
                OzelAlanTanimi12.Visible = false;
                txt_OzelAlanTanimi12.Visible = false;
                OzelAlanTanimi13.Visible = false;
                txt_OzelAlanTanimi13.Visible = false;
                OzelAlanTanimi14.Visible = false;
                txt_OzelAlanTanimi14.Visible = false;
                OzelAlanTanimi15.Visible = false;
                txt_OzelAlanTanimi15.Visible = false;
            }
            /*switch(txt_StokTuru.Text){
                case "KUMAS":
                    OzelAlanTanimi1.Text = ;
                    break;
                case "KUMAS ST":
                    break;
            }*/


            /*
            if(stokDegerleri!=null)
            {
                
                
            }
            else
            {
                txt_OzelAlanTanimi1.Text = string.Empty;
                txt_OzelAlanTanimi2.Text = string.Empty;
                txt_OzelAlanTanimi3.Text = string.Empty;
                txt_OzelAlanTanimi4.Text = string.Empty;
                txt_OzelAlanTanimi5.Text = string.Empty;
                txt_OzelAlanTanimi6.Text = string.Empty;
                txt_OzelAlanTanimi7.Text = string.Empty;
                txt_OzelAlanTanimi8.Text = string.Empty;
                txt_OzelAlanTanimi9.Text = string.Empty;
                txt_OzelAlanTanimi10.Text = string.Empty;
                txt_OzelAlanTanimi11.Text = string.Empty;
                txt_OzelAlanTanimi12.Text = string.Empty;
                txt_OzelAlanTanimi13.Text = string.Empty;
                txt_OzelAlanTanimi14.Text = string.Empty;
                txt_OzelAlanTanimi15.Text = string.Empty;
            
            }
            */
        }

        public void OzelAlanDegeri()
        {

        }

        private void StokKaydet()
        {

            StokTablosu YeniStok = new StokTablosu();

            if(!string.IsNullOrWhiteSpace(txt_StokTuru.Text))
            {
                YeniStok.StokTuru = txt_StokTuru.Text;
            }
            else { YeniStok.StokTuru = null; }

            if(!string.IsNullOrWhiteSpace(txt_StokKodu.Text))
            {
                YeniStok.StokKodu = txt_StokKodu.Text;
            }
            else { YeniStok.StokKodu = null; }

            if(!string.IsNullOrWhiteSpace (txt_StokGrubu.Text))
            {
                YeniStok.StokGrubu = txt_StokGrubu.Text;
            }
            else { YeniStok.StokGrubu = null; }

            if(!string.IsNullOrWhiteSpace(txt_StokAdi.Text))
            {
                YeniStok.StokAdi = txt_StokAdi.Text;
            }
            else { YeniStok.StokAdi = null; }

            if(comboBox_LotNo.SelectedIndex != -1)
            {
                YeniStok.LotNo = comboBox_LotNo.SelectedItem.ToString();
            }
            else { YeniStok.LotNo = null; }

            if(!string.IsNullOrWhiteSpace(txt_Barkod.Text))
            {
                YeniStok.Barkod = txt_Barkod.Text;
            }
            else { YeniStok.Barkod = null; }

            if(!string.IsNullOrWhiteSpace(txt_StokMuhasebeGrubu.Text))
            {
                YeniStok.StokMuhasebeGrubu = txt_StokMuhasebeGrubu.Text;

            }
            else { YeniStok.StokMuhasebeGrubu = null; }

            YeniStok.Kullanimda = checkBox_KullanimdaMi.Checked;
        }

        private void btn_StokTSecenekler_Click(object sender, EventArgs e)
        {
            Frm_StokTuruTablosu form_StokTuruTablosu = new Frm_StokTuruTablosu();
            
            if (form_StokTuruTablosu.ShowDialog() == DialogResult.OK)
            {
                txt_StokTuru.Text = form_StokTuruTablosu.SecilenDeger;
                OzelAlanTanimla();
            }

            /*txt_StokTuru.Text = form_StokTuruTablosu.SecilenDeger;
            OzelAlanTanimla();*/
        }

        private void txt_StokTuru_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_StokTuru_Leave(object sender, EventArgs e)
        {
            OzelAlanTanimla();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_StokKSecenekler_Click(object sender, EventArgs e)
        {

        }

        private void Form_StokIslemleri_Load(object sender, EventArgs e)
        {
            panel_SIGenelBilgiler.Dock = DockStyle.Fill;
            panel_UrunResmi.Dock = DockStyle.Fill;
            panel_UrunAgaci.Dock = DockStyle.Fill;

            // Ozel Alanları gizle
            OzelAlanTanimi1.Visible = false;
            txt_OzelAlanTanimi1.Visible = false;
            OzelAlanTanimi2.Visible = false;
            txt_OzelAlanTanimi2.Visible = false;
            OzelAlanTanimi3.Visible = false;
            txt_OzelAlanTanimi3.Visible = false;
            OzelAlanTanimi4.Visible = false;
            txt_OzelAlanTanimi4.Visible = false;
            OzelAlanTanimi5.Visible = false;
            txt_OzelAlanTanimi5.Visible = false;
            OzelAlanTanimi6.Visible = false;
            txt_OzelAlanTanimi6.Visible = false;
            OzelAlanTanimi7.Visible = false;
            txt_OzelAlanTanimi7.Visible = false;
            OzelAlanTanimi8.Visible = false;
            txt_OzelAlanTanimi8.Visible = false;
            OzelAlanTanimi9.Visible = false;
            txt_OzelAlanTanimi9.Visible = false;
            OzelAlanTanimi10.Visible = false;
            txt_OzelAlanTanimi10.Visible = false;
            OzelAlanTanimi11.Visible = false;
            txt_OzelAlanTanimi11.Visible = false;
            OzelAlanTanimi12.Visible = false;
            txt_OzelAlanTanimi12.Visible = false;
            OzelAlanTanimi13.Visible = false;
            txt_OzelAlanTanimi13.Visible = false;
            OzelAlanTanimi14.Visible = false;
            txt_OzelAlanTanimi14.Visible = false;
            OzelAlanTanimi15.Visible = false;
            txt_OzelAlanTanimi15.Visible = false;

        }

        private void btn_UrunResmi_Click(object sender, EventArgs e)
        {

        }

        private void btn_StokDokuman_Click(object sender, EventArgs e)
        {

        }

        private void btn_StokCariTalimat_Click(object sender, EventArgs e)
        {

        }

        private void panel_GenelBilgilerBolum1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

        }

        private void btn_GenelBilgiler_Click(object sender, EventArgs e)
        {
            panel_SIGenelBilgiler.Visible = true;
            panel_UrunResmi.Visible = false;
            panel_UrunAgaci.Visible = false;

        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UrunResmi_Click_1(object sender, EventArgs e)
        {
            panel_SIGenelBilgiler.Visible = false;
            panel_UrunResmi.Visible = true;
            panel_UrunAgaci.Visible = false;

        }

        private void btn_UrunAgaci_Click(object sender, EventArgs e)
        {
            panel_SIGenelBilgiler.Visible = false;
            panel_UrunResmi.Visible = false;
            panel_UrunAgaci.Visible = true;

            panel_UrunAgaci.BringToFront(); // öne getir


        }

        private void btn_StokGrubuSecenekler_Click(object sender, EventArgs e)
        {
            frm_StokGrubuSecenekler FRM_StokGrubuSecenekler = new frm_StokGrubuSecenekler();
            FRM_StokGrubuSecenekler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
