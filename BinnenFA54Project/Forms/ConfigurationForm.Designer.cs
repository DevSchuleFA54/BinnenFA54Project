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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGC.SuspendLayout();
            this.giladGradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDateFormat
            // 
            this.cbDateFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDateFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDateFormat.FormattingEnabled = true;
            this.cbDateFormat.Location = new System.Drawing.Point(133, 201);
            this.cbDateFormat.Name = "cbDateFormat";
            this.cbDateFormat.Size = new System.Drawing.Size(204, 21);
            this.cbDateFormat.TabIndex = 0;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFormat.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDateFormat.Location = new System.Drawing.Point(41, 204);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(86, 15);
            this.lblDateFormat.TabIndex = 1;
            this.lblDateFormat.Text = "Date Format";
            // 
            // cbUiControls
            // 
            this.cbUiControls.AutoSize = true;
            this.cbUiControls.Location = new System.Drawing.Point(6, 19);
            this.cbUiControls.Name = "cbUiControls";
            this.cbUiControls.Size = new System.Drawing.Size(139, 19);
            this.cbUiControls.TabIndex = 2;
            this.cbUiControls.Text = "Interface Controls";
            this.cbUiControls.UseVisualStyleBackColor = true;
            // 
            // cbOnTopMost
            // 
            this.cbOnTopMost.AutoSize = true;
            this.cbOnTopMost.Location = new System.Drawing.Point(6, 42);
            this.cbOnTopMost.Name = "cbOnTopMost";
            this.cbOnTopMost.Size = new System.Drawing.Size(199, 19);
            this.cbOnTopMost.TabIndex = 2;
            this.cbOnTopMost.Text = "Exam Window on Top Most";
            this.cbOnTopMost.UseVisualStyleBackColor = true;
            // 
            // cbIconInTray
            // 
            this.cbIconInTray.AutoSize = true;
            this.cbIconInTray.Location = new System.Drawing.Point(6, 65);
            this.cbIconInTray.Name = "cbIconInTray";
            this.cbIconInTray.Size = new System.Drawing.Size(100, 19);
            this.cbIconInTray.TabIndex = 2;
            this.cbIconInTray.Text = "Icon in Tray";
            this.cbIconInTray.UseVisualStyleBackColor = true;
            // 
            // tbAppTitle
            // 
            this.tbAppTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAppTitle.Location = new System.Drawing.Point(133, 4);
            this.tbAppTitle.Name = "tbAppTitle";
            this.tbAppTitle.Size = new System.Drawing.Size(204, 20);
            this.tbAppTitle.TabIndex = 3;
            // 
            // tbPassedWithPrercent
            // 
            this.tbPassedWithPrercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPassedWithPrercent.Location = new System.Drawing.Point(133, 32);
            this.tbPassedWithPrercent.Name = "tbPassedWithPrercent";
            this.tbPassedWithPrercent.Size = new System.Drawing.Size(204, 20);
            this.tbPassedWithPrercent.TabIndex = 3;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCompanyName.Location = new System.Drawing.Point(133, 60);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(204, 20);
            this.tbCompanyName.TabIndex = 3;
            // 
            // tbStreetName
            // 
            this.tbStreetName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbStreetName.Location = new System.Drawing.Point(133, 88);
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.Size = new System.Drawing.Size(204, 20);
            this.tbStreetName.TabIndex = 3;
            // 
            // tbPostcodeCity
            // 
            this.tbPostcodeCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPostcodeCity.Location = new System.Drawing.Point(133, 116);
            this.tbPostcodeCity.Name = "tbPostcodeCity";
            this.tbPostcodeCity.Size = new System.Drawing.Size(204, 20);
            this.tbPostcodeCity.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPhone.Location = new System.Drawing.Point(133, 172);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(204, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // groupBoxGC
            // 
            this.groupBoxGC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGC.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGC.Controls.Add(this.cbUiControls);
            this.groupBoxGC.Controls.Add(this.cbOnTopMost);
            this.groupBoxGC.Controls.Add(this.cbIconInTray);
            this.groupBoxGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGC.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBoxGC.Location = new System.Drawing.Point(372, 14);
            this.groupBoxGC.Name = "groupBoxGC";
            this.groupBoxGC.Size = new System.Drawing.Size(204, 97);
            this.groupBoxGC.TabIndex = 4;
            this.groupBoxGC.TabStop = false;
            this.groupBoxGC.Text = "General Configuration";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Application Title";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Required Percent";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Street Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postcode and City";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(24, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(195, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Location = new System.Drawing.Point(99, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(90, 27);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbCountry
            // 
            this.tbCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCountry.Location = new System.Drawing.Point(133, 144);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(204, 20);
            this.tbCountry.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(72, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Country";
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
            this.giladGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giladGradientPanel1.DraggableForm = true;
            this.giladGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladGradientPanel1.Location = new System.Drawing.Point(9, 50);
            this.giladGradientPanel1.Name = "giladGradientPanel1";
            this.giladGradientPanel1.Size = new System.Drawing.Size(598, 306);
            this.giladGradientPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbAppTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPassedWithPrercent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbDateFormat, 1, 7);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 227);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnApply, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(292, 261);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(291, 33);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ConfigurationForm
            // 
            this.AllowResize = false;
            this.AppTitle.Icon = null;
            this.AppTitle.IconLocation = new System.Drawing.Point(0, 0);
            this.AppTitle.IconSize = new System.Drawing.Size(0, 0);
            this.AppTitle.ShowIcon = false;
            this.AppTitle.ShowTextTitle = true;
            this.AppTitle.Text = "Configuration";
            this.AppTitle.TextColor = System.Drawing.Color.SeaShell;
            this.AppTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.TextLocation = new System.Drawing.Point(10, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 365);
            this.Controls.Add(this.giladGradientPanel1);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.Color.DarkRed;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.LightSeaGreen;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.FormBorders.Color = System.Drawing.Color.FloralWhite;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 8;
            this.MinimumSize = new System.Drawing.Size(615, 365);
            this.Name = "ConfigurationForm";
            this.ResizeGrip = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurationForm";
            this.groupBoxGC.ResumeLayout(false);
            this.groupBoxGC.PerformLayout();
            this.giladGradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDateFormat;
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
    }
}