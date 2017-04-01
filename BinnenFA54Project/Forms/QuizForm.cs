﻿using System;
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
        QuizMgr quiz;
        FeedbackForm feedbackForm;
        private int qIndex = 0; // Question Indexer.
        private bool[] _checked; // Event handlers flag.
        private bool alreadyChecked;


        public QuizForm()
        {
            Loader.StartLoader(LoaderSelector.Loader);

            quiz = new QuizMgr();
            InitializeComponent();
            RegisterEventHandlers();
            GenerateQuestionSelectors();
            progressBar.Maximum = quiz.Questions.QuestionList.Count;
            UpdateQuestions();

            Thread.Sleep(5000);
            Loader.StopLoader();
        }


        private void UpdateQuestions()
        {

            alreadyChecked = cbCombo.Checked; // progressBar stuffs.

            lblQuestion.Text        = quiz.Questions.QuestionList[qIndex].QuestionMeoww;
            cbCombo.CheckBox1Text   = quiz.Questions.QuestionList[qIndex].Options[0];
            cbCombo.CheckBox2Text   = quiz.Questions.QuestionList[qIndex].Options[1];
            cbCombo.CheckBox3Text   = quiz.Questions.QuestionList[qIndex].Options[2];
            cbCombo.CheckBox4Text   = quiz.Questions.QuestionList[qIndex].Options[3];
            // if question has an image, display the image, otherwise null.
            pbSign.Image            = quiz.Questions.QuestionList[qIndex].SignImg ?? null;
            // db based 1 value while _questions.QuestionList<List> based 0.
            lblQuestionIndexer.Text = (qIndex + 1).ToString();
        }



        /// <summary>
        /// Simply selects the checkbox if state is answered.
        /// </summary>
        /// <param name="direction"></param>
        private void RenderQuestionResults(CustomButtonDirection? direction)
        {
            int tmpIndex = qIndex;
            if (direction != null)
            {
                if (direction == CustomButtonDirection.Forward)
                    tmpIndex += 1;
                else
                    tmpIndex -= 1;
            }

            SetQuestionState(tmpIndex);
        }


        private void SetQuestionState(int index)
        {
            switch (quiz.Answers.AnswerList[index].State)
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
                    // index+1 since we want to check what is selected answer on the next question before showing to the user.
                    switch (quiz.Answers.AnswerList[index].SelectedAnswer)
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

        private void UpdateProgressBar()
        {
            if (cbCombo.Checked && alreadyChecked == false)
            {
                progressBar.Value++;
            }
            else if (cbCombo.Checked && alreadyChecked)
            {

            }
            else if (cbCombo.Checked == false && alreadyChecked)
            {
                progressBar.Value--;
            }
            else if (cbCombo.Checked == false && alreadyChecked == false)
            {

            }
        }

        #region --------------- Events Handlers ---------------

        private void btnNext_Click(object sender, EventArgs e)
        {
            UpdateProgressBar();
            RenderQuestionResults(CustomButtonDirection.Forward);

            // We only want to increment after the switch cases, since we play with base 0 values.
            qIndex++;

            if (qIndex == 1)
                btnBack.ButtonEnabled = true;

            if (qIndex == quiz.Questions.QuestionList.Count - 1) // last question.
                btnNext.ButtonEnabled = false;

            
            UpdateQuestions();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateProgressBar();
            RenderQuestionResults(CustomButtonDirection.Back);

            qIndex--;

            if (qIndex == 0)
                btnBack.ButtonEnabled = false;

            if (qIndex == quiz.Questions.QuestionList.Count - 2)
                btnNext.ButtonEnabled = true;

            
            UpdateQuestions();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("You are about to finish the exam, are you sure you want to continue?",
                "Finish Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                if (progressBar.Value != progressBar.Maximum)
                {
                    DialogResult pbarAnswer = MessageBox.Show(
                            string.Format("Seems like you only answered {0} questions from {1}. To continue?",
                            progressBar.Value, progressBar.Maximum),
                            "WARNING",
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Warning);

                    if (pbarAnswer != DialogResult.Yes)
                        return;
                }
                // TODO: Pass the results to store somewhere so we'll access it later from a different form.



                feedbackForm = new FeedbackForm();
                feedbackForm.Show();
                this.Close();
            }


        }

        #endregion --------------- Events Handlers ---------------


        #region --------------- Extra Events Handlers ---------------
        enum EventHandlerEnum
        {
            Click    = 0,
            KeyPress = 1,
            Empty    = 2
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


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are you sure you want to exit the exam?", 
                "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult != DialogResult.Yes)
                return;

            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        #endregion --------------- Events Handlers ---------------



        private void CheckBox1ChangeState(EventHandlerEnum handler)
        {
            if (_checked[0])
            {
                _checked[0] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.First, false);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = null;
                quiz.Answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[0] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.First, true);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                quiz.Answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void CheckBox2ChangeState(EventHandlerEnum handler)
        {
            if (_checked[1])
            {
                _checked[1] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Second, false);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = null;
                quiz.Answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[1] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Second, true);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                quiz.Answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void CheckBox3ChangeState(EventHandlerEnum handler)
        {
            if (_checked[2])
            {
                _checked[2] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Third, false);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = null;
                quiz.Answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[2] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Third, true);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                quiz.Answers.AnswerList[qIndex].State = State.Answered;
            }
        }

        private void CheckBox4ChangeState(EventHandlerEnum handler)
        {
            if (_checked[3])
            {
                _checked[3] = false;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Fourth, false);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = null;
                quiz.Answers.AnswerList[qIndex].State = State.Waiting;
            }
            else
            {
                _checked[3] = true;
                if (handler == EventHandlerEnum.KeyPress)
                    cbCombo.SelectCheckBox(CbIndex.Fourth, true);
                quiz.Answers.AnswerList[qIndex].SelectedAnswer = cbCombo.SelectedCheckBoxIndex;
                quiz.Answers.AnswerList[qIndex].State = State.Answered;
            }
        }



        #region -------------- Button Question Selectors --------------
        /// <summary>
        /// There are 30 questions in this particular quiz.
        /// </summary>
        private int x;
        private int y;
        private int startX = 148;
        private int startY = 499;
        private int spacingX = 30;
        private int spacingY = 28;
        private Button[] buttons;

        public void GenerateQuestionSelectors()
        {
            x = startX;
            y = startY;
            buttons = new Button[quiz.Questions.QuestionList.Count];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = (i + 1).ToString();
                buttons[i].UseVisualStyleBackColor = true;
                buttons[i].BackColor = Color.DeepSkyBlue;
                buttons[i].Size = new Size(27, 23);
                buttons[i].Tag = i.ToString();
                buttons[i].TabIndex = 20;
                buttons[i].Anchor = AnchorStyles.Bottom;

                if (i == 18) // If 18 buttons generated go on the 19 button 1 floor down.
                {
                    // endX - startX / 2 + startX = centerX
                    // if the number of the center is odd, do (results - incrementer / 2).
                    x = (((x - startX) / 2) + startX) - (spacingX / 2);
                    x = (x - (spacingX * 6) + (spacingX / 2)); // 6 is the rest.
                    y += spacingY;
                }

                buttons[i].Location = new Point(x, y);
                buttons[i].Click += btnSelector_Click;
                x += spacingX;

                this.Controls.Add(buttons[i]);
            }

        }


        private void btnSelector_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(((Button)sender).Tag.ToString()); // gets the indexer of the generated button.

            if (value == 0)
            {
                btnBack.ButtonEnabled = false;
                btnNext.ButtonEnabled = true;
            }
            else if (value == (quiz.Questions.QuestionList.Count - 1)) // last question
            {
                btnBack.ButtonEnabled = true;
                btnNext.ButtonEnabled = false;
            }
            else
            {
                btnBack.ButtonEnabled = true;
                btnNext.ButtonEnabled = true;
            }


            qIndex = value;
            RenderQuestionResults(null); UpdateQuestions();
        }


        #endregion -------------- Button Question Selectors --------------
    }
}
