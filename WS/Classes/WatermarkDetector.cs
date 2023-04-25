using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

public static class WatermarkAlgorithm
{
    public static void EmbedWatermark(Image image, int n)
    {
        Random random = new Random();
        int bitsPerPixel = GetBitsPerPixel(image.PixelFormat);
        int d = (int)(255.0 / (Math.Pow(2, bitsPerPixel) - 1));

        for (int i = 0; i < n; i++)
        {
            int x1 = random.Next(image.Width);
            int y1 = random.Next(image.Height);
            int x2 = random.Next(image.Width);
            int y2 = random.Next(image.Height);

            AdjustBrightness(image, x1, y1, d);
            AdjustBrightness(image, x2, y2, -d);
        }

        image.Save("output.png", ImageFormat.Png);
    }

    private static int GetBitsPerPixel(PixelFormat pixelFormat)
    {
        int bitsPerPixel = Image.GetPixelFormatSize(pixelFormat);
        return bitsPerPixel;
    }

    private static void AdjustBrightness(Image image, int x, int y, int d)
    {
        Bitmap bitmap = (Bitmap)image;
        Color color = bitmap.GetPixel(x, y);
        int r = color.R + d;
        int g = color.G + d;
        int b = color.B + d;
        r = Math.Min(255, Math.Max(0, r));
        g = Math.Min(255, Math.Max(0, g));
        b = Math.Min(255, Math.Max(0, b));
        Color newColor = Color.FromArgb(color.A, r, g, b);
        bitmap.SetPixel(x, y, newColor);
    }

    public static string ExtractText(Image image, int n)
    {
        StringBuilder sb = new StringBuilder();
        Random random = new Random();
        int bitsPerPixel = GetBitsPerPixel(image.PixelFormat);
        int d = (int)(255.0 / (Math.Pow(2, bitsPerPixel) - 1));

        for (int i = 0; i < n; i++)
        {
            int x1 = random.Next(image.Width);
            int y1 = random.Next(image.Height);
            int x2 = random.Next(image.Width);
            int y2 = random.Next(image.Height);

            int brightness1 = GetBrightness(image, x1, y1);
            int brightness2 = GetBrightness(image, x2, y2);
            int delta = brightness1 - brightness2;

            if (delta > d / 2)
            {
                sb.Append("0");
            }
            else if (delta < -d / 2)
            {
                sb.Append("1");
            }
            else
            {
                // If the difference is too small, assume that no watermark bit was embedded
                // at these pixels and try again with a different pair of pixels.
                i--;
            }
        }

        return BinaryToString(sb.ToString());
    }

    private static int GetBrightness(Image image, int x, int y)
    {
        Bitmap bitmap = (Bitmap)image;
        Color color = bitmap.GetPixel(x, y);
        int brightness = (int)(0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B);
        return brightness;
    }

    private static string BinaryToString(string binary)
    {
        int length = binary.Length;
        byte[] bytes = new byte[length / 8];

        for (int i = 0; i < length; i += 8)
        {
            bytes[i / 8] = Convert.ToByte(binary.Substring(i, 8), 2);
        }

        string text = Encoding.UTF8.GetString(bytes);
        return text;
    }
}
