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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.giladGradientPanel1 = new GiladControllers.GiladGradientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.groupBoxGC.SuspendLayout();
            this.giladGradientPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Name = "label6";
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Name = "label7";
            // 
            // giladGradientPanel1
            // 
            this.giladGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color2 = System.Drawing.Color.DarkBlue;
            this.giladGradientPanel1.Controls.Add(this.tableLayoutPanel2);
            this.giladGradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.giladGradientPanel1.Controls.Add(this.groupBoxGC);
            this.giladGradientPanel1.CustomCursor = true;
            resources.ApplyResources(this.giladGradientPanel1, "giladGradientPanel1");
            this.giladGradientPanel1.DraggableForm = true;
            this.giladGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladGradientPanel1.Name = "giladGradientPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnApply, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tbAppTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPassedWithPrercent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboDateFormat, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDateFormat, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbCompanyName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbStreetName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPostcodeCity, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbCountry, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbPhone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboLanguage, 1, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Name = "label8";
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
            this.Controls.Add(this.giladGradientPanel1);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.Color.DarkRed;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.LightSeaGreen;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.FormBorders.Color = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 8;
            this.Name = "ConfigurationForm";
            this.ResizeGrip = false;
            this.groupBoxGC.ResumeLayout(false);
            this.groupBoxGC.PerformLayout();
            this.giladGradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label7;
        private GiladControllers.GiladGradientPanel giladGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.PictureBox pbIcon;
    }
}