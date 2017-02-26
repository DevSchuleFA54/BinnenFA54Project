using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;

namespace BinnenFA54Project.Main.ServeData
{
    class QuestionMgr : QuizBase
    {
        List<Question> _questionslist = new List<Question>();

        public QuestionMgr()
        {
            InitializeQuestionList();
        }


        public List<Question> QuestionList { get { return _questionslist; } set { _questionslist = value; } }


        private void InitializeQuestionList()
        {
            try
            {
                var results = from   query in this.dbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedExam
                              select query;

                foreach (var result in results)
                {
                    _questionslist.Add(new Question()
                    {
                        Id            = result.P_Id,
                        QuestionMeoww = result.Frage,
                        Option1       = result.Antwort1,
                        Option2       = result.Antwort2,
                        Option3       = result.Antwort3,
                        Option4       = result.Antwort4
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "[InitializeQuestionList] - Failed to retrieve data from the database!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
