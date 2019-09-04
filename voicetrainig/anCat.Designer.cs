namespace voicetrainig
{
    partial class anCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anCat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.waitBox = new System.Windows.Forms.PictureBox();
            this.okeyBox = new System.Windows.Forms.PictureBox();
            this.mainBox = new System.Windows.Forms.PictureBox();
            this.playBox = new System.Windows.Forms.PictureBox();
            this.pauseBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okeyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // waitBox
            // 
            this.waitBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waitBox.Image = ((System.Drawing.Image)(resources.GetObject("waitBox.Image")));
            this.waitBox.Location = new System.Drawing.Point(336, 328);
            this.waitBox.Name = "waitBox";
            this.waitBox.Size = new System.Drawing.Size(66, 64);
            this.waitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.waitBox.TabIndex = 1;
            this.waitBox.TabStop = false;
            // 
            // okeyBox
            // 
            this.okeyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okeyBox.Image = ((System.Drawing.Image)(resources.GetObject("okeyBox.Image")));
            this.okeyBox.Location = new System.Drawing.Point(336, 328);
            this.okeyBox.Name = "okeyBox";
            this.okeyBox.Size = new System.Drawing.Size(66, 64);
            this.okeyBox.TabIndex = 2;
            this.okeyBox.TabStop = false;
            // 
            // mainBox
            // 
            this.mainBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainBox.Image = ((System.Drawing.Image)(resources.GetObject("mainBox.Image")));
            this.mainBox.Location = new System.Drawing.Point(336, 328);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(66, 64);
            this.mainBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainBox.TabIndex = 3;
            this.mainBox.TabStop = false;
            // 
            // playBox
            // 
            this.playBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playBox.Image = ((System.Drawing.Image)(resources.GetObject("playBox.Image")));
            this.playBox.Location = new System.Drawing.Point(621, 3);
            this.playBox.Name = "playBox";
            this.playBox.Size = new System.Drawing.Size(66, 64);
            this.playBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playBox.TabIndex = 4;
            this.playBox.TabStop = false;
            this.playBox.Click += new System.EventHandler(this.recognizer_Start);
            // 
            // pauseBox
            // 
            this.pauseBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pauseBox.Image = ((System.Drawing.Image)(resources.GetObject("pauseBox.Image")));
            this.pauseBox.Location = new System.Drawing.Point(621, 3);
            this.pauseBox.Name = "pauseBox";
            this.pauseBox.Size = new System.Drawing.Size(66, 64);
            this.pauseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseBox.TabIndex = 5;
            this.pauseBox.TabStop = false;
            this.pauseBox.Click += new System.EventHandler(this.recognizer_Stop);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ses Komutu Bekleniyor. . .";
            // 
            // anCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseBox);
            this.Controls.Add(this.playBox);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.okeyBox);
            this.Controls.Add(this.waitBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "anCat";
            this.Size = new System.Drawing.Size(800, 480);
            this.Load += new System.EventHandler(this.anCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okeyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox waitBox;
        private System.Windows.Forms.PictureBox okeyBox;
        private System.Windows.Forms.PictureBox mainBox;
        private System.Windows.Forms.PictureBox playBox;
        private System.Windows.Forms.PictureBox pauseBox;
        private System.Windows.Forms.Label label1;
    }
}
