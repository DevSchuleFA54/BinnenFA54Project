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
            this.cbDateFormat = new System.Windows.Forms.ComboBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.cbUiControls = new System.Windows.Forms.CheckBox();
            this.cbOnTopMost = new System.Windows.Forms.CheckBox();
            this.cbIconInTray = new System.Windows.Forms.CheckBox();
            this.cbSqlInstance = new System.Windows.Forms.CheckBox();
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
            this.groupBoxGC.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDateFormat
            // 
            this.cbDateFormat.FormattingEnabled = true;
            this.cbDateFormat.Location = new System.Drawing.Point(126, 204);
            this.cbDateFormat.Name = "cbDateFormat";
            this.cbDateFormat.Size = new System.Drawing.Size(121, 21);
            this.cbDateFormat.TabIndex = 0;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(55, 207);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(65, 13);
            this.lblDateFormat.TabIndex = 1;
            this.lblDateFormat.Text = "Date Format";
            // 
            // cbUiControls
            // 
            this.cbUiControls.AutoSize = true;
            this.cbUiControls.Location = new System.Drawing.Point(6, 19);
            this.cbUiControls.Name = "cbUiControls";
            this.cbUiControls.Size = new System.Drawing.Size(109, 17);
            this.cbUiControls.TabIndex = 2;
            this.cbUiControls.Text = "Interface Controls";
            this.cbUiControls.UseVisualStyleBackColor = true;
            // 
            // cbOnTopMost
            // 
            this.cbOnTopMost.AutoSize = true;
            this.cbOnTopMost.Location = new System.Drawing.Point(6, 42);
            this.cbOnTopMost.Name = "cbOnTopMost";
            this.cbOnTopMost.Size = new System.Drawing.Size(157, 17);
            this.cbOnTopMost.TabIndex = 2;
            this.cbOnTopMost.Text = "Exam Window on Top Most";
            this.cbOnTopMost.UseVisualStyleBackColor = true;
            // 
            // cbIconInTray
            // 
            this.cbIconInTray.AutoSize = true;
            this.cbIconInTray.Location = new System.Drawing.Point(6, 65);
            this.cbIconInTray.Name = "cbIconInTray";
            this.cbIconInTray.Size = new System.Drawing.Size(82, 17);
            this.cbIconInTray.TabIndex = 2;
            this.cbIconInTray.Text = "Icon in Tray";
            this.cbIconInTray.UseVisualStyleBackColor = true;
            // 
            // cbSqlInstance
            // 
            this.cbSqlInstance.AccessibleDescription = "When this enabled, the SQL Instance will be set to true since some db connections" +
    " needs the instance of the sql db.";
            this.cbSqlInstance.AutoSize = true;
            this.cbSqlInstance.Location = new System.Drawing.Point(6, 88);
            this.cbSqlInstance.Name = "cbSqlInstance";
            this.cbSqlInstance.Size = new System.Drawing.Size(127, 17);
            this.cbSqlInstance.TabIndex = 2;
            this.cbSqlInstance.Text = "Enable SQL Instance";
            this.cbSqlInstance.UseVisualStyleBackColor = true;
            // 
            // tbAppTitle
            // 
            this.tbAppTitle.Location = new System.Drawing.Point(126, 28);
            this.tbAppTitle.Name = "tbAppTitle";
            this.tbAppTitle.Size = new System.Drawing.Size(136, 20);
            this.tbAppTitle.TabIndex = 3;
            // 
            // tbPassedWithPrercent
            // 
            this.tbPassedWithPrercent.Location = new System.Drawing.Point(126, 54);
            this.tbPassedWithPrercent.Name = "tbPassedWithPrercent";
            this.tbPassedWithPrercent.Size = new System.Drawing.Size(136, 20);
            this.tbPassedWithPrercent.TabIndex = 3;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(126, 80);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(136, 20);
            this.tbCompanyName.TabIndex = 3;
            // 
            // tbStreetName
            // 
            this.tbStreetName.Location = new System.Drawing.Point(126, 106);
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.Size = new System.Drawing.Size(136, 20);
            this.tbStreetName.TabIndex = 3;
            // 
            // tbPostcodeCity
            // 
            this.tbPostcodeCity.Location = new System.Drawing.Point(126, 132);
            this.tbPostcodeCity.Name = "tbPostcodeCity";
            this.tbPostcodeCity.Size = new System.Drawing.Size(136, 20);
            this.tbPostcodeCity.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(126, 158);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(136, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // groupBoxGC
            // 
            this.groupBoxGC.Controls.Add(this.cbUiControls);
            this.groupBoxGC.Controls.Add(this.cbOnTopMost);
            this.groupBoxGC.Controls.Add(this.cbIconInTray);
            this.groupBoxGC.Controls.Add(this.cbSqlInstance);
            this.groupBoxGC.Location = new System.Drawing.Point(363, 28);
            this.groupBoxGC.Name = "groupBoxGC";
            this.groupBoxGC.Size = new System.Drawing.Size(210, 124);
            this.groupBoxGC.TabIndex = 4;
            this.groupBoxGC.TabStop = false;
            this.groupBoxGC.Text = "General Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Application Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Required Percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Street Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postcode and City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(398, 244);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(317, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 279);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxGC);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPostcodeCity);
            this.Controls.Add(this.tbStreetName);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.tbPassedWithPrercent);
            this.Controls.Add(this.tbAppTitle);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.cbDateFormat);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.groupBoxGC.ResumeLayout(false);
            this.groupBoxGC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.CheckBox cbUiControls;
        private System.Windows.Forms.CheckBox cbOnTopMost;
        private System.Windows.Forms.CheckBox cbIconInTray;
        private System.Windows.Forms.CheckBox cbSqlInstance;
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
    }
}