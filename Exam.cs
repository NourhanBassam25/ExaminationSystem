using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
       

        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        List<BaseQuestion> Questions { get; set; }
      
        public abstract void DisplayExam();

    }
}
