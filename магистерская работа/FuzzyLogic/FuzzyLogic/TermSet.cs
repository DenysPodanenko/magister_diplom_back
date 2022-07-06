using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.MembershipFunction;
namespace FuzzyLogic
{
    public class TermSet
    {
        private HashSet<Term> terms;

        public TermSet()
        {
            terms = new HashSet<Term>();
        }
        public void setTerm(String name, IAccessoryFunc func)
        {
            terms.Add(new Term(name, func));
        }

        public bool containsTerm(String termName)
        {
            IEnumerator<Term> iterator = terms.GetEnumerator();
            while (iterator.MoveNext())
            {
                Term term = iterator.Current;
                if (term.getName() == termName)
                {
                    return true;
                }
            }
            return false;
        }

        public Term getTerm(String termName)
        {
            IEnumerator<Term> iterator = terms.GetEnumerator();
            while (iterator.MoveNext())
            {
                Term term = iterator.Current;
                if (term.getName() == termName)
                {
                    return term;
                }
            }
            return null;
        }

        public IAccessoryFunc getFuncForTerm(Term x)
        {
            IEnumerator<Term> iterator = terms.GetEnumerator();
            while (iterator.MoveNext())
            {
                Term term = iterator.Current;
                if (term.Equals(x))
                {
                    return term.getAccessoryFunc();
                }
            }
            return null;
        }
    }
}
