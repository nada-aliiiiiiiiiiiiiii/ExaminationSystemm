using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks) : base(header, body, marks) { }
        public override void Display( )
        {
            Console.WriteLine("");

            Console.WriteLine( $"{Header}: ");
            Console.WriteLine($"{Body} true/false   ({Marks})");
        }


    }
}
