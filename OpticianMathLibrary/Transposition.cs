using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Individual Transposition Calculations
    /// </summary>
    public static class Transposition
    {
        /// <summary>
        /// Calculates the transposed sphere value of lens with plus cylinder. Inputs are sphere and cylinder.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <returns>Transposed sphere power</returns>
        public static double TransposeSpherePower(double sphere, double cylinder)
        {
            double newSphere = 0;
            if (cylinder > 0)
            {
                return newSphere = sphere + cylinder;
            }
            if (cylinder < 0)
            {
                return sphere;
            }
            return newSphere;
        }

        /// <summary>
        /// Transposes the axis of a prescription with plus cylinder. Inputs are cylinder and cylinder axis.
        /// </summary>
        /// <param name="cylinder">In diopters.</param>
        /// <param name="axis">In degrees</param>
        /// <returns>Transposed axis</returns>
        public static double TransposeAxis(double cylinder, double axis)
        {
            double axisTransposed = 0;
            if (cylinder > 0 && axis < 90)
            {
                return axisTransposed = (axis + 90);
            }
            if (cylinder > 0 && axis > 90)
            {
                return axisTransposed = (axis - 90);
            }
            if (cylinder < 0)
            {
                return axis;
            }
            return axisTransposed;
        }



        /// <summary>
        /// Switches the sign of the cylindrical component for a lens with plus power. Input is cylinder. 
        /// </summary>
        /// <param name="cylinder">In diopters</param>
        /// <returns>Trasposed cylinder sign</returns>
        public static double TransposedCylinderSign(double cylinder)
        {
            double newCylinderSign = 0;
            if (cylinder > 0)
            {
                return newCylinderSign = cylinder * -1;
            }
            if (cylinder < 0)
            {
                return cylinder;
            }
            return newCylinderSign;
        }
    }
}
