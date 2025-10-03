using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class Subject
    {
        public string Name {  get; set; }
        public Subject(string _name)
        {
            Name = _name;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
