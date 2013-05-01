using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoMocksTutorial1
{
    public class LoggedSimpleInterestCalculator : SimpleInterestCalculator
    {
        // Using log4net for logging
        private readonly ILog logger = LogManager.GetLogger("interestLogger");

        public override double CalculateInterestAmount()
        {
            logger.DebugFormat("Calculating Interest: P={0}, i={1}, t={2}", Principal, InterestRate, Time);
            var interest = base.CalculateInterestAmount();
            logger.DebugFormat("Interest Calculated: {0}", interest);

            return interest;
        }
    }
}
