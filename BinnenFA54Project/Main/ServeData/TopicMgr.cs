using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;

namespace BinnenFA54Project.Main.ServeData
{
    class TopicMgr : QuizBase
    {
        List<Topic> _topicList = new List<Topic>();

        public TopicMgr()
        {
            InitializeTopicList();
        }

        public List<Topic> TopicList { get { return _topicList; } set { _topicList = value; } }


        private void InitializeTopicList()
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
