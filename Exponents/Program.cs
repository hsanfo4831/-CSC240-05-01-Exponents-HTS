using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exponents
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Hunter Sanford
        /// 11/3/2021
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
