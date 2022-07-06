using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic
{
    public class Conclusion : Statement
    {
        public double weight;
        public Conclusion(string name, double weight, string termName) : base(name, termName)
        {
           
            this.weight = weight;
        }

        public Term getTerm()
        {
            return base.getTerm();
        }
        public double getWeight()
        {
            return this.weight;
        }
    }
}
