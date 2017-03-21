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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(148, 442);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(530, 31);
            this.progressBar1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Application Title";
            // 
            // lblExamNum
            // 
            this.lblExamNum.AutoSize = true;
            this.lblExamNum.Location = new System.Drawing.Point(9, 72);
            this.lblExamNum.Name = "lblExamNum";
            this.lblExamNum.Size = new System.Drawing.Size(73, 13);
            this.lblExamNum.TabIndex = 2;
            this.lblExamNum.Text = "Exam Number";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(14, 125);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(655, 32);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Go Back";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Next Question";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(747, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(92, 40);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish Exam";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // lblQuestionIndexer
            // 
            this.lblQuestionIndexer.AutoSize = true;
            this.lblQuestionIndexer.Location = new System.Drawing.Point(462, 480);
            this.lblQuestionIndexer.Name = "lblQuestionIndexer";
            this.lblQuestionIndexer.Size = new System.Drawing.Size(13, 13);
            this.lblQuestionIndexer.TabIndex = 2;
            this.lblQuestionIndexer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question Number: ";
            // 
            // pbSign
            // 
            this.pbSign.Location = new System.Drawing.Point(12, 198);
            this.pbSign.Name = "pbSign";
            this.pbSign.Size = new System.Drawing.Size(79, 135);
            this.pbSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSign.TabIndex = 9;
            this.pbSign.TabStop = false;
            // 
            // cbCombo
            // 
            this.cbCombo.CheckBox1Text = "CheckBox Text";
            this.cbCombo.CheckBox2Text = "CheckBox Text";
            this.cbCombo.CheckBox3Text = "CheckBox Text";
            this.cbCombo.CheckBox4Text = "CheckBox Text";
            this.cbCombo.CheckBoxAutoSize = false;
            this.cbCombo.CheckBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombo.CheckBoxLabelSize = new System.Drawing.Size(600, 40);
            this.cbCombo.CheckBoxSize = new System.Drawing.Size(645, 55);
            this.cbCombo.HandCursorHover = true;
            this.cbCombo.LabelForeColor = System.Drawing.Color.NavajoWhite;
            this.cbCombo.LabelForeColorDisabled = System.Drawing.Color.Gray;
            this.cbCombo.LabelForeColorHover = System.Drawing.Color.White;
            this.cbCombo.Location = new System.Drawing.Point(96, 160);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(650, 235);
            this.cbCombo.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.AnimateHover = true;
            this.btnBack.ButtonDirection = GiladControllers.CustomButtonDirection.Back;
            this.btnBack.ButtonEnabled = false;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.HandCursorHover = true;
            this.btnBack.Location = new System.Drawing.Point(12, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.AnimateHover = true;
            this.btnNext.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnNext.ButtonEnabled = true;
            this.btnNext.HandCursorHover = true;
            this.btnNext.Location = new System.Drawing.Point(764, 418);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 75);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(851, 505);
            this.Controls.Add(this.pbSign);
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblExamNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestionIndexer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.progressBar1);
            this.KeyPreview = true;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTitle;
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
    }
}