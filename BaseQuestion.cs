using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class BaseQuestion
    {

        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark {  get; set; }
        public Answers[] AnswerList { get; set; }
        public int RightAnswer { get; set; }
      

        public BaseQuestion()
        {
            Header = string.Empty;
            Body = string.Empty;
            Mark = 0;
            AnswerList = new Answers[0] ;
            RightAnswer = 0;
          
        }

    }
}
