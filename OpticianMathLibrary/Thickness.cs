using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Thickness Calculations
    /// </summary>
    public static class Thickness
    {
        /// <summary>
        /// Calculates the sagittal depth of a lens. Inputs are radius of curvature and lens diameter in millimeters.
        /// </summary>
        /// <param name="radiusOfCurvature">In millimeters</param>
        /// <param name="lensDiameter">In millimeters</param>
        /// <returns>Sagittal depth</returns>
        public static double SagittalDepth(double radiusOfCurvature, double lensDiameter)
        {
            double semiDiameter = lensDiameter / 2;
            double radiusSquared = radiusOfCurvature * radiusOfCurvature;
            double semiDiameterSquared = semiDiameter * semiDiameter;

            return radiusOfCurvature - Math.Sqrt(radiusSquared - semiDiameterSquared);
        }

        /// <summary>
        /// Calculates the sagittal depth of a lens. Inputs are the true lens power in diopters, diameter in millimeters and index of refraction.
        /// </summary>
        /// <param name="trueLensPower">In diopters</param>
        /// <param name="lensDiameter">In millimeters</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Sagittal depth</returns>
        public static double SagittalDepth(double trueLensPower, double lensDiameter, double index)
        {
            double semiDiameter = lensDiameter / 2;
            double semiDiameterSquared = semiDiameter * semiDiameter;
            double radiusOfCurvature = (index - 1) / trueLensPower;
            double radiusSquared = radiusOfCurvature * radiusOfCurvature;

            return radiusOfCurvature - Math.Sqrt(radiusSquared - semiDiameterSquared);
        }

        /// <summary>
        /// Calculates the edge thickness of a minus lens. Inputs are the front sagittal depth, back sagittal depth and center thickness in millimeters.
        /// </summary>
        /// <param name="sagBack">Sagittal depth of front surface</param>
        /// <param name="sagFront">Sagittal depth of back surface</param>
        /// <param name="centerThickness">In millimeters</param>
        /// <returns>Edge thickness</returns>
        public static double EdgeThickness(double sagFront, double sagBack, double centerThickness)
        {
            double sagDifference = sagBack - sagFront;
            return sagDifference + centerThickness;
        }

        /// <summary>
        /// Calculates the edge thickness of a minus lens. Inputs are the front sagittal depth, back sagittal depth and edge thickness in millimeters.
        /// </summary>
        /// <param name="sagFront">Sagittal depth of front surface</param>
        /// <param name="sagBack">Sagittal depth of back surface</param>
        /// <param name="edgeThickness">In millimeters</param>
        /// <returns>Center thickness</returns>
        public static double CenterThickness(double sagFront, double sagBack, double edgeThickness)
        {

            return sagFront - sagBack + edgeThickness;
        }

        /// <summary>
        /// Calculates an approximate sagittal depth. Inputs are surface power in diopters, lens diameter in millimeters and index of refraction.
        /// </summary>
        /// <param name="surfacePower">In diopters</param>
        /// <param name="lensDiameter">In millimeters</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Approximate sagittal depth</returns>
        public static double ApproximateSagFormula(double surfacePower, double lensDiameter, double index)
        {
            double semiDiameter = lensDiameter / 2;
            double semiDiameterSquared = semiDiameter * semiDiameter;

            return (semiDiameterSquared * surfacePower) / (2000 * (index - 1));
        }

        /// <summary>
        /// Calculates an approximate lens thickness. Inputs are surface power in diopters, lens diameter in millimeters, index of refraction and center OR edge thickness in millimeters.
        /// </summary>
        /// <param name="surfacePower">In diopters</param>
        /// <param name="lensDiameter">In millimeters</param>
        /// <param name="index">Index of refraction</param>
        /// <param name="thickness">In millimeters</param>
        /// <returns>Approximate lens thickness</returns>
        public static double ApproximateThickness(double surfacePower, double lensDiameter, double index, double thickness)
        {
            double semiDiameter = lensDiameter / 2;
            double semiDiameterSquared = semiDiameter * semiDiameter;

            return (semiDiameterSquared * surfacePower) / (2000 * (index - 1)) + thickness;

        }


        /// <summary>
        /// Calculates the thickness of a exclusively prismatic lens. Inputs are the prism power in diopters, lens diameter in millimeters and index of refraction.
        /// </summary>
        /// <param name="prismPower">In diopters</param>
        /// <param name="lensDiameter">In millimeters</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Prism thickness</returns>
        public static double PrismThickness(double prismPower, double lensDiameter, double index)
        {
            return (lensDiameter * prismPower) / (100 * (index - 1));
        }

        /// <summary>
        /// Calculates the power of a prism based on it's thickness. Inputs are the thickness DIFFERENCE between the two edges, lens Diameter in millimeters and index of refraction.
        /// </summary>
        /// <param name="thicknessDifference">Thickness difference of prism</param>
        /// <param name="lensDiameter">Diameter of the lens</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Prism power</returns>
        public static double PrismPowerFromThickness(double thicknessDifference, double lensDiameter, double index)
        {
            return (thicknessDifference * (100 * (index - 1))) / lensDiameter;
        }

        /// <summary>
        /// Calculates the edge thickness of a plus lens with prism. Inputs are the prism base thickness and minimum edge thickness in millimeters.
        /// </summary>
        /// <param name="prismBaseThickness">In millimeters</param>
        /// <param name="minimumEdgeThickness">In millimeters</param>
        /// <returns>Plus prism lens thickest edge</returns>
        public static double PlusPrismLensThickestEdge(double prismBaseThickness, double minimumEdgeThickness)
        {
            return prismBaseThickness + minimumEdgeThickness;
        }

        /// <summary>
        /// Calculates the center thickness of a plus power lens with prism. Inputs are sagittal depth, minimum edge thickness and prism base thickness.
        /// </summary>
        /// <param name="sagittalDepth">Sagittal depth of lens</param>
        /// <param name="minimumEdgeThickness">In millimeters</param>
        /// <param name="prismBaseThickness">In millimeters</param>
        /// <returns>Plus prism lens center thickness</returns>
        public static double PlusPrismLensCenterThickness(double sagittalDepth, double minimumEdgeThickness, double prismBaseThickness)
        {
            return sagittalDepth + minimumEdgeThickness + (prismBaseThickness / 2);
        }


        /// <summary>
        /// Calculates the edge thickness of minus lens with prism. Inputs are the sagittal depth, minimum center thickness and prism base thickness in millimeters.
        /// </summary>
        /// <param name="sagittalDepth">Sagittal depth of lens</param>
        /// <param name="minimumCenterThickness">In millimeters</param>
        /// <param name="prismBaseThickness">In millimeters</param>
        /// <returns>Minux prism lens edge thickness</returns>
        public static double MinusPrismLensEdgeThickness(double sagittalDepth, double minimumCenterThickness, double prismBaseThickness)
        {
            return sagittalDepth + minimumCenterThickness + (prismBaseThickness / 2);
        }
    }
}
