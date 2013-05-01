using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoMocksTutorial1
{
    public class TesterInterestCalculator : SimpleInterestCalculator
    {
        public bool CalculateWasCalled { get; set; }

        public override double CalculateInterestAmount()
        {
            CalculateWasCalled = true;
            return base.CalculateInterestAmount();
        }
    }
}
