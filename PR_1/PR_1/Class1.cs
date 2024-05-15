using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    internal class Class1
    {
        private double Distance { get; }
        private double AverageSpeed { get; }
        public double CalculateTime(double distance, double averagespeed)
        {
            return Math.Round(averagespeed / distance, 3);
        }
    }
}
