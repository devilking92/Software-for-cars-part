namespace WindowsFormsApp1
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.picturesPreview = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturesPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.listBoxImages);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Всички снимки";
            // 
            // listBoxImages
            // 
            this.listBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.Location = new System.Drawing.Point(6, 19);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(198, 485);
            this.listBoxImages.TabIndex = 0;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // picturesPreview
            // 
            this.picturesPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturesPreview.Location = new System.Drawing.Point(228, 15);
            this.picturesPreview.Name = "picturesPreview";
            this.picturesPreview.Size = new System.Drawing.Size(576, 517);
            this.picturesPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturesPreview.TabIndex = 1;
            this.picturesPreview.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 552);
            this.Controls.Add(this.picturesPreview);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturesPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.PictureBox picturesPreview;
    }
}