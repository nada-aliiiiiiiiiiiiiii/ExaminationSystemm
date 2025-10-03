using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal abstract class Question
    {
       public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public AnswerList Answers { get; set; } = new AnswerList();


        public Question(string _header, string _body, int _marks)
        {
            Header = _header;
            Body = _body;
            Marks = _marks;
        }

        public abstract void Display();

        public override string ToString()
        {
            return $"{Header}: {Body}  (Marks: {Marks})";
        }
    }
}
