using System;
using System.Globalization;
using System.Threading;
using BinnenFA54Project.Forms;
using BinnenFA54Project.Frameworks.IniParser;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ServeData;
using GiladControllers;

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

            var myDicResults = ResultsIni.GetExamResults();
            for (int i = 1; i <= myDicResults.Count; i++)
                listBoxResults.Items.Add(myDicResults[i]);


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
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new ConfigurationForm().Show();
        }

    }
}
