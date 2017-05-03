using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;
using BinnenFA54Project.Properties;

namespace BinnenFA54Project.Main.ServeData
{
    public class AnswerMgr : QuizBase
    {
        List<Answer> _answerList = new List<Answer>();
        private QuestionMgr _questionMgr = new QuestionMgr();

        public AnswerMgr()
        {
            InitializeAnswerList();
        }


        public List<Answer> AnswerList { get { return _answerList; } set { _answerList = value; } }


        private void InitializeAnswerList()
        {
            try
            {
#if SERVER_DATABASE // See comment in QuizBase.
                var results = from   query in base.dbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedTopic
                              select query;
#endif

#if LOCAL_DATABASE  // See comment in QuizBase.
                var results = from   query in base.localDbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedTopic
                              select query;
#endif

                // ToList because it's easier to manipulate it with for loop indexer comparing to IQueryable.
                var resultsList   = results.ToList();
                int resultsLength = results.Count();

                for (int i = 0; i < resultsLength; i++)
                {
                    // Since we doing some regex and parsing question, check if null.
                    // Because it throwed an error due to some useless row in db that is NULL.
                    if (resultsList[i].Frage == null) 
                    {

                        resultsLength--;
                        continue;
                    }

                    _answerList.Add(new Answer()
                    {
                        Id                = resultsList[i].P_Id,
                        CorrectAnswerText = GetText(i, resultsList[i].RichtigeAntwort),
                        CorrectAnswerNum  = resultsList[i].RichtigeAntwort
                    });
                }
            }
            catch (Exception)
            {
                // [InitializeAnswerList] - Failed to retrieve data from the database!
                MessageBox.Show(
                    Resources.ResourceManager.GetString("ERR_ANSWERLIST_DB"),
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string GetText(int index, int? option)
        {
            if (option != null)
                return _questionMgr.QuestionList[index].Options[(int)option - 1];
            
            // No correct answer.
            return Resources.ResourceManager.GetString("NO_ANSWER");
        }

    }
}
