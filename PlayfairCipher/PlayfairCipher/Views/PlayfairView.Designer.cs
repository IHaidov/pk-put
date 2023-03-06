namespace PlayfairCipher
{
    partial class PlayfairView
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ownKeyRadioBtn = new System.Windows.Forms.RadioButton();
            this.defaultKeyRadioBtn = new System.Windows.Forms.RadioButton();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.inputTextLbl = new System.Windows.Forms.Label();
            this.outputTextLbl = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptButton.Location = new System.Drawing.Point(12, 436);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(141, 55);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptButton.Location = new System.Drawing.Point(212, 436);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(141, 55);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outputRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputRichTextBox.Location = new System.Drawing.Point(12, 295);
            this.outputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(341, 117);
            this.outputRichTextBox.TabIndex = 2;
            this.outputRichTextBox.Text = "";
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputRichTextBox.Location = new System.Drawing.Point(12, 42);
            this.inputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(341, 113);
            this.inputRichTextBox.TabIndex = 3;
            this.inputRichTextBox.Text = "hello joe";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.InputRichTextBox_TextChanged);
            // 
            // ownKeyRadioBtn
            // 
            this.ownKeyRadioBtn.AutoSize = true;
            this.ownKeyRadioBtn.Location = new System.Drawing.Point(12, 161);
            this.ownKeyRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ownKeyRadioBtn.Name = "ownKeyRadioBtn";
            this.ownKeyRadioBtn.Size = new System.Drawing.Size(118, 19);
            this.ownKeyRadioBtn.TabIndex = 4;
            this.ownKeyRadioBtn.TabStop = true;
            this.ownKeyRadioBtn.Text = "Use Your own key";
            this.ownKeyRadioBtn.UseVisualStyleBackColor = true;
            this.ownKeyRadioBtn.CheckedChanged += new System.EventHandler(this.OwnKeyRadioBtn_CheckedChanged);
            // 
            // defaultKeyRadioBtn
            // 
            this.defaultKeyRadioBtn.AutoSize = true;
            this.defaultKeyRadioBtn.Location = new System.Drawing.Point(12, 184);
            this.defaultKeyRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.defaultKeyRadioBtn.Name = "defaultKeyRadioBtn";
            this.defaultKeyRadioBtn.Size = new System.Drawing.Size(105, 19);
            this.defaultKeyRadioBtn.TabIndex = 5;
            this.defaultKeyRadioBtn.TabStop = true;
            this.defaultKeyRadioBtn.Text = "Use default key";
            this.defaultKeyRadioBtn.UseVisualStyleBackColor = true;
            this.defaultKeyRadioBtn.CheckedChanged += new System.EventHandler(this.DefaultKeyRadioBtn_CheckedChanged);
            // 
            // keyTextBox
            // 
            this.keyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keyTextBox.Location = new System.Drawing.Point(12, 206);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(341, 18);
            this.keyTextBox.TabIndex = 6;
            this.keyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // inputTextLbl
            // 
            this.inputTextLbl.AutoSize = true;
            this.inputTextLbl.Location = new System.Drawing.Point(12, 9);
            this.inputTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputTextLbl.Name = "inputTextLbl";
            this.inputTextLbl.Size = new System.Drawing.Size(61, 15);
            this.inputTextLbl.TabIndex = 7;
            this.inputTextLbl.Text = "Input text:";
            // 
            // outputTextLbl
            // 
            this.outputTextLbl.AutoSize = true;
            this.outputTextLbl.Location = new System.Drawing.Point(12, 255);
            this.outputTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTextLbl.Name = "outputTextLbl";
            this.outputTextLbl.Size = new System.Drawing.Size(71, 15);
            this.outputTextLbl.TabIndex = 8;
            this.outputTextLbl.Text = "Output text:";
            // 
            // CopyButton
            // 
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.Location = new System.Drawing.Point(212, 248);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(141, 40);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Text = "Copy to Input";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(212, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Paste previous text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PlayfairView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(365, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.outputTextLbl);
            this.Controls.Add(this.inputTextLbl);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.defaultKeyRadioBtn);
            this.Controls.Add(this.ownKeyRadioBtn);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PlayfairView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playfire Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button encryptButton;
        private Button decryptButton;
        private RichTextBox outputRichTextBox;
        private RichTextBox inputRichTextBox;
        private RadioButton ownKeyRadioBtn;
        private RadioButton defaultKeyRadioBtn;
        private TextBox keyTextBox;
        private Label inputTextLbl;
        private Label outputTextLbl;
        private Button CopyButton;
        private Button button1;
    }
}