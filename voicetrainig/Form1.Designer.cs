namespace voicetrainig
{
    partial class frm_menu
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_onizle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buton1 = new voicetrainig.buton();
            this.pcr_kenarlık = new voicetrainig.pcr_kenarlık();
            this.buton2 = new voicetrainig.buton();
            this.buton3 = new voicetrainig.buton();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_kenarlık)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Controls.Add(this.pcr_kenarlık);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(182, 479);
            this.pnl_menu.TabIndex = 0;
            // 
            // pnl_onizle
            // 
            this.pnl_onizle.BackColor = System.Drawing.Color.White;
            this.pnl_onizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_onizle.Location = new System.Drawing.Point(182, 0);
            this.pnl_onizle.Name = "pnl_onizle";
            this.pnl_onizle.Size = new System.Drawing.Size(799, 479);
            this.pnl_onizle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buton3);
            this.panel1.Controls.Add(this.buton2);
            this.panel1.Controls.Add(this.buton1);
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 389);
            this.panel1.TabIndex = 2;
            // 
            // buton1
            // 
            this.buton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton1.Font = new System.Drawing.Font("Arial", 10F);
            this.buton1.Location = new System.Drawing.Point(24, 43);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(123, 46);
            this.buton1.TabIndex = 0;
            this.buton1.Text = "buton1";
            this.buton1.UseVisualStyleBackColor = true;
            // 
            // pcr_kenarlık
            // 
            this.pcr_kenarlık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pcr_kenarlık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_kenarlık.Image = global::voicetrainig.Properties.Resources.logo_menu;
            this.pcr_kenarlık.Location = new System.Drawing.Point(-31, -31);
            this.pcr_kenarlık.Name = "pcr_kenarlık";
            this.pcr_kenarlık.Size = new System.Drawing.Size(122, 121);
            this.pcr_kenarlık.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_kenarlık.TabIndex = 1;
            this.pcr_kenarlık.TabStop = false;
            // 
            // buton2
            // 
            this.buton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton2.Font = new System.Drawing.Font("Arial", 10F);
            this.buton2.Location = new System.Drawing.Point(24, 112);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(123, 46);
            this.buton2.TabIndex = 1;
            this.buton2.Text = "buton2";
            this.buton2.UseVisualStyleBackColor = true;
            // 
            // buton3
            // 
            this.buton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton3.Font = new System.Drawing.Font("Arial", 10F);
            this.buton3.Location = new System.Drawing.Point(24, 180);
            this.buton3.Name = "buton3";
            this.buton3.Size = new System.Drawing.Size(123, 46);
            this.buton3.TabIndex = 2;
            this.buton3.Text = "buton3";
            this.buton3.UseVisualStyleBackColor = true;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 479);
            this.Controls.Add(this.pnl_onizle);
            this.Controls.Add(this.pnl_menu);
            this.Name = "frm_menu";
            this.Text = "Voice Training";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_kenarlık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private pcr_kenarlık pcr_kenarlık;
        private System.Windows.Forms.Panel pnl_onizle;
        private System.Windows.Forms.Panel panel1;
        private buton buton1;
        private buton buton3;
        private buton buton2;




    }
}

