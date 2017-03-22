using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project.Forms
{
    public partial class QuizForm : Form
    {
        // TODO: Create a progress bar to update when questions index changing.
        QuestionMgr questions;
        AnswerMgr answers;
        FeedbackForm _feedbackForm;
        int qIndex = 0; // Question Indexer.

        public QuizForm()
        {
            InitializeComponent();
            // Creating manageable locally objects.
            questions = QuizMgr.Questions;
            answers   = QuizMgr.Answers;

            //Thread.Sleep(1000); // TODO: create during that time loading indicator runs on another thread.
            UpdateQuestions();
        }


        private void UpdateQuestions()
        {
            lblQuestion.Text        = questions.QuestionList[qIndex].QuestionMeoww;
            cbCombo.CheckBox1Text   = questions.QuestionList[qIndex].Options[0];
            cbCombo.CheckBox2Text   = questions.QuestionList[qIndex].Options[1];
            cbCombo.CheckBox3Text   = questions.QuestionList[qIndex].Options[2];
            cbCombo.CheckBox4Text   = questions.QuestionList[qIndex].Options[3];
            // if question has an image, display the image, otherwise null.
            pbSign.Image            = questions.QuestionList[qIndex].SignImg ?? null;
            // db based 1 value while _questions.QuestionList<List> based 0.
            lblQuestionIndexer.Text = (qIndex + 1).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            qIndex++;

            if (qIndex == 1)
                btnBack.ButtonEnabled = true;

            if (qIndex == questions.QuestionList.Count - 1) // last question.
                btnNext.ButtonEnabled = false;

            UpdateQuestions();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            qIndex--;

            if (qIndex == 0)
                btnBack.ButtonEnabled = false;

            if (qIndex == questions.QuestionList.Count - 2)
                btnNext.ButtonEnabled = true;

            UpdateQuestions();
        }
    }
}
