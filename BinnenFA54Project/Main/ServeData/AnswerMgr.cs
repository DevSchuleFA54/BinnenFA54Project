﻿using System;
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
                var resultsList = results.ToList();
                int resultsLength = results.Count();

                for (int i = 0; i < resultsLength; i++)
                {
                    _answerList.Add(new Answer()
                    {
                        Id = resultsList[i].P_Id,
                        CorrectAnswerText = GetText(i, resultsList[i].RichtigeAntwort),
                        CorrectAnswerNum = resultsList[i].RichtigeAntwort
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

        private string GetText(int index, int? option)
        {
            if (option != null)
                return QuizMgr.Questions.QuestionList[index].Options[(int)option - 1];

            return "Keine Richtige Antwort.";
        }

    }
}
