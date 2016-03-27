using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LectorQRv2.Views;

namespace LectorQRv2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
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
