using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace BinnenFA54Project.Frameworks.IniParser
{
    /// <summary>
    /// This class should not be instantiated or derived, only by the usuage of the interfaces! Example:
    /// In main class i want to create an object that can only read the values without by accident
    /// using the set methods. Usuage:
    /// ISettingIniEdit settingEdit = new SettingIniImpl();
    /// ISettingIniEdit setting = new SettingIniImpl();
    /// </summary>
    internal sealed class SettingIniImpl : ISettingIni, ISettingIniEdit
    {
        private static FileIniDataParser iniParser = new FileIniDataParser();
        private static IniData data = new IniData();
        private static string settingPath = AppDomain.CurrentDomain.BaseDirectory + "Settings.ini";


        public SettingIniImpl()
        {
            if (!File.Exists(settingPath))
            {
                MessageBox.Show("Missing Settings.ini file. Generating Settings.ini with default settings for you.",
                    "Missing Settings File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.WriteAllText(settingPath, Properties.Resources.Settings);
            }
        }



        #region ------ ISettingIni ---------------------------------------------------------------------------------------------


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::UIControls
        /// \param
        /// \return bool
        ///
        public bool UIControls()
        {
            bool windowControls = true; // default setting

            try
            {
                data = iniParser.ReadFile(settingPath);
                windowControls = bool.Parse(data["GeneralConfiguration"]["ENABLE_UI_CONTROLS"]);
            }
            catch (Exception)
            {
                ErrorMsg("ENABLE_UI_CONTROLS");
            }

            return windowControls;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::OnTopMost
        /// \param
        /// \return bool
        ///
        public bool OnTopMost()
        {
            bool appOnTopMost = false; // default setting

            try
            {
                data = iniParser.ReadFile(settingPath);
                appOnTopMost = bool.Parse(data["GeneralConfiguration"]["ENABLE_ON_TOP_MOST"]);
            }
            catch (Exception)
            {
                ErrorMsg("ENABLE_ON_TOP_MOST");
            }

            return appOnTopMost;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::IconInTray
        /// \param
        /// \return bool
        ///
        public bool IconInTray()
        {
            bool iconInTray = false; // default setting

            try
            {
                data = iniParser.ReadFile(settingPath);
                iconInTray = bool.Parse(data["GeneralConfiguration"]["ENABLE_ICON_IN_TRAY"]);
            }
            catch (Exception)
            {
                ErrorMsg("ENABLE_ICON_IN_TRAY");
            }

            return iconInTray;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::DateFormat
        /// \param
        /// \return string
        ///
        public string DateFormat()
        {
            string dateFormat = "yyyy-M-d";  // 2008-04-15

            try
            {
                data = iniParser.ReadFile(settingPath);
                dateFormat = data["MiscConfiguration"]["DATE_FORMAT"];
            }
            catch (Exception)
            {
                ErrorMsg("DATE_FORMAT");
            }

            return dateFormat;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::ApplicationTitle
        /// \param
        /// \return string
        ///
        public string ApplicationTitle()
        {
            string applicationTitle = "Application";

            try
            {
                data = iniParser.ReadFile(settingPath);
                applicationTitle = data["UserConfiguration"]["APPLICATION_NAME"];
            }
            catch (Exception)
            {
                ErrorMsg("APPLICATION_NAME");
            }

            return applicationTitle;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::PassedWithPercent
        /// \param
        /// \return int
        ///
        public int PassedWithPercent()
        {
            int passedWithPercent = 70;

            try
            {
                data = iniParser.ReadFile(settingPath);
                passedWithPercent = int.Parse(data["UserConfiguration"]["PASSED_WITH_PERCENT"]);
            }
            catch (Exception)
            {
                ErrorMsg("PASSED_WITH_PERCENT");
            }

            return passedWithPercent;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::CompanyName
        /// \param
        /// \return string
        ///
        public string CompanyName()
        {
            string companyName = "Company Name";

            try
            {
                data = iniParser.ReadFile(settingPath);
                companyName = data["UserConfiguration"]["COMPANY_NAME"];
            }
            catch (Exception)
            {
                ErrorMsg("COMPANY_NAME");
            }

            return companyName;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::StreetName
        /// \param
        /// \return string
        ///
        public string StreetName()
        {
            string streetName = "Street Name 34";

            try
            {
                data = iniParser.ReadFile(settingPath);
                streetName = data["UserConfiguration"]["STREET_NAME"];
            }
            catch (Exception)
            {
                ErrorMsg("STREET_NAME");
            }

            return streetName;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::PostcodeAndCity
        /// \param
        /// \return string
        ///
        public string PostcodeAndCity()
        {
            string postcodeAndCity = "54321 Berlin";

            try
            {
                data = iniParser.ReadFile(settingPath);
                postcodeAndCity = data["UserConfiguration"]["POSTCODE_AND_CITY"];
            }
            catch (Exception)
            {
                ErrorMsg("POSTCODE_AND_CITY");
            }

            return postcodeAndCity;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::Country
        /// \param
        /// \return string
        ///
        public string Country()
        {
            string country = "Germany";

            try
            {
                data = iniParser.ReadFile(settingPath);
                country = data["UserConfiguration"]["COUNTRY_NAME"];
            }
            catch (Exception)
            {
                ErrorMsg("COUNTRY_NAME");
            }

            return country;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::Country
        /// \param
        /// \return string
        ///
        public string PhoneNumber()
        {
            string phoneNumber = "0157-2651235";

            try
            {
                data = iniParser.ReadFile(settingPath);
                phoneNumber = data["UserConfiguration"]["TELEPHONE_NUMBER"];
            }
            catch (Exception)
            {
                ErrorMsg("TELEPHONE_NUMBER");
            }

            return phoneNumber;
        }

        #endregion ------ ISettingIni ------------------------------------------------------------------------------------------







        #region ------ ISettingIniEdit -----------------------------------------------------------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditUIControls
        /// \param flag
        /// \return
        ///
        public void SetUIControls(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_UI_CONTROLS"] = flag.ToString().ToLower();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("ENABLE_UI_CONTROLS");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditOnTopMost
        /// \param flag
        /// \return
        ///
        public void SetOnTopMost(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_ON_TOP_MOST"] = flag.ToString().ToLower();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("ENABLE_ON_TOP_MOST");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditIconInTray
        /// \param flag
        /// \return 
        ///
        public void SetIconInTray(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_ICON_IN_TRAY"] = flag.ToString();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("ENABLE_ICON_IN_TRAY");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditGetDateFormat
        /// \param dateFormat
        /// \return
        ///
        public void SetDateFormat(string dateFormat)
        {
            try
            {
                data["GeneralConfiguration"]["DATE_FORMAT"] = dateFormat;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("DATE_FORMAT");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::ApplicationTitle
        /// \param applicationName
        /// \return
        ///
        public void SetApplicationTitle(string applicationTitle)
        {
            try
            {
                data["UserConfiguration"]["APPLICATION_NAME"] = applicationTitle;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("APPLICATION_NAME");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::PassedWithPercent
        /// \param
        /// \return int
        ///
        public void SetPassedWithPercent(int passedWithPercent)
        {
            if (passedWithPercent < 0 || passedWithPercent > 100)
                throw new ArgumentOutOfRangeException();

            try
            {
                data["UserConfiguration"]["PASSED_WITH_PERCENT"] = passedWithPercent.ToString();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("PASSED_WITH_PERCENT");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::CompanyName
        /// \param companyName
        /// \return 
        ///
        public void SetCompanyName(string companyName)
        {
            try
            {
                data["UserConfiguration"]["COMPANY_NAME"] = companyName;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("COMPANY_NAME");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::StreetName
        /// \param streetName
        /// \return 
        ///
        public void SetStreetName(string streetName)
        {
            try
            {
                data["UserConfiguration"]["STREET_NAME"] = streetName;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("STREET_NAME");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::PostcodeAndCity
        /// \param postcodeAndCity
        /// \return 
        ///
        public void SetPostcodeAndCity(string postcodeAndCity)
        {
            try
            {
                data["UserConfiguration"]["POSTCODE_AND_CITY"] = postcodeAndCity;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("POSTCODE_AND_CITY");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::Country
        /// \param country
        /// \return 
        ///
        public void SetCountry(string country)
        {
            try
            {
                data["UserConfiguration"]["COUNTRY_NAME"] = country;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("COUNTRY_NAME");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::Country
        /// \param phoneNumber
        /// \return 
        ///
        public void SetPhoneNumber(string phoneNumber)
        {
            try
            {
                data["UserConfiguration"]["TELEPHONE_NUMBER"] = phoneNumber;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsg("TELEPHONE_NUMBER");
            }
        }
        #endregion ------ ISettingIniEdit --------------------------------------------------------------------------------------



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::ErrorMsg
        /// \param
        /// \return bool
        ///
        private void ErrorMsg(string msg)
        {
            MessageBox.Show(
                string.Format("[{0}] - Missing or Wrong input in \"Settings.ini\" Configuration File! /n Using default configurations...", msg),
                "ERROR", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );

        }
    }
}