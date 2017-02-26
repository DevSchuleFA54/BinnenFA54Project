﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnenFA54Project.Main.ResourceData
{
    class Topic
    {
        public int Id                 { get; set; }
        public string Name            { get; set; }
        public string Description     { get; set; }
        public byte? CorrectAnswerNum { get; set; }
    }
}
