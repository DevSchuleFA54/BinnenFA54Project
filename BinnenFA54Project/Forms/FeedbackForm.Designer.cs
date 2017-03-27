namespace BinnenFA54Project.Forms
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassedOrNot = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.maximize_FeedbackForm = new System.Windows.Forms.Button();
            this.minimize_Feedbackform = new System.Windows.Forms.Button();
            this.exit_FeedbackForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Feedback";
            // 
            // lblPassedOrNot
            // 
            this.lblPassedOrNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassedOrNot.Location = new System.Drawing.Point(56, 284);
            this.lblPassedOrNot.Name = "lblPassedOrNot";
            this.lblPassedOrNot.Size = new System.Drawing.Size(212, 50);
            this.lblPassedOrNot.TabIndex = 0;
            this.lblPassedOrNot.Text = "Passed or Not label";
            this.lblPassedOrNot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 199);
            this.listBox1.TabIndex = 1;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(17, 52);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Results:";
            // 
            // maximize_FeedbackForm
            // 
            this.maximize_FeedbackForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_FeedbackForm.Image = ((System.Drawing.Image)(resources.GetObject("maximize_FeedbackForm.Image")));
            this.maximize_FeedbackForm.Location = new System.Drawing.Point(249, 0);
            this.maximize_FeedbackForm.Name = "maximize_FeedbackForm";
            this.maximize_FeedbackForm.Size = new System.Drawing.Size(37, 27);
            this.maximize_FeedbackForm.TabIndex = 17;
            this.maximize_FeedbackForm.UseVisualStyleBackColor = true;
            this.maximize_FeedbackForm.Click += new System.EventHandler(this.maximize_FeedbackForm_Click);
            // 
            // minimize_Feedbackform
            // 
            this.minimize_Feedbackform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_Feedbackform.Image = ((System.Drawing.Image)(resources.GetObject("minimize_Feedbackform.Image")));
            this.minimize_Feedbackform.Location = new System.Drawing.Point(206, 0);
            this.minimize_Feedbackform.Name = "minimize_Feedbackform";
            this.minimize_Feedbackform.Size = new System.Drawing.Size(37, 27);
            this.minimize_Feedbackform.TabIndex = 16;
            this.minimize_Feedbackform.UseVisualStyleBackColor = true;
            this.minimize_Feedbackform.Click += new System.EventHandler(this.minimize_Feedbackform_Click);
            // 
            // exit_FeedbackForm
            // 
            this.exit_FeedbackForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_FeedbackForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exit_FeedbackForm.Image = ((System.Drawing.Image)(resources.GetObject("exit_FeedbackForm.Image")));
            this.exit_FeedbackForm.Location = new System.Drawing.Point(292, 0);
            this.exit_FeedbackForm.Name = "exit_FeedbackForm";
            this.exit_FeedbackForm.Size = new System.Drawing.Size(37, 27);
            this.exit_FeedbackForm.TabIndex = 15;
            this.exit_FeedbackForm.UseVisualStyleBackColor = false;
            this.exit_FeedbackForm.Click += new System.EventHandler(this.exit_FeedbackForm_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 339);
            this.Controls.Add(this.maximize_FeedbackForm);
            this.Controls.Add(this.minimize_Feedbackform);
            this.Controls.Add(this.exit_FeedbackForm);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblPassedOrNot);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassedOrNot;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button maximize_FeedbackForm;
        private System.Windows.Forms.Button minimize_Feedbackform;
        private System.Windows.Forms.Button exit_FeedbackForm;
    }
}