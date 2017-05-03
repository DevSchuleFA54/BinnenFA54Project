using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Properties;

namespace BinnenFA54Project
{
    static class Program
    {
        private const string APP_GUI_REG = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";
        private static SettingIni setting;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            setting = new SettingIni();
            // NOTE: Sets the language environment for the program reading from setting.
            Thread.CurrentThread.CurrentUICulture = setting.Language == "en-US" ?
                new CultureInfo("en-US") : new CultureInfo("de-DE");

            using (Mutex mutex = new Mutex(false, "Global\\" + APP_GUI_REG))
            {
                if (!mutex.WaitOne(0, false))
                {
                    // Only one instance of the current application allowed!
                    MessageBox.Show(Resources.ResourceManager.GetString("ONE_INSTANCE_ALLOWED"));
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
