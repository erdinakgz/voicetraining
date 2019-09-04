using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voicetrainig
{
    public partial class usr_hayvan : UserControl
    {
        public usr_hayvan()
        {
            InitializeComponent();
            frm_menu.ButonOz(pnl_kucuk); // butonlara özelliklerini veiyoruz
        }
        
        private void usr_hayvan_Load(object sender, EventArgs e)
        {
           
            
        }
        private void btn_hava_Click(object sender, EventArgs e)
        {
            Program.menu.pnl_onizle.Controls.Clear(); // pnl_onizle içindekiler siliniyor
            //buralar bildiğin içine çekme işte
            ornekform ornkfrm = new ornekform();
            ornkfrm.TopLevel = false;
            ornkfrm.Parent = Program.menu.pnl_onizle;
            ornkfrm.Dock = DockStyle.Fill;
            ornkfrm.ControlBox = false;
            ornkfrm.Text = null;
            ornkfrm.FormBorderStyle = FormBorderStyle.None;
            ornkfrm.Show();
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            Program.menu.pnl_onizle.Controls.Clear();
            ornekform2_su ornkfrm2_su = new ornekform2_su();
            ornkfrm2_su.TopLevel = false;
            ornkfrm2_su.Parent = Program.menu.pnl_onizle;
            ornkfrm2_su.Dock = DockStyle.Fill;
            ornkfrm2_su.ControlBox = false;
            ornkfrm2_su.Text = null;
            ornkfrm2_su.FormBorderStyle = FormBorderStyle.None;
            ornkfrm2_su.Show();
        }

        private void btn_kara_Click(object sender, EventArgs e)
        {
            Program.menu.pnl_onizle.Controls.Clear();
            anCat us_anCat = new anCat();
            us_anCat.Parent = Program.menu.pnl_onizle;
            us_anCat.Dock = DockStyle.Fill;
            us_anCat.Text = null;
            us_anCat.Show();
        }
    }
}
