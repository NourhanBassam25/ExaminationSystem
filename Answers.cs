using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get;set; }

        public Answers()
        {
            AnswerId = 0;
            AnswerText = string.Empty;
        }
        
    }
}
