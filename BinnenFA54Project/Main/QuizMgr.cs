using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project.Main
{
    /// <summary>
    /// 
    /// </summary>
    public class QuizMgr
    {
        private QuestionMgr _questions;
        private AnswerMgr _answers;
        private static TopicMgr _topics;


        public QuizMgr()
        {
            _questions = new QuestionMgr();
            _answers = new AnswerMgr();
        }


        public QuestionMgr Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }

        public AnswerMgr Answers
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
