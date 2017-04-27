using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Frameworks.Database;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main.ResourceData;

namespace BinnenFA54Project.Main.ServeData
{

    /// <summary>
    /// Builded this class in order to access the necessary data for previewing exam with all information
    /// just as viewing the exam in preview mode after finish.
    /// Not stable yet.
    /// </summary>
    public class ResultsMgr : QuizBase
    {
        private static SettingIni setting;
        private List<Result> resultsList;

        public List<Result> ResultsList { get; set; }


        public ResultsMgr()
        {
        }

        public ResultsMgr(bool toInitList)
        {
            resultsList = new List<Result>();

            InitResultList();
        }


        private void InitResultList()
        {

            var results = from query in base.localDbContext.EXAM_RESULTs
                          select new { query.pExamNum, query.examDesc, query.sPercent, query.sPassOrNot, query.date};

            foreach (var examResult in results)
            {
                resultsList.Add(new Result()
                {
                    ExamNum = examResult.pExamNum,
                    ExamName = examResult.examDesc,
                    Percent = examResult.sPercent,
                    Passed = examResult.sPassOrNot,
                    Date = examResult.date
                });
            }
        }


        public void StoreResultsInDb(QuizMgr quizMgr)
        {
            setting = new SettingIni();

            // Need to find more effecient way, so this is just temproray to get things working.
            for (int i = 0; i < quizMgr.Questions.QuestionList.Count; i++)
            {
                EXAM_RESULT ex       = new EXAM_RESULT();
                ex.pExamNum          = SelectedTopic;
                ex.examDesc          = QuizMgr.Topics.TopicList[SelectedTopic].Name;
                ex.sPercent          = EvaluateExamPercent(quizMgr.Questions.QuestionList.Count);
                ex.sPassOrNot        = ex.sPercent > setting.PassedWithPercent; // default 70                
                ex.question          = quizMgr.Questions.QuestionList[i].QuestionMeoww; 
                ex.answer1           = quizMgr.Questions.QuestionList[i].Options[0];
                ex.answer2           = quizMgr.Questions.QuestionList[i].Options[1];
                ex.answer3           = quizMgr.Questions.QuestionList[i].Options[2];
                ex.answer4           = quizMgr.Questions.QuestionList[i].Options[3];
                ex.correctAnswerNum  = (byte?) quizMgr.Answers.AnswerList[i].CorrectAnswerNum;
                ex.selectedAnswerNum = (byte?) quizMgr.Answers.AnswerList[i].SelectedAnswer;
                ex.noSelectedAnswer  = quizMgr.Answers.AnswerList[i].State == State.Waiting;
                ex.date              = DateTime.Now.ToString(setting.DateFormat);
                // temp random num until we create real session id.
                ex.UserSession       = 300;
                ex.pId = i;
                
                localDbContext.EXAM_RESULTs.InsertOnSubmit(ex);
            }

            localDbContext.SubmitChanges();
        }

        private int EvaluateExamPercent(int questionCount)
        {
            return (100/questionCount) * RightAnswerCount;
        }
    }
}
