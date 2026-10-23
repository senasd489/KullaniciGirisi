using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisi.RaporlarModels
{
    public class SiparisRaporlariModel
    {
        public int RaporNo { get; set; }
        public string RaporAdi { get; set; }
        public string GroupAdi { get; set; }
        public string FrxDosyaYolu { get; set; }

        public List<FiltreModel> Filtreler { get; set; } = new List<FiltreModel>();
             
    }
}
