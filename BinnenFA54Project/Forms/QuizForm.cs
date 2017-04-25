using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ResourceData;
using BinnenFA54Project.Main.ServeData;
using GiladControllers;

namespace BinnenFA54Project.Forms
{
    // TODO: @togi - Create German Translation.  See ConfigurationForm as example.
    public partial class QuizForm : GiladForm
    {
        QuizMgr quiz;
        FeedbackForm feedbackForm;
        private int qIndex = 0; // Question Indexer.
        private bool[] _checked; // Event handlers flag.
        private bool alreadyChecked;
        private bool reviewExam = false;
        private SettingIni setting;



        public QuizForm()
        {
            //Loader.StartLoader(LoaderSelector.Loader);

            setting = new SettingIni();
            //// NOTE: It has to be before the InitializeComponent function in order to take effect.
            //Thread.CurrentThread.CurrentUICulture = setting.Language == "en-US" ?
            //    new CultureInfo("en-US") : new CultureInfo("de-DE");

            quiz = new QuizMgr();
            InitializeComponent();
            RegisterEventHandlers();
            GenerateQuestionSelectors();
            UpdateQuestions();
            this.progressBar.Maximum = quiz.Questions.QuestionList.Count;
            this.Text = setting.ApplicationTitle;
            //Thread.Sleep(5000);
            //Loader.StopLoader();
        }

