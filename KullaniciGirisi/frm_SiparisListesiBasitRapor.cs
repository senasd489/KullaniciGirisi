using FastReport;
using FastReport.Data;
using KullaniciGirisi.RaporlarModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Export.PdfSimple;
using System.Diagnostics;

namespace KullaniciGirisi
{
    public partial class frm_SiparisListesiBasitRapor : Form
    {
        ERPEntities db = new ERPEntities();
        public frm_SiparisListesiBasitRapor()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            var siparisler = from x in db.Siparis
                          select new
                          {
                              x.SiparisNo,
                              x.SiparisTuru,
                              x.SiparisiAlan,
                              x.SiparisiVeren,
                              x.AlinmaTarihi
                          };
            dgv_SiparisListesi.DataSource = siparisler.ToList();
        }

        private void frm_SiparisListesiBasitRapor_Load(object sender, EventArgs e)
        {
            Listele();





            /*
            Lisans olması durumunda fast rapor tasarımı burdaki kodu bir kere çalıştırılarak tasarım yapılır.

            Report report = new Report();
            report.Design();
            */
        }

        private void btn_SiparisListeRaporuOlustur_Click(object sender, EventArgs e)
        {
            //kullanılcak veri 
            using (ERPEntities db = new ERPEntities())
            {

                List<SiparisListeModel> siparisler = db.Siparis
                    .OrderByDescending(s => s.AlinmaTarihi)
                    .Select(s => new SiparisListeModel
                    {
                        SiparisNo = s.SiparisNo,
                        SiparisTuru = s.SiparisTuru,
                        SiparisiAlan = s.SiparisiAlan,                                    // gerçek property adları farklıysa uyarlayın
                        SiparisiVeren = s.SiparisiVeren,
                        AlinmaTarihi= s.AlinmaTarihi ?? DateTime.Now
                    })
                    .ToList();
            
               //new SiparisListeModel { SiparisNo = "1001", SiparisTuru = "Yurt İçi", SiparisiAlan = "Ahmet Yılmaz", SiparisiVeren = "ABC Tekstil", AlinmaTarihi = DateTime.Now },
               //new SiparisListeModel { SiparisNo = "1002", SiparisTuru = "İhracat", SiparisiAlan = "Mehmet Kaya", SiparisiVeren = "XYZ Ltd.", AlinmaTarihi = DateTime.Now.AddDays(-1) },
            

                //2 Raporu yükle
                Report report = new Report();
                report.Load("BasitSiparisRaporu.frx");
                // 3 veriyi st ismiyle kaydet
                report.RegisterData(siparisler, "ST");
                report.GetDataSource("ST").Enabled = true;

                //4 data bandına bu veri kaynağını bağla
                DataBand dataBand = report.FindObject("Data1") as DataBand;
                if (dataBand != null)
                {
                    dataBand.DataSource = report.GetDataSource("ST");
                }
                //5 raporu hazırla ve önizleme penceresini aç
                report.Prepare();
                // report.Show();  ücretsiz sürümde yok o yüzden kullanamadım

                // 6 pdf olarak dışa aktar
                string pdfYolu = System.IO.Path.Combine(Environment.CurrentDirectory, "SiparisRaporu.pdf");
                PDFSimpleExport pdfExport = new PDFSimpleExport();
                report.Export(pdfExport, pdfYolu);
                // 7 pdf'i varsayılan programla açç :
                Process.Start(new ProcessStartInfo(pdfYolu) { UseShellExecute = true });
            }
        }
    }
}
