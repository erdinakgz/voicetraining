namespace voicetrainig
{
    partial class usr_bitkiler
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
            this.btn_cicek = new voicetrainig.buton();
            this.btn_sebze = new voicetrainig.buton();
            this.btn_meyve = new voicetrainig.buton();
            this.btn_agac = new voicetrainig.buton();
            this.pnl_kucuk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_kucuk
            // 
            this.pnl_kucuk.Controls.Add(this.btn_cicek);
            this.pnl_kucuk.Controls.Add(this.btn_sebze);
            this.pnl_kucuk.Controls.Add(this.btn_meyve);
            this.pnl_kucuk.Controls.Add(this.btn_agac);
            this.pnl_kucuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_kucuk.Location = new System.Drawing.Point(0, 0);
            this.pnl_kucuk.Name = "pnl_kucuk";
            this.pnl_kucuk.Size = new System.Drawing.Size(175, 295);
            this.pnl_kucuk.TabIndex = 0;
            // 
            // btn_cicek
            // 
            this.btn_cicek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cicek.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_cicek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cicek.Location = new System.Drawing.Point(33, 218);
            this.btn_cicek.Name = "btn_cicek";
            this.btn_cicek.Size = new System.Drawing.Size(104, 48);
            this.btn_cicek.TabIndex = 7;
            this.btn_cicek.Text = "Çiçek";
            this.btn_cicek.UseVisualStyleBackColor = true;
            // 
            // btn_sebze
            // 
            this.btn_sebze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sebze.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_sebze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sebze.Location = new System.Drawing.Point(33, 150);
            this.btn_sebze.Name = "btn_sebze";
            this.btn_sebze.Size = new System.Drawing.Size(104, 48);
            this.btn_sebze.TabIndex = 6;
            this.btn_sebze.Text = "Sebze";
            this.btn_sebze.UseVisualStyleBackColor = true;
            // 
            // btn_meyve
            // 
            this.btn_meyve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_meyve.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_meyve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_meyve.Location = new System.Drawing.Point(33, 81);
            this.btn_meyve.Name = "btn_meyve";
            this.btn_meyve.Size = new System.Drawing.Size(104, 48);
            this.btn_meyve.TabIndex = 5;
            this.btn_meyve.Text = "Meyve";
            this.btn_meyve.UseVisualStyleBackColor = true;
            // 
            // btn_agac
            // 
            this.btn_agac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agac.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_agac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agac.Location = new System.Drawing.Point(33, 15);
            this.btn_agac.Name = "btn_agac";
            this.btn_agac.Size = new System.Drawing.Size(104, 48);
            this.btn_agac.TabIndex = 4;
            this.btn_agac.Text = "Ağaçlar";
            this.btn_agac.UseVisualStyleBackColor = true;
            // 
            // usr_bitkiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_kucuk);
            this.Name = "usr_bitkiler";
            this.Size = new System.Drawing.Size(175, 295);
            this.Load += new System.EventHandler(this.usr_bitkiler_Load);
            this.pnl_kucuk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_kucuk;
        private buton btn_cicek;
        private buton btn_sebze;
        private buton btn_meyve;
        private buton btn_agac;

    }
}
