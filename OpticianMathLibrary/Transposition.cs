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
        /// <param name="spherePower">In diopters</param>
        /// <param name="cylinderPower">In diopters</param>
        /// <returns>Transposed sphere power</returns>
        public static double TransposeSpherePower(double spherePower, double cylinderPower)
        {
            double newSphere = 0;
            if (cylinderPower > 0)
            {
                return newSphere = spherePower + cylinderPower;
            }
            if (cylinderPower < 0)
            {
                return spherePower;
            }
            return newSphere;
        }

        /// <summary>
        /// Transposes the axis of a prescription with plus cylinder. Inputs are cylinder and cylinder axis.
        /// </summary>
        /// <param name="cylinderPower">In diopters.</param>
        /// <param name="cylinderAxis">In degrees</param>
        /// <returns>Transposed axis</returns>
        public static double TransposeAxis(double cylinderPower, double cylinderAxis)
        {
            double axisTransposed = 0;
            if (cylinderPower > 0 && cylinderAxis < 90)
            {
                return axisTransposed = (cylinderAxis + 90);
            }
            if (cylinderPower > 0 && cylinderAxis > 90)
            {
                return axisTransposed = (cylinderAxis - 90);
            }
            if (cylinderPower < 0)
            {
                return cylinderAxis;
            }
            return axisTransposed;
        }



        /// <summary>
        /// Switches the sign of the cylindrical component for a lens with plus power. Input is cylinder. 
        /// </summary>
        /// <param name="cylinderPower">In diopters</param>
        /// <returns>Trasposed cylinder sign</returns>
        public static double TransposedCylinderSign(double cylinderPower)
        {
            double newCylinderSign = 0;
            if (cylinderPower > 0)
            {
                return newCylinderSign = cylinderPower * -1;
            }
            if (cylinderPower < 0)
            {
                return cylinderPower;
            }
            return newCylinderSign;
        }
    }
}
