﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameLibrary
{
    public class Questions
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        public int CorrectAns { get; set; }
    }
}
