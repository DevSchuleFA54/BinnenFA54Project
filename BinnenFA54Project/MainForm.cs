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
            InitializeTopicList();
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








        private void exit_MainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximize_MainForm_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void minimize_MainForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
