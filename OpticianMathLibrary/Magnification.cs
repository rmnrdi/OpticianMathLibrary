using System;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Magnification Calculations
    /// </summary>
    public static class Magnification
    {
        /// <summary>
        /// Calculates the magnification of a lens. Inputs are front base curve and actual lens power in diopters, index of refraction, center thickness in meters and vertex distance in meters.
        /// </summary>
        /// <param name="frontBaseCurve">In diopters</param>
        /// <param name="actualLensPower">In diopters</param>
        /// <param name="index">Index of refraction</param>
        /// <param name="thickness">In millimeters</param>
        /// <param name="vertexDistance">In millimeters</param>
        /// <returns>Magnification of a lens</returns>
        public static double SpectacleMagnification(double frontBaseCurve, double actualLensPower, double index, double thickness, double vertexDistance)
        {
            //Converting thickness and vertex to meters
            double thicknessMeters = thickness / 1000;
            double vertexMeters = vertexDistance / 1000;

            //Shape Factor
            double thicknessFactor = (thicknessMeters / index) * frontBaseCurve;
            double shapeProduct = 1 - (thicknessFactor);
            double inverseShapeProduct = (1 / shapeProduct);

            //Power Factor
            double vertexAdjusted = vertexMeters + .003;
            double powerFactor = (1 / (1 - (vertexAdjusted * actualLensPower)));

            return Math.Round(inverseShapeProduct * powerFactor, 3);

        }

        /// <summary>
        /// Calculates the magnification percentage. Input is spectacle magnification.
        /// </summary>
        /// <param name="spectacleMagnifcation">From spectacle magnification formula</param>
        /// <returns>Magnification of a lens as a percent</returns>
        public static double MagnificationPercent(double spectacleMagnifcation)
        {
            return Math.Round((spectacleMagnifcation - 1) * 100, 2);
        }

    }
}
