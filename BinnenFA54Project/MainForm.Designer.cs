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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostcodeCity = new System.Windows.Forms.Label();
            this.cbQuizPicker = new System.Windows.Forms.ComboBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblExamTopics = new System.Windows.Forms.Label();
            this.btnStartExam = new GiladControllers.GiladButton();
            this.lblHistory = new System.Windows.Forms.Label();
            this.giladGradientPanel1 = new GiladControllers.GiladGradientPanel();
            this.giladControlBox1 = new GiladControllers.GiladControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.giladGradientPanel1.SuspendLayout();
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
            // btnConfig
            // 
            resources.ApplyResources(this.btnConfig, "btnConfig");
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
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
            // giladGradientPanel1
            // 
            resources.ApplyResources(this.giladGradientPanel1, "giladGradientPanel1");
            this.giladGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color2 = System.Drawing.SystemColors.MenuText;
            this.giladGradientPanel1.Controls.Add(this.btnStartExam);
            this.giladGradientPanel1.Controls.Add(this.cbQuizPicker);
            this.giladGradientPanel1.Controls.Add(this.lblPostcodeCity);
            this.giladGradientPanel1.Controls.Add(this.btnConfig);
            this.giladGradientPanel1.Controls.Add(this.listBox1);
            this.giladGradientPanel1.Controls.Add(this.lblExamTopics);
            this.giladGradientPanel1.Controls.Add(this.lblCompanyName);
            this.giladGradientPanel1.Controls.Add(this.lblHistory);
            this.giladGradientPanel1.Controls.Add(this.lblStreet);
            this.giladGradientPanel1.Controls.Add(this.pbLogo);
            this.giladGradientPanel1.CustomCursor = true;
            this.giladGradientPanel1.DraggableForm = true;
            this.giladGradientPanel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.giladGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladGradientPanel1.Name = "giladGradientPanel1";
            // 
            // giladControlBox1
            // 
            resources.ApplyResources(this.giladControlBox1, "giladControlBox1");
            this.giladControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.giladControlBox1.Color1 = System.Drawing.Color.White;
            this.giladControlBox1.Color2 = System.Drawing.Color.Black;
            this.giladControlBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladControlBox1.Name = "giladControlBox1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AppTitle.Icon = ((System.Drawing.Icon)(resources.GetObject("resource.Icon")));
            this.AppTitle.IconLocation = new System.Drawing.Point(15, 15);
            this.AppTitle.IconSize = new System.Drawing.Size(32, 32);
            this.AppTitle.ShowIcon = true;
            this.AppTitle.ShowTextTitle = true;
            this.AppTitle.TextColor = System.Drawing.Color.Tan;
            this.AppTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.TextLocation = new System.Drawing.Point(50, 20);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.giladControlBox1);
            this.Controls.Add(this.giladGradientPanel1);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.Color.Firebrick;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.MediumTurquoise;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.FormBorders.Color = System.Drawing.Color.GreenYellow;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 12;
            this.Name = "MainForm";
            this.ResizeGripColor = System.Drawing.SystemColors.ButtonHighlight;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.giladGradientPanel1.ResumeLayout(false);
            this.giladGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostcodeCity;
        private System.Windows.Forms.Label lblExamTopics;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbQuizPicker;
        private System.Windows.Forms.Button btnConfig;
        private GiladControllers.GiladButton btnStartExam;
        private GiladControllers.GiladGradientPanel giladGradientPanel1;
        private GiladControllers.GiladControlBox giladControlBox1;
    }
}

