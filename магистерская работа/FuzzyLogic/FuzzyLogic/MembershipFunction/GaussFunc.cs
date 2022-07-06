using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.MembershipFunction
{
    public class GaussFunc : IAccessoryFunc
    {
        private double b;
        private double c;
        private double activatedValue;
        public GaussFunc(double c, double b)
        {
            this.c = c;
            this.b = b;

        }
        public IAccessoryFunc copyFunc()
        {
            return new GaussFunc(this.c, this.b);
        }

        public double getActivatedValue(double x)
        {
            return Math.Min(getValue(x), activatedValue);
        }

        public double getValue(double x)
        {
            return Math.Pow(Math.E, ((-1 * ((x - b) * (x - b)) / (2 * c * c))));
        }

        public void setActivatedValue(double x)
        {
            this.activatedValue = x;
        }
    }
}
