using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project.Main
{
    class QuizMgr
    {
        AnswerMgr _answers = new AnswerMgr();

        QuestionMgr _questions = new QuestionMgr();

        TopicMgr _topics = new TopicMgr();

        private static int _selectExam = 1;





        public AnswerMgr Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        public QuestionMgr Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public TopicMgr Topics
        {
            get { return _topics; }
            set { _topics = value; }
        }

        protected static int SelectedExam
        {
            get { return _selectExam; }
            set { _selectExam = value; }
        }
    }
}
