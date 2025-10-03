using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class ChooseAllQuestion :Question
    {

        public ChooseAllQuestion(string header, string body, int marks) : base(header, body, marks) { }
        public override void Display()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Header}: Choose All  ");
            Console.WriteLine($"{Body}   ({Marks})");


        }
    }
}
