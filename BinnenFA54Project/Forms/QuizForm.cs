﻿using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ResourceData;
using BinnenFA54Project.Main.ServeData;
using GiladControllers;
using static BinnenFA54Project.Properties.Resources;

namespace BinnenFA54Project.Forms
{
    /// <summary>
    /// This is the Quiz form of the program which inherited from GiladForm part of the custom framework,
    /// in order to isolate the design code from the application it self.
    /// In this form we'll have the questions and images that we retrieve from the database. For production
    /// We'll need to change the build preprocessor to SERVER_DATABASE, but for local testing or simple usage
    /// use the LOCAL_DATABASE preprocessor.
    /// The progress will be updated every time an question is answered. We can also jump to a specific question
    /// by the buttons selector on the bottom of the form.
    /// After the exam is done, the same window will be displayed for revewing our exam which being called from
    /// the second constructor and when the form is closed, the results will be updated on the Main form.
    /// </summary>
    public partial class QuizForm : GiladForm
    {
        #region --- Variables -----------------------------------------------------------------
        QuizMgr quiz;
        private int qIndex = 0; // Question Indexer.
        private bool[] _checked; // Event handlers flag.
        private bool alreadyChecked;
        private bool reviewExam;
        private bool btnFinishClicked;
        private SettingIni setting;
        #endregion // Variables -----------------------------------------------------------------


        /// <summary>
        /// The first constructor will:
        /// 1. Initialize the UI components.
        /// 2. Load the setting model, QuizMgr-> builds the data structure which will call the database 
        /// to retrieve the questions and answers.
        /// 3. Register our event handlers for our CheckBoxes.
        /// 4. Generate the buttons selectors for jumping between questions.
        /// 5. Update the configuration in the UI from the Settings.ini.
        /// </summary>
        public QuizForm()
        {
#if !HIDE_LOADERS
            Loader.StartLoader(LoaderSelector.Loader);
            Thread.Sleep(3000);
#endif // !HIDE_LOADERS

            setting = new SettingIni();
            quiz = new QuizMgr();

            InitializeComponent();
            RegisterEventHandlers();
            GenerateQuestionSelectors();
            UpdateQuestions();
            SetFormConfiguration();


#if !HIDE_LOADERS
            Loader.StopLoader(this.Handle);
#endif // !HIDE_LOADERS
        }


        /// <summary>
        /// The second and last constructor will:
        /// 1. Initialize the UI components.
        /// 2. Retrieves the QuizMgr data when exam is finished so we display the results after all the flags that
        /// has been added, such as if question answered right or false or answered or not.
        /// 3. Set our exam in review mode by setting reviewExam to true.
        /// 4. Generate the buttons selectors for jumping between questions.
        /// 5. Update the questions results for the first question to be displayed.
        /// 6. Update the configuration in the UI from the Settings.ini.
        /// </summary>
        public QuizForm(QuizMgr quiz) // reviewing your exam answers mode.
        {
#if !HIDE_LOADERS
            Loader.StartLoader(LoaderSelector.Loader);
            Thread.Sleep(5000);
#endif // !HIDE_LOADERS

            setting = new SettingIni(); // reloading settings.
            reviewExam = true; // Set the window in review mode.
            _checked   = new bool[4];
            this.quiz  = quiz;

            InitializeComponent();
            GenerateQuestionSelectors();
            RenderQuestionResults(null);
            UpdateQuestions();
            SetFormConfiguration();


#if !HIDE_LOADERS
            Loader.StopLoader(this.Handle);
#endif // !HIDE_LOADERS
        }



        /// <summary>
        /// Reads all the values from the Settings.ini file and setting the UI values such as:
        /// application title, if app on top most(used for reviewing your students), control box on top
        /// right visible or not, Exam number and if the exam in review mode, it will remove the finish and
        /// progress bar controls from the UI and unsubscribe the events for checking checkboxes. 
        /// </summary>
        private void SetFormConfiguration()
        {
            this.Text = setting.ApplicationTitle;
            if (setting.OnTopMost) this.TopMost = true;
            if (!setting.UIControls) this.controlsBox.Visible = false;
            this.lblExamNum.Text = ResourceManager.GetString("EXAM_NUMBER") + QuizBase.SelectedTopic;
            if (!reviewExam) this.progressBar.Maximum = quiz.Questions.QuestionList.Count - 1;

            if (reviewExam)
            {
                this.btnFinish.Dispose();
                this.progressBar.Dispose();

                // Unregistering all the events in the sub controllers so the user will only review his exam.
                this.KeyPress -= QuizForm_KeyPress;
                this.cbCombo.ViewModeState = ControlViewMode.Inactive;
            }

        }


        /// <summary>
        /// Updated the next or forward question and if there is an image for that specific question, 
        /// display it in the picturebox.
        /// </summary>
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
        /// Before we set a question, we incrementing or decrementing the indexer for the questions
        /// so that way we know if a next or back button is clicked in order to the display the right question.
        /// And then we pass that indexer to the SetQuestionState.
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


        /// <summary>
        /// Receives an indexer from the RenderQuestionResults and checks the state of the question so 
        /// that way we can display the selected question if the user already selected before in case if 
        /// he wants to go back and changed his selected answer.
        /// In the sub switch statement we updating what is the selected answer and checking if it's in review mode.
        /// If it's in review mode, we display an image wether he got is right or not and showing the user 
        /// what is the right answer and what he checked.
        /// If he didn't check anything, we display him the correct answer when it's in review mode of course.
        /// </summary>
        /// <param name="index"></param>
        private void SetQuestionState(int index)
        {
            // TODO: OutOfRangeException on Exam 8, need to check that later.
            // TODO: Symptoms -> When the Count of the questions/answeres < 30.
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

                    int? correctAnswer = quiz.Answers.AnswerList[index].CorrectAnswerNum;

                    // If he already checked the checkbox before, we want to see which has been selected before
                    // with the flag we added on keypress or click on the checkboxes.
                    switch (quiz.Answers.AnswerList[index].SelectedAnswer)
                    {
                        case 0:
                            _checked[0] = true;
                            cbCombo.SelectCheckBoxIndex = 0;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].ResultsEnum != ResultsEnum.Right) // wrong answer.
                                {
                                    // Mark the selected cb with WrongSelect.
                                    cbCombo.cbOption1.WrongSelected = true;
                                    // Select the correct answer.
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    this.pbSmiley.Image = smiley_sad;

                                }
                                else
                                    this.pbSmiley.Image = smiley_happy;
                            }
                            break;
                        case 1:
                            _checked[1] = true;
                            cbCombo.SelectCheckBoxIndex = 1;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].ResultsEnum != ResultsEnum.Right)
                                {
                                    cbCombo.cbOption2.WrongSelected = true;
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    this.pbSmiley.Image = smiley_sad;
                                }
                                else
                                    this.pbSmiley.Image = smiley_happy;
                            }
                            break;
                        case 2:
                            _checked[2] = true;
                            cbCombo.SelectCheckBoxIndex = 2;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].ResultsEnum != ResultsEnum.Right)
                                {
                                    cbCombo.cbOption3.WrongSelected = true;
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    this.pbSmiley.Image = smiley_sad;
                                }
                                else
                                    this.pbSmiley.Image = smiley_happy;
                            }
                            break;
                        case 3:
                            _checked[3] = true;
                            cbCombo.SelectCheckBoxIndex = 3;
                            if (reviewExam)
                            {
                                if (quiz.Answers.AnswerList[index].ResultsEnum != ResultsEnum.Right)
                                {
                                    cbCombo.cbOption4.WrongSelected = true;
                                    if (correctAnswer != null)
                                        cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                                    this.pbSmiley.Image = smiley_sad;
                                }
                                else
                                    this.pbSmiley.Image = smiley_happy;
                            }
                            break;
                        default: // if no selected answer.
                            cbCombo.cbOption1.WrongAnswer = cbCombo.cbOption2.WrongAnswer =
                            cbCombo.cbOption3.WrongAnswer = cbCombo.cbOption4.WrongAnswer = true;
                            if (correctAnswer != null)
                                cbCombo.SelectCheckBoxIndex = (int)correctAnswer - 1;
                            this.pbSmiley.Image = smiley_upset;
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
                        answer.ResultsEnum = ResultsEnum.Right;
                        rightCount++;
                    }
                    else
                    {
                        answer.ResultsEnum = ResultsEnum.Wrong;
                        wrongCount++;
                    }

                    answer.State = State.Answered;
                }
                else
                {
                    // If the correct answer is null results to noone of the answers are correct.
                    // So we check if the user selected one of the check boxes, and if he did, wrong, if not, right. 
                    // if user have a selected answer for that question.
                    if (selectedAnswer.In(0, 1, 2, 3)) // same as value == 0, value == 1... using extension method.
                    {
                        answer.ResultsEnum = ResultsEnum.Wrong;
                        wrongCount++;
                    }
                    else
                    {
                        // Right because no correct answer for that question and user didn't select any.
                        answer.ResultsEnum = ResultsEnum.Right;
                        rightCount++;
                    }
                }
            }

            QuizBase.WrongAnswerCount = wrongCount;
            QuizBase.RightAnswerCount = rightCount;

#if DEBUG
            // {0} wrong and {1} right. 
            MessageBox.Show(string.Format(Regex.Unescape(ResourceManager.GetString("NOTIF_RESULTS")), 
                wrongCount, rightCount));
#endif
        }



        /// <summary>
        /// Update the progress bar depending if the user selected a question or not.
        /// </summary>
        private void UpdateProgressBar()
        {
            if (cbCombo.Checked && alreadyChecked == false && progressBar.Value < quiz.Questions.QuestionList.Count - 1)
                progressBar.Value++;
            else if (cbCombo.Checked == false && alreadyChecked)
                progressBar.Value--;
        }

        #region --------------- Events Handlers ---------------


        /// <summary>
        /// When the button next clicked, we update progress bar, rendering the question, incrementing the 
        /// indexer and also checking if we are in the last question so that we disable the button when we 
        /// reach to the end of the exam.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// When the button back clicked, we update progress bar, rendering the question, decrementing the 
        /// indexer and also checking if we are in the first question so that we disable the button when we 
        /// reach to the first question of the exam or enabling when it's not at the first question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// When a button finish is clicked, we checking wether all the questions has been answered and 
        /// displaying a warning window so the user can re-check his answers in case he missed something. 
        /// Then we store the results in our data structure and passing that object in the second constructor 
        /// which will start the quiz form again in a review mode.
        /// We also storing the results in the Results.ini which will display later in the user history on the
        /// MainForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Finish Exam
            // You are about to finish the exam, are you sure you want to continue?
            DialogResult dialog = MessageBox.Show(ResourceManager.GetString("NOTIF_FINISH_EXAM"),
                                                  ResourceManager.GetString("NOTIF_FINISH_EXAM_CP"), 
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                if (progressBar.Value != progressBar.Maximum)
                {
                    // WARNING
                    // Seems like you only answered {0} questions from {1}. To continue?
                    DialogResult dialogResult = MessageBox.Show(string.Format(Regex.Unescape(
                                                ResourceManager.GetString("NOTIF_NOT_ALL_ANSWERED")), progressBar.Value, progressBar.Maximum + 1),
                                                ResourceManager.GetString("WARNING"),
                                                MessageBoxButtons.YesNo, 
                                                MessageBoxIcon.Warning);

                    if (dialogResult != DialogResult.Yes)
                        return;
                }
                // @Gilad: Feature -> Store the results in database.

                StoreResults();
                
                
                string examName = string.Format(ResourceManager.GetString("EXAM") + QuizBase.SelectedTopic); // Exam
                int percent = (100 / quiz.Questions.QuestionList.Count) * QuizBase.RightAnswerCount;
                bool pass = percent > setting.PassedWithPercent;

                ResultsIni.SaveExamResults(examName, percent, pass);

                //new ResultsMgr().StoreResultsInDb(quiz); // NOT STABLE YET.
                new QuizForm(quiz).Show();
                btnFinishClicked = true;
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

        /// <summary>
        /// We generating here buttons programmatically with the amount of questions to be displayed on the bottom 
        /// of the form so the user can select or jump to a specific question.
        /// We also registering to each button an event of course so the right answer will be displayed when the user
        /// selects one of them.
        /// </summary>

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

                this.gradientPanel.Controls.Add(buttons[i]);
            }

        }

        /// <summary>
        /// Main event for the buttons selectors to display the answer that the user selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// When the form closes and it's in Review mode or not the button finish click, 
        /// we setting the MainForm visibility to true which will refresh the UI of the MainForm and display
        /// the results of the all the exams history.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (reviewExam || !btnFinishClicked)
                FormsBase.MainForm.Visible = true;
        }
    }
}
