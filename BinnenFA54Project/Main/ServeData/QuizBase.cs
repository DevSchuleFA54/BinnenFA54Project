using BinnenFA54Project.Frameworks.Database;

namespace BinnenFA54Project.Main.ServeData
{
    /// <summary>
    /// The base class of the data structure which all the sub managers class will be using.
    /// </summary>
    public abstract class QuizBase
    {
        // @Gilad: To define/use the SERVER_DATABASE go to:
        // Project -> Properties -> Build -> Conditional complition symbols
        // and change the name from LOCAL_DATABASE to SERVER_DATABASE
#if SERVER_DATABASE 
        protected DbDataContext dbContext = new DbDataContext();
#endif

#if LOCAL_DATABASE
        protected LocalDbDataContext localDbContext = new LocalDbDataContext();
#endif


        #region --- Variables -----------------------------------------------------------------

        private static int _selectTopic = 1;
        private static int _rightAnswerCount;
        private static int _wrongAnswerCount;

        #endregion // Variables -----------------------------------------------------------------


        /// <summary>
        /// Indexer for the selected Exam topic so when we serialize the data with the database calls in the
        /// sub managers classes, we call it with specific exam topic.
        /// </summary>
        public static int SelectedTopic
        {
            get { return _selectTopic; }
            set { _selectTopic = value; }
        }


        /// <summary>
        /// When exam finised, we store how many right answers were answered.
        /// </summary>
        public static int RightAnswerCount
        {
            get { return _rightAnswerCount; }

            set { _rightAnswerCount = value; }
        }


        /// <summary>
        /// When exam finised, we store how many wrong answers were answered.
        /// </summary>
        public static int WrongAnswerCount
        {
            get { return _wrongAnswerCount; }

            set { _wrongAnswerCount = value; }
        }
    }
}
