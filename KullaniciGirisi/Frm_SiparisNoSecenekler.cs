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
    public partial class Form_SiparisNoSecenekler : Form
    {
        public Form_SiparisNoSecenekler()
        {
            InitializeComponent();
        }
        ERPEntities db = new ERPEntities();
        private void Form8_Load(object sender, EventArgs e)
        {
            var siparis = db.View_SiparisSecenekler;
            dataGridView_SiparisNoSecenekler.DataSource = siparis.ToList();
        }
    }
}
