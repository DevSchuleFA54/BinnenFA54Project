namespace BinnenFA54Project.Forms
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblExamNum = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblQuestionIndexer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSign = new System.Windows.Forms.PictureBox();
            this.cbCombo = new GiladControllers.Gilad4CheckBox();
            this.btnBack = new GiladControllers.GiladButton();
            this.btnNext = new GiladControllers.GiladButton();
            this.giladGradientPanel1 = new GiladControllers.GiladGradientPanel();
            this.giladControlBox1 = new GiladControllers.GiladControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).BeginInit();
            this.giladGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(157, 407);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(515, 31);
            this.progressBar.TabIndex = 1;
            // 
            // lblExamNum
            // 
            this.lblExamNum.AutoSize = true;
            this.lblExamNum.BackColor = System.Drawing.Color.Transparent;
            this.lblExamNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamNum.ForeColor = System.Drawing.Color.Azure;
            this.lblExamNum.Location = new System.Drawing.Point(8, 17);
            this.lblExamNum.Name = "lblExamNum";
            this.lblExamNum.Size = new System.Drawing.Size(107, 17);
            this.lblExamNum.TabIndex = 2;
            this.lblExamNum.Text = "Exam Number";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Azure;
            this.lblQuestion.Location = new System.Drawing.Point(48, 61);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(655, 32);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question Text";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(91, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Go Back";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(678, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Next Question";
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.Azure;
            this.btnFinish.Location = new System.Drawing.Point(753, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(92, 40);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish Exam";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblQuestionIndexer
            // 
            this.lblQuestionIndexer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQuestionIndexer.AutoSize = true;
            this.lblQuestionIndexer.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionIndexer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionIndexer.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblQuestionIndexer.Location = new System.Drawing.Point(456, 447);
            this.lblQuestionIndexer.Name = "lblQuestionIndexer";
            this.lblQuestionIndexer.Size = new System.Drawing.Size(14, 13);
            this.lblQuestionIndexer.TabIndex = 2;
            this.lblQuestionIndexer.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(355, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question Number: ";
            // 
            // pbSign
            // 
            this.pbSign.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbSign.BackColor = System.Drawing.Color.Transparent;
            this.pbSign.Location = new System.Drawing.Point(681, 145);
            this.pbSign.Name = "pbSign";
            this.pbSign.Size = new System.Drawing.Size(164, 167);
            this.pbSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSign.TabIndex = 9;
            this.pbSign.TabStop = false;
            // 
            // cbCombo
            // 
            this.cbCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCombo.BackColor = System.Drawing.Color.Transparent;
            this.cbCombo.CheckBox1Text = "CheckBox Text";
            this.cbCombo.CheckBox2Text = "CheckBox Text";
            this.cbCombo.CheckBox3Text = "CheckBox Text";
            this.cbCombo.CheckBox4Text = "CheckBox Text";
            this.cbCombo.CheckBoxAutoSize = false;
            this.cbCombo.CheckBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombo.CheckBoxLabelSize = new System.Drawing.Size(546, 60);
            this.cbCombo.CheckBoxSize = new System.Drawing.Size(587, 60);
            this.cbCombo.HandCursorHover = false;
            this.cbCombo.LabelForeColor = System.Drawing.Color.Azure;
            this.cbCombo.LabelForeColorDisabled = System.Drawing.Color.Gray;
            this.cbCombo.LabelForeColorHover = System.Drawing.Color.White;
            this.cbCombo.Location = new System.Drawing.Point(82, 96);
            this.cbCombo.MinimumSize = new System.Drawing.Size(230, 150);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(593, 267);
            this.cbCombo.TabIndex = 8;
            this.cbCombo.ViewModeState = GiladControllers.ControlViewMode.Active;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.AnimateHover = true;
            this.btnBack.ButtonDirection = GiladControllers.CustomButtonDirection.Back;
            this.btnBack.ButtonEnabled = false;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.HandCursor = true;
            this.btnBack.Location = new System.Drawing.Point(6, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AnimateHover = true;
            this.btnNext.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnNext.ButtonEnabled = true;
            this.btnNext.HandCursor = true;
            this.btnNext.Location = new System.Drawing.Point(781, 385);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 75);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // giladGradientPanel1
            // 
            this.giladGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.giladGradientPanel1.Controls.Add(this.btnNext);
            this.giladGradientPanel1.Controls.Add(this.btnFinish);
            this.giladGradientPanel1.Controls.Add(this.pbSign);
            this.giladGradientPanel1.Controls.Add(this.lblExamNum);
            this.giladGradientPanel1.Controls.Add(this.lblQuestion);
            this.giladGradientPanel1.Controls.Add(this.progressBar);
            this.giladGradientPanel1.Controls.Add(this.cbCombo);
            this.giladGradientPanel1.Controls.Add(this.lblQuestionIndexer);
            this.giladGradientPanel1.Controls.Add(this.btnBack);
            this.giladGradientPanel1.Controls.Add(this.label1);
            this.giladGradientPanel1.Controls.Add(this.label4);
            this.giladGradientPanel1.Controls.Add(this.label5);
            this.giladGradientPanel1.CustomCursor = true;
            this.giladGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giladGradientPanel1.DraggableForm = true;
            this.giladGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladGradientPanel1.Location = new System.Drawing.Point(9, 50);
            this.giladGradientPanel1.Name = "giladGradientPanel1";
            this.giladGradientPanel1.Size = new System.Drawing.Size(855, 535);
            this.giladGradientPanel1.TabIndex = 10;
            // 
            // giladControlBox1
            // 
            this.giladControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.giladControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.giladControlBox1.Color1 = System.Drawing.Color.White;
            this.giladControlBox1.Color2 = System.Drawing.Color.Black;
            this.giladControlBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladControlBox1.Location = new System.Drawing.Point(747, 9);
            this.giladControlBox1.Name = "giladControlBox1";
            this.giladControlBox1.Size = new System.Drawing.Size(115, 40);
            this.giladControlBox1.TabIndex = 11;
            // 
            // QuizForm
            // 
            this.AppTitle.Icon = ((System.Drawing.Icon)(resources.GetObject("resource.Icon")));
            this.AppTitle.IconLocation = new System.Drawing.Point(10, 10);
            this.AppTitle.IconSize = new System.Drawing.Size(32, 32);
            this.AppTitle.ShowIcon = true;
            this.AppTitle.ShowTextTitle = true;
            this.AppTitle.TextColor = System.Drawing.Color.Bisque;
            this.AppTitle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.TextLocation = new System.Drawing.Point(50, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(872, 594);
            this.Controls.Add(this.giladControlBox1);
            this.Controls.Add(this.giladGradientPanel1);
            this.CustomCursor = true;
            this.FormBackColor.GradientColor1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBackColor.GradientColor2 = System.Drawing.Color.Navy;
            this.FormBackColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.FormBorders.Color = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorders.DrawBorders = true;
            this.FormBorders.Width = 8;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(850, 560);
            this.Name = "QuizForm";
            this.ResizeGripColor = System.Drawing.Color.Lavender;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Title";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuizForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuizForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).EndInit();
            this.giladGradientPanel1.ResumeLayout(false);
            this.giladGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblExamNum;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblQuestionIndexer;
        private System.Windows.Forms.Label label1;
        private GiladControllers.GiladButton btnNext;
        private GiladControllers.GiladButton btnBack;
        private GiladControllers.Gilad4CheckBox cbCombo;
        private System.Windows.Forms.PictureBox pbSign;
        private GiladControllers.GiladGradientPanel giladGradientPanel1;
        private GiladControllers.GiladControlBox giladControlBox1;
    }
}