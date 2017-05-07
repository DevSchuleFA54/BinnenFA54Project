using System;
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
    /// <summary>
    /// This is the main/parent form of the program which inherited from GiladForm part of the custom framework,
    /// in order to isolate the design code from the application it self.
    /// In this form we can select the exam we want and see the results of every exam that is done.
    /// </summary>
    public partial class MainForm : GiladForm
    {
        #region --- Variables -----------------------------------------------------------------
        private QuizMgr _quizMgr;
        private TopicMgr _topics;
        private QuizForm quizForm;
        private ConfigurationForm configurationForm;
        private SettingIni setting;
        #endregion // Variables -----------------------------------------------------------------


        /// <summary>
        /// The constructor will initialize the UI component, setting, topic list retrieved from the database,
        /// and icon in tray if enabled from settings.
        /// We also sending a reference pointer to the FormsBase so we can manipulate the mainform from 
        /// the child forms without the need of creating an instance of it. 
        /// </summary>
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



        /// <summary>
        /// Update the UI values such as title, company name, street, postcode and city
        /// from the Settings.ini file.
        /// </summary>
        private void InitializeSettings()
        {
            this.Text = setting.ApplicationTitle;
            lblCompanyName.Text  = setting.CompanyName;
            lblStreet.Text       = setting.StreetName;
            lblPostcodeCity.Text = setting.PostcodeAndCity + " " + setting.Country;
        }


        /// <summary>
        /// Updating the UI with the topic list by creating an instance of the TopicMgr model which will
        /// call the database to retrieve the topic list exams.
        /// </summary>
        private void InitializeTopicList()
        {
            // Creates and calls the db to initialize topics.
            _topics = new TopicMgr();

            foreach (var topic in _topics.TopicList)
                cbQuizPicker.Items.Add(topic.Name);

            // default selected item in combobox.
            cbQuizPicker.SelectedIndex = 0;
        }


        /// <summary>
        /// When the start exam button is clicked, this event will update the SelectedTopic in the QuizBase
        /// in order to let the data structure model in QuizMgr know what exam is selected and retrieve the 
        /// required questions for that specific exam which is being called on the constructor of the QuizForm.
        /// That way we load the application faster without waiting for the database communicate with the 
        /// application as soon as it started.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// This event will load the configuration form and before then, check if an instance of it already open,
        /// so when the it loads, it sets a reference pointer to the FormsBase so that way when we close the
        /// configuration form, we can update it statically in the FormsBase again as false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (FormsBase.ConfigurationInstanceOpened) return;
            FormsBase.ConfigurationInstanceOpened = true;
            new ConfigurationForm().Show();
        }


        /// <summary>
        /// As soon as visibility changes, we reload the quiz results list on the form so if the QuizForm in 
        /// reviewExam mode closes, then we get the updated results to be displayed.
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


        /// <summary>
        /// Initialize the Icon in tray configuration.
        /// Before we run this, we check in the settings if it's enabled or not.
        /// Creates some menues when we right click on the icon when it's state is minimized and registering 
        /// the events so when one of them clicked, they will be called.
        /// </summary>
        private void InitIconInTray()
        {
            if (!setting.IconInTray) return;

            // Sets the icon in tray icon.
            // Configuration, Open, Exit
            MenuItem configMI = new MenuItem(ResourceManager.GetString("MI_CONFIG"), ShowConfigForm);
            MenuItem openMI   = new MenuItem(ResourceManager.GetString("MI_OPEN"), notifyIcon_DoubleClick);
            MenuItem exitMI   = new MenuItem(ResourceManager.GetString("MI_EXIT"), Exit);


            this.notifyIcon.ContextMenu = new ContextMenu(new[] { configMI, openMI, exitMI });
            this.Resize += MainForm_Resize;
            this.notifyIcon.DoubleClick += notifyIcon_DoubleClick;
        }


        /// <summary>
        /// When the form resized, we hidding or showing the form and setting the visibility of icon in tray 
        /// to true and displaying the balloon tip which will notify the user that the application is minimized.
        /// Also Context Menu Event -> When Open option is clicked, it will display the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized) return;

            this.Hide();
            this.notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(700);
        }


        /// <summary>
        /// When clicking on the icon in tray on the bottom right, it will display the application again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon.Visible = false;
        }


        /// <summary>
        /// Context Menu Event -> When Exit option is clicked, application will be closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Context Menu Event -> When Configuration option is clicked, only the Configuration 
        /// Form will be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowConfigForm(object sender, EventArgs e)
        {
            new ConfigurationForm().Show();
        }


        #endregion Icon in Tray Events ----------------------------------------------------------


    }
}
