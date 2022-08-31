using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConverter
{
    internal class LengthMeasurement
    {
        protected double measurement;

        // Constructer
        protected LengthMeasurement()
        {
            measurement = 0.0;
        }

        // Getter and Setter

        public double getMeasurement()
        { 
            return measurement; 
        }
        public void setMeasurement(double m)
        {
            measurement = m;
        }

    }
}
