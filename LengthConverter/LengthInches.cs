using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConverter
{
    internal class LengthInches: LengthMeasurement
    {
        public double FeetToInches()
        {
            return measurement * 12;
        }
    }
}
