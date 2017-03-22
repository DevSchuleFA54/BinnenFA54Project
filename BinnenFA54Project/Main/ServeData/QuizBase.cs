using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinnenFA54Project.Frameworks.Database;

namespace BinnenFA54Project.Main.ServeData
{
    /// <summary>
    /// Common data that all members share with.
    /// </summary>
    abstract class QuizBase
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
        private static int _selectTopic = 1;



        public static int SelectedTopic
        {
            get { return _selectTopic; }
            set { _selectTopic = value; }
        }
    }
}
