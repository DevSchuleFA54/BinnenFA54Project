using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Frameworks.IniParser
{
    class SettingIniUtility : SettingIniImpl
    {
        #region ------------------------------- PROPERTIES -------------------------------

        [Description("Displays the window Exit and Minimize buttons on top right."), Category("GeneralConfiguration")]
        public bool UIControls => UIControls();


        [Description("Window on top most."), Category("GeneralConfiguration")]
        public bool OnTopMost => OnTopMost();


        [Description("Displays the application icon on right bottom where all other apps."), Category("GeneralConfiguration")]
        public bool IconInTray => IconInTray();


        [Description("Returns the Date Format that is set in Setting.ini as String."), Category("MiscConfiguration")]
        public string GetDateFormat => GetDateFormat();


        [Description("Name instance enabled or not. default: Server=localhost\\sqlexpress."), Category("MiscConfiguration")]
        public bool SQLNameInstance => SQLNameInstance();

        #endregion ---------------------------- PROPERTIES -------------------------------
    }
}
