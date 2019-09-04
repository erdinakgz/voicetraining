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
            this.pnl_nesne = new System.Windows.Forms.Panel();
            this.btn_hak = new voicetrainig.buton();
            this.btn_hayvan = new voicetrainig.buton();
            this.btn_nesne = new voicetrainig.buton();
            this.btn_gunluk = new voicetrainig.buton();
            this.btn_bitki = new voicetrainig.buton();
            this.btn_sayi = new voicetrainig.buton();
            this.btn_alfa = new voicetrainig.buton();
            this.pcr_kenarlık = new voicetrainig.pcr_kenarlık();
            this.pnl_onizle = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_nesne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_kenarlık)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_menu.Controls.Add(this.pnl_nesne);
            this.pnl_menu.Controls.Add(this.pcr_kenarlık);
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(182, 479);
            this.pnl_menu.TabIndex = 0;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // pnl_nesne
            // 
            this.pnl_nesne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_nesne.AutoScroll = true;
            this.pnl_nesne.Controls.Add(this.btn_hak);
            this.pnl_nesne.Controls.Add(this.btn_hayvan);
            this.pnl_nesne.Controls.Add(this.btn_nesne);
            this.pnl_nesne.Controls.Add(this.btn_gunluk);
            this.pnl_nesne.Controls.Add(this.btn_bitki);
            this.pnl_nesne.Controls.Add(this.btn_sayi);
            this.pnl_nesne.Controls.Add(this.btn_alfa);
            this.pnl_nesne.Location = new System.Drawing.Point(0, 90);
            this.pnl_nesne.Name = "pnl_nesne";
            this.pnl_nesne.Size = new System.Drawing.Size(182, 389);
            this.pnl_nesne.TabIndex = 2;
            // 
            // btn_hak
            // 
            this.btn_hak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hak.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_hak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hak.Location = new System.Drawing.Point(31, 477);
            this.btn_hak.Name = "btn_hak";
            this.btn_hak.Size = new System.Drawing.Size(104, 48);
            this.btn_hak.TabIndex = 6;
            this.btn_hak.Text = "Hakkında";
            this.btn_hak.UseVisualStyleBackColor = true;
            this.btn_hak.Click += new System.EventHandler(this.btn_hak_Click);
            // 
            // btn_hayvan
            // 
            this.btn_hayvan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hayvan.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_hayvan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hayvan.Location = new System.Drawing.Point(31, 74);
            this.btn_hayvan.Name = "btn_hayvan";
            this.btn_hayvan.Size = new System.Drawing.Size(104, 48);
            this.btn_hayvan.TabIndex = 0;
            this.btn_hayvan.Text = "Hayvanlar";
            this.btn_hayvan.UseVisualStyleBackColor = true;
            this.btn_hayvan.Click += new System.EventHandler(this.btn_hayvan_Click);
            // 
            // btn_nesne
            // 
            this.btn_nesne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nesne.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_nesne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nesne.Location = new System.Drawing.Point(31, 208);
            this.btn_nesne.Name = "btn_nesne";
            this.btn_nesne.Size = new System.Drawing.Size(104, 48);
            this.btn_nesne.TabIndex = 2;
            this.btn_nesne.Text = "Nesneler";
            this.btn_nesne.UseVisualStyleBackColor = true;
            // 
            // btn_gunluk
            // 
            this.btn_gunluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gunluk.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_gunluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_gunluk.Location = new System.Drawing.Point(31, 409);
            this.btn_gunluk.Name = "btn_gunluk";
            this.btn_gunluk.Size = new System.Drawing.Size(104, 48);
            this.btn_gunluk.TabIndex = 5;
            this.btn_gunluk.Text = "Günlük Hayat";
            this.btn_gunluk.UseVisualStyleBackColor = true;
            this.btn_gunluk.Click += new System.EventHandler(this.btn_gunluk_Click);
            // 
            // btn_bitki
            // 
            this.btn_bitki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bitki.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_bitki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bitki.Location = new System.Drawing.Point(31, 143);
            this.btn_bitki.Name = "btn_bitki";
            this.btn_bitki.Size = new System.Drawing.Size(104, 48);
            this.btn_bitki.TabIndex = 1;
            this.btn_bitki.Text = "Bitkiler";
            this.btn_bitki.UseVisualStyleBackColor = true;
            this.btn_bitki.Click += new System.EventHandler(this.btn_bitki_Click);
            // 
            // btn_sayi
            // 
            this.btn_sayi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sayi.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_sayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sayi.Location = new System.Drawing.Point(31, 276);
            this.btn_sayi.Name = "btn_sayi";
            this.btn_sayi.Size = new System.Drawing.Size(104, 48);
            this.btn_sayi.TabIndex = 3;
            this.btn_sayi.Text = "Sayılar";
            this.btn_sayi.UseVisualStyleBackColor = true;
            // 
            // btn_alfa
            // 
            this.btn_alfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alfa.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_alfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_alfa.Location = new System.Drawing.Point(31, 341);
            this.btn_alfa.Name = "btn_alfa";
            this.btn_alfa.Size = new System.Drawing.Size(104, 48);
            this.btn_alfa.TabIndex = 4;
            this.btn_alfa.Text = "Alfabe";
            this.btn_alfa.UseVisualStyleBackColor = true;
            // 
            // pcr_kenarlık
            // 
            this.pcr_kenarlık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pcr_kenarlık.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_kenarlık.Image = global::voicetrainig.Properties.Resources.logo_menu;
            this.pcr_kenarlık.Location = new System.Drawing.Point(-30, -30);
            this.pcr_kenarlık.Name = "pcr_kenarlık";
            this.pcr_kenarlık.Size = new System.Drawing.Size(122, 121);
            this.pcr_kenarlık.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_kenarlık.TabIndex = 1;
            this.pcr_kenarlık.TabStop = false;
            // 
            // pnl_onizle
            // 
            this.pnl_onizle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_onizle.BackColor = System.Drawing.Color.White;
            this.pnl_onizle.Location = new System.Drawing.Point(182, 0);
            this.pnl_onizle.Name = "pnl_onizle";
            this.pnl_onizle.Size = new System.Drawing.Size(799, 479);
            this.pnl_onizle.TabIndex = 1;
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
            this.pnl_nesne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_kenarlık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private buton btn_hayvan;
        private buton btn_bitki;
        public System.Windows.Forms.Panel pnl_nesne;
        public System.Windows.Forms.Panel pnl_menu;
        private buton btn_gunluk;
        private buton btn_alfa;
        private buton btn_sayi;
        private buton btn_nesne;
        public pcr_kenarlık pcr_kenarlık;
        public System.Windows.Forms.Panel pnl_onizle;
        private buton btn_hak;




    }
}

