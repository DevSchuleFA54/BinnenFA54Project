using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinnenFA54Project.Forms;

namespace BinnenFA54Project.Main
{
    public class FormsBase
    {
        public static MainForm MainForm { get; set; } = new MainForm();
        public static QuizForm QuizForm { get; set; } = new QuizForm();
        public static ConfigurationForm ConfigurationForm { get; set; } = new ConfigurationForm();
    }

}
