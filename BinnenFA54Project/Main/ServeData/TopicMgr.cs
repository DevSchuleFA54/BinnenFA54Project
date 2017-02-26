﻿using System;
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
                var results = from   query in this.dbContext.T_Fragenbogen_Themas
                              select query;

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
                MessageBox.Show(
                    "[InitializeTopicList] - Failed to retrieve data from the database!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


    }
}
