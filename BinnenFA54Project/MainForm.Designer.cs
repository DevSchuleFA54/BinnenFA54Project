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
            this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCompanyName.Location = new System.Drawing.Point(578, 13);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(155, 21);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStreet.Location = new System.Drawing.Point(578, 34);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(155, 19);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // lblPostcodeCity
            // 
            this.lblPostcodeCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostcodeCity.BackColor = System.Drawing.Color.Transparent;
            this.lblPostcodeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcodeCity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPostcodeCity.Location = new System.Drawing.Point(578, 53);
            this.lblPostcodeCity.Name = "lblPostcodeCity";
            this.lblPostcodeCity.Size = new System.Drawing.Size(155, 21);
            this.lblPostcodeCity.TabIndex = 0;
            this.lblPostcodeCity.Text = "Postcode City";
            // 
            // cbQuizPicker
            // 
            this.cbQuizPicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbQuizPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuizPicker.FormattingEnabled = true;
            this.cbQuizPicker.Location = new System.Drawing.Point(472, 135);
            this.cbQuizPicker.Name = "cbQuizPicker";
            this.cbQuizPicker.Size = new System.Drawing.Size(229, 23);
            this.cbQuizPicker.TabIndex = 3;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConfig.Location = new System.Drawing.Point(239, 220);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(118, 23);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Configuration";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(29, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 79);
            this.listBox1.TabIndex = 5;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Location = new System.Drawing.Point(472, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 50);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblExamTopics
            // 
            this.lblExamTopics.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExamTopics.AutoSize = true;
            this.lblExamTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTopics.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblExamTopics.Location = new System.Drawing.Point(469, 117);
            this.lblExamTopics.Name = "lblExamTopics";
            this.lblExamTopics.Padding = new System.Windows.Forms.Padding(0, 0, 140, 0);
            this.lblExamTopics.Size = new System.Drawing.Size(233, 15);
            this.lblExamTopics.TabIndex = 0;
            this.lblExamTopics.Text = "Exam Topics:";
            // 
            // btnStartExam
            // 
            this.btnStartExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartExam.AnimateHover = true;
            this.btnStartExam.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnStartExam.ButtonEnabled = true;
            this.btnStartExam.HandCursor = true;
            this.btnStartExam.Location = new System.Drawing.Point(668, 363);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(76, 72);
            this.btnStartExam.TabIndex = 6;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHistory.Location = new System.Drawing.Point(26, 117);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(92, 15);
            this.lblHistory.TabIndex = 0;
            this.lblHistory.Text = "Exams Done:";
            // 
            // giladGradientPanel1
            // 
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
            this.giladGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giladGradientPanel1.DraggableForm = true;
            this.giladGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giladGradientPanel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.giladGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladGradientPanel1.Location = new System.Drawing.Point(12, 50);
            this.giladGradientPanel1.Name = "giladGradientPanel1";
            this.giladGradientPanel1.Size = new System.Drawing.Size(747, 438);
            this.giladGradientPanel1.TabIndex = 11;
            // 
            // giladControlBox1
            // 
            this.giladControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.giladControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.giladControlBox1.Color1 = System.Drawing.Color.White;
            this.giladControlBox1.Color2 = System.Drawing.Color.Black;
            this.giladControlBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladControlBox1.Location = new System.Drawing.Point(648, 10);
            this.giladControlBox1.Name = "giladControlBox1";
            this.giladControlBox1.Size = new System.Drawing.Size(110, 38);
            this.giladControlBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AppTitle.Icon = ((System.Drawing.Icon)(resources.GetObject("resource.Icon")));
            this.AppTitle.IconLocation = new System.Drawing.Point(15, 15);
            this.AppTitle.IconSize = new System.Drawing.Size(32, 32);
            this.AppTitle.ShowIcon = true;
            this.AppTitle.ShowTextTitle = true;
            this.AppTitle.TextColor = System.Drawing.Color.Tan;
            this.AppTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.TextLocation = new System.Drawing.Point(50, 20);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.giladControlBox1);
            this.Controls.Add(this.giladGradientPanel1);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.Color.Firebrick;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.MediumTurquoise;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.FormBorders.Color = System.Drawing.Color.GreenYellow;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 12;
            this.MinimumSize = new System.Drawing.Size(770, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(12, 50, 11, 12);
            this.ResizeGripColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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

