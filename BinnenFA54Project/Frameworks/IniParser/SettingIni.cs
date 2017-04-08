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
        SettingIniImpl a = new SettingIniImpl();
        private ISettingIni setting = new SettingIniImpl();
        private ISettingIniEdit settingEdit = new SettingIniImpl();

        #region ----- GET PROPERTIES ---------------------------------------------------------------------------------------------

        [Description("Displays the window Exit and Minimize buttons on top right."), Category("GeneralConfiguration")]
        public bool UIControls => setting.UIControls();


        [Description("Window on top most."), Category("GeneralConfiguration")]
        public bool OnTopMost => setting.OnTopMost();


        [Description("Displays the application icon on right bottom where all other apps."), Category("GeneralConfiguration")]
        public bool IconInTray => setting.IconInTray();


        [Description("Returns the Date Format as String."), Category("MiscConfiguration")]
        public string DateFormat => setting.DateFormat();


        [Description("Returns the Application Title as String."), Category("UserConfiguration")]
        public string ApplicationTitle => setting.ApplicationTitle();


        [Description("Returns the percent to pass exam as int."), Category("UserConfiguration")]
        public int PassedWithPercent => setting.PassedWithPercent();


        [Description("Returns the Company name as String."), Category("UserConfiguration")]
        public string CompanyName => setting.CompanyName();


        [Description("Returns the Street name as String."), Category("UserConfiguration")]
        public string StreetName => setting.StreetName();


        [Description("Returns the Postcode and City name as String."), Category("UserConfiguration")]
        public string PostcodeAndCity => setting.PostcodeAndCity();


        [Description("Returns the Country name as String."), Category("UserConfiguration")]
        public string Country => setting.Country();


        [Description("Returns the Phone Number as String."), Category("UserConfiguration")]
        public string PhoneNumber => setting.PhoneNumber();
        #endregion ----- GET PROPERTIES ---------------------------------------------------------------------------------------------





        #region ----- SET PROPERTIES ---------------------------------------------------------------------------------------------

        [Description("Displays the window Exit and Minimize buttons on top right."), Category("GeneralConfiguration")]
        public bool SetUIControls { set { settingEdit.SetUIControls(value); } } 


        [Description("Window on top most."), Category("GeneralConfiguration")]
        public bool SetOnTopMost { set { settingEdit.SetOnTopMost(value); } }


        [Description("Displays the application icon on right bottom where all other apps."), Category("GeneralConfiguration")]
        public bool SetIconInTray { set { settingEdit.SetIconInTray(value); } }


        [Description("Set the Date Format that is set in Setting.ini as String."), Category("MiscConfiguration")]
        public string SetDateFormat { set { settingEdit.SetDateFormat(value); } }


        [Description("Set the Application Title as String."), Category("UserConfiguration")]
        public string SetApplicationTitle { set { settingEdit.SetApplicationTitle(value); } }


        [Description("Set the percent to pass exam as int."), Category("UserConfiguration")]
        public int SetPassedWithPercent { set { settingEdit.SetPassedWithPercent(value); } }


        [Description("Set the Company name as String."), Category("UserConfiguration")]
        public string SetCompanyName { set { settingEdit.SetCompanyName(value); } }


        [Description("Set the Street name as String."), Category("UserConfiguration")]
        public string SetStreetName { set { settingEdit.SetStreetName(value); } }


        [Description("Set the Postcode and City name as String."), Category("UserConfiguration")]
        public string SetPostcodeAndCity { set { settingEdit.SetPostcodeAndCity(value); } }


        [Description("Set the Country name as String."), Category("UserConfiguration")]
        public string SetCountry { set { settingEdit.SetCountry(value); } }


        [Description("Set the Phone Number as String."), Category("UserConfiguration")]
        public string SetPhoneNumber { set { settingEdit.SetPhoneNumber(value); } }

        #endregion ----- SET PROPERTIES ---------------------------------------------------------------------------------------------




    }
}
