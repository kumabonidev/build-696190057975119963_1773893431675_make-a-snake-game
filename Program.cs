// هذا الملف يحتوي على نقطة الدخول إلى التطبيق
using System;
using System.Windows.Forms;

namespace SnakeGame
{
    static class Program
    {
        /// <summary>
        /// النقطة الرئيسية للدخول إلى التطبيق.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}