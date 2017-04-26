using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Forms;
using BinnenFA54Project.Forms.Misc;

namespace BinnenFA54Project
{
    static class Program
    {
        private static MainAppLoader mainAppLoader;
        private static MainForm mainForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread splashThread = new Thread(new ThreadStart(
                delegate
                {
                    mainAppLoader = new MainAppLoader();
                    Application.Run(mainAppLoader);
                }
            ));


            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();



            //Application.Run(new MainForm());


            //run form - time taking operation
            mainForm = new MainForm();
            mainForm.Load += new EventHandler(mainForm_Load);
            Application.Run(mainForm);


            //Application.Run(new MainAppLoader());

        }


        static void mainForm_Load(object sender, EventArgs e)
        {
            //close splash
            if (mainAppLoader == null)
            {
                return;
            }

            mainAppLoader.Invoke(new Action(mainAppLoader.Close));
            mainAppLoader.Dispose();
            mainAppLoader = null;
            mainForm.WindowState = FormWindowState.Minimized;
            mainForm.Show();
            mainForm.WindowState = FormWindowState.Normal;
        }
    }
}
