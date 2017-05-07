using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Main.ResourceData
{
    /// <summary>
    /// The structure of the Result class which will be used as list in the ResultMgr.
    /// </summary>
    public class Result
    {
        public int ExamNum { get; set; }
        public string ExamName { get; set; }
        public int Percent { get; set; }
        public bool Passed { get; set; }
        public string Date { get; set; }
    }
}
