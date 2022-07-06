using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic.MembershipFunction
{
    public interface IAccessoryFunc
    {
        double getValue(double x);

        IAccessoryFunc copyFunc();

        void setActivatedValue(double x);

        double getActivatedValue(double x);
    }
}
