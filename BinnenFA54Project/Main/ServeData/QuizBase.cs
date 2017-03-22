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
        protected DbDataContext dbContext = new DbDataContext();
        private static int _selectTopic = 1;



        public static int SelectedTopic
        {
            get { return _selectTopic; }
            set { _selectTopic = value; }
        }
    }
}
