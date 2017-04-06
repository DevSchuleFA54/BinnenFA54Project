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
    /// This class should not be accessed directetly, only with the usuage of the interface. Example:
    /// In main class i wanna create for a example an object that can only read the values without by accident
    /// using the edit methods. Usuage:
    /// ISettingIniEdit settingEdit = new SettingIniImpl();
    /// ISettingIniEdit setting = new SettingIniImpl();
    /// </summary>
    class SettingIniImpl : ISettingIni, ISettingIniEdit
    {
        private static FileIniDataParser iniParser = new FileIniDataParser();
        private static IniData data                = new IniData();
        private static string settingPath          = AppDomain.CurrentDomain.BaseDirectory + "Settings.ini";


        public SettingIniImpl()
        {
            if (!File.Exists(settingPath))
            {
                MessageBox.Show("Missing Settings.ini file. Generating Settings.ini with default settings for you.", 
                    "Missing Settings File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.WriteAllText(settingPath, Properties.Resources.Settings);
            }
        }



        #region ------------------------------------- ISettingIni -------------------------------------
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
                ErrorMsgMissingFile("ENABLE_ON_TOP_MOST");
            }

            return appOnTopMost;
        }


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
                ErrorMsgMissingFile("ENABLE_UI_CONTROLS");
            }

            return windowControls;
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
                ErrorMsgMissingFile("ENABLE_ICON_IN_TRAY");
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
            if (!File.Exists(settingPath))
            {
                ErrorMsgMissingFile("DATE_FORMAT");
                return "yyyy-M-d"; // Format example -> 2008-04-15
            }

            data = iniParser.ReadFile(settingPath);
            return data["MiscConfiguration"]["DATE_FORMAT"];      
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::SQLNameInstance
        /// \param
        /// \return bool
        ///
        public bool SQLNameInstance()
        {
            bool sqlNameInstance = false; // default setting

            try
            {
                data = iniParser.ReadFile(settingPath);
                sqlNameInstance = bool.Parse(data["MiscConfiguration"]["ENABLE_SQL_NAME_INSTANCE"]);
            }
            catch (Exception)
            {
                ErrorMsgMissingFile("ENABLE_SQL_NAME_INSTANCE");
            }

            return sqlNameInstance;
        }

        #endregion ------------------------------------- ISettingIni -------------------------------------







        #region ------------------------------------- ISettingIniEdit -------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditOnTopMost
        /// \param flag
        /// \return
        ///
        public void EditOnTopMost(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_ON_TOP_MOST"] = flag.ToString().ToLower();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsgMissingFile("ENABLE_ON_TOP_MOST");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditUIControls
        /// \param flag
        /// \return
        ///
        public void EditUIControls(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_UI_CONTROLS"] = flag.ToString().ToLower();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsgMissingFile("ENABLE_UI_CONTROLS");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditIconInTray
        /// \param flag
        /// \return 
        ///
        public void EditIconInTray(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_ICON_IN_TRAY"] = flag.ToString();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsgMissingFile("ENABLE_ICON_IN_TRAY");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditGetDateFormat
        /// \param dateFormat
        /// \return
        ///
        public void EditDateFormat(string dateFormat)
        {
            try
            {
                data["GeneralConfiguration"]["DATE_FORMAT"] = dateFormat;
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsgMissingFile("DATE_FORMAT");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditSQLNameInstance
        /// \param flag
        /// \return 
        ///
        public void EditSQLNameInstance(bool flag)
        {
            try
            {
                data["GeneralConfiguration"]["ENABLE_SQL_NAME_INSTANCE"] = flag.ToString().ToLower();
                iniParser.WriteFile(settingPath, data);
            }
            catch (Exception)
            {
                ErrorMsgMissingFile("ENABLE_SQL_NAME_INSTANCE");
            }
        }
        #endregion ------------------------------------- ISettingIniEdit -------------------------------------



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::ErrorMsgMissingFile
        /// \param
        /// \return bool
        ///
        private void ErrorMsgMissingFile(string msg)
        {
            MessageBox.Show(
                string.Format("[{0}] - Missing or Wrong in \"Setting.ini\" Configuration File! /n Setting defaults configuration...", msg),
                "ERROR", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );

        }
    }
}