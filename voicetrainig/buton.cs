using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace voicetrainig
{
    public partial class buton : Button
    {
        public buton()
        {
            InitializeComponent();
            this.Font = new Font("Arial", 10);
            this.ForeColor = Color.FromArgb(64, 64, 64);
            this.Cursor = Cursors.Hand;
        }
          
        private void buton_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(genislik, yukseklik);
            this.Font = new Font("Arial", 10);
           this.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void buton_MouseMove(object sender, MouseEventArgs e)
        {
            this.Size = new Size(genislik + 10, yukseklik + 10);
            this.Font = new Font("Arial", 15);
            this.ForeColor = Color.FromArgb(230, 76, 60);
        }
        public int yukseklik;
        public int genislik;
    }
}
