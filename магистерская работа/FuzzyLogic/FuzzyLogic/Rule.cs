using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic
{
    public class Rule 
    {
        private static int numberOfConditions;
        private static int numberOfConclusions;
        List<Condition> conditions;
        Conclusion conclusion;

        public void setConditions(List<Condition> conditions)
        {
            this.conditions = new List<Condition>();
            this.conditions.AddRange(conditions);
            Rule.numberOfConditions += conditions.Count;
        }

        public void setConclusion(Conclusion conclusion)
        {
            this.conclusion = conclusion;
            Rule.numberOfConclusions++;
        }

        public static int getNumberOfConditions()
        {
            return numberOfConditions;
        }

        public static int getNumberOfConclusions()
        {
            return numberOfConclusions;
        }

        public List<Condition> getConditions()
        {
            return conditions;
        }

        public Conclusion getConclusion()
        {
            return conclusion;
        }
    }
}
