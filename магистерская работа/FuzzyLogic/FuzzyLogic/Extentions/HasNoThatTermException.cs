using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Extentions
{
    public class HasNoThatTermException : Exception
    {
        public HasNoThatTermException()
        {

        }
        public HasNoThatTermException(string str) : base(str)
        {
        }
    }
}
