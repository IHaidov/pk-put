using System;
using System.Drawing;
using System.Windows.Forms;

namespace WS
{
    public partial class WS : Form
    {
        public WS()
        {
            InitializeComponent();
            originalImageBox.Image = Image.FromFile("input.bmp");
        }

        private void WS_Load(object sender, EventArgs e)
        {
            WatermarkAlgorithm.WS();
        }
    }
}
