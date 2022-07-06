using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Extentions
{
    public class MamdaniException : Exception
    {
        public MamdaniException()
        {

        }
        public MamdaniException(string str) : base(str)
        {
        }
    }
}
