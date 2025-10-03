using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class QuestionList : List<Question>
    {
        private string fileName;
        public QuestionList(string _fileName)
        {
            fileName = _fileName;
        }

        public new void Add(Question question)
        {
            base.Add(question);

            using (StreamWriter writer = new StreamWriter(fileName, true)) 
            {
                writer.WriteLine(question.ToString());
                writer.WriteLine(); 
            }
        }
    }
}
