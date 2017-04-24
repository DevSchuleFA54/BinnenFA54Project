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
using System.Threading;
using BinnenFA54Project.Frameworks.IniParser;

namespace BinnenFA54Project.Forms
{
    public partial class ConfigurationForm : GiladForm
    {
        bool bDefault = true;
        private SettingIni setting;

        public ConfigurationForm()
        {
            // NOTE: It has to be before the InitializeComponent function.
            // If Language Selected == German, do this:
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            // TODO: Implement settings for Multilanguage support.
            setting = new SettingIni();
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

            cbDateFormat.Items.Add(DateTime.Now.ToString("D"));
            cbDateFormat.Items.Add(DateTime.Now.ToString("dd-MM-yyyy"));
            cbDateFormat.Items.Add(DateTime.Now.ToString("yy-MM-dd"));
            cbDateFormat.Items.Add(DateTime.Now.ToString("yyyy-M-d"));
            cbDateFormat.SelectedIndex = 0;


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


            setting.SetUIControls        = cbUiControls.Checked;
            setting.SetOnTopMost         = cbOnTopMost.Checked;
            setting.SetIconInTray        = cbOnTopMost.Checked;
        }



        private string ValidateDateFormat()
        {
            switch (cbDateFormat.SelectedIndex)
            {
                case 0: return "D";
                case 1: return "dd-MM-yyyy";
                case 2: return "yy-MM-dd";
                case 3: return "yyyy-M-d";
                default: return "";
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (configChanged)
            {
                MessageBox.Show("Successfully saved your changes!");
                WriteNewConfiguration();
                this.Close();
            }
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            if (configChanged)
            {
                MessageBox.Show("Successfully saved your changes!");
                WriteNewConfiguration();
                configChanged = false; // Finished writting changes, so it won't promote if user click close.
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (configChanged)
            {
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
