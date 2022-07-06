using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fuzzy
{
    public static class Parser
    {
        public static void Parse(Mamdani calculator, string text)
        {
            foreach (Match block in Regex.Matches(text, @"\[(?<name>.+?)\](?<body>[^\[]+)"))
            {
                var name = block.Groups["name"].Value;
                var body = block.Groups["body"].Value.Trim();

                switch (name)
                {
                    case "RULES": ParseRules(calculator, body); break;
                    default: ParseVar(calculator, name, body); break;
                }
            }
        }

        private static void ParseVar(Mamdani calculator, string varName, string text)
        {
            var variable = new Variable() {Name = varName};
            var isOutVar = false;

            foreach (Match block in Regex.Matches(text, @"(?<name>\S+):(?<body>.+?)(?=\w+:|$)"))
            {
                var name = block.Groups["name"].Value;
                var body = block.Groups["body"].Value;
                var parts = body.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                //parse term
                switch (name)
                {
                    case "MAX": variable.Max = float.Parse(parts[0], CultureInfo.InvariantCulture); isOutVar = true; break;
                    case "MIN": variable.Min = float.Parse(parts[0], CultureInfo.InvariantCulture); isOutVar = true; break;
                    default:
                        var c = double.Parse(parts[0], CultureInfo.InvariantCulture);
                        var b = double.Parse(parts[1], CultureInfo.InvariantCulture);
                        var term = new Term() {Name = name, Variable = variable, MembershipFunction = MathHelper.Gauss(c, b)};
                        variable.Terms.Add(name, term);
                        break;
                }
            }
            if (isOutVar)
                calculator.OutputVariables.Add(variable);
            else
                calculator.InputVariables.Add(variable);
        }

        private static void ParseRules(Mamdani calculator, string text)
        {
            foreach (var line in text.Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries))
            {
                var rule = new Rule();

                foreach (Match block in Regex.Matches(line.Trim(), @"(?<name>\S+):(?<body>.+?)(?=\w+:|$)"))
                {
                    var name = block.Groups["name"].Value;
                    var body = block.Groups["body"].Value;
                    var parts = body.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    //parse term
                    var variable = calculator.InputVariables.FirstOrDefault(v => v.Name == name);
                    if (variable != null)
                        rule.Conditions.Add(variable.Terms[parts[0]]);
                    //
                    variable = calculator.OutputVariables.FirstOrDefault(v => v.Name == name);
                    if (variable != null)
                    {
                        rule.Conclusion = variable.Terms[parts[0]];
                        rule.Weight = double.Parse(parts[1], CultureInfo.InvariantCulture);
                    }
                }

                calculator.Rules.Add(rule);
            }
        }

        public static double[] ParseVarValues(Mamdani calculator, string text)
        {
            var res = new double[calculator.InputVariables.Count];

            foreach (Match block in Regex.Matches(text, @"(?<name>\S+):(?<body>.+?)(?=\w+:|$)"))
            {
                var name = block.Groups["name"].Value;
                var body = block.Groups["body"].Value;
                var i = calculator.InputVariables.FindIndex(v => v.Name == name);
                res[i] = double.Parse(body, CultureInfo.InvariantCulture);
            }

            return res;
        }
    }
}