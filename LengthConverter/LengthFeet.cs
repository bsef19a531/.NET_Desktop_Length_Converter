using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConverter
{
    internal class LengthFeet: LengthMeasurement
    {
        public double InchesToFeet()
        {
            return measurement / 12;
        }
    }
}
