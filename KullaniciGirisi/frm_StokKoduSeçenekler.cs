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
    public partial class frm_StokKoduSeçenekler : Form
    {
        public frm_StokKoduSeçenekler()
        {
            InitializeComponent();
        }
        ERPEntities db = new ERPEntities();

        private void btn_Vaazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
