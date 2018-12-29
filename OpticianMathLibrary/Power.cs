using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Power Calculations
    /// </summary>
    public static class Power
    {
        /// <summary>
        /// Calculates the vergence of light at a given distance. Input is distance in Centimeters.
        /// </summary>
        /// <param name="distance">In meters</param>
        /// <returns>Vergence in diopters</returns>
        public static double Vergence(double distance)
        {
            double distInMeters = distance / 100;
            return Math.Round((-1 / distInMeters), 3);
        }

        /// <summary>
        /// Calculates the dioptric power of a lens. Input is focal length in meters.
        /// </summary>
        /// <param name="distance">In meters</param>
        /// <returns>Dioptric power</returns>
        public static double DioptricPower(double distance)
        {
            return Math.Round((1 / distance), 3);
        }

        /// <summary>
        /// Calculates the focal length of a lens. Input is dioptric power.
        /// </summary>
        /// <param name="diopter">Dioptric power of lens</param>
        /// <returns>Focal distance in meters</returns>
        public static double FocalDistance(double diopter)
        {
            return Math.Round((1 / diopter), 3);
        }

        /// <summary>
        /// Calculates the surface power of lens. Input is the refractive index and radius of curvature in millimeters.
        /// </summary>
        /// <param name="index">Index of refraction</param>
        /// <param name="radiusMM">Radius curvature in mm</param>
        /// <returns>Surface power in diopters</returns>
        public static double SurfacePower(double index, double radiusMM)
        {
            return ((index - 1) * 1000) / radiusMM;
        }

        /// <summary>
        /// Calculates the radius of curvature of a lens. Input is refractive index and dioptric power.
        /// </summary>
        /// <param name="index">Index of refraction</param>
        /// <param name="diopter">Dioptric power of lens</param>
        /// <returns>Radius of curvature in millimeters</returns>
        public static double RadiusOfCurvature(double index, double diopter)
        {
            return Math.Round(Math.Abs(((index - 1) * 1000) / diopter), 2);
        }

        /// <summary>
        /// Calculates the nominal power of a lens in diopters. Input is the dioptric power of the front and back of a lens.
        /// </summary>
        /// <param name="powerFront">In diopters</param>
        /// <param name="powerBack">In diopters</param>
        /// <returns>Nominal lens power</returns>
        public static double NominalPower(double powerFront, double powerBack)
        {
            return Math.Round(powerFront + powerBack, 2);
        }

        /// <summary>
        /// Calculates the nominal back surface power of a lens. Inputs are the front surface power and the total lens power.
        /// </summary>
        /// <param name="powerFront">In diopters</param>
        /// <param name="totalPower">In diopters</param>
        /// <returns>Nominal back side power</returns>
        public static double NominalBacksidePower(double powerFront, double totalPower)
        {
            return Math.Round(totalPower - powerFront, 2);
        }

        /// <summary>
        /// Calculates the nominal power  of lens in diopters. Input is the index of refraction and 
        /// radius of curvature for front/back surfaces in meters.
        /// <para>
        /// NOTE: You must enter the radius of curvature as plus or minus depending on the surface.
        /// </para>
        /// </summary>
        /// <param name="index">Index of refraction</param>
        /// <param name="radiusFrontCM">Plus or Minus. In meters</param>
        /// <param name="radiusBackCM">Plus or Minus. In meters</param>
        /// <returns>Nominal lens power in diopters</returns>
        public static double LensMakersEquation(double index, double radiusFrontCM, double radiusBackCM)
        {
            double radiusFrontInMeters = radiusFrontCM / 100;
            double radiusBackInMeters = radiusBackCM / 100;

            double frontSurfaceInDiopters = ((index - 1) / radiusFrontInMeters);
            double backSurfaceInDiopters = ((index - 1) / radiusBackInMeters);

            return Math.Round(frontSurfaceInDiopters + backSurfaceInDiopters, 2);
        }

        /// <summary>
        /// Calculates the spherical equivalent of a spherocylinder lens. Inputs are sphere and cylinder power.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <returns>Spherical equivalent </returns>
        public static double SpericalEquivalant(double sphere, double cylinder)
        {
            return sphere + (cylinder / 2);
        }

        /// <summary>
        /// Calculates approximate lens power in the 180 degree meridian.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <param name="thetaDegrees">Axis of cylinder in degrees</param>
        /// <returns>Power in the horizontal meridian</returns>
        public static double PowerMeridian180(double sphere, double cylinder, int thetaDegrees)
        {
            double theta180 = thetaDegrees - 180;
            double thetaRadians = theta180 * (Math.PI / 180);
            double sinTheta = Math.Sin(thetaRadians);
            double sinSquareTheta = Math.Pow(sinTheta, 2);
            return Math.Round(sphere + cylinder * sinSquareTheta, 2);
        }

        /// <summary>
        /// Calculates approximate lens power in the 90 degree meridian.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <param name="thetaDegrees">Axis of cylinder in degrees</param>
        /// <returns>Power in the vertical meridian</returns>
        public static double PowerMeridian90(double sphere, double cylinder, int thetaDegrees)
        {
            double theta90 = thetaDegrees - 90;
            double thetaRadians = theta90 * (Math.PI / 180);
            double sinTheta = Math.Sin(thetaRadians);
            double sinSquareTheta = Math.Pow(sinTheta, 2);
            return Math.Round(sphere + cylinder * sinSquareTheta, 2);
        }

        /// <summary>
        /// Calculates effective lens power. Inputs are original lens power in diopters and vertex CHANGE in millimeters.
        /// <para>
        /// NOTE: The vertex change should be positive if the lens moves closer to the eye and negative if moved further away.
        /// </para>
        /// </summary>
        /// <param name="originalPower">In diopters</param>
        /// <param name="vertexChangeMM">Closer is +. Further is -.In meters</param>
        /// <returns>Effective lens power</returns>
        public static double EffectivePower(double originalPower, double vertexChangeMM)
        {
            double vertexChangeInMeters = vertexChangeMM / 1000;
            return Math.Round(originalPower / (1 + vertexChangeInMeters * originalPower), 2);
        }

        /// <summary>
        /// Calculates the compensated lens power to be ordered. Inputs are the original power and vertex CHANGE in millimeters.
        /// <para>
        /// NOTE: The vertex change should be positive if the lens moves closer to the eye and negative if moved further away.
        /// </para>
        /// </summary>
        /// <param name="originalPower">In diopters</param>
        /// <param name="vertexChangeMM">Closer is +. Further is -.In meters</param>
        /// <returns>Compensated lens power</returns>
        public static double CompensatedPower(double originalPower, double vertexChangeMM)
        {
            double vertexChangeInMeters = vertexChangeMM / 1000;
            double compensatedPower = (originalPower / (1 - vertexChangeInMeters * originalPower));
            return Math.Round(compensatedPower, 2);
        }

        /// <summary>
        /// Approximates the overall change in lens power per mm. Inputs are original lens power and change in vertex.
        /// <para>
        /// NOTE: This approximation only gives the CHANGE in power and not the final power to be ordered from the lab.
        /// You must determine if the value should be added or subtracted from the original lens power.
        /// </para>
        /// </summary>
        /// <param name="originalPower">In diopters</param>
        /// <param name="vertexChangeMM">In millimeters</param>
        /// <returns>Approximate change in power</returns>
        public static double VertexPowerChangeApprox(double originalPower, double vertexChangeMM)
        {
            double originalPowerSquared = Math.Pow(originalPower, 2);
            double vertexPowerChangeApprox = (vertexChangeMM * originalPowerSquared) / 1000;
            return Math.Round(vertexPowerChangeApprox, 2);
        }

        /// <summary>
        /// Calculates the back vertex power. Inputs are front surface power, back surface power, lens thickness in millimeters and refractive index.
        /// </summary>
        /// <param name="frontSurfacePower">In diopters</param>
        /// <param name="backSurfacePower">In diopters</param>
        /// <param name="thicknessMM">In meters.</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Back vertex power</returns>
        public static double BackVertexPower(double frontSurfacePower, double backSurfacePower, double thicknessMM, double index)
        {
            double thicknessInMeters = thicknessMM / 1000;
            double thicknessFactor = thicknessInMeters / index;
            double denominator = (1 - thicknessFactor * frontSurfacePower);
            double backVertexPower = frontSurfacePower / denominator + backSurfacePower;
            return Math.Round(backVertexPower, 2);
        }

        /// <summary>
        /// Calculates the front vertex power. Inputs are front surface power, back surface power, lens thickness in meters and refractive index
        /// </summary>
        /// <param name="frontSurfacePower">In diopters</param>
        /// <param name="backSurfacePower">In diopters</param>
        /// <param name="thicknessMM">In meters</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Front vertex power</returns>
        public static double FrontVertexPower(double frontSurfacePower, double backSurfacePower, double thicknessMM, double index)
        {
            double thicknessInMeters = thicknessMM / 1000;
            double thicknessFactor = thicknessInMeters / index;
            double denominator = (1 - thicknessFactor * backSurfacePower);
            double frontVertexPower = backSurfacePower / denominator + frontSurfacePower;
            return Math.Round(frontVertexPower, 2);
        }

    }
}
