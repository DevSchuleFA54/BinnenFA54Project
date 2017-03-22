using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;
using BinnenFA54Project.Properties;

namespace BinnenFA54Project.Main.ServeData
{
    class QuestionMgr : QuizBase
    {
        // Great way to debug regex pattern -> www.regexr.com
        private string regexPattern = @"\{[a-zA-Z]+([0-9]+)\.[a-zA-Z0-9]+\}";

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
                        QuestionMeoww = RegexCleanQuestion(result.Frage),
                        Options = optionsPackage,
                        SignImg = QuestionImage(result.Frage)
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


        private string RegexCleanQuestion(string question)
        {
            return Regex.Replace(question, regexPattern, String.Empty);
        }

        private Image QuestionImage(string question)
        {
            string fileName = "_" + Regex.Match(question, regexPattern).Groups[1];

            if (String.IsNullOrEmpty(fileName))
                return null;

            try
            {
                return (Bitmap)Resources.ResourceManager.GetObject(fileName);
            }
            catch (Exception)
            {
                Console.WriteLine("[QuestionMgr::RegexImageName] - Failed to retrieve image from resource or missing.");
                return null;
            }

        }

    }
}
