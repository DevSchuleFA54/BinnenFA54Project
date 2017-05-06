﻿using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using BinnenFA54Project.Forms;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ServeData;
using GiladControllers;
using static BinnenFA54Project.Properties.Resources;

namespace BinnenFA54Project
{
    public partial class MainForm : GiladForm
    {

        private QuizMgr _quizMgr;
        private TopicMgr _topics;
        private QuizForm quizForm;
        private ConfigurationForm configurationForm;
        private SettingIni setting;


        public MainForm()
        {
#if !HIDE_LOADERS
            Loader.StartLoader(LoaderSelector.MainAppLoader);
            Thread.Sleep(3000); // keeps the fancy splash bar up for a bit
#endif // !HIDE_LOADERS

            setting = new SettingIni();
            InitializeComponent();
            InitializeSettings();
            InitializeTopicList();
            InitIconInTray();

            FormsBase.MainForm = this; // holds a reference pointer in FormsBase.

            #region Work in Progress.
            // NOT STABLE YET!!!
            // Example:
            //listBox1.Items.Add("Fragenbogen 3 - 50% - nicht bestanden");
            //listBox1.Items.Add("Fragenbogen 7 - 83% - bestanden");
            //listBox1.Items.Add("Fragenbogen 1 - 64% - nicht bestanden");
            //listBox1.Items.Add("Fragenbogen 12 - 72% - bestanden");
            //ResultsMgr resultMgr = new ResultsMgr(true);
            //if (resultMgr.ResultsList != null)
            //{
            //    foreach (var result in resultMgr.ResultsList)
            //    {
            //        listBox1.Items.Add(
            //            string.Format("{0}-{1}-{2}", result.ExamName, result.Percent, result.Passed.ToString()));
            //    }
            //}
            #endregion Work in Progress.
#if !HIDE_LOADERS
            Loader.StopLoader(this.Handle); // stops the splash screen.
#endif // !HIDE_LOADERS
        }


        private void InitializeSettings()
        {
            this.Text = setting.ApplicationTitle;
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


            new QuizForm().Show();
            this.Visible = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (FormsBase.ConfigurationInstanceOpened) return;
            FormsBase.ConfigurationInstanceOpened = true;
            new ConfigurationForm().Show();
        }


        /// <summary>
        /// As soon as visibility changes, we reload the quiz results list 
        /// on the form so if the QuizForm in reviewExam mode closes, then 
        /// we get the updated results to be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            var myDicResults = ResultsIni.GetExamResults();
            for (int i = 1; i <= myDicResults.Count; i++)
                listBoxResults.Items.Add(myDicResults[i]);
        }


        #region --- Icon in Tray Stuff ----------------------------------------------------------

        private void InitIconInTray()
        {
            if (!setting.IconInTray) return;

            // Sets the icon in tray icon.
            // Configuration, Open, Exit
            MenuItem configMI = new MenuItem(ResourceManager.GetString("MI_CONFIG"), ShowConfigForm);
            MenuItem openMI   = new MenuItem(ResourceManager.GetString("MI_OPEN"), Open);
            MenuItem exitMI   = new MenuItem(ResourceManager.GetString("MI_EXIT"), Exit);


            this.notifyIcon.ContextMenu = new ContextMenu(new[] { configMI, openMI, exitMI });
            this.Resize += MainForm_Resize;
            this.notifyIcon.DoubleClick += notifyIcon_DoubleClick;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized) return;

            this.Hide();
            this.notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(700);
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon.Visible = false;
        }

        private void Open(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon.Visible = false;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowConfigForm(object sender, EventArgs e)
        {
            new ConfigurationForm().Show();
        }


        #endregion Icon in Tray Events ----------------------------------------------------------


    }
}
