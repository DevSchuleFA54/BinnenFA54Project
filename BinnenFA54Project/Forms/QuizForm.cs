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
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project.Forms
{
    public partial class QuizForm : Form
    {
		// TODO: Create a progress bar to update when questions index changing.
        private QuestionMgr _questionMgr;
        private int questionIndexer = 0;

        public QuizForm()
        {
            InitializeComponent();

            _questionMgr = new QuestionMgr();
            //Thread.Sleep(1000); // TODO: create during that time loading indicator runs on another thread.
            UpdateQuestions();
        }


        private void UpdateQuestions()
        {
            lblQuestionIndexer.Text = (questionIndexer + 1).ToString(); // +1 because array starts from 0 while db from 1.
            lblQuestion.Text        = _questionMgr.QuestionList[questionIndexer].QuestionMeoww;
            cbCombo.CheckBox1Text   = _questionMgr.QuestionList[questionIndexer].Options[0];
            cbCombo.CheckBox2Text   = _questionMgr.QuestionList[questionIndexer].Options[1];
            cbCombo.CheckBox3Text   = _questionMgr.QuestionList[questionIndexer].Options[2];
            cbCombo.CheckBox4Text   = _questionMgr.QuestionList[questionIndexer].Options[3];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            questionIndexer++;


            if (questionIndexer > 0)
                btnBack.ButtonEnabled = true;

            if (questionIndexer == _questionMgr.QuestionList.Count - 1) // last question.
            {
                btnNext.ButtonEnabled = false;
                return;
            }

            UpdateQuestions();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            questionIndexer--;

            if (questionIndexer == 0)
                btnBack.ButtonEnabled = false;

            if (questionIndexer == _questionMgr.QuestionList.Count - 2)
                btnNext.ButtonEnabled = true;

            UpdateQuestions();
        }
    }
}
