﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Forms;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project
{
    public partial class MainForm : Form
    {
        private QuizMgr _quizMgr;
        private TopicMgr _topics;
        private QuizForm quizForm;
        private ConfigurationForm configurationForm;
        private SettingIni setting;

        public MainForm()
        {
            setting = new SettingIni();

            InitializeComponent();
            InitializeSettings();

            InitializeTopicList();
        }

        private void InitializeSettings()
        {
            lblAppTitle.Text     = setting.ApplicationTitle;
            lblCompanyName.Text  = setting.CompanyName;
            lblStreet.Text       = setting.StreetName;
            lblPostcodeCity.Text = setting.PostcodeAndCity + " " + setting.Country;
        }

        private void InitializeTopicList()
        {
            // Creates and calls the db to initialize topics.
            _topics = new TopicMgr();

            foreach (var topic in _topics.TopicList)
                cbQuizPicker.Items.Add(topic.Name);

            // default selected item in combobox.
            cbQuizPicker.SelectedIndex = 0;
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            // db based 1 value while CB based 0.
            QuizBase.SelectedTopic = cbQuizPicker.SelectedIndex + 1;

            // Updating staticly the topics in the QuizMgr.Topics so we have 
            // better control instead of creating another instance in memory.
            QuizMgr.Topics = _topics;

            quizForm = new QuizForm();
            quizForm.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            configurationForm = new ConfigurationForm();
            configurationForm.Show();
        }



    }
}
