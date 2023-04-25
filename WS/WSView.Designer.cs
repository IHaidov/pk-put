namespace WS
{
    partial class WS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.cleanImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleanImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImageBox
            // 
            this.originalImageBox.Location = new System.Drawing.Point(12, 46);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(215, 212);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImageBox.TabIndex = 0;
            this.originalImageBox.TabStop = false;
            // 
            // cleanImageBox
            // 
            this.cleanImageBox.Location = new System.Drawing.Point(310, 46);
            this.cleanImageBox.Name = "cleanImageBox";
            this.cleanImageBox.Size = new System.Drawing.Size(216, 212);
            this.cleanImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cleanImageBox.TabIndex = 1;
            this.cleanImageBox.TabStop = false;
            // 
            // WS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 341);
            this.Controls.Add(this.cleanImageBox);
            this.Controls.Add(this.originalImageBox);
            this.Name = "WS";
            this.Text = "Steganografia";
            this.Load += new System.EventHandler(this.WS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleanImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox originalImageBox;
        private PictureBox cleanImageBox;
    }
}