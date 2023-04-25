using System;
using System.Drawing;

namespace VC.Classes
{
    public static class VisualCrypto
    {
        public static void Encrypt()
        {
            // Wczytanie obrazu wejściowego
            Bitmap inputImage = new Bitmap("input.bmp");

            // Stworzenie dwóch obrazów z udziałami
            Bitmap share1 = new Bitmap(inputImage.Width, inputImage.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Bitmap share2 = new Bitmap(inputImage.Width, inputImage.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Podział pikseli na udziały
            for (int x = 0; x < inputImage.Width; x++)
            {
                for (int y = 0; y < inputImage.Height; y++)
                {
                    // Wygenerowanie losowych wartości dla pikseli udziałów
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int r = pixelColor.R;
                    int g = pixelColor.G;
                    int b = pixelColor.B;
                    int randomNumber = new Random().Next(2);

                    // Przypisanie odpowiednich wartości do udziałów
                    if (randomNumber == 0)
                    {
                        share1.SetPixel(x, y, Color.FromArgb(r, g, b));
                        share2.SetPixel(x, y, Color.FromArgb(255 - r, 255 - g, 255 - b));
                    }
                    else
                    {
                        share2.SetPixel(x, y, Color.FromArgb(r, g, b));
                        share1.SetPixel(x, y, Color.FromArgb(255 - r, 255 - g, 255 - b));
                    }
                }
            }

            // Zapisanie udziałów do plików
            share1.Save("share1.bmp");
            share2.Save("share2.bmp");

            Console.WriteLine("Udziały zostały wygenerowane i zapisane do plików.");
            Console.ReadLine();
        }

        public static void Decrypt()
        {
            // Wczytanie udziałów
            Bitmap share1 = new Bitmap("share1.bmp");
            Bitmap share2 = new Bitmap("share2.bmp");

            // Utworzenie obrazu wynikowego
            Bitmap outputImage = new Bitmap(share1.Width, share1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Odczytanie wartości pikseli oryginalnego obrazu z udziałów
            for (int x = 0; x < share1.Width; x++)
            {
                for (int y = 0; y < share1.Height; y++)
                {
                    Color pixelColor1 = share1.GetPixel(x, y);
                    Color pixelColor2 = share2.GetPixel(x, y);

                    int r = (pixelColor1.R + pixelColor2.R) / 2;
                    int g = (pixelColor1.G + pixelColor2.G) / 2;
                    int b = (pixelColor1.B + pixelColor2.B) / 2;

                    outputImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            // Zapisanie oryginalnego obrazu do pliku
            outputImage.Save("output.bmp");

            Console.WriteLine("Oryginalny obraz został odtworzony i zapisany do pliku.");
            Console.ReadLine();
        }
    }
}