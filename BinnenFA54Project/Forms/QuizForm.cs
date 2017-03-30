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
using GiladControllers;

namespace BinnenFA54Project.Forms
{
    public partial class QuizForm : Form
    {
        QuestionMgr questions;
        AnswerMgr answers;
        FeedbackForm _feedbackForm;
        int qIndex = 0; // Question Indexer.
        private bool[] _checked; // Event handlers flag.
        bool already_checked = false;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        public QuizForm()
        {
            Loader.StartLoader(LoaderSelector.Loader);

            InitializeComponent();
            // Creating manageable locally objects.
            questions = QuizMgr.Questions;
            answers   = QuizMgr.Answers;
            RegisterEventHandlers();
            progressBar1.Maximum = questions.QuestionList.Count;
            UpdateQuestions();

            Thread.Sleep(5000); // TODO: create during that time loading indicator runs on another thread.
            Loader.StopLoader();
        }


        private void UpdateQuestions()
        {

            if (cbCombo.Checked == true)
            {
                already_checked = true;
            }
            else
                already_checked = false;

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



        /// <summary>
        /// Checks to see which question has beeen answered or waiting and display the checked checkbox
        /// for
        /// Gets a direction for knowing if a back or forward button has been pressed in order to know 
        /// if we need to check the answer before or after a specific index.
        /// </summary>
        /// <param name="direction"></param>
        private void UpdateQuestionState(CustomButtonDirection direction)
        {
            int index;

            if (direction == CustomButtonDirection.Forward)
                index = qIndex + 1;
            else
                index = qIndex - 1;


            switch (answers.AnswerList[index].State)
            {
                case State.Waiting:
                    // We updating the _checked boolean flags because of the events when a checkbox is
                    // checked with Click or KeyPress events. otherwise it would results in some
                    // cases clicking twice. So if the question not answered yet, set all to false.
                    for (int i = 0; i < _checked.Length; i++)
                        _checked[i] = false;
                    cbCombo.ClearAllCheckMarks();
                    break;

                case State.Answered:
                    cbCombo.ClearAllCheckMarks();
                    // qIndex+1 since we want to check what is selected answer on the next question before showing to the user.
                    switch (answers.AnswerList[index].SelectedAnswer)
                    {
                        case 0:
                            _checked[0] = true;
                            cbCombo.SelectCheckBox(CbIndex.First, true);
                            break;
                        case 1:
                            _checked[1] = true;
                            cbCombo.SelectCheckBox(CbIndex.Second, true);
                            break;
                        case 2:
                            _checked[2] = true;
                            cbCombo.SelectCheckBox(CbIndex.Third, true);
                            break;
                        case 3:
                            _checked[3] = true;
                            cbCombo.SelectCheckBox(CbIndex.Fourth, true);
                            break;
                        default:
                            MessageBox.Show(@"[QuizForm::btnNext/Back_Click] - Unmatched <State> switch case.");
                            break;
                    }
                    break;
            }
        }



        #region --------------- Events Handlers ---------------

        private void btnNext_Click(object sender, EventArgs e)
        {
            Answerchecking();
            UpdateQuestionState(CustomButtonDirection.Forward);

            // We only want to increment after the switch cases, since we play with base 0 values.
            qIndex++;

            if (qIndex == 1)
                btnBack.ButtonEnabled = true;

            if (qIndex == questions.QuestionList.Count - 1) // last question.
                btnNext.ButtonEnabled = false;

            
            UpdateQuestions();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Answerchecking();
            UpdateQuestionState(CustomButtonDirection.Back);

            qIndex--;

            if (qIndex == 0)
                btnBack.ButtonEnabled = false;

            if (qIndex == questions.QuestionList.Count - 2)
                btnNext.ButtonEnabled = true;

            
            UpdateQuestions();
        }

        private void Answerchecking()
        {
            if (cbCombo.Checked == true && already_checked == false)
            {
                progressBar1.Value++;
            }
            else if (cbCombo.Checked == true && already_checked == true)
            {

            }
            else if (cbCombo.Checked == false && already_checked == true)
            {
                progressBar1.Value--;
            }
            else if (cbCombo.Checked == false && already_checked == false)
            {

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are about to finish the exam, are you sure you want to continue?",
                "Finish Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                if (progressBar1.Value != progressBar1.Maximum)
                {
                    DialogResult pbarAnswer = MessageBox.Show("Are you really sure? You have only answered " + progressBar1.Value + " from " + progressBar1.Maximum + " answers, do you want finish?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (pbarAnswer == DialogResult.No)
                    {
                        return;
                    }
                        
                }
                // TODO: Pass the results to store somewhere so we'll access it later from a different form.

                _feedbackForm = new FeedbackForm();
                _feedbackForm.Show();
                this.Close();
            }
        }

        #endregion --------------- Events Handlers ---------------


        #region --------------- Extra Events Handlers ---------------
        enum EventHandlerEnum
        {
            Click = 0,
            KeyPress = 1,
            Empty = 2
        }

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
            if (!cbCombo.cbOption1.Checked) return;
            CheckBox1ChangeState(EventHandlerEnum.KeyPress);
        }

        private void cbOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCombo.cbOption2.Checked) return;
            CheckBox2ChangeState(EventHandlerEnum.KeyPress);
        }

        private void cbOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCombo.cbOption3.Checked) return;
            CheckBox3ChangeState(EventHandlerEnum.KeyPress);
        }

        private void cbOption4_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCombo.cbOption4.Checked) return;
            CheckBox4ChangeState(EventHandlerEnum.KeyPress);
        }


        private void QuizForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)49: // D1
                    // saftey check, if not enable, do nothing.
                    if (!cbCombo.cbOption1.CheckBoxEnabled)
                        return;

                    CheckBox1ChangeState(EventHandlerEnum.KeyPress);
                    break;
                case (char)50: // D2
                    if (!cbCombo.cbOption2.CheckBoxEnabled)
                        return;

                    CheckBox2ChangeState(EventHandlerEnum.KeyPress);
                    break;
                case (char)51: // D3
                    if (!cbCombo.cbOption3.CheckBoxEnabled)
                        return;

                    CheckBox3ChangeState(EventHandlerEnum.KeyPress);
                    break;
                case (char)52: // D4
                    if (!cbCombo.cbOption4.CheckBoxEnabled)
                        return;

                    CheckBox4ChangeState(EventHandlerEnum.KeyPress);
                    break;
            }
        }

        private void QuizForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (!btnNext.ButtonEnabled)
                        return;

                    btnNext_Click(sender, e);
                    break;

                case Keys.Left:
                    if (!btnBack.ButtonEnabled)
                        return;

                    btnBack_Click(sender, e);
                    break;
            }
        }

        #endregion --------------- Events Handlers ---------------



        private void CheckBox1ChangeState(EventHandlerEnum handler)
        {
            if (_checked[0])
            {
                _checked[0] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.First, false);
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[0] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.First, true);
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void CheckBox2ChangeState(EventHandlerEnum handler)
        {
            if (_checked[1])
            {
                _checked[1] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Second, false);
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[1] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Second, true);
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void CheckBox3ChangeState(EventHandlerEnum handler)
        {
            if (_checked[2])
            {
                _checked[2] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Third, false);
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[2] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Third, true);
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void CheckBox4ChangeState(EventHandlerEnum handler)
        {
            if (_checked[3])
            {
                _checked[3] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Fourth, false);
                answers.AnswerList[qIndex].SelectedAnswer = null;
                answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[3] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Fourth, true);
                answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void exit_quizform_Click(object sender, EventArgs e)
        {
            DialogResult quizcloseAnswer = MessageBox.Show("Are you really want abort this exam?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (quizcloseAnswer == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void minimize_quizform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_quizform_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
