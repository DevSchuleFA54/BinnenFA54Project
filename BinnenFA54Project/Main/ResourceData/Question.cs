using System.Drawing;

namespace BinnenFA54Project.Main.ResourceData
{
    /// <summary>
    /// The structure of the Question class which will be used as list in the QuestionMgr.
    /// </summary>
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
