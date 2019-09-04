namespace voicetrainig
{
    partial class frm_hakkinda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hakkinda));
            this.lbl_voi = new System.Windows.Forms.Label();
            this.lbl_tra = new System.Windows.Forms.Label();
            this.lbl_yazi = new System.Windows.Forms.Label();
            this.pcr_face = new System.Windows.Forms.PictureBox();
            this.pcr_twit = new System.Windows.Forms.PictureBox();
            this.pcr_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_face)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_twit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_voi
            // 
            this.lbl_voi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_voi.AutoSize = true;
            this.lbl_voi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_voi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lbl_voi.Location = new System.Drawing.Point(258, 110);
            this.lbl_voi.Name = "lbl_voi";
            this.lbl_voi.Size = new System.Drawing.Size(62, 24);
            this.lbl_voi.TabIndex = 4;
            this.lbl_voi.Text = "Voice";
            // 
            // lbl_tra
            // 
            this.lbl_tra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_tra.AutoSize = true;
            this.lbl_tra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_tra.Location = new System.Drawing.Point(311, 110);
            this.lbl_tra.Name = "lbl_tra";
            this.lbl_tra.Size = new System.Drawing.Size(89, 24);
            this.lbl_tra.TabIndex = 3;
            this.lbl_tra.Text = " Training";
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_yazi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_yazi.Location = new System.Drawing.Point(12, 165);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(640, 346);
            this.lbl_yazi.TabIndex = 5;
            this.lbl_yazi.Text = resources.GetString("lbl_yazi.Text");
            this.lbl_yazi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pcr_face
            // 
            this.pcr_face.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcr_face.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_face.Image = global::voicetrainig.Properties.Resources.facebook_4_48;
            this.pcr_face.Location = new System.Drawing.Point(550, 514);
            this.pcr_face.Name = "pcr_face";
            this.pcr_face.Size = new System.Drawing.Size(48, 48);
            this.pcr_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_face.TabIndex = 7;
            this.pcr_face.TabStop = false;
            this.pcr_face.Click += new System.EventHandler(this.pcr_face_Click);
            // 
            // pcr_twit
            // 
            this.pcr_twit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcr_twit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_twit.Image = global::voicetrainig.Properties.Resources.twitter_4_48;
            this.pcr_twit.Location = new System.Drawing.Point(604, 514);
            this.pcr_twit.Name = "pcr_twit";
            this.pcr_twit.Size = new System.Drawing.Size(48, 48);
            this.pcr_twit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_twit.TabIndex = 6;
            this.pcr_twit.TabStop = false;
            this.pcr_twit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcr_logo
            // 
            this.pcr_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcr_logo.Image = global::voicetrainig.Properties.Resources.mikro;
            this.pcr_logo.Location = new System.Drawing.Point(275, 12);
            this.pcr_logo.Name = "pcr_logo";
            this.pcr_logo.Size = new System.Drawing.Size(95, 95);
            this.pcr_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_logo.TabIndex = 0;
            this.pcr_logo.TabStop = false;
            // 
            // frm_hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 574);
            this.Controls.Add(this.pcr_face);
            this.Controls.Add(this.pcr_twit);
            this.Controls.Add(this.lbl_yazi);
            this.Controls.Add(this.lbl_voi);
            this.Controls.Add(this.lbl_tra);
            this.Controls.Add(this.pcr_logo);
            this.Name = "frm_hakkinda";
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.frm_hakkinda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_face)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_twit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_logo;
        private System.Windows.Forms.Label lbl_voi;
        private System.Windows.Forms.Label lbl_tra;
        private System.Windows.Forms.Label lbl_yazi;
        private System.Windows.Forms.PictureBox pcr_twit;
        private System.Windows.Forms.PictureBox pcr_face;
    }
}