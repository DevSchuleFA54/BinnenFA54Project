using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Forms;

namespace BinnenFA54Project.Main
{
    /// <summary>
    /// Used for holding reference to the forms statically in memory when we need to update
    /// a form from another form without the need to instantiate them.
    /// Makes things easier to be maintained.
    /// </summary>
    public class FormsBase
    {
        public static MainForm MainForm { get; set; }
        public static QuizForm QuizForm { get; set; }
        public static ConfigurationForm ConfigurationForm { get; set; }


        public static bool MainInstanceOpened { get; set; }
        public static bool QuizInstanceOpened { get; set; }
        public static bool ConfigurationInstanceOpened { get; set; }



        public static void RefreshMainForm()
        {
            MainForm.Visible = false;
            MainForm.Visible = true;
        }
    }

}
