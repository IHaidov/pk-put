using System.Drawing.Imaging;
using VC.Classes;

namespace VC
{
    public partial class VCView : Form
    {
        public VCView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // utworzenie obrazu BMP o wymiarach 100x100 pikseli
            Bitmap original = new Bitmap(100, 100);
            original = (Bitmap)Bitmap.FromFile("input1.bmp");
            
            // utworzenie dwóch obrazów
            Bitmap encrypted1 = new Bitmap(100, 100);
            Bitmap encrypted2 = new Bitmap(100, 100);

            // zaszyfrowanie oryginalnego obrazu
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);

                    // wygenerowanie losowej wartości
                    int random = new Random().Next(256);

                    // zapisanie wartości pierwszej części zaszyfrowanego piksela
                    Color encryptedPixel1 = Color.FromArgb(pixel.R ^ random, pixel.G ^ random, pixel.B ^ random);
                    encrypted1.SetPixel(x, y, encryptedPixel1);

                    // zapisanie wartości drugiej części zaszyfrowanego piksela
                    Color encryptedPixel2 = Color.FromArgb(random, random, random);
                    encrypted2.SetPixel(x, y, encryptedPixel2);
                }
            }

            // odszyfrowanie obrazu
            Bitmap decrypted = new Bitmap(100, 100);
            for (int x = 0; x < decrypted.Width; x++)
            {
                for (int y = 0; y < decrypted.Height; y++)
                {
                    Color pixel1 = encrypted1.GetPixel(x, y);
                    Color pixel2 = encrypted2.GetPixel(x, y);

                    // odczytanie wartości losowej
                    int random = pixel2.R;

                    // odszyfrowanie piksela
                    Color decryptedPixel = Color.FromArgb(pixel1.R ^ random, pixel1.G ^ random, pixel1.B ^ random);
                    decrypted.SetPixel(x, y, decryptedPixel);
                }
            }

            // zapisanie obrazów BMP
            original.Save("original.bmp", ImageFormat.Bmp);
            encrypted1.Save("encrypted1.bmp", ImageFormat.Bmp);
            encrypted2.Save("encrypted2.bmp", ImageFormat.Bmp);
            decrypted.Save("decrypted.bmp", ImageFormat.Bmp);
            initPictureBox.Image = original;
            firstPictureBox.Image = encrypted1;
            secondPictureBox.Image = encrypted2;
            outPictureBox.Image = decrypted;
        }
    

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}