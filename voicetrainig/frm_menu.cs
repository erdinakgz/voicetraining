using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace voicetrainig
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();

            ButonOz(pnl_nesne);
        }
        public static void ButonOz(Panel pnl)
        {
            /* buton nesnesi olan butonların (garip) yukseklik ve genişlikleri aktarılıyor
             * (büyültme ve küçültme işlemleri için)
             */
            foreach (Control btn in pnl.Controls)
            {
                if (btn is buton)
                {
                    ((buton)btn).yukseklik = btn.Height;
                    ((buton)btn).genislik = btn.Width;
                }
            }
        }
        void Gizle()
        {

            foreach (Control btn in pnl_nesne.Controls)
            {
                if (btn is buton) btn.Hide(); // pnl_nesne içinde olan tüm butonları gizliyor

            }
        }
        void Goster()
        {
            foreach (Control btn in pnl_nesne.Controls)
            {
                if (btn is buton) btn.Show(); //pnl_nesne içinde gizlenmiş olan nesneleri göstermek için yazılmıştır

            }
        }
        void ResimDegistir()
        {
            pcr_kenarlık.Image = Properties.Resources.arrow_88_48__1_; // ev logosunu < logosu yapar
            pcr_kenarlık.Click += pcr_kenarlık_Click; //click atandı
        }

        void pcr_kenarlık_Click(object sender, EventArgs e)
        {
            //eğer pcr_kenarlık < simgesindeyken clicklenirse;

            pcr_kenarlık.Image = Properties.Resources.logo_menu;// < logosunu ev logosu ile değiştirir
            for (int i = 0; i < pnl_nesne.Controls.Count; i++)
            {
                if (pnl_nesne.Controls[i] is UserControl) pnl_nesne.Controls[i].Dispose(); // pnl_nesne içinde olan usercontrol ya da usercontroller siliniyor
            }
            Goster(); //daha önce clickle gizlediğimiz nesneler gösteriliyor
            pcr_kenarlık.Click += null; // pcr_kenarlığın click olayını nullanıyor
        }
        private void frm_menu_Load(object sender, EventArgs e)
        {
            usr_logo ac = new usr_logo();
            ac.Dock = DockStyle.Fill;
            pnl_onizle.Controls.Add(ac); //usr_logo adlı controlü pcr_onizlenin içinde açıyoruz
        }

        private void btn_hayvan_Click(object sender, EventArgs e)
        {
            Gizle(); //pnl_nesne içinde olan controller gizleniyor
            ResimDegistir(); // resim değiştiriliyor ve click eventi atanıyor resime
            usr_hayvan ac = new usr_hayvan();
            ac.Dock = DockStyle.Fill;
            pnl_nesne.Controls.Add(ac);
        }

        private void btn_hak_Click(object sender, EventArgs e)
        {
            Program.menu.pnl_onizle.Controls.Clear(); // pnl_onizlenin içi siliniyor
            frm_hakkinda ac = new frm_hakkinda();
            ac.TopLevel = false;
            ac.Parent = Program.menu.pnl_onizle;
            ac.Dock = DockStyle.Fill;
            ac.ControlBox = false; //bunları yazmıyorum artık :/
            ac.Text = null;
            ac.FormBorderStyle = FormBorderStyle.None;
            ac.Show();
        }

        private void btn_bitki_Click(object sender, EventArgs e)
        {
            Gizle(); //pnl_nesne içinde olan controller gizleniyor
            ResimDegistir(); // resim değiştiriliyor ve click eventi atanıyor resime
            usr_bitkiler ac = new usr_bitkiler();
            ac.Dock = DockStyle.Fill;
            pnl_nesne.Controls.Add(ac);
        }

        private void btn_gunluk_Click(object sender, EventArgs e)
        {
            Program.menu.pnl_onizle.Controls.Clear();
            frm_gunlukhayat frmgunluk = new frm_gunlukhayat();
            frmgunluk.TopLevel = false;
            frmgunluk.Parent = Program.menu.pnl_onizle;
            frmgunluk.Dock = DockStyle.Fill;
            frmgunluk.ControlBox = false;
            frmgunluk.Text = null;
            frmgunluk.FormBorderStyle = FormBorderStyle.None;
            frmgunluk.Show();
        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

