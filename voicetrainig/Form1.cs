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
            ButonOz(panel1);
        }
        public static void ButonOz(Panel pnl)
        {
            foreach (Control btn in pnl.Controls)
            {
                if (btn is buton)
                {
                    ((buton)btn).yukseklik = btn.Height;
                    ((buton)btn).genislik = btn.Width;
                }
            }
        }
        private void frm_menu_Load(object sender, EventArgs e)
        {
            
            usr_logo ac = new usr_logo();
            ac.Dock = DockStyle.Fill;
            pnl_onizle.Controls.Add(ac);
           
        }
        }
    }

