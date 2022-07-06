using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.Set
{
    public class UnionOfTermSet
    {
        List<Term> unionOfTermSet;

        public UnionOfTermSet(int i)
        {
            unionOfTermSet = new List<Term>(i);
        }

        public double getMaxValue(double x)
        {
            double y = 0.0;
            foreach(Term term in unionOfTermSet)
            {
                y = Math.Max(y, term.getActivatedValue(x));
            }
            return y;
        }

        public void add(Term term)
        {
            unionOfTermSet.Add(term);
        }
    }
}
