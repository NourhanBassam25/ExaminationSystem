using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Subject 
    {
        public Subject(int subjectId, string subjectName)
            {
            SubjectId = subjectId;
            SubjectName = subjectName;
            
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        
       

        DateTime startTime;

        List<BaseQuestion> Questions = new List<BaseQuestion>();

        List<int> Answers = new List<int>();

        public void NewExam()
        {
             int typeOfExam;
             int numberOfQuestions;
             int timeOfExam;
             int typeOfQuestion;
             int rightAnswer;

            startTime = DateTime.Now;

            do
            {

                Console.WriteLine($"Enter The Type Of Exam => \n1- Final \n2- Practical");
            }
            while (!int.TryParse(Console.ReadLine(), out typeOfExam));

            do
            {

                Console.WriteLine($"Enter The Number Of Questions");
            }
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions));

            do
            {

                Console.WriteLine($"Enter The Time Of Exam");
            }
            while (!int.TryParse(Console.ReadLine(), out timeOfExam));

          Console.Clear();


            if (typeOfExam == 1)
            {

                for (int i = 0; i < numberOfQuestions; i++)
                {
                   
                    do
                    {

                        Console.WriteLine($"Enter The The Type Of Question =>\n1- MCQ \n2- True Or False ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out typeOfQuestion));

                    Console.Clear();

                    if (typeOfQuestion == 1)
                    {
                        MCQQuestions mCQQuestions = new MCQQuestions();

                        mCQQuestions.Header = ("Choose one answer Question");
                        Console.WriteLine("Enter The Body of Question");
                        mCQQuestions.Body = Console.ReadLine();

                        Console.WriteLine("Enter The Choices of Questions");

                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Answer number{j + 1} => ");
                            string answer = Console.ReadLine();
                            mCQQuestions.AnswerList[j].AnswerText = answer;
                        }

                        int mark;


                        do
                        {

                            Console.WriteLine($"Enter The Mark");
                        }
                        while (!int.TryParse(Console.ReadLine(), out mark));


                        mCQQuestions.Mark = mark;

                        do
                        {

                            Console.WriteLine($"Enter The Right Answer");
                        }
                        while (!int.TryParse(Console.ReadLine(), out rightAnswer));


                        mCQQuestions.RightAnswer = rightAnswer;

                        Questions.Add(mCQQuestions);
                        Console.Clear();
                    }
                    else
                    {
                        TFQuestions tFQuestions = new TFQuestions();
                        tFQuestions.Header = ("True or False");


                        do
                        {

                            Console.WriteLine("Enter The Body of Question");
                            tFQuestions.Body = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(tFQuestions.Body));


                        int mark;
                        do
                        {

                            Console.WriteLine($"Enter The Mark");
                        }
                        while (!int.TryParse(Console.ReadLine(), out mark));


                        tFQuestions.Mark = mark;

                       
                        do
                        {

                            Console.WriteLine($"Enter The Right Answer => True Or False");
                        }
                        while (!int.TryParse(Console.ReadLine(), out rightAnswer));

                        tFQuestions.RightAnswer = rightAnswer;

                        Questions.Add(tFQuestions);
                        Console.Clear();
                    }
                }
            }

            else if (typeOfExam == 2)
            {
                for(int i = 0;i< numberOfQuestions;i++)
                {
                    MCQQuestions mCQQuestions = new MCQQuestions();

                    mCQQuestions.Header = ("Choose one answer Question");
                    Console.WriteLine("Enter The Body of Question");
                    mCQQuestions.Body = Console.ReadLine();

                    Console.WriteLine("Enter The Choices of Questions");

                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Answer number{j + 1} => ");
                        string answer = Console.ReadLine();
                        mCQQuestions.AnswerList[j].AnswerText = answer;
                    }

                    int mark;


                    do
                    {

                        Console.WriteLine($"Enter The Mark");
                    }
                    while (!int.TryParse(Console.ReadLine(), out mark));


                    mCQQuestions.Mark = mark;

                    int rirgtAnswer;
                    do
                    {

                        Console.WriteLine($"Enter The Right Answer");
                    }
                    while (!int.TryParse(Console.ReadLine(), out rightAnswer));


                    mCQQuestions.RightAnswer = rightAnswer;

                    Questions.Add(mCQQuestions);
                    Console.Clear();

                }

            }



                    
        }

       
        public void DisplayExam()
        {
            foreach(BaseQuestion baseQuestion in Questions)
            {
                Console.WriteLine(baseQuestion.Header);
                Console.WriteLine(baseQuestion.Body);
                Console.WriteLine($"Mark = {baseQuestion.Mark}");

                if(baseQuestion.Header == "True or False")

                    Console.WriteLine("1- True \n2- False");
                else
                {
                    for(int i = 0;i < 3; i++)
                    {
                        Console.WriteLine($"{i+1}- {baseQuestion.AnswerList[i].AnswerText}");
                    }
                }

                int answer = int.Parse(Console.ReadLine());

                Answers.Add(answer);
                Console.WriteLine(answer);
            }
            Console.Clear() ;
            Console.WriteLine("Your Answers => ");

            int yourGrade =0;
            int totalGrade =0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {i+1}- {Questions[i].Body} : ");
                if (Questions[i].RightAnswer == Answers[i])
                {
                    Console.WriteLine("True");
                    yourGrade = yourGrade + Questions[i].Mark;
                }
                else
                {
                    Console.WriteLine("False");
                    Console.WriteLine("Total Grade = 0");
                }

                totalGrade = totalGrade + Questions[i].Mark;
            }

            Console.WriteLine($"Grade = {yourGrade}/{totalGrade}");
            TimeSpan ElapsedTime = DateTime.UtcNow - startTime;
            Console.WriteLine($"Time = {ElapsedTime.TotalSeconds}");

        }


    }
}
