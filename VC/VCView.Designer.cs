namespace VC
{
    partial class VCView
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
            this.initPictureBox = new System.Windows.Forms.PictureBox();
            this.outPictureBox = new System.Windows.Forms.PictureBox();
            this.firstPictureBox = new System.Windows.Forms.PictureBox();
            this.secondPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.initPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // initPictureBox
            // 
            this.initPictureBox.Location = new System.Drawing.Point(9, 38);
            this.initPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.initPictureBox.Name = "initPictureBox";
            this.initPictureBox.Size = new System.Drawing.Size(70, 60);
            this.initPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.initPictureBox.TabIndex = 0;
            this.initPictureBox.TabStop = false;
            this.initPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // outPictureBox
            // 
            this.outPictureBox.Location = new System.Drawing.Point(231, 38);
            this.outPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.outPictureBox.Name = "outPictureBox";
            this.outPictureBox.Size = new System.Drawing.Size(70, 60);
            this.outPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outPictureBox.TabIndex = 1;
            this.outPictureBox.TabStop = false;
            this.outPictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // firstPictureBox
            // 
            this.firstPictureBox.Location = new System.Drawing.Point(83, 38);
            this.firstPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstPictureBox.Name = "firstPictureBox";
            this.firstPictureBox.Size = new System.Drawing.Size(70, 60);
            this.firstPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstPictureBox.TabIndex = 2;
            this.firstPictureBox.TabStop = false;
            this.firstPictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // secondPictureBox
            // 
            this.secondPictureBox.Location = new System.Drawing.Point(157, 38);
            this.secondPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondPictureBox.Name = "secondPictureBox";
            this.secondPictureBox.Size = new System.Drawing.Size(70, 60);
            this.secondPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondPictureBox.TabIndex = 3;
            this.secondPictureBox.TabStop = false;
            this.secondPictureBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 127);
            this.Controls.Add(this.secondPictureBox);
            this.Controls.Add(this.firstPictureBox);
            this.Controls.Add(this.outPictureBox);
            this.Controls.Add(this.initPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox initPictureBox;
        private PictureBox outPictureBox;
        private PictureBox firstPictureBox;
        private PictureBox secondPictureBox;
    }
}