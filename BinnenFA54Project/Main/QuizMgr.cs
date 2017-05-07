using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project.Main
{
    /// <summary>
    /// This is our main entry to build the whole data structure when we instantiating this class.
    /// The constructor will build the QuestionMgr and AnswerMgr which will call the database and fill
    /// our objects with the questions and answers from the database.
    /// </summary>
    public class QuizMgr
    {

        #region --- Variables -----------------------------------------------------------------
        private QuestionMgr _questions;
        private AnswerMgr _answers;
        private static TopicMgr _topics;
        #endregion // Variables -----------------------------------------------------------------


        /// <summary>
        /// The constructor builds the QuestionMgr and AnswerMgr which will call the database and fill 
        /// the objects which the data we need from the database.
        /// </summary>
        public QuizMgr()
        {
            _questions = new QuestionMgr();
            _answers = new AnswerMgr();
        }


        #region --- Properties -----------------------------------------------------------------
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
        #endregion // Properties -----------------------------------------------------------------


    }
}
