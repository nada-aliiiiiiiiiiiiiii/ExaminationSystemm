using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal abstract class Exam
    {
        public int Time { get; set; }             
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswerDictionary { get; set; }

        public Subject Subject { get; set; }
        public Exam(int time, int numberOfQuestions, Subject subject)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
            QuestionAnswerDictionary = new Dictionary<Question, Answer>();
        }


        public abstract void ShowExam();

        public override string ToString()
        {
            return $" {Subject.Name} Exam   Duration: {Time} hours   {NumberOfQuestions} Questions";
        }


    }
}
