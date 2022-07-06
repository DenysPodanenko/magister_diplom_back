using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Set;
using FuzzyLogic.MembershipFunction;
namespace FuzzyLogic
{
    class Program
    {
        private static Dictionary<string, LingVariable> variables;
        private static List<Rule> rules;
        private static UnionOfTermSet unionOfTerms;
        static void Main(string[] args)
        {
            loadVariables();
            loadRules();
            double[] b = fuzzification(new double[] { -2, 7, -8, 1.75, 17 });
            double[] c = aggregation(b);
            unionOfTerms = composition(c);

            for (double x = -3.0; x <= 3.0; x += 0.01)
            {
               Console.WriteLine(x + " : " + unionOfTerms.getMaxValue(x) + " ");
            }
            Console.WriteLine(integrate(-3, 3, unionOfTerms));
            Console.WriteLine(integrate1(-3, 3, unionOfTerms));
            Console.ReadLine();
        }
        private static void loadVariables()
        {
            variables = new Dictionary<string, LingVariable>();

            TermSet ts1 = new TermSet();
            ts1.setTerm("БС", new GaussFunc(2.55, -6));
            ts1.setTerm("ОС", new GaussFunc(2.55, 0));
            ts1.setTerm("КС", new GaussFunc(2.55, 6));
            LingVariable x1 = new LingVariable("input1", ts1);
            variables.Add("X1", x1);

            TermSet ts2 = new TermSet();
            ts2.setTerm("СП", new GaussFunc(4.25, -15));
            ts2.setTerm("П", new GaussFunc(4.25, -5));
            ts2.setTerm("В", new GaussFunc(4.25, 5));
            ts2.setTerm("СВ", new GaussFunc(4.25, 15));
            LingVariable x2 = new LingVariable("input2", ts2);
            variables.Add("X2", x2);

            TermSet ts3 = new TermSet();
            ts3.setTerm("Л", new GaussFunc(2.76, -13));
            ts3.setTerm("ВП", new GaussFunc(2.76, -6.5));
            ts3.setTerm("С", new GaussFunc(2.76, 0));
            ts3.setTerm("НП", new GaussFunc(2.76, 6.5));
            ts3.setTerm("А", new GaussFunc(2.76, 13));
            LingVariable x3 = new LingVariable("input3", ts3);
            variables.Add("X3", x3);

            TermSet ts4 = new TermSet();
            ts4.setTerm("АНД", new GaussFunc(0.7, -2));
            ts4.setTerm("НД", new GaussFunc(0.7, -0.33));
            ts4.setTerm("ПР", new GaussFunc(0.7, 1.33));
            ts4.setTerm("АПР", new GaussFunc(0.7, 3));
            LingVariable x4 = new LingVariable("input4", ts4);
            variables.Add("X4", x4);

            TermSet ts5 = new TermSet();
            ts5.setTerm("ПЗ", new GaussFunc(8.55, -20));
            ts5.setTerm("Р", new GaussFunc(8.55, 0));
            ts5.setTerm("РЗ", new GaussFunc(8.55, 20));
            LingVariable x5 = new LingVariable("input5", ts5);
            variables.Add("X5", x5);

            TermSet ts6 = new TermSet();
            ts6.setTerm("КП", new GaussFunc(0.64, -3));
            ts6.setTerm("П", new GaussFunc(0.44, -0.9));
            ts6.setTerm("Н", new GaussFunc(0.44, 0));
            ts6.setTerm("В", new GaussFunc(0.44, 0.9));
            ts6.setTerm("КВ", new GaussFunc(0.64, 3));
            LingVariable y = new LingVariable("output", ts6);
            variables.Add("Y", y);
        }
        private static void loadRules()
        {
            Statement.setLingVariables(variables);
            rules = new List<Rule>();

            Rule r1 = new Rule();
            r1.setConditions(new List<Condition> { new Condition("X1", "БС"), new Condition("X2", "СВ"), new Condition("X3", "Л"), new Condition("X4", "АПР"), new Condition("X5", "РЗ") });
            r1.setConclusion(new Conclusion("Y", 0.5, "КВ"));
            rules.Add(r1);

            Rule r2 = new Rule();
            r2.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "В"), new Condition("X3", "ВП"), new Condition("X4", "ПР"), new Condition("X5", "РЗ") });
            r2.setConclusion(new Conclusion("Y", 0.95, "КВ"));
            rules.Add(r2);

            Rule r3 = new Rule();
            r3.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "П"), new Condition("X3", "Л"), new Condition("X4", "ПР"), new Condition("X5", "РЗ") });
            r3.setConclusion(new Conclusion("Y", 0.5, "КВ"));
            rules.Add(r3);

            Rule r4 = new Rule();
            r4.setConditions(new List<Condition> { new Condition("X1", "БС"), new Condition("X2", "В"), new Condition("X3", "ВП"), new Condition("X4", "ПР"), new Condition("X5", "Р") });
            r4.setConclusion(new Conclusion("Y", 0.63, "КВ"));
            rules.Add(r4);




            Rule r5 = new Rule();
            r5.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "В"), new Condition("X3", "С"), new Condition("X4", "НД"), new Condition("X5", "РЗ") });
            r5.setConclusion(new Conclusion("Y", 0.5, "В"));
            rules.Add(r5);

            Rule r6 = new Rule();
            r6.setConditions(new List<Condition> { new Condition("X1", "КС"), new Condition("X2", "П"), new Condition("X3", "ВП"), new Condition("X4", "ПР"), new Condition("X5", "Р") });
            r6.setConclusion(new Conclusion("Y", 0.75, "В"));
            rules.Add(r6);

            Rule r7 = new Rule();
            r7.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "В"), new Condition("X3", "С"), new Condition("X4", "НД"), new Condition("X5", "РЗ") });
            r7.setConclusion(new Conclusion("Y", 0.5, "В"));
            rules.Add(r7);

            Rule r8 = new Rule();
            r8.setConditions(new List<Condition> { new Condition("X1", "БС"), new Condition("X2", "СВ"), new Condition("X3", "НП"), new Condition("X4", "ПР"), new Condition("X5", "Р") });
            r8.setConclusion(new Conclusion("Y", 1, "В"));
            rules.Add(r8);



            Rule r9 = new Rule();
            r9.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "В"), new Condition("X3", "С"), new Condition("X4", "НД"), new Condition("X5", "Р") });
            r9.setConclusion(new Conclusion("Y", 0, "Н"));
            rules.Add(r9);

            Rule r10 = new Rule();
            r10.setConditions(new List<Condition> { new Condition("X1", "КС"), new Condition("X2", "СП"), new Condition("X3", "С"), new Condition("X4", "НД"), new Condition("X5", "Р") });
            r10.setConclusion(new Conclusion("Y", 0.22, "Н"));
            rules.Add(r10);

            Rule r11 = new Rule();
            r11.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "П"), new Condition("X3", "НП"), new Condition("X4", "ПР"), new Condition("X5", "ПЗ") });
            r11.setConclusion(new Conclusion("Y", 0.1, "Н"));
            rules.Add(r11);

            Rule r12 = new Rule();
            r12.setConditions(new List<Condition> { new Condition("X1", "БС"), new Condition("X2", "СП"), new Condition("X3", "ВП"), new Condition("X4", "НД"), new Condition("X5", "Р") });
            r12.setConclusion(new Conclusion("Y", 0.08, "Н"));
            rules.Add(r12);



            Rule r13 = new Rule();
            r13.setConditions(new List<Condition> { new Condition("X1", "БС"), new Condition("X2", "П"), new Condition("X3", "С"), new Condition("X4", "АНД"), new Condition("X5", "Р") });
            r13.setConclusion(new Conclusion("Y", 0.01, "П"));
            rules.Add(r13);

            Rule r14 = new Rule();
            r14.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "В"), new Condition("X3", "НП"), new Condition("X4", "НД"), new Condition("X5", "ПЗ") });
            r14.setConclusion(new Conclusion("Y", 0.29, "П"));
            rules.Add(r14);

            Rule r15 = new Rule();
            r15.setConditions(new List<Condition> { new Condition("X1", "КС"), new Condition("X2", "СП"), new Condition("X3", "С"), new Condition("X4", "ПР"), new Condition("X5", "ПЗ") });
            r15.setConclusion(new Conclusion("Y", 0.3, "П"));
            rules.Add(r15);

            Rule r16 = new Rule();
            r16.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "П"), new Condition("X3", "А"), new Condition("X4", "НД"), new Condition("X5", "Р") });
            r16.setConclusion(new Conclusion("Y", 1, "П"));
            rules.Add(r16);


            Rule r17 = new Rule();
            r17.setConditions(new List<Condition> { new Condition("X1", "КС"), new Condition("X2", "СП"), new Condition("X3", "А"), new Condition("X4", "АНД"), new Condition("X5", "Р") });
            r17.setConclusion(new Conclusion("Y", 1, "КП"));
            rules.Add(r17);

            Rule r18 = new Rule();
            r18.setConditions(new List<Condition> { new Condition("X1", "ОС"), new Condition("X2", "СП"), new Condition("X3", "НП"), new Condition("X4", "НД"), new Condition("X5", "ПЗ") });
            r18.setConclusion(new Conclusion("Y", 1, "КП"));
            rules.Add(r18);

            Rule r19 = new Rule();
            r19.setConditions(new List<Condition> { new Condition("X1", "КС"), new Condition("X2", "П"), new Condition("X3", "НП"), new Condition("X4", "АНД"), new Condition("X5", "Р") });
            r19.setConclusion(new Conclusion("Y", 1, "КП"));
            rules.Add(r19);

            Rule r20 = new Rule();
            r20.setConditions(new List<Condition> { new Condition("X1", "БС"), new Condition("X2", "СП"), new Condition("X3", "НП"), new Condition("X4", "НД"), new Condition("X5", "ПЗ") });
            r20.setConclusion(new Conclusion("Y", 1, "КП"));
            rules.Add(r20);


        }

        public static double[] fuzzification(double[] inputData)
        {
            //if (inputData.Length != variables.Count - 1)
            //{
            //    throw new ArgumentOutOfBoundsException();
            //}

            int i = 0;
            double[] b = new double[Rule.getNumberOfConditions()];
            foreach (Rule rule in rules)
            {
                foreach(Statement condition in rule.getConditions())
                {
                    int id = condition.getVariableId();
                    LingVariable variable = condition.getLingVariable();
                    b[i] = variable.getValueForTerm(condition.getTerm(), inputData[id]);
                    Console.WriteLine(variable.getName() + " : " + b[i] + " ");
                    i++;
                }
                Console.WriteLine(Environment.NewLine);
            }
            return b;
        }

        private static double[] aggregation(double[] b)
        {
            int i = 0;
            int j = 0;
            double[] c = new double[Rule.getNumberOfConclusions()];
            foreach (Rule rule in rules)
            {
                double truthOfConditions = 1.0;
                foreach (Statement condition in rule.getConditions())
                {
                    truthOfConditions = Math.Min(truthOfConditions, b[i]);
                    i++;
                }
                c[j] = truthOfConditions;
                j++;
            }
            return c;
        }

        private static UnionOfTermSet composition(double[] c)
        {
            UnionOfTermSet unionOfTerms = new UnionOfTermSet(Rule.getNumberOfConclusions());
            int i = 0;
            foreach(Rule rule in rules)
            {
                Term term = rule.getConclusion().getTerm().copyTerm();
                term.setActivatedValue(c[i] * rule.getConclusion().getWeight());
                unionOfTerms.add(term);
                i++;
            }
            return unionOfTerms;
        }

        private static double defuzzification(UnionOfTermSet unionOfTerms)
        {
            double x, y1 = 0.0, y2 = 0.0, step = 0.01;
            for (x = -3.0; x <= 3.0; x += step)
            {
                y1 += x * unionOfTerms.getMaxValue(x);
            }

            for (x = -3.0; x <= 3.0; x += step)
            {
                y2 += unionOfTerms.getMaxValue(x);
            }
            return y1 / y2;

        }


        public static double f(double x)
        {
            return x;
        }


        /**********************************************************************
         * Integrate f from a to b using Simpson's rule.
         * Increase N for more precision.
         **********************************************************************/
        public static double integrate(double a, double b, UnionOfTermSet unionOfTerms)
        {
            int N = 10000;                    // precision parameter
            double h = (b - a) / (N - 1);     // step size

            // 1/3 terms
            double sum = 1.0 / 3.0 * (f(a) + f(b));

            // 4/3 terms
            for (int i = 1; i < N - 1; i += 2)
            {
                double x = a + h * i;
                sum += 4.0 / 3.0 * f(unionOfTerms.getMaxValue(x) * x);
            }

            // 2/3 terms
            for (int i = 2; i < N - 1; i += 2)
            {
                double x = a + h * i;
                sum += 2.0 / 3.0 * f(unionOfTerms.getMaxValue(x) * x);
            }

            return sum * h;
        }
        public static double integrate1(double a, double b, UnionOfTermSet unionOfTerms)
        {
            int N = 10000;                    // precision parameter
            double h = (b - a) / (N - 1);     // step size

            // 1/3 terms
            double sum = 1.0 / 3.0 * (f(a) + f(b));

            // 4/3 terms
            for (int i = 1; i < N - 1; i += 2)
            {
                double x = a + h * i;
                sum += 4.0 / 3.0 * f(unionOfTerms.getMaxValue(x));
            }

            // 2/3 terms
            for (int i = 2; i < N - 1; i += 2)
            {
                double x = a + h * i;
                sum += 2.0 / 3.0 * f(unionOfTerms.getMaxValue(x));
            }

            return sum * h;
        }

    }
}
