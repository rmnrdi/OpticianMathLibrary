using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Rounds numbers to nearest value
    /// </summary>
    public static class NumberRounder
    {
        /// <summary>
        /// Rounds double to nearest .25
        /// </summary>
        /// <param name="value">value of type double</param>
        /// <returns>Number rounded to .25</returns>
        public static double RoundToQuarter(double value)
        {
            return Math.Round(value * 4) / 4;
        }

        /// <summary>
        /// Rounds double to nearest .125
        /// </summary>
        /// <param name="value">value of type double</param>
        /// <returns>Number rounded to .125</returns>
        public static double RoundToEighth(double value)
        {
            return Math.Round(value * 8) / 8;
        }
    }
}
