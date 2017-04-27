﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;


namespace BinnenFA54Project.Frameworks.IniParser
{
    /// <summary>
    /// This is the class you want to instantiate to access settings.
    /// </summary>
    class SettingIni
    {
        private ISettingIni setting = new SettingIniImpl();
        private ISettingIniEdit settingEdit = new SettingIniImpl();

        private static FileIniDataParser iniParser = new FileIniDataParser();
        private static IniData data = new IniData();
        private static string settingPath = AppDomain.CurrentDomain.BaseDirectory + "Results.ini";


        public void SaveExamResults(string examName, int passWithP, bool pass)
        {
            if (!File.Exists(settingPath))
            {
                MessageBox.Show("Created Results.ini");
                File.WriteAllText(settingPath, Properties.Resources.Results);
            }

            try
            {
                data = iniParser.ReadFile(settingPath);
                var sectionData = data.Sections.GetSectionData("ExamResults");
                string lastNewKeyName = String.Empty;

                // Get the amount of keys and store in lastNewKeyName.
                lastNewKeyName = ("LOG" + (sectionData.Keys.Count + 1));
                string value = string.Format("{0} - ({1}%) - {2}",
                    examName, passWithP, pass ? "Bestanden" : "Nicht bestanden");

                sectionData.Keys.AddKey(lastNewKeyName, value);
               
                //data["MiscConfiguration"]["DATE_FORMAT"] = dateFormat;
                iniParser.WriteFile(settingPath, data);
            }
            catch { }
        }

        public Dictionary<int, string> GetExamResults()
        {
            Dictionary<int, string> examResultsDic = new Dictionary<int, string>();

            try
            {
                data = iniParser.ReadFile(settingPath);
                var sectionData = data.Sections.GetSectionData("ExamResults");

                for (int i = 1; i <= sectionData.Keys.Count; i++)
                {
                    examResultsDic.Add(i, data["ExamResults"]["LOG"+i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return examResultsDic;
        }

        #region ----- GET PROPERTIES ---------------------------------------------------------------------------------------------
        [Category("GeneralConfiguration")]
        [Description("Displays the window Exit and Minimize buttons on top right.")]
        public bool UIControls => setting.UIControls();

        [Category("GeneralConfiguration")]
        [Description("Window on top most.")]
        public bool OnTopMost => setting.OnTopMost();

        [Category("GeneralConfiguration")]
        [Description("Displays the application icon on right bottom where all other apps.")]
        public bool IconInTray => setting.IconInTray();

        [Category("MiscConfiguration")]
        [Description("Returns the Localized Language as String.")]
        public string Language => setting.LocalizeLanguage();

        [Category("MiscConfiguration")]
        [Description("Returns the Date Format as String.")]
        public string DateFormat => setting.DateFormat();

        [Category("UserConfiguration")]
        [Description("Returns the Application Title as String.")]
        public string ApplicationTitle => setting.ApplicationTitle();

        [Category("UserConfiguration")]
        [Description("Returns the percent to pass exam as int.")]
        public int PassedWithPercent => setting.PassedWithPercent();

        [Category("UserConfiguration")]
        [Description("Returns the Company name as String.")]
        public string CompanyName => setting.CompanyName();

        [Category("UserConfiguration")]
        [Description("Returns the Street name as String.")]
        public string StreetName => setting.StreetName();

        [Category("UserConfiguration")]
        [Description("Returns the Postcode and City name as String.")]
        public string PostcodeAndCity => setting.PostcodeAndCity();

        [Category("UserConfiguration")]
        [Description("Returns the Country name as String.")]
        public string Country => setting.Country();

        [Category("UserConfiguration")]
        [Description("Returns the Phone Number as String.")]
        public string PhoneNumber => setting.PhoneNumber();
        #endregion ----- GET PROPERTIES ---------------------------------------------------------------------------------------------





        #region ----- SET PROPERTIES ---------------------------------------------------------------------------------------------
        [Category("GeneralConfiguration")]
        [Description("Displays the window Exit and Minimize buttons on top right.")]
        public bool SetUIControls { set { settingEdit.SetUIControls(value); } }

        [Category("GeneralConfiguration")]
        [Description("Window on top most.")]
        public bool SetOnTopMost { set { settingEdit.SetOnTopMost(value); } }

        [Category("GeneralConfiguration")]
        [Description("Displays the application icon on right bottom where all other apps.")]
        public bool SetIconInTray { set { settingEdit.SetIconInTray(value); } }

        [Category("MiscConfiguration")]
        [Description("Set the Localized Language user interface that will be set in Settings.ini as String.")]
        public string SetLanguage { set { settingEdit.SetLocalizeLanguage(value); } }

        [Category("MiscConfiguration")]
        [Description("Set the Date Format that will be set in Settings.ini as String.")]
        public string SetDateFormat { set { settingEdit.SetDateFormat(value); } }

        [Category("UserConfiguration")]
        [Description("Set the Application Title as String.")]
        public string SetApplicationTitle { set { settingEdit.SetApplicationTitle(value); } }

        [Category("UserConfiguration")]
        [Description("Set the percent to pass exam as int.")]
        public int SetPassedWithPercent { set { settingEdit.SetPassedWithPercent(value); } }

        [Category("UserConfiguration")]
        [Description("Set the Company name as String.")]
        public string SetCompanyName { set { settingEdit.SetCompanyName(value); } }

        [Category("UserConfiguration")]
        [Description("Set the Street name as String.")]
        public string SetStreetName { set { settingEdit.SetStreetName(value); } }

        [Category("UserConfiguration")]
        [Description("Set the Postcode and City name as String.")]
        public string SetPostcodeAndCity { set { settingEdit.SetPostcodeAndCity(value); } }

        [Category("UserConfiguration")]
        [Description("Set the Country name as String.")]
        public string SetCountry { set { settingEdit.SetCountry(value); } }

        [Category("UserConfiguration")]
        [Description("Set the Phone Number as String.")]
        public string SetPhoneNumber { set { settingEdit.SetPhoneNumber(value); } }

        #endregion ----- SET PROPERTIES ---------------------------------------------------------------------------------------------




    }
}
