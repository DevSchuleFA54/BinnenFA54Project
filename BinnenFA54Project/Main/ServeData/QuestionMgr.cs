using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;
using static BinnenFA54Project.Properties.Resources;

namespace BinnenFA54Project.Main.ServeData
{
    /// <summary>
    /// The QuestionMgr class will serialize the data into the QuestionList from the data we retrieving from 
    /// the database.
    /// </summary>
    public class QuestionMgr : QuizBase
    {
        #region --- Variables -----------------------------------------------------------------

        // Great way to debug regex pattern -> www.regexr.com
        private string regexPattern = @"\{[a-zA-Z]+([0-9]+)\.[a-zA-Z0-9]+\}";

        #endregion // Variables -----------------------------------------------------------------


        /// <summary>
        /// This list will store all the values that serialized from the database.
        /// </summary>
        List<Question> _questionslist = new List<Question>();


        /// <summary>
        /// The constructor will call the InitializeQuestionList which will call the database.
        /// </summary>
        public QuestionMgr()
        {
            InitializeQuestionList();
        }


        /// <summary>
        /// This list will store all the values that serialized from the database.
        /// </summary>
        public List<Question> QuestionList { get { return _questionslist; } set { _questionslist = value; } }


        /// <summary>
        /// This list will store all the values that serialized from the database.
        /// </summary>
        private void InitializeQuestionList()
        {
            try
            {
#if SERVER_DATABASE  // See comment in QuizBase.
                var results = from   query in base.dbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedTopic
                              select query;
#endif

#if LOCAL_DATABASE  // See comment in QuizBase.
                var results = from   query in base.localDbContext.View_Topics_And_Questions
                              where  query.FragebogenNr == SelectedTopic
                              select query;
#endif

                foreach (var result in results)
                {
                    if (result.Frage == null) continue; // See comment in AnswerMgr line 45.

                    string[] optionsPackage = { result.Antwort1, result.Antwort2, result.Antwort3, result.Antwort4 };

                    _questionslist.Add(new Question()
                    {
                        Id            = result.P_Id,
                        QuestionMeoww = RegexCleanQuestion(result.Frage),
                        Options       = optionsPackage,
                        SignImg       = QuestionImage(result.Frage)
                    });
                }
            }
            catch (Exception)
            {
                // [InitializeQuestionList] - Failed to retrieve data from the database!
                MessageBox.Show(
                    ResourceManager.GetString("ERR_QUESTIONLIST_DB"),
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// We receive sometimes question with curly brackets with the image name, so we clean out the
        /// {} and returning a clean question text.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        private string RegexCleanQuestion(string question)
        {
            return Regex.Replace(question, regexPattern, String.Empty);
        }


        /// <summary>
        /// Some of questions have images in their name as string {123.gif}, so we get that string name
        /// by the power of regex and fill the question with an image by calling the resource.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        private Image QuestionImage(string question)
        {
            string fileName = "_" + Regex.Match(question, regexPattern).Groups[1];

            if (String.IsNullOrEmpty(fileName))
                return null;

            try
            {
                return (Bitmap)ResourceManager.GetObject(fileName);
            }
            catch (Exception)
            {
                // [QuestionMgr::RegexImageName] - Failed to retrieve image from resource or missing.
                Console.WriteLine(ResourceManager.GetString("ERR_QUESTIONLIST_IMG"));
                return null;
            }

        }

    }
}
