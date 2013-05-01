using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoMocksTutorial1
{
    public class SimpleInterestCalculator
    {
        public double Principal { get; set; }
        public double InterestRate { get; set; }
        public double Time { get; set; }

        public virtual double CalculateInterestAmount()
        {
            return Principal * InterestRate * Time;
        }
    }
}
