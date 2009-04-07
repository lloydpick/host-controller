using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;

namespace HostController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OSVersionInfo os = new OperatingSystemVersion();
            if ((os != OSVersionInfo.WinXP) && (os != OSVersionInfo.Vista))
            {
                MessageBox.Show("Sorry, this is a Windows XP application only!", Application.ProductName.ToString() + " v" + Application.ProductVersion.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Application.Run(new Main());
            }
        }
    }
}