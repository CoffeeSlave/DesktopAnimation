
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GlobalFloaty
{
    static class Program
    {
        /// <summary>
        /// Main Entry
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}