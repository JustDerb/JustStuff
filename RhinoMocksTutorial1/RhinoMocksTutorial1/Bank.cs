using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoMocksTutorial1
{
    public class Bank
    {
        private readonly SimpleInterestCalculator interestCalculator;

        public Bank(SimpleInterestCalculator interestCalculator)
        {
            this.interestCalculator = interestCalculator;
        }

        public void RunProcessing()
        {
            if (interestCalculator.Principal > 500)
            {
                var interest = interestCalculator.CalculateInterestAmount();
                // do something with interest
            }
        }
    }
}
