using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemm
{
    internal class Answer
    {
        public string Answerr {  get; set; }
        public bool Iscorrect {  get; set; }
        public Answer( string _answerr ,bool _iscorrect ) {
          Answerr = _answerr;
          Iscorrect = _iscorrect;
        }

        public override string ToString() { 
        
        return Answerr;
            
        }
    }
}
