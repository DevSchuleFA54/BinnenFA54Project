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
using BinnenFA54Project.Main.ResourceData;
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
        private bool[] _checked; // Event handlers flag.

        public QuizForm()
        {
            InitializeComponent();
            // Creating manageable locally objects.
            questions = QuizMgr.Questions;
            answers   = QuizMgr.Answers;
            RegisterEventHandlers();

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


        #region --------------- Events Handlers ---------------

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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are about to finish the exam, are you sure you want to continue?",
                "Finish Exam", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                // TODO: Pass the results to store somewhere so we'll access it later from a different form.

                _feedbackForm = new FeedbackForm();
                _feedbackForm.Show();
            }
        }

        #endregion --------------- Events Handlers ---------------


        #region --------------- Extra Events Handlers ---------------

        /// <summary>
        /// Avoid from trying adding it to the designer file, it would cause some problems
        /// in the desginer since it's sub-component of cbCombo.
        /// </summary>
        private void RegisterEventHandlers()
        {
            _checked = new bool[4];

            cbCombo.cbOption1.pbCheckBox.Click += new EventHandler(cbOption1_CheckedChanged);
            cbCombo.cbOption2.pbCheckBox.Click += new EventHandler(cbOption2_CheckedChanged);
            cbCombo.cbOption3.pbCheckBox.Click += new EventHandler(cbOption3_CheckedChanged);
            cbCombo.cbOption4.pbCheckBox.Click += new EventHandler(cbOption4_CheckedChanged);
        }

        private void cbOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (_checked[0]) //  if unchecked
            {
                _checked[0] = false;
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[0] = true;
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void cbOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (_checked[1])
            {
                _checked[1] = false;
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[1] = true;
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void cbOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (_checked[2])
            {
                _checked[2] = false;
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[2] = true;
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void cbOption4_CheckedChanged(object sender, EventArgs e)
        {
            if (_checked[3])
            {
                _checked[3] = false;
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[3] = true;
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        #endregion --------------- Events Handlers ---------------

    }
}
