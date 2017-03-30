using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Main.ResourceData
{
    public class Question
    {
        private string[] _options = new string[4];

        public int Id               { get; set; }
        public string QuestionMeoww { get; set; }
        public string[] Options
        {
            get { return _options; }
            set { _options = value; }
        }
        public Image SignImg { get; set; }
    }
}
