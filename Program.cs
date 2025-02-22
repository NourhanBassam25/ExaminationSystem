using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10, "c#");
            subject.NewExam();
            Console.Clear();

            Console.WriteLine("Do You Want to Start The Exam (y | n)");

            if (char.Parse(Console.ReadLine())== 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.Exam.DisplayExam();
                Console.WriteLine($"The elapsed time ={stopwatch.Elapsed}");

            }
        }
    }
}
