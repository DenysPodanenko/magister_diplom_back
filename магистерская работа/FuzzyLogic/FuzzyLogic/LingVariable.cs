using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic
{
    public class LingVariable
    {
        private String name;
        private TermSet termSet;
        private static int count = 0;
        private int id;

        public LingVariable(String name, TermSet termSet)
        {
            this.name = name;
            this.termSet = termSet;
            this.id = LingVariable.count++;
        }


        public bool hasTerm(String term)
        {
            if (termSet.containsTerm(term))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Term getTerm(String termName)
        {
            return termSet.getTerm(termName);
        }

        public int getId()
        {
            return id;
        }

        public double getValueForTerm(Term term, double x)
        {
            return termSet.getFuncForTerm(term).getValue(x);
        }

        public String getName()
        {
            return name;
        }
    }
}
