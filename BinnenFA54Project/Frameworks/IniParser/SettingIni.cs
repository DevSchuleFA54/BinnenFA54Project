using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Frameworks.IniParser
{
    /// <summary>
    /// Considering deleting this class, but if you want to use the configuration as properties,
    /// feel free to instanciat this class as all in one configuration.
    /// </summary>
    class SettingIni
    {
        private ISettingIni setting = new SettingIniImpl();
        private ISettingIniEdit settingEdit = new SettingIniImpl();

        #region ------------------------------- GET PROPERTIES -------------------------------

        [Description("Displays the window Exit and Minimize buttons on top right."), Category("GeneralConfiguration")]
        public bool UIControls => setting.UIControls();


        [Description("Window on top most."), Category("GeneralConfiguration")]
        public bool OnTopMost => setting.OnTopMost();


        [Description("Displays the application icon on right bottom where all other apps."), Category("GeneralConfiguration")]
        public bool IconInTray => setting.IconInTray();


        [Description("Returns the Date Format that is set in Setting.ini as String."), Category("MiscConfiguration")]
        public string DateFormat => setting.DateFormat();


        #endregion ---------------------------- GET PROPERTIES -------------------------------




        #region ------------------------------- SET PROPERTIES -------------------------------

        [Description("Displays the window Exit and Minimize buttons on top right."), Category("GeneralConfiguration")]
        public bool SetUIControls { set { settingEdit.EditUIControls(value); } } 


        [Description("Window on top most."), Category("GeneralConfiguration")]
        public bool SetOnTopMost { set { settingEdit.EditOnTopMost(value); } }


        [Description("Displays the application icon on right bottom where all other apps."), Category("GeneralConfiguration")]
        public bool SetIconInTray { set { settingEdit.EditIconInTray(value); } }


        [Description("Set the Date Format that is set in Setting.ini as String."), Category("MiscConfiguration")]
        public string SetDateFormat { set { settingEdit.EditDateFormat(value); } }



        #endregion ---------------------------- SET PROPERTIES -------------------------------




    }
}
