using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Tool Calculations
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Calculates the back side tool curve based on 1.53 index. Inputs are the refractive power NEEDED in diopters and the index of refraction.
        /// </summary>
        /// <param name="refractivePower">In diopters</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Tool selection</returns>
        public static double ToolSelector(double refractivePower, double index)
        {
            double toolPower = (.53 / (index - 1)) * refractivePower;
            return Math.Round(toolPower * 4) / 4.0;
        }

        /// <summary>
        /// Calculates the actual refractive power of a surface based on 1.53 index. Inputs are toolPower in diopters and index of refraction.
        /// </summary>
        /// <param name="toolPower">In diopters</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Actual refractive power of lens</returns>
        public static double RefractivePower(double toolPower, double index)
        {
            double refractivePower = ((index - 1) / .53) * toolPower;
            return Math.Round(refractivePower * 4) / 4.0;
        }


    }
}
