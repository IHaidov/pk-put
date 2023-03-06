using PlayfairCipher.Classes;
using System.Text.RegularExpressions;

namespace PlayfairCipher
{
    public partial class PlayfairView : Form
    {
        public const string Key = "Leopard";
        public string RememberedText = "";
        internal Playfire playfire;

        public PlayfairView()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            keyTextBox.Text = Key;
            defaultKeyRadioBtn.Checked = true;
            keyTextBox.Enabled = false;
            playfire = new Playfire();
        }
        private void InputRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OwnKeyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            keyTextBox.Enabled = true;
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DefaultKeyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            keyTextBox.Text = Key;
            keyTextBox.Enabled = false;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
           outputRichTextBox.Text =  playfire.Encrypt(Regex.Replace(inputRichTextBox.Text, "[^a-zA-Z0-9]", ""), keyTextBox.Text.ToUpper());
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = playfire.Decrypt(Regex.Replace(inputRichTextBox.Text, "[^a-zA-Z0-9]", ""), keyTextBox.Text.ToUpper());
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            RememberedText = inputRichTextBox.Text;
            inputRichTextBox.Text = outputRichTextBox.Text;
            outputRichTextBox.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            inputRichTextBox.Text = RememberedText;
            outputRichTextBox.Text = "";
        }
    }
}