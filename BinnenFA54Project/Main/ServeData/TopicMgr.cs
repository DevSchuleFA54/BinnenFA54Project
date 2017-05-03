using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;
using BinnenFA54Project.Properties;

namespace BinnenFA54Project.Main.ServeData
{
    public class TopicMgr : QuizBase
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
#if SERVER_DATABASE  // See comment in QuizBase.
                var results = from   query in base.dbContext.T_Fragenbogen_Themas
                              select query;
#endif

#if LOCAL_DATABASE  // See comment in QuizBase.
                var results = from   query in base.localDbContext.T_Fragenbogen_Themas
                              select query;
#endif

                foreach (var result in results)
                {
                    _topicList.Add(new Topic()
                    {
                        Id          = result.FragebogenNr,
                        Name        = result.Thema,
                        Description = result.Beschreib
                    });
                }
            }
            catch (Exception)
            {
                // [InitializeTopicList] - Failed to retrieve data from the database!
                MessageBox.Show(
                    Resources.ResourceManager.GetString("ERR_TOPICLIST_DB"),
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


    }
}
