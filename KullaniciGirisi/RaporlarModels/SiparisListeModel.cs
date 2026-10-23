using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisi.RaporlarModels
{
    public class SiparisListeModel
    {
        public string SiparisNo {  get; set; }
        public string SiparisTuru { get; set; }
        public string SiparisiAlan {  get; set; }
        public string SiparisiVeren {  get; set; }
        public DateTime AlinmaTarihi { get; set; }
    }
}
