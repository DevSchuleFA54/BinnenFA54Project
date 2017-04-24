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

namespace BinnenFA54Project.Forms
{
    public partial class ConfigurationForm : Form
    {
        bool bDefault = true;

        public ConfigurationForm()
        {
            InitializeComponent();

        }


        private void check_config()
        {
            

            if (tbAppTitle.Text != "")
            {
                bDefault = false;
            }
            else if (tbPassedWithPrercent.Text != "")
            {
                bDefault = false;
            }
            else if (tbCompanyName.Text != "")
            {
                bDefault = false;
            }
            else if (tbStreetName.Text != "")
            {
                bDefault = false;
            }
            else if (tbPostcodeCity.Text != "")
            {
                bDefault = false;
            }
            else if (tbPhone.Text != "")
            {
                bDefault = false;
            }
            else if (cbDateFormat.Text != "")
            {
                bDefault = false;
            }

        }

        // Close Button only Closes...
        private void btnClose_Click(object sender, EventArgs e)
        {
            /* Need Method to check if u have writed somethng in the Config but aborted.... 
            need Message like "Are you really want to Close without saving the Changes? y/n... */
            check_config();
            if (bDefault == false)
            {

                DialogResult btn_toClose = MessageBox.Show("Are you really want to close without saving the Changes?", "Close windows?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (btn_toClose == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }


        }
    }
}
