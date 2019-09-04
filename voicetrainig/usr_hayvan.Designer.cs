namespace voicetrainig
{
    partial class usr_hayvan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_kucuk = new System.Windows.Forms.Panel();
            this.btn_kara = new voicetrainig.buton();
            this.btn_su = new voicetrainig.buton();
            this.btn_hava = new voicetrainig.buton();
            this.pnl_kucuk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_kucuk
            // 
            this.pnl_kucuk.Controls.Add(this.btn_kara);
            this.pnl_kucuk.Controls.Add(this.btn_su);
            this.pnl_kucuk.Controls.Add(this.btn_hava);
            this.pnl_kucuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_kucuk.Location = new System.Drawing.Point(0, 0);
            this.pnl_kucuk.Name = "pnl_kucuk";
            this.pnl_kucuk.Size = new System.Drawing.Size(244, 253);
            this.pnl_kucuk.TabIndex = 0;
            this.pnl_kucuk.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // btn_kara
            // 
            this.btn_kara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_kara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kara.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_kara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kara.Location = new System.Drawing.Point(66, 162);
            this.btn_kara.Name = "btn_kara";
            this.btn_kara.Size = new System.Drawing.Size(104, 48);
            this.btn_kara.TabIndex = 5;
            this.btn_kara.Text = "Karada ";
            this.btn_kara.UseVisualStyleBackColor = true;
            this.btn_kara.Click += new System.EventHandler(this.btn_kara_Click);
            // 
            // btn_su
            // 
            this.btn_su.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_su.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_su.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_su.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_su.Location = new System.Drawing.Point(66, 97);
            this.btn_su.Name = "btn_su";
            this.btn_su.Size = new System.Drawing.Size(104, 48);
            this.btn_su.TabIndex = 4;
            this.btn_su.Text = "Suda";
            this.btn_su.UseVisualStyleBackColor = true;
            this.btn_su.Click += new System.EventHandler(this.btn_su_Click);
            // 
            // btn_hava
            // 
            this.btn_hava.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_hava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hava.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_hava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hava.Location = new System.Drawing.Point(66, 31);
            this.btn_hava.Name = "btn_hava";
            this.btn_hava.Size = new System.Drawing.Size(104, 48);
            this.btn_hava.TabIndex = 3;
            this.btn_hava.Text = "Havada";
            this.btn_hava.UseVisualStyleBackColor = true;
            this.btn_hava.Click += new System.EventHandler(this.btn_hava_Click);
            // 
            // usr_hayvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnl_kucuk);
            this.Name = "usr_hayvan";
            this.Size = new System.Drawing.Size(244, 253);
            this.Load += new System.EventHandler(this.usr_hayvan_Load);
            this.pnl_kucuk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_kucuk;
        private buton btn_kara;
        private buton btn_su;
        private buton btn_hava;


    }
}
