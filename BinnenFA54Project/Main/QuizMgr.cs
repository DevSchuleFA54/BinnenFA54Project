using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project.Main
{
    /// <summary>
    /// Manageable class to access these objects statictly and creates the data structur.
    /// It shouldn't be instantiated more than once, so it is recommened creating an instance
    /// of it in the main function.
    /// For that purpose we have static properties to access those objects from anywhere.
    /// </summary>
    class QuizMgr
    {
        private static QuestionMgr _questions;
        private static AnswerMgr _answers;
        private static TopicMgr _topics;


        public QuizMgr()
        {
            _questions = new QuestionMgr();
            _answers = new AnswerMgr();
        }


        public static QuestionMgr Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public static AnswerMgr Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        public static TopicMgr Topics
        {
            get { return _topics; }
            set { _topics = value; }
        }

    }
}
