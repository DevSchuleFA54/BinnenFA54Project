using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinnenFA54Project.Forms;
using BinnenFA54Project.Main;
using BinnenFA54Project.Main.ServeData;

namespace BinnenFA54Project
{
    public partial class MainForm : Form
    {
        private QuizMgr _quizMgr = new QuizMgr();
        private QuizForm quizForm;
        private ConfigurationForm configurationForm;

        public MainForm()
        {
            InitializeComponent();
            InitializeTopicList();
        }

        private void InitializeTopicList()
        {
            for (int i = 0; i < _quizMgr.Topics.TopicList.Count; i++)
                cbQuizPicker.Items.Add(_quizMgr.Topics.TopicList[i].Name);

            cbQuizPicker.SelectedIndex = 0;
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            quizForm = new QuizForm();
            quizForm.Show();
        }


    }
}
