namespace voicetrainig
{
    partial class usr_logo
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
            this.lbl_tra = new System.Windows.Forms.Label();
            this.lbl_voi = new System.Windows.Forms.Label();
            this.pcr_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tra
            // 
            this.lbl_tra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tra.AutoSize = true;
            this.lbl_tra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_tra.Location = new System.Drawing.Point(187, 262);
            this.lbl_tra.Name = "lbl_tra";
            this.lbl_tra.Size = new System.Drawing.Size(89, 24);
            this.lbl_tra.TabIndex = 1;
            this.lbl_tra.Text = " Training";
            // 
            // lbl_voi
            // 
            this.lbl_voi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_voi.AutoSize = true;
            this.lbl_voi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_voi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lbl_voi.Location = new System.Drawing.Point(134, 262);
            this.lbl_voi.Name = "lbl_voi";
            this.lbl_voi.Size = new System.Drawing.Size(62, 24);
            this.lbl_voi.TabIndex = 2;
            this.lbl_voi.Text = "Voice";
            // 
            // pcr_logo
            // 
            this.pcr_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcr_logo.BackColor = System.Drawing.Color.White;
            this.pcr_logo.Image = global::voicetrainig.Properties.Resources.computer_4_256___Kopya;
            this.pcr_logo.Location = new System.Drawing.Point(48, 49);
            this.pcr_logo.Name = "pcr_logo";
            this.pcr_logo.Size = new System.Drawing.Size(302, 201);
            this.pcr_logo.TabIndex = 0;
            this.pcr_logo.TabStop = false;
            // 
            // usr_logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_voi);
            this.Controls.Add(this.lbl_tra);
            this.Controls.Add(this.pcr_logo);
            this.Name = "usr_logo";
            this.Size = new System.Drawing.Size(407, 338);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_logo;
        private System.Windows.Forms.Label lbl_tra;
        private System.Windows.Forms.Label lbl_voi;
    }
}
