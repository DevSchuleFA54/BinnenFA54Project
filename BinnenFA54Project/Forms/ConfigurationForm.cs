using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiladControllers;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Properties;

namespace BinnenFA54Project.Forms
{
    // TODO: @togi - Improve German Translation.
    public partial class ConfigurationForm : GiladForm
    {
        bool bDefault = true;
        private SettingIni setting;

        public ConfigurationForm()
        {
            setting = new SettingIni();

            // NOTE: It has to be before the InitializeComponent function in order to take effect.
            Thread.CurrentThread.CurrentUICulture = setting.Language == "en-US" ?
                new CultureInfo("en-US") : new CultureInfo("de-DE");

            InitializeComponent();
            InitializeValues();
        }

        private bool finishedLoading = false;
        /// <summary>
        /// Updates all the values from the Settings.ini
        /// </summary>
        private void InitializeValues()
        {
            tbAppTitle.Text           = setting.ApplicationTitle;
            tbPassedWithPrercent.Text = setting.PassedWithPercent.ToString();
            tbCompanyName.Text        = setting.CompanyName;
            tbStreetName.Text         = setting.StreetName;
            tbPostcodeCity.Text       = setting.PostcodeAndCity;
            tbCountry.Text            = setting.Country;
            tbPhone.Text              = setting.PhoneNumber;

            comboDateFormat.Items.Add(DateTime.Now.ToString("D"));
            comboDateFormat.Items.Add(DateTime.Now.ToString("dd-MM-yyyy"));
            comboDateFormat.Items.Add(DateTime.Now.ToString("yy-MM-dd"));
            comboDateFormat.Items.Add(DateTime.Now.ToString("yyyy-M-d"));
            comboLanguage.Items.Add(Resources.ResourceManager.GetString("GERMAN"));
            comboLanguage.Items.Add(Resources.ResourceManager.GetString("ENGLISH"));
            SelectComboBoxes();

            if (setting.UIControls)
                cbUiControls.Checked = true;
            else if (!setting.UIControls)
                cbUiControls.Checked = false;
            
            if (setting.OnTopMost)
                cbOnTopMost.Checked = true;
            else if (!setting.OnTopMost)
                cbOnTopMost.Checked = false;

            if (setting.IconInTray)
                cbIconInTray.Checked = true;
            else if (!setting.IconInTray)
                cbIconInTray.Checked = false;


            finishedLoading = true;
        }


        /// <summary>
        /// Applying changes to the Settings.ini in the executeable path.
        /// </summary>
        private void WriteNewConfiguration()
        {
            setting.SetApplicationTitle  = tbAppTitle.Text;
            setting.SetPassedWithPercent = int.Parse(tbPassedWithPrercent.Text);
            setting.SetCompanyName       = tbCompanyName.Text;
            setting.SetStreetName        = tbStreetName.Text;
            setting.SetPostcodeAndCity   = tbPostcodeCity.Text;
            setting.SetCountry           = tbCountry.Text;
            setting.SetPhoneNumber       = tbPhone.Text;
            setting.SetDateFormat        = ValidateDateFormat();
            setting.SetLanguage          = ValidateLanguage();

            setting.SetUIControls        = cbUiControls.Checked;
            setting.SetOnTopMost         = cbOnTopMost.Checked;
            setting.SetIconInTray        = cbIconInTray.Checked;
        }


        private void SelectComboBoxes()
        {
            switch (setting.DateFormat)
            {
                case "D":
                    comboDateFormat.SelectedIndex = 0;
                    break;
                case "dd-MM-yyyy":
                    comboDateFormat.SelectedIndex = 1;
                    break;
                case "yy-MM-dd":
                    comboDateFormat.SelectedIndex = 2;
                    break;
                case "yyyy-M-d":
                    comboDateFormat.SelectedIndex = 3;
                    break;
                default:
                    comboDateFormat.SelectedIndex = 0;
                    break;
            }


            comboLanguage.SelectedIndex = setting.Language == "de-DE" ? 0 : 1;
        }


        private string ValidateDateFormat()
        {
            switch (comboDateFormat.SelectedIndex)
            {
                case 0: return "D";
                case 1: return "dd-MM-yyyy";
                case 2: return "yy-MM-dd";
                case 3: return "yyyy-M-d";
                default: return "D";
            }
        }


        private string ValidateLanguage()
        {
            switch (comboLanguage.SelectedIndex)
            {
                case 0: return "de-DE";
                case 1: return "en-US";
                default: return "de-DE"; // default language
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (configChanged)
            {
                // TODO: @togi - Here is an example that might seems a bit complicated.
                //MessageBox.Show("Successfully saved your changes! " +
                //                "\nMake sure to restart application for changes to take effect."
                //                , "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);      

                MessageBox.Show(Resources.ResourceManager.GetString("SAVED_CHANGES") + "\n" +
                                Resources.ResourceManager.GetString("NOTIF_RESTARTAPP"),
                                Resources.ResourceManager.GetString("SAVE"), 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                WriteNewConfiguration();
                Application.Restart();
            }
            else
                MessageBox.Show("No changes has been made, nothing to save.");

        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!configChanged) return;

            MessageBox.Show(Resources.ResourceManager.GetString("SAVED_CHANGES") + "\n" +
                            Resources.ResourceManager.GetString("NOTIF_RESTARTAPP"),
                            Resources.ResourceManager.GetString("SAVE"),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            WriteNewConfiguration();
            configChanged = false; // Finished writting changes, so it won't promote if user click close.
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (configChanged)
            {
                // TODO: Localize text.
                DialogResult dialogResult = MessageBox.Show(
                    "Are you really want to close without saving the Changes?", 
                    "Close Window Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult != DialogResult.Yes) return;   
            }

            this.Close();
        }


        private bool configChanged = false;
        private void OnValueTextChanged(object sender, EventArgs e)
        {
            ValidateConfiguration();
        }


        private void cbUiControls_CheckedChanged(object sender, EventArgs e)
        {
            ValidateConfiguration();
        }


        private void ValidateConfiguration()
        {
            if (!finishedLoading) return;
            configChanged = true;
        }


    }
}
