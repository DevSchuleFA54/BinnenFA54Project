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
        private static FileIniDataParser fileIniData = new FileIniDataParser();
        private static IniData parsedData = new IniData();
        private static string settingFilePath = AppDomain.CurrentDomain.BaseDirectory + "Setting.ini";


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
                parsedData = fileIniData.ReadFile(settingFilePath);
                appOnTopMost = bool.Parse(parsedData["GeneralConfiguration"]["ENABLE_ON_TOP_MOST"]);
            }
            catch (Exception e)
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
                parsedData = fileIniData.ReadFile(settingFilePath);
                windowControls = bool.Parse(parsedData["GeneralConfiguration"]["ENABLE_UI_CONTROLS"]);
            }
            catch (Exception e)
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
                parsedData = fileIniData.ReadFile(settingFilePath);
                iconInTray = bool.Parse(parsedData["GeneralConfiguration"]["ENABLE_ICON_IN_TRAY"]);
            }
            catch (Exception e)
            {
                ErrorMsgMissingFile("ENABLE_ICON_IN_TRAY");
            }

            return iconInTray;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::GetDateFormat
        /// \param
        /// \return bool
        ///
        public string GetDateFormat()
        {
            if (!File.Exists(settingFilePath))
            {
                ErrorMsgMissingFile("DATE_FORMAT");
                return "yyyy-M-d"; // Format example -> 2008-04-15
            }

            parsedData = fileIniData.ReadFile(settingFilePath);
            return parsedData["MiscConfiguration"]["DATE_FORMAT"];      
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
                parsedData = fileIniData.ReadFile(settingFilePath);
                sqlNameInstance = bool.Parse(parsedData["MiscConfiguration"]["ENABLE_SQL_NAME_INSTANCE"]);
            }
            catch (Exception e)
            {
                ErrorMsgMissingFile("ENABLE_SQL_NAME_INSTANCE");
            }

            return sqlNameInstance;
        }

        #endregion ------------------------------------- ISettingIni -------------------------------------







        #region region ------------------------------------- ISettingIniEdit -------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditOnTopMost
        /// \param
        /// \return bool
        ///
        public void EditOnTopMost(bool flag)
        {
            throw new NotImplementedException();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditUIControls
        /// \param
        /// \return bool
        ///
        public void EditUIControls(bool flag)
        {
            throw new NotImplementedException();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditIconInTray
        /// \param
        /// \return bool
        ///
        public void EditIconInTray(bool flag)
        {
            throw new NotImplementedException();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditGetDateFormat
        /// \param
        /// \return bool
        ///
        public void EditGetDateFormat(string dateFormat)
        {
            throw new NotImplementedException();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// \brief SettingIniImpl::EditSQLNameInstance
        /// \param
        /// \return bool
        ///
        public void EditSQLNameInstance(bool flag)
        {
            throw new NotImplementedException();
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