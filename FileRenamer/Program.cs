using System;
using System.Windows.Forms;

namespace FileRenamer
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args) 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Utilities.SingleApplication.Run(new FrmMain(args), false);
        }
    }
}