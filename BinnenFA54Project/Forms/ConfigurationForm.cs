using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GiladControllers;
using System.Threading;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main;
using static BinnenFA54Project.Properties.Resources;

namespace BinnenFA54Project.Forms
{
    /// <summary>
    /// This is the Configuration form of the program which inherited from GiladForm part of the custom framework,
    /// in order to isolate the design code from the application it self.
    /// In this form we can change all the configuration related to the layout and exam. We can also clear the 
    /// exam results that being displayed on the main form or reset the configuration to their deault state.
    /// </summary>
    public partial class ConfigurationForm : GiladForm
    {
        bool bDefault = true;
        private SettingIni setting;

        public ConfigurationForm()
        {
#if !HIDE_LOADERS
            Loader.StartLoader(LoaderSelector.Loader);
            Thread.Sleep(700);
#endif // !HIDE_LOADERS


            setting = new SettingIni();
            InitializeComponent();
            InitializeValues();


#if !HIDE_LOADERS
            Loader.StopLoader(this.Handle);
#endif // !HIDE_LOADERS
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
            comboLanguage.Items.Add(ResourceManager.GetString("GERMAN"));
            comboLanguage.Items.Add(ResourceManager.GetString("ENGLISH"));
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
                // Successfully saved your changes! \nMake sure to restart application for changes to take effect.
                // Save
                MessageBox.Show(Regex.Unescape(
                    ResourceManager.GetString("NOTIF_RESTARTAPP")),
                    ResourceManager.GetString("SAVE"), 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                WriteNewConfiguration();
                Application.Restart();
            }
            else // No changes has been made, nothing to save.
                MessageBox.Show(ResourceManager.GetString("NO_CHANGES"));

        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!configChanged) return;

            // Successfully saved your changes! 
            // Make sure to restart application for changes to take effect.
            // Save
            MessageBox.Show(Regex.Unescape(
                ResourceManager.GetString("NOTIF_RESTARTAPP")),
                ResourceManager.GetString("SAVE"),
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            WriteNewConfiguration();
            configChanged = false; // Finished writting changes, so it won't promote if user click close.
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (configChanged)
            {
                // Are you really want to close without saving the Changes?
                // Close Window Prompt
                DialogResult dialogResult = MessageBox.Show(
                    ResourceManager.GetString("MSG_UNSAVED_CHANGES_CLOSED"), 
                    ResourceManager.GetString("CLOSE_TITLE"), 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void btnRemoveHistory_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Regex.Unescape(
                                            ResourceManager.GetString("NOTIF_REMOVE_RESULTS")),
                                            ResourceManager.GetString("WARNING"),
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.Yes) return;

            ResultsIni.ClearExamResults();

            // It will execute the MainForm_VisibleChanged event and re-load the results.
            FormsBase.RefreshMainForm();
            this.Focus();
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                                ResourceManager.GetString("NOTIF_RESET_DEFAULTS"),
                                ResourceManager.GetString("WARNING"),
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult != DialogResult.Yes) return;

            SettingIni.ResetDefaults();
            InitializeValues();
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsBase.ConfigurationInstanceOpened = false;
        }
    }
}
