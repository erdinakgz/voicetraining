using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace voicetrainig
{
    public class pcr_kenarlık : PictureBox
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            Point[] point = new Point[3];
            point[0] = new Point(30,30);
            point[1] = new Point(120, 30);
            point[2] = new Point(30, 120);
            gp.AddPolygon(point);
            this.Region = new Region(gp);
            this.BackColor = Color.FromArgb(230, 76, 60);
          this.TabStop = false;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kenarlık
            // 
            this.Name = "btn_kenarlık";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
