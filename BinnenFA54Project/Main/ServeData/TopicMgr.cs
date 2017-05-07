using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BinnenFA54Project.Main.ResourceData;
using static BinnenFA54Project.Properties.Resources;

namespace BinnenFA54Project.Main.ServeData
{

    /// <summary>
    /// The TopicMgr class will serialize the data into the QuestionList from the data we retrieving from 
    /// the database.
    /// </summary>
    public class TopicMgr : QuizBase
    {
        List<Topic> _topicList = new List<Topic>();

        /// <summary>
        /// The constructor will call the InitializeTopicList which will call the database.
        /// </summary>
        public TopicMgr()
        {
            InitializeTopicList();
        }


        /// <summary>
        /// This list will store all the values that serialized from the database.
        /// </summary>
        public List<Topic> TopicList { get { return _topicList; } set { _topicList = value; } }


        /// <summary>
        /// We call the database to retrieve the topic list data and serialize everything into our
        /// TopicList object.
        /// </summary>
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
                    ResourceManager.GetString("ERR_TOPICLIST_DB"),
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


    }
}
