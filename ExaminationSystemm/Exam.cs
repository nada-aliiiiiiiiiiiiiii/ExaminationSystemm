using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class Exam
    {
        public int Time { get; set; }             
        public int NumberOfQuestions { get; set; }
        public Subject Subject { get; set; }
        public Exam(int time, int numberOfQuestions, Subject subject)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
        }

    }
}
