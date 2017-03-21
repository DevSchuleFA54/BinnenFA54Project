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
                var results = from   query in base.dbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedTopic
                              select query;

                foreach (var result in results)
                {
                    string[] optionsPackage = { result.Antwort1, result.Antwort2, result.Antwort3, result.Antwort4 };

                    _questionslist.Add(new Question()
                    {
                        Id = result.P_Id,
                        QuestionMeoww = result.Frage,
                        Options = optionsPackage,
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
