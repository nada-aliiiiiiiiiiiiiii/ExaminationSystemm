using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class ChooseOneQuestion :Question
    {

        public ChooseOneQuestion(string header, string body, int marks) : base(header, body, marks) { }
        public override void Display()
        {
            Console.WriteLine("");

            Console.WriteLine($"{Header}: Choose One ");
            Console.WriteLine($"{Body}   ({Marks})");

        }
    }
}