        public QuizForm(QuizMgr quiz) // reviewing your exam answers mode.
        {
            //Loader.StartLoader(LoaderSelector.Loader);

            setting = new SettingIni();
            //Thread.CurrentThread.CurrentUICulture = setting.Language == "en-US" ?
            //    new CultureInfo("en-US") : new CultureInfo("de-DE");

            reviewExam = true;
            _checked   = new bool[4];

            this.quiz  = quiz;
            InitializeComponent();
            this.btnFinish.Dispose();
            GenerateQuestionSelectors();
            RenderQuestionResults(null);
            UpdateQuestions();
            this.Text = setting.ApplicationTitle;

            // Unregistering all the events in the sub controllers so the user will only review his exam.
            this.KeyPress -= QuizForm_KeyPress;
            this.cbCombo.ViewModeState = ControlViewMode.Inactive;

            //Loader.StopLoader();
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

                    // TODO: Handle nullable correctAnswer.
                    int? correctAnswer = quiz.Answers.AnswerList[index].CorrectAnswerNum;
                    switch (quiz.Answers.AnswerList[index].SelectedAnswer)
                    {
                        case 0:
                            _checked[0] = true;
                            cbCombo.SelectCheckBoxIndex = 0;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].Results != Results.Right) // wrong answer.
                                {
                                    // Mark the selected cb with WrongSelect.
                                    cbCombo.cbOption1.WrongSelected = true;
                                    // Select the correct answer.
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    // TODO: Add smiley sad.

                                }
                                // TODO: Add smiley happy.

                            }
                            break;
                        case 1:
                            _checked[1] = true;
                            cbCombo.SelectCheckBoxIndex = 1;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].Results != Results.Right)
                                {
                                    cbCombo.cbOption2.WrongSelected = true;
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    // TODO: Add smiley sad.

                                }
                                // TODO: Add smiley happy.

                            }
                            break;
                        case 2:
                            _checked[2] = true;
                            cbCombo.SelectCheckBoxIndex = 2;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].Results != Results.Right)
                                {
                                    cbCombo.cbOption3.WrongSelected = true;
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    // TODO: Add smiley sad.

                                }
                                // TODO: Add smiley happy.

                            }
                            break;
                        case 3:
                            _checked[3] = true;
                            cbCombo.SelectCheckBoxIndex = 3;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].Results != Results.Right)
                                {
                                    cbCombo.cbOption4.WrongSelected = true;
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    // TODO: Add smiley sad.

                                }
                                // TODO: Add smiley happy.

                            }
                            break;
                        default: // if no selected answer.
                            cbCombo.cbOption1.WrongAnswer = cbCombo.cbOption2.WrongAnswer =
                            cbCombo.cbOption3.WrongAnswer = cbCombo.cbOption4.WrongAnswer = true;
                            if (correctAnswer != null)
                                cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                            // TODO: Add smiley netural.

                            break;
                    } // End State.Answered switch

                    break;
            } // End switch.

        }


        /// <summary>
        /// Checks with the quiz.AnswerMgr answers which of the questions is wrong or right
        /// and change their state in the list.
        /// Also counting how many wrong and right.
        /// </summary>
        private void StoreResults()
        {
            int rightCount = 0;
            int wrongCount = 0;

            foreach (var answer in quiz.Answers.AnswerList)
            {
                int? correctAnswer = answer.CorrectAnswerNum;
                int? selectedAnswer = answer.SelectedAnswer + 1;

                if (correctAnswer != null)
                {
                    if (correctAnswer == selectedAnswer)
                    {
                        answer.Results = Results.Right;
                        rightCount++;
                    }
                    else
                    {
                        answer.Results = Results.Wrong;
                        wrongCount++;
                    }

                    // TODO: If there is a correct answer and he didn't answer, set the state to answered. because we check later.
                    // Problem here that we don't have selected answer and switch case will fail later on btnNext.
                    answer.State = State.Answered;
                }
                else
                {
                    // If the correct answer is null results to noone of the answers are correct.
                    // So we check if the user selected one of the check boxes, and if he did, wrong, if not, right. 
                    // if user have a selected answer for that question.
                    if (selectedAnswer.In(0, 1, 2, 3)) // same as value == 0, value == 1... using extension method.
                    {
                        answer.Results = Results.Wrong;
                        wrongCount++;
                    }
                    else
                    {
                        // Right because no correct answer for that question and user didn't select any.
                        answer.Results = Results.Right;
                        rightCount++;
                    }
                }
            }
#if DEBUG
            MessageBox.Show(string.Format("{0} wrong and {1} right.", wrongCount, rightCount));
#endif
        }



        private void UpdateProgressBar()
        {
            if (cbCombo.Checked && alreadyChecked == false)
                progressBar.Value++;
            else if (cbCombo.Checked == false && alreadyChecked)
                progressBar.Value--;
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
            // TODO: Localize text.
            DialogResult dialog = MessageBox.Show("You are about to finish the exam, are you sure you want to continue?",
                "Finish Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                if (progressBar.Value != progressBar.Maximum)
                {
                    // TODO: Localize text.
                    DialogResult dialogResult = MessageBox.Show(
                            string.Format("Seems like you only answered {0} questions from {1}. To continue?",
                            progressBar.Value, progressBar.Maximum),
                            "WARNING",
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Warning);

                    if (dialogResult != DialogResult.Yes)
                        return;
                }
                // TODO: Store the results in database.
                StoreResults();
                QuizForm quizForm = new QuizForm(quiz);
                quizForm.Show();
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
            cbCombo.cbOption1.pbCheckBox.Click += cbOption_CheckedChanged;
            cbCombo.cbOption2.pbCheckBox.Click += cbOption_CheckedChanged;
            cbCombo.cbOption3.pbCheckBox.Click += cbOption_CheckedChanged;
            cbCombo.cbOption4.pbCheckBox.Click += cbOption_CheckedChanged;
        }


        private void cbOption_CheckedChanged(object sender, EventArgs e)
        {
            var tag = Convert.ToInt32(((PictureBox)sender).Tag);

            switch (tag)
            {
                case 0:
                    if (!cbCombo.cbOption1.Checked)
                    {
                        _checked[0] = false;
                        return;
                    }
                    CheckBox1ChangeState(EventHandlerEnum.KeyPress);
                    break;
                case 1:
                    if (!cbCombo.cbOption2.Checked)
                    {
                        _checked[1] = false;
                        return;
                    }
                    CheckBox2ChangeState(EventHandlerEnum.KeyPress);
                    break;
                case 2:
                    if (!cbCombo.cbOption3.Checked)
                    {
                        _checked[2] = false;
                        return;
                    }
                    CheckBox3ChangeState(EventHandlerEnum.KeyPress);
                    break;
                case 3:
                    if (!cbCombo.cbOption4.Checked)
                    {
                        _checked[3] = false;
                        return;
                    }
                    CheckBox4ChangeState(EventHandlerEnum.KeyPress);
                    break;
            }


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
        private int startY = 475;
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
                buttons[i].BackColor = SystemColors.HotTrack;
                buttons[i].ForeColor = Color.Azure;
                buttons[i].Font = new Font("Microsoft Sans Serif", 6.50F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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

                this.giladGradientPanel1.Controls.Add(buttons[i]);
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
