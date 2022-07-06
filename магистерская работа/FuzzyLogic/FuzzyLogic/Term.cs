using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.MembershipFunction;
namespace FuzzyLogic
{
    public class Term
    {
        private String name;
        private IAccessoryFunc accessoryFunc;

        public Term(String name, IAccessoryFunc func)
        {
            this.name = name;
            this.accessoryFunc = func;
        }

        public String getName()
        {
            return name;
        }

        public IAccessoryFunc getAccessoryFunc()
        {
            return accessoryFunc;
        }

        public Term copyTerm()
        {
            Term term = new Term(this.name, accessoryFunc.copyFunc());
            return term;
        }

        public void setActivatedValue(double x)
        {
            accessoryFunc.setActivatedValue(x);
        }

        public double getActivatedValue(double x)
        {
            return accessoryFunc.getActivatedValue(x);
        }

    }
}
