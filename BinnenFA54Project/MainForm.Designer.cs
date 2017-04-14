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
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostcodeCity = new System.Windows.Forms.Label();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationUsuageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbQuizPicker = new System.Windows.Forms.ComboBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnStartExam = new GiladControllers.GiladButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblExamTopics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(12, 47);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(248, 22);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Sportbootführerschein Binnen";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(671, 63);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(155, 21);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblStreet
            // 
            this.lblStreet.Location = new System.Drawing.Point(671, 84);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(155, 19);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // lblPostcodeCity
            // 
            this.lblPostcodeCity.Location = new System.Drawing.Point(671, 103);
            this.lblPostcodeCity.Name = "lblPostcodeCity";
            this.lblPostcodeCity.Size = new System.Drawing.Size(155, 25);
            this.lblPostcodeCity.TabIndex = 0;
            this.lblPostcodeCity.Text = "Postcode City";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingConfigurationFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.printResultsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filToolStripMenuItem.Text = "File";
            // 
            // openExistingConfigurationFileToolStripMenuItem
            // 
            this.openExistingConfigurationFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationFileToolStripMenuItem,
            this.userResultsToolStripMenuItem});
            this.openExistingConfigurationFileToolStripMenuItem.Name = "openExistingConfigurationFileToolStripMenuItem";
            this.openExistingConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openExistingConfigurationFileToolStripMenuItem.Text = "Open";
            // 
            // configurationFileToolStripMenuItem
            // 
            this.configurationFileToolStripMenuItem.Name = "configurationFileToolStripMenuItem";
            this.configurationFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.configurationFileToolStripMenuItem.Text = "Configuration File";
            // 
            // userResultsToolStripMenuItem
            // 
            this.userResultsToolStripMenuItem.Name = "userResultsToolStripMenuItem";
            this.userResultsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.userResultsToolStripMenuItem.Text = "User Results";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigurationFileToolStripMenuItem,
            this.configurationFileToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveConfigurationFileToolStripMenuItem
            // 
            this.saveConfigurationFileToolStripMenuItem.Name = "saveConfigurationFileToolStripMenuItem";
            this.saveConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveConfigurationFileToolStripMenuItem.Text = "Exam Results";
            // 
            // configurationFileToolStripMenuItem1
            // 
            this.configurationFileToolStripMenuItem1.Name = "configurationFileToolStripMenuItem1";
            this.configurationFileToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.configurationFileToolStripMenuItem1.Text = "More";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // printResultsToolStripMenuItem
            // 
            this.printResultsToolStripMenuItem.Name = "printResultsToolStripMenuItem";
            this.printResultsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.printResultsToolStripMenuItem.Text = "Print Results";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // applicationUsuageToolStripMenuItem
            // 
            this.applicationUsuageToolStripMenuItem.Name = "applicationUsuageToolStripMenuItem";
            this.applicationUsuageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applicationUsuageToolStripMenuItem.Text = "Application Usuage";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates...";
            // 
            // cbQuizPicker
            // 
            this.cbQuizPicker.FormattingEnabled = true;
            this.cbQuizPicker.Location = new System.Drawing.Point(565, 196);
            this.cbQuizPicker.Name = "cbQuizPicker";
            this.cbQuizPicker.Size = new System.Drawing.Size(286, 21);
            this.cbQuizPicker.TabIndex = 3;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(199, 252);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(144, 23);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 108);
            this.listBox1.TabIndex = 5;
            // 
            // btnStartExam
            // 
            this.btnStartExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartExam.AnimateHover = true;
            this.btnStartExam.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnStartExam.ButtonEnabled = true;
            this.btnStartExam.HandCursorHover = true;
            this.btnStartExam.Location = new System.Drawing.Point(759, 346);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(92, 89);
            this.btnStartExam.TabIndex = 6;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(565, 63);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 50);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblExamTopics
            // 
            this.lblExamTopics.Location = new System.Drawing.Point(562, 168);
            this.lblExamTopics.Name = "lblExamTopics";
            this.lblExamTopics.Size = new System.Drawing.Size(155, 25);
            this.lblExamTopics.TabIndex = 0;
            this.lblExamTopics.Text = "Exam Topics:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(880, 460);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.cbQuizPicker);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblExamTopics);
            this.Controls.Add(this.lblPostcodeCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostcodeCity;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationUsuageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cbQuizPicker;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ListBox listBox1;
        private GiladControllers.GiladButton btnStartExam;
        private System.Windows.Forms.Label lblExamTopics;
    }
}

