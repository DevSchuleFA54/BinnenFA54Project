namespace BinnenFA54Project.Forms
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.comboDateFormat = new System.Windows.Forms.ComboBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.cbUiControls = new System.Windows.Forms.CheckBox();
            this.cbOnTopMost = new System.Windows.Forms.CheckBox();
            this.cbIconInTray = new System.Windows.Forms.CheckBox();
            this.tbAppTitle = new System.Windows.Forms.TextBox();
            this.tbPassedWithPrercent = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbStreetName = new System.Windows.Forms.TextBox();
            this.tbPostcodeCity = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.groupBoxGC = new System.Windows.Forms.GroupBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblReqPercent = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblPostcodeCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.gradientPanel = new GiladControllers.GiladGradientPanel();
            this.btnRemoveHistory = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetDefaults = new System.Windows.Forms.Button();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblLang = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.groupBoxGC.SuspendLayout();
            this.gradientPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDateFormat
            // 
            resources.ApplyResources(this.comboDateFormat, "comboDateFormat");
            this.comboDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDateFormat.FormattingEnabled = true;
            this.comboDateFormat.Name = "comboDateFormat";
            this.comboDateFormat.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // lblDateFormat
            // 
            resources.ApplyResources(this.lblDateFormat, "lblDateFormat");
            this.lblDateFormat.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFormat.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDateFormat.Name = "lblDateFormat";
            // 
            // cbUiControls
            // 
            resources.ApplyResources(this.cbUiControls, "cbUiControls");
            this.cbUiControls.Name = "cbUiControls";
            this.cbUiControls.UseVisualStyleBackColor = true;
            this.cbUiControls.CheckedChanged += new System.EventHandler(this.cbUiControls_CheckedChanged);
            // 
            // cbOnTopMost
            // 
            resources.ApplyResources(this.cbOnTopMost, "cbOnTopMost");
            this.cbOnTopMost.Name = "cbOnTopMost";
            this.cbOnTopMost.UseVisualStyleBackColor = true;
            this.cbOnTopMost.CheckedChanged += new System.EventHandler(this.cbUiControls_CheckedChanged);
            // 
            // cbIconInTray
            // 
            resources.ApplyResources(this.cbIconInTray, "cbIconInTray");
            this.cbIconInTray.Name = "cbIconInTray";
            this.cbIconInTray.UseVisualStyleBackColor = true;
            this.cbIconInTray.CheckedChanged += new System.EventHandler(this.cbUiControls_CheckedChanged);
            // 
            // tbAppTitle
            // 
            resources.ApplyResources(this.tbAppTitle, "tbAppTitle");
            this.tbAppTitle.Name = "tbAppTitle";
            this.tbAppTitle.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // tbPassedWithPrercent
            // 
            resources.ApplyResources(this.tbPassedWithPrercent, "tbPassedWithPrercent");
            this.tbPassedWithPrercent.Name = "tbPassedWithPrercent";
            this.tbPassedWithPrercent.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // tbCompanyName
            // 
            resources.ApplyResources(this.tbCompanyName, "tbCompanyName");
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // tbStreetName
            // 
            resources.ApplyResources(this.tbStreetName, "tbStreetName");
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // tbPostcodeCity
            // 
            resources.ApplyResources(this.tbPostcodeCity, "tbPostcodeCity");
            this.tbPostcodeCity.Name = "tbPostcodeCity";
            this.tbPostcodeCity.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // tbPhone
            // 
            resources.ApplyResources(this.tbPhone, "tbPhone");
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // groupBoxGC
            // 
            resources.ApplyResources(this.groupBoxGC, "groupBoxGC");
            this.groupBoxGC.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGC.Controls.Add(this.cbUiControls);
            this.groupBoxGC.Controls.Add(this.cbOnTopMost);
            this.groupBoxGC.Controls.Add(this.cbIconInTray);
            this.groupBoxGC.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBoxGC.Name = "groupBoxGC";
            this.groupBoxGC.TabStop = false;
            // 
            // lblAppTitle
            // 
            resources.ApplyResources(this.lblAppTitle, "lblAppTitle");
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblAppTitle.Name = "lblAppTitle";
            // 
            // lblReqPercent
            // 
            resources.ApplyResources(this.lblReqPercent, "lblReqPercent");
            this.lblReqPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblReqPercent.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblReqPercent.Name = "lblReqPercent";
            // 
            // lblCompanyName
            // 
            resources.ApplyResources(this.lblCompanyName, "lblCompanyName");
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCompanyName.Name = "lblCompanyName";
            // 
            // lblStreetName
            // 
            resources.ApplyResources(this.lblStreetName, "lblStreetName");
            this.lblStreetName.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblStreetName.Name = "lblStreetName";
            // 
            // lblPostcodeCity
            // 
            resources.ApplyResources(this.lblPostcodeCity, "lblPostcodeCity");
            this.lblPostcodeCity.BackColor = System.Drawing.Color.Transparent;
            this.lblPostcodeCity.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPostcodeCity.Name = "lblPostcodeCity";
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPhone.Name = "lblPhone";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbCountry
            // 
            resources.ApplyResources(this.tbCountry, "tbCountry");
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // lblCountry
            // 
            resources.ApplyResources(this.lblCountry, "lblCountry");
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCountry.Name = "lblCountry";
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel.Color1 = System.Drawing.Color.Transparent;
            this.gradientPanel.Color2 = System.Drawing.Color.DarkBlue;
            this.gradientPanel.Controls.Add(this.btnRemoveHistory);
            this.gradientPanel.Controls.Add(this.tableLayoutPanel2);
            this.gradientPanel.Controls.Add(this.tableLayout);
            this.gradientPanel.Controls.Add(this.groupBoxGC);
            this.gradientPanel.CustomCursor = true;
            resources.ApplyResources(this.gradientPanel, "gradientPanel");
            this.gradientPanel.DraggableForm = true;
            this.gradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel.Name = "gradientPanel";
            // 
            // btnRemoveHistory
            // 
            this.btnRemoveHistory.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRemoveHistory, "btnRemoveHistory");
            this.btnRemoveHistory.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveHistory.Name = "btnRemoveHistory";
            this.btnRemoveHistory.UseVisualStyleBackColor = false;
            this.btnRemoveHistory.Click += new System.EventHandler(this.btnRemoveHistory_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnApply, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnResetDefaults, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnResetDefaults
            // 
            resources.ApplyResources(this.btnResetDefaults, "btnResetDefaults");
            this.btnResetDefaults.Name = "btnResetDefaults";
            this.btnResetDefaults.UseVisualStyleBackColor = true;
            this.btnResetDefaults.Click += new System.EventHandler(this.btnResetDefaults_Click);
            // 
            // tableLayout
            // 
            resources.ApplyResources(this.tableLayout, "tableLayout");
            this.tableLayout.Controls.Add(this.tbAppTitle, 1, 0);
            this.tableLayout.Controls.Add(this.tbPassedWithPrercent, 1, 1);
            this.tableLayout.Controls.Add(this.comboDateFormat, 1, 7);
            this.tableLayout.Controls.Add(this.lblDateFormat, 0, 7);
            this.tableLayout.Controls.Add(this.lblAppTitle, 0, 0);
            this.tableLayout.Controls.Add(this.lblReqPercent, 0, 1);
            this.tableLayout.Controls.Add(this.lblPhone, 0, 6);
            this.tableLayout.Controls.Add(this.lblCountry, 0, 5);
            this.tableLayout.Controls.Add(this.tbCompanyName, 1, 2);
            this.tableLayout.Controls.Add(this.lblCompanyName, 0, 2);
            this.tableLayout.Controls.Add(this.lblPostcodeCity, 0, 4);
            this.tableLayout.Controls.Add(this.tbStreetName, 1, 3);
            this.tableLayout.Controls.Add(this.lblStreetName, 0, 3);
            this.tableLayout.Controls.Add(this.tbPostcodeCity, 1, 4);
            this.tableLayout.Controls.Add(this.tbCountry, 1, 5);
            this.tableLayout.Controls.Add(this.tbPhone, 1, 6);
            this.tableLayout.Controls.Add(this.lblLang, 0, 8);
            this.tableLayout.Controls.Add(this.comboLanguage, 1, 8);
            this.tableLayout.Name = "tableLayout";
            // 
            // lblLang
            // 
            resources.ApplyResources(this.lblLang, "lblLang");
            this.lblLang.BackColor = System.Drawing.Color.Transparent;
            this.lblLang.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLang.Name = "lblLang";
            // 
            // comboLanguage
            // 
            resources.ApplyResources(this.comboLanguage, "comboLanguage");
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.TextChanged += new System.EventHandler(this.OnValueTextChanged);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Image = global::BinnenFA54Project.Properties.Resources.settings_icon;
            resources.ApplyResources(this.pbIcon, "pbIcon");
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AllowResize = false;
            this.AppTitle.Icon = null;
            this.AppTitle.IconLocation = new System.Drawing.Point(0, 0);
            this.AppTitle.IconSize = new System.Drawing.Size(0, 0);
            this.AppTitle.ShowIcon = false;
            this.AppTitle.ShowTextTitle = true;
            this.AppTitle.TextColor = System.Drawing.Color.SeaShell;
            this.AppTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.TextLocation = new System.Drawing.Point(10, 15);
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.gradientPanel);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.Color.DarkRed;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.LightSeaGreen;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.FormBorders.Color = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 8;
            this.Name = "ConfigurationForm";
            this.ResizeGrip = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationForm_FormClosed);
            this.groupBoxGC.ResumeLayout(false);
            this.groupBoxGC.PerformLayout();
            this.gradientPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.CheckBox cbUiControls;
        private System.Windows.Forms.CheckBox cbOnTopMost;
        private System.Windows.Forms.CheckBox cbIconInTray;
        private System.Windows.Forms.TextBox tbAppTitle;
        private System.Windows.Forms.TextBox tbPassedWithPrercent;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbStreetName;
        private System.Windows.Forms.TextBox tbPostcodeCity;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.GroupBox groupBoxGC;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblReqPercent;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblPostcodeCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lblCountry;
        private GiladControllers.GiladGradientPanel gradientPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnRemoveHistory;
        private System.Windows.Forms.Button btnResetDefaults;
    }
}