using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQQuestions : BaseQuestion
    {
        public MCQQuestions() 
        {
            AnswerList = new Answers[3];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                AnswerList[i] = new Answers();
            }
        }
    }
}
