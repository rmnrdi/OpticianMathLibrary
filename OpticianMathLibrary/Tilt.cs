using System;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Tilt Formulas
    /// </summary>
    public static class Tilt
    {
        /// <summary>
        /// Approximates the effective power of a tilted lens. Inputs are the original sphere power in diopters, degrees of tilt in degrees and index of refraction.
        /// NOTE: Rx must be transposed to the same axis as the axis of tilt.
        /// </summary>
        /// <param name="originalSpherePower">In diopters.</param>
        /// <param name="degreesOfTilt">In degrees</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>New sphere power after tilt</returns>
        public static double MartinTiltFormulaSphere(double originalSpherePower, double degreesOfTilt, double index)
        {
            double radians = degreesOfTilt * (Math.PI / 180);
            double sinSquared = Math.Sin(radians) * Math.Sin(radians);
            double ratio = sinSquared / (2 * index);

            return originalSpherePower * (1 + ratio);
        }

        /// <summary>
        /// Approximates the induced cylinder of a spherical lens with no cylinder. Inputs are the new sphere power in diopters from Martin's tilt formula and degrees of tilt.
        /// NOTE: Rx must be transposed to same axis as the axis of tilt. Also, resulting induced cylinder will be on same axis as tilt.
        /// </summary>
        /// <param name="newSpherePower">In diopters</param>
        /// <param name="degreesOfTilt">In degrees</param>
        /// <returns>Induced cylinder power after tilt</returns>
        public static double MartinTiltFormulaInducedCylinder(double newSpherePower, double degreesOfTilt)
        {
            double radians = degreesOfTilt * (Math.PI / 180);
            double tanSquared = Math.Tan(radians) * Math.Tan(radians);

            return newSpherePower * tanSquared;
        }

        /// <summary>
        /// Calculates the induced cylinder of a tilted lens. Inputs are the new sphere power in diopters from Martin's tilt formula.
        /// NOTE: NOTE: Rx must be transposed to same axis as the axis of tilt. Also, resulting induced cylinder will be ADDED to existing cylinder on same axis.
        /// </summary>
        /// <param name="newSpherePower">In diopters</param>
        /// <param name="degreesOfTilt">In degrees</param>
        /// <param name="originalCylinderPower">In degrees.</param>
        /// <returns>Induced cylinder power after tilt</returns>
        public static double MartinTiltFormulaInducedCylinder(double newSpherePower, double degreesOfTilt, double originalCylinderPower)
        {
            double radians = degreesOfTilt * (Math.PI / 180);
            double tanSquared = Math.Tan(radians) * Math.Tan(radians);

            return newSpherePower * tanSquared + originalCylinderPower;
        }
    }
}
