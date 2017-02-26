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
                // DB Call.
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "[GetAllExams] - Failed to retrieve data from the database!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
