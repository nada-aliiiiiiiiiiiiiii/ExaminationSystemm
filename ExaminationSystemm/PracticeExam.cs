using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class PracticeExam :Exam
    {
        public PracticeExam(int time, int numberOfQuestions, Subject subject) : base(time, numberOfQuestions, subject) { }
        public override void ShowExam()
        {
            Console.WriteLine("------------------------Practical Exam--------------------------");
            Console.WriteLine(this.ToString());
            Console.WriteLine("--------------------------------------------------");
            foreach (var Ques in QuestionAnswerDictionary)
            {
                Question q = Ques.Key;
                Answer studentAnswer = Ques.Value;


                q.Display();

                foreach (var ans in q.Answers)
                {
                    Console.WriteLine($" - {ans.Answerr}");
                }


                Console.WriteLine($"Your Answer: {studentAnswer.Answerr}");

                    Console.WriteLine("Correct Answer(s):");
                foreach (var ans in q.Answers)
                {
                    if (ans.Iscorrect)
                        Console.WriteLine($" - {ans.Answerr}");
                }

                Console.WriteLine("");
            }
        }
    }
}
