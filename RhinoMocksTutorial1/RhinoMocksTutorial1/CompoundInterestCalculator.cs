using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoMocksTutorial1
{
    public class CompoundInterestCalculator : SimpleInterestCalculator
    {
        public override double CalculateInterestAmount()
        {
            var newPrincipal = Principal * Math.Pow((1 + InterestRate), Time);
            return newPrincipal - Principal;
        }
    }
}
