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
        private AnswerMgr   _answers;

        private QuestionMgr _questions;

        private TopicMgr    _topics;

        private static int  _selectExam = 1;


        public QuizMgr()
        {
            _answers   = new AnswerMgr();
            _questions = new QuestionMgr();
            _topics    = new TopicMgr();
        }


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
