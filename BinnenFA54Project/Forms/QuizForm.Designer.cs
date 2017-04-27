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
            this.pbSmiley = new System.Windows.Forms.PictureBox();
            this.giladControlBox1 = new GiladControllers.GiladControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).BeginInit();
            this.giladGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmiley)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // lblExamNum
            // 
            resources.ApplyResources(this.lblExamNum, "lblExamNum");
            this.lblExamNum.BackColor = System.Drawing.Color.Transparent;
            this.lblExamNum.ForeColor = System.Drawing.Color.Azure;
            this.lblExamNum.Name = "lblExamNum";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblQuestion, "lblQuestion");
            this.lblQuestion.ForeColor = System.Drawing.Color.Azure;
            this.lblQuestion.Name = "lblQuestion";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Name = "label5";
            // 
            // btnFinish
            // 
            resources.ApplyResources(this.btnFinish, "btnFinish");
            this.btnFinish.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFinish.ForeColor = System.Drawing.Color.Azure;
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblQuestionIndexer
            // 
            resources.ApplyResources(this.lblQuestionIndexer, "lblQuestionIndexer");
            this.lblQuestionIndexer.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionIndexer.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblQuestionIndexer.Name = "lblQuestionIndexer";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Name = "label1";
            // 
            // pbSign
            // 
            resources.ApplyResources(this.pbSign, "pbSign");
            this.pbSign.BackColor = System.Drawing.Color.Transparent;
            this.pbSign.Name = "pbSign";
            this.pbSign.TabStop = false;
            // 
            // cbCombo
            // 
            resources.ApplyResources(this.cbCombo, "cbCombo");
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
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.ViewModeState = GiladControllers.ControlViewMode.Active;
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.AnimateHover = true;
            this.btnBack.ButtonDirection = GiladControllers.CustomButtonDirection.Back;
            this.btnBack.ButtonEnabled = false;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.HandCursor = true;
            this.btnBack.Name = "btnBack";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.AnimateHover = true;
            this.btnNext.ButtonDirection = GiladControllers.CustomButtonDirection.Forward;
            this.btnNext.ButtonEnabled = true;
            this.btnNext.HandCursor = true;
            this.btnNext.Name = "btnNext";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // giladGradientPanel1
            // 
            this.giladGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color1 = System.Drawing.Color.Transparent;
            this.giladGradientPanel1.Color2 = System.Drawing.Color.DarkSlateBlue;
            this.giladGradientPanel1.Controls.Add(this.btnNext);
            this.giladGradientPanel1.Controls.Add(this.btnFinish);
            this.giladGradientPanel1.Controls.Add(this.pbSmiley);
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
            resources.ApplyResources(this.giladGradientPanel1, "giladGradientPanel1");
            this.giladGradientPanel1.DraggableForm = true;
            this.giladGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.giladGradientPanel1.Name = "giladGradientPanel1";
            // 
            // pbSmiley
            // 
            resources.ApplyResources(this.pbSmiley, "pbSmiley");
            this.pbSmiley.BackColor = System.Drawing.Color.Transparent;
            this.pbSmiley.Name = "pbSmiley";
            this.pbSmiley.TabStop = false;
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            this.Name = "QuizForm";
            this.ResizeGripColor = System.Drawing.Color.Lavender;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuizForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuizForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbSign)).EndInit();
            this.giladGradientPanel1.ResumeLayout(false);
            this.giladGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmiley)).EndInit();
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
        private System.Windows.Forms.PictureBox pbSmiley;
    }
}