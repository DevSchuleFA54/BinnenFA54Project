using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;

namespace BinnenFA54Project.Main.ServeData
{
    class AnswerMgr : QuizBase
    {
        List<Answer> _answerList = new List<Answer>();

        public AnswerMgr()
        {
            InitializeAnswerList();
        }


        public List<Answer> AnswerList { get { return _answerList; } set { _answerList = value; } }


        private void InitializeAnswerList()
        {
            try
            {
                var results = from   query in base.dbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedExam
                              select query;

                foreach (var result in results)
                {
                    _answerList.Add(new Answer()
                    {
                        Id               = result.P_Id,
                        CorrectAnswerNum = result.RichtigeAntwort
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "[InitializeAnswerList] - Failed to retrieve data from the database!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
