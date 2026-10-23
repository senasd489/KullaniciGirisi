using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KullaniciGirisi.RaporlarModels;

namespace KullaniciGirisi
{
    public partial class Frm_SiparisRaporlari : Form
    {

        public Frm_SiparisRaporlari()
        {
            InitializeComponent();
        }

        private void Frm_SiparisRaporlari_Load(object sender, EventArgs e)
        {
            TreeViewiDoldur();
        }

        private void TreeViewiDoldur()
        {
            //Örnek rapor listesini oluşturuyoruz
            List<SiparisRaporlariModel> SiparisRaporlari = new List<SiparisRaporlariModel>
            {
                new SiparisRaporlariModel
                {
                    RaporNo = 1100,
                    RaporAdi = "Müşteri Sevk Bekleyen",
                    GroupAdi = "Kumaş",
                    FrxDosyaYolu = @".frx",
                    Filtreler = new List<FiltreModel>
                    {
                        new FiltreModel { FiltreAdi = "AmbarNo", KullanildiMi = false },
                        new FiltreModel { FiltreAdi = "CariNo", KullanildiMi = false }
                    }


                },
                new SiparisRaporlariModel
                {
                    RaporNo = 221,
                    RaporAdi = "ALMANAL ARAPÇA ETİKET",
                    GroupAdi = "CUVAL ETIKET",
                    FrxDosyaYolu = @"Raporlar\221_AlmanalArapcaEtiket.frx",
                    Filtreler = new List<FiltreModel>
                    {
                       new FiltreModel { FiltreAdi = "AmbarNo", KullanildiMi = false },
                       new FiltreModel { FiltreAdi = "CariNo", KullanildiMi = false }
                    }

                }
            };

            //TreeView'i temizle
            treeView_SRRaporlar.Nodes.Clear();

            // Raporları GrupAdi'na göre grupla ve ağaca ekle
            var gruplar = SiparisRaporlari.GroupBy(r => r.GroupAdi);

            foreach ( var group in gruplar )
            {
                TreeNode grupNode = new TreeNode(group.Key);
                foreach (SiparisRaporlariModel rapor in group)
                {
                    TreeNode raporNode = new TreeNode($"{rapor.RaporNo}-{rapor.RaporAdi}");
                    raporNode.Tag = rapor;
                    grupNode.Nodes.Add(raporNode);
                }

                treeView_SRRaporlar.Nodes.Add(grupNode);
            }
            treeView_SRRaporlar.ExpandAll();
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView_SRRaporlar_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is SiparisRaporlariModel seciliRapor)
            {
                FiltreleriGoster(seciliRapor);
            }
            else
            {
                listBox_SRFiltreler.Items.Clear();
                dataGridView_FiltreDegerleri.Rows.Clear();
            }

        }
        private void FiltreleriGoster(SiparisRaporlariModel rapor)
        {
            listBox_SRFiltreler.Items.Clear();

            foreach (FiltreModel filtre in rapor.Filtreler)
            {
                listBox_SRFiltreler.Items.Add(filtre);
            }
        }
    }
}
