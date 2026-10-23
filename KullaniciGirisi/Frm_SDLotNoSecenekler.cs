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
    public partial class Frm_SDLotNoSecenekler : Form
    {
        ERPEntities db = new ERPEntities();
        public Frm_SDLotNoSecenekler()
        {
            InitializeComponent();
        }
        public string SecilenLotNo;
        private void Frm_SDLotNoSecenekler_Load(object sender, EventArgs e)
        {

        }
    }
}
