using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voicetrainig
{
    public partial class frm_hakkinda : Form
    {
        public frm_hakkinda()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com/isim");
        }

        private void pcr_face_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/isim");
        }

        private void frm_hakkinda_Load(object sender, EventArgs e)
        {

        }
    }
}
