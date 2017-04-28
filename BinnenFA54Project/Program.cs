using System;
using System.Threading;
using System.Windows.Forms;
using GiladControllers.Forms;

namespace BinnenFA54Project
{
    static class Program
    {
        private const string APP_GUI_REG = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + APP_GUI_REG))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Only one instance of the current application allowed!");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
