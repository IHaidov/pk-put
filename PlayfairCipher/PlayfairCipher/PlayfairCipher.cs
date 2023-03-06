using System;
using System.Windows.Forms;

namespace PlayfairCipher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PlayfairView());
        }
    }
}