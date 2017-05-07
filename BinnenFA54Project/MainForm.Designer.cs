namespace BinnenFA54Project
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostcodeCity = new System.Windows.Forms.Label();
            this.cbQuizPicker = new System.Windows.Forms.ComboBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblExamTopics = new System.Windows.Forms.Label();
            this.btnStartExam = new GiladControllers.GiladButton();
            this.lblHistory = new System.Windows.Forms.Label();
            this.gradientPanel = new GiladControllers.GiladGradientPanel();
            this.pbConfig = new System.Windows.Forms.PictureBox();
            this.lblLetsGo = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.controlBox = new GiladControllers.GiladControlBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            resources.ApplyResources(this.lblCompanyName, "lblCompanyName");
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblCompanyName.Name = "lblCompanyName";
            // 
            // lblStreet
            // 
            resources.ApplyResources(this.lblStreet, "lblStreet");
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblStreet.Name = "lblStreet";
            // 
            // lblPostcodeCity
            // 
            resources.ApplyResources(this.lblPostcodeCity, "lblPostcodeCity");
            this.lblPostcodeCity.BackColor = System.Drawing.Color.Transparent;
            this.lblPostcodeCity.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPostcodeCity.Name = "lblPostcodeCity";
            // 
            // cbQuizPicker
            // 
            resources.ApplyResources(this.cbQuizPicker, "cbQuizPicker");
            this.cbQuizPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuizPicker.FormattingEnabled = true;
            this.cbQuizPicker.Name = "cbQuizPicker";
            // 
            // listBoxResults
            // 
            resources.ApplyResources(this.listBoxResults, "listBoxResults");
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Name = "listBoxResults";
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::BinnenFA54Project.Properties.Resources.developer_logo;
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // lblExamTopics
            // 
            resources.ApplyResources(this.lblExamTopics, "lblExamTopics");
            this.lblExamTopics.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblExamTopics.Name = "lblExamTopics";
            // 
            // btnStartExam
            // 
            resources.ApplyResources(this.btnStartExam, "btnStartExam");
            this.btnStartExam.AnimateHover = true;
            this.btnStartExam.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnStartExam.ButtonEnabled = true;
            this.btnStartExam.HandCursor = true;
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // lblHistory
            // 
            resources.ApplyResources(this.lblHistory, "lblHistory");
            this.lblHistory.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblHistory.Name = "lblHistory";
            // 
            // gradientPanel
            // 
            this.gradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel.Color1 = System.Drawing.Color.Transparent;
            this.gradientPanel.Color2 = System.Drawing.Color.DarkBlue;
            this.gradientPanel.Controls.Add(this.pbConfig);
            this.gradientPanel.Controls.Add(this.btnStartExam);
            this.gradientPanel.Controls.Add(this.cbQuizPicker);
            this.gradientPanel.Controls.Add(this.lblPostcodeCity);
            this.gradientPanel.Controls.Add(this.listBoxResults);
            this.gradientPanel.Controls.Add(this.lblExamTopics);
            this.gradientPanel.Controls.Add(this.lblCompanyName);
            this.gradientPanel.Controls.Add(this.lblLetsGo);
            this.gradientPanel.Controls.Add(this.lblConfig);
            this.gradientPanel.Controls.Add(this.lblHistory);
            this.gradientPanel.Controls.Add(this.lblStreet);
            this.gradientPanel.Controls.Add(this.pbLogo);
            this.gradientPanel.CustomCursor = true;
            resources.ApplyResources(this.gradientPanel, "gradientPanel");
            this.gradientPanel.DraggableForm = true;
            this.gradientPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel.Name = "gradientPanel";
            // 
            // pbConfig
            // 
            this.pbConfig.BackColor = System.Drawing.Color.Transparent;
            this.pbConfig.Image = global::BinnenFA54Project.Properties.Resources.settings_icon;
            resources.ApplyResources(this.pbConfig, "pbConfig");
            this.pbConfig.Name = "pbConfig";
            this.pbConfig.TabStop = false;
            this.pbConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblLetsGo
            // 
            resources.ApplyResources(this.lblLetsGo, "lblLetsGo");
            this.lblLetsGo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLetsGo.Name = "lblLetsGo";
            // 
            // lblConfig
            // 
            resources.ApplyResources(this.lblConfig, "lblConfig");
            this.lblConfig.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblConfig.Name = "lblConfig";
            // 
            // controlBox
            // 
            resources.ApplyResources(this.controlBox, "controlBox");
            this.controlBox.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.Color1 = System.Drawing.Color.White;
            this.controlBox.Color2 = System.Drawing.Color.Black;
            this.controlBox.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.controlBox.Name = "controlBox";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            // 
            // MainForm
            // 
            this.AppTitle.Icon = ((System.Drawing.Icon)(resources.GetObject("resource.Icon")));
            this.AppTitle.IconLocation = new System.Drawing.Point(15, 15);
            this.AppTitle.IconSize = new System.Drawing.Size(32, 32);
            this.AppTitle.ShowIcon = true;
            this.AppTitle.ShowTextTitle = true;
            this.AppTitle.TextColor = System.Drawing.Color.AntiqueWhite;
            this.AppTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.TextLocation = new System.Drawing.Point(50, 20);
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.gradientPanel);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.Color.DarkRed;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.Black;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.FormBorders.Color = System.Drawing.Color.LightSteelBlue;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 12;
            this.Name = "MainForm";
            this.ResizeGripColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gradientPanel.ResumeLayout(false);
            this.gradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostcodeCity;
        private System.Windows.Forms.Label lblExamTopics;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.ComboBox cbQuizPicker;
        private GiladControllers.GiladButton btnStartExam;
        private GiladControllers.GiladGradientPanel gradientPanel;
        private GiladControllers.GiladControlBox controlBox;
        private System.Windows.Forms.PictureBox pbConfig;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblLetsGo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

