using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Extentions;
namespace FuzzyLogic
{
    public class Statement
    {
        private static Dictionary<string, LingVariable> variables;
        private LingVariable lingVariable;
        private Term term;

        public static void setLingVariables(Dictionary<string, LingVariable> variables)
        {
            Statement.variables = variables;
        }

        public Statement(String variableName, String termName)
        {
            if (!variables.ContainsKey(variableName))
            {
                throw new HasNoThatVariableException();
            }
            if (!variables[variableName].hasTerm(termName))
            {
                throw new HasNoThatTermException(variableName + ":" + termName);
            }
            this.lingVariable = variables[variableName];
            this.term = variables[variableName].getTerm(termName);
        }

        public int getVariableId()
        {
            return lingVariable.getId();
        }

        public LingVariable getLingVariable()
        {
            return lingVariable;
        }

        public Term getTerm()
        {
            return term;
        }
    }
}
