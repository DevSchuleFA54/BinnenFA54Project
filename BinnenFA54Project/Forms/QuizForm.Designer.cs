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
            this.cbOption1 = new System.Windows.Forms.CheckBox();
            this.cbOption2 = new System.Windows.Forms.CheckBox();
            this.cbOption3 = new System.Windows.Forms.CheckBox();
            this.cbOption4 = new System.Windows.Forms.CheckBox();
            this.lblQuestionIndexer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new GiladControllers.GiladButton();
            this.btnBack = new GiladControllers.GiladButton();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(146, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 31);
            this.progressBar1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Application Title";
            // 
            // lblExamNum
            // 
            this.lblExamNum.AutoSize = true;
            this.lblExamNum.Location = new System.Drawing.Point(12, 40);
            this.lblExamNum.Name = "lblExamNum";
            this.lblExamNum.Size = new System.Drawing.Size(73, 13);
            this.lblExamNum.TabIndex = 2;
            this.lblExamNum.Text = "Exam Number";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 92);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(655, 32);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Go Back";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Next Question";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(575, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(92, 40);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish Exam";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // cbOption1
            // 
            this.cbOption1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption1.Location = new System.Drawing.Point(83, 127);
            this.cbOption1.Name = "cbOption1";
            this.cbOption1.Size = new System.Drawing.Size(584, 31);
            this.cbOption1.TabIndex = 6;
            this.cbOption1.Text = "Option 1";
            this.cbOption1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption1.UseVisualStyleBackColor = true;
            // 
            // cbOption2
            // 
            this.cbOption2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption2.Location = new System.Drawing.Point(83, 164);
            this.cbOption2.Name = "cbOption2";
            this.cbOption2.Size = new System.Drawing.Size(584, 34);
            this.cbOption2.TabIndex = 6;
            this.cbOption2.Text = "Option 2";
            this.cbOption2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption2.UseVisualStyleBackColor = true;
            // 
            // cbOption3
            // 
            this.cbOption3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption3.Location = new System.Drawing.Point(83, 204);
            this.cbOption3.Name = "cbOption3";
            this.cbOption3.Size = new System.Drawing.Size(584, 34);
            this.cbOption3.TabIndex = 6;
            this.cbOption3.Text = "Option 3";
            this.cbOption3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption3.UseVisualStyleBackColor = true;
            // 
            // cbOption4
            // 
            this.cbOption4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption4.Location = new System.Drawing.Point(83, 244);
            this.cbOption4.Name = "cbOption4";
            this.cbOption4.Size = new System.Drawing.Size(584, 34);
            this.cbOption4.TabIndex = 6;
            this.cbOption4.Text = "Option 4";
            this.cbOption4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOption4.UseVisualStyleBackColor = true;
            // 
            // lblQuestionIndexer
            // 
            this.lblQuestionIndexer.AutoSize = true;
            this.lblQuestionIndexer.Location = new System.Drawing.Point(369, 366);
            this.lblQuestionIndexer.Name = "lblQuestionIndexer";
            this.lblQuestionIndexer.Size = new System.Drawing.Size(13, 13);
            this.lblQuestionIndexer.TabIndex = 2;
            this.lblQuestionIndexer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question Number: ";
            // 
            // btnNext
            // 
            this.btnNext.AnimateHover = true;
            this.btnNext.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnNext.ButtonEnabled = true;
            this.btnNext.HandCursorHover = true;
            this.btnNext.Location = new System.Drawing.Point(590, 304);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 75);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimateHover = true;
            this.btnBack.ButtonDirection = GiladControllers.CustomButtonDirection.Back;
            this.btnBack.ButtonEnabled = false;
            this.btnBack.HandCursorHover = true;
            this.btnBack.Location = new System.Drawing.Point(10, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(679, 397);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbOption4);
            this.Controls.Add(this.cbOption3);
            this.Controls.Add(this.cbOption2);
            this.Controls.Add(this.cbOption1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblExamNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestionIndexer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.progressBar1);
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizForm";
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
        private System.Windows.Forms.CheckBox cbOption1;
        private System.Windows.Forms.CheckBox cbOption2;
        private System.Windows.Forms.CheckBox cbOption3;
        private System.Windows.Forms.CheckBox cbOption4;
        private System.Windows.Forms.Label lblQuestionIndexer;
        private System.Windows.Forms.Label label1;
        private GiladControllers.GiladButton btnNext;
        private GiladControllers.GiladButton btnBack;
    }
}