using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Prism Calculations
    /// </summary>
    public static class Prism
    {
        /// <summary>
        /// Calculates the angle formed by the emerging ray and the original ray path. Inputs are apical angle in degrees and index of refraction.
        /// </summary>
        /// <param name="apicalAngle">In degrees</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Deviation angle</returns>
        public static double PrimsDeviation(double apicalAngle, double index)
        {
            double prismDeviation = apicalAngle * (index - 1);
            return Math.Round(prismDeviation, 1);
        }

        /// <summary>
        /// Calculates what apical angle the prism will need to deviate a ray of light by a given amount. Inputs are degrees of deviation and index.
        /// </summary>
        /// <param name="degreesDeviation">In degrees</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Apical angle</returns>
        public static double ApicalAngle(double degreesDeviation, double index)
        {
            double apicalAngle = degreesDeviation / (index - 1);
            return Math.Round(apicalAngle, 1);
        }

        /// <summary>
        /// Calculates prism diopters. Inputs are displacement of light ray in centimeters and distance from prism in meters.
        /// </summary>
        /// <param name="displacement">In centimeters</param>
        /// <param name="distance">In Meters</param>
        /// <returns>Dioptric prism power</returns>
        public static double PrismDiopter(double displacement, double distance)
        {
            double prismDiopter = displacement / distance;
            return Math.Round(prismDiopter, 2);
        }

        /// <summary>
        /// Calculates displacement of ray in centimeters. Inputs are the prism's dioptric power and the distance in meters.
        /// </summary>
        /// <param name="prismDiopters">In diopters</param>
        /// <param name="distance">In meters</param>
        /// <returns>Displacement of light ray</returns>
        public static double PrismDisplacement(double prismDiopters, double distance)
        {
            return prismDiopters * distance;
        }

        /// <summary>
        /// Calculates the distance a light ray is from a prism in meters. Inputs are the prism power in diopters and the displacement in centimeters.
        /// </summary>
        /// <param name="prismDiopters">In diopters</param>
        /// <param name="displacement">In centimeters</param>
        /// <returns>Distance of light ray from prism</returns>
        public static double PrismDistance(double prismDiopters, double displacement)
        {
            return displacement / prismDiopters;
        }

        /// <summary>
        /// Calculates prism based on the centrad in diopters. Input is the angle of deviation in degrees.
        /// </summary>
        /// <param name="deviationAngle">Angle of deviation in degrees</param>
        /// <returns>Prism power in diopters</returns>
        public static double PrismCentrad(double deviationAngle)
        {
            double radians = deviationAngle * (Math.PI / 180);
            double tangent = Math.Tan(radians);
            return 100 * tangent;
        }

        /// <summary>
        /// Approximates the power of a prism in diopters. Inputs are the apical angle in degrees and index of refraction.
        /// </summary>
        /// <param name="apicalAngle">In degrees</param>
        /// <param name="index">Index of refraction</param>
        /// <returns>Approximate prism power</returns>
        public static double PrismDiopterApproximation(double apicalAngle, double index)
        {
            double prismDiopterApproximation = apicalAngle * (index - 1);
            double radians = prismDiopterApproximation * (Math.PI / 180);
            double tangent = Math.Tan(radians);
            return Math.Round(100 * tangent, 1);
        }

        /// <summary>
        /// Calculates prismatic effect in diopters. Inputs are the lens power in diopters and distance from optical center in centimeters.
        /// </summary>
        /// <param name="lensPower">In diopters</param>
        /// <param name="distance">In centimeters</param>
        /// <returns>Prismatic effect</returns>
        public static double PrenticesLawCentimeters(double lensPower, double distance)
        {
            return distance * lensPower;
        }

        /// <summary>
        /// Calculates prismatic effect in diopters. Inputs are the lens power in diopters and distance from optical center in millimeters.
        /// </summary>
        /// <param name="lensPower">In diopters</param>
        /// <param name="distance">In millimeters</param>
        /// <returns>Prismatic effect</returns>
        public static double PrenticesLawMillimeters(double lensPower, double distance)
        {
            return (distance * lensPower) / 10;
        }

        /// <summary>
        /// Calculates resultant prism magnitude. Inputs are the horizontal and vertical prism components in diopters.
        /// </summary>
        /// <param name="horizontalComponent">In diopters</param>
        /// <param name="verticalComponent">In diopters</param>
        /// <returns>Resultant prism</returns>
        public static double ResultantPrism(double verticalComponent, double horizontalComponent)
        {
            double sumOfSquares = Math.Pow(horizontalComponent, 2) + Math.Pow(verticalComponent, 2);

            return Math.Sqrt(sumOfSquares);
        }

        /// <summary>
        /// Calculates the effective decentration from the optical center of a spherocylinder lens in centimeters.
        /// </summary>
        /// <param name="horizontalDecentration">In centimeters</param>
        /// <param name="verticalDecentration">In centimeters</param>
        /// <param name="cylinderAxis">Cylinder axis in degrees</param>
        /// <returns>Effective decentration</returns>
        public static double EffectiveDecentration(double horizontalDecentration, double verticalDecentration, double cylinderAxis)
        {
            double cylAxisRadians = cylinderAxis * (Math.PI / 180);

            return horizontalDecentration * Math.Sin(cylAxisRadians) + verticalDecentration * Math.Cos(cylAxisRadians);
        }

        /// <summary>
        /// Calculates the angle of prism for the right eye (OD) in degrees. Inputs are the horizontal and vertical prism components in diopters.
        /// </summary>
        /// <param name="horizontalComponent">In is +. Out is -. In diopters</param>
        /// <param name="verticalComponent">Up is +. Down is -. In diopters</param>
        /// <returns>Resultant prism angle for the right eye</returns>
        public static double ResultantPrismAngleRightEye(double verticalComponent, double horizontalComponent)
        {
            //Finds the arctangent of the two prism components
            double componentRatio = verticalComponent / horizontalComponent;
            double inverseTangentRadians = Math.Atan(componentRatio);
            double tangentRadiansToDegrees = inverseTangentRadians * (180 / Math.PI);
            double finalAngle = Math.Abs(tangentRadiansToDegrees);

            //Logic to determine quadrant by sign of the prism components
            //When there's no horizontal prism and base up vertical prism
            if (horizontalComponent == 0 && verticalComponent > 0)
            {
                return 90;
            }
            //When there's no horizontal prism and base down vertical prism
            if (horizontalComponent == 0 && verticalComponent < 0)
            {
                return 270;
            }
            //Quadrant I
            if (horizontalComponent > 0 && verticalComponent > 0)
            {
                return finalAngle;
            }
            //Quadrant II
            if (horizontalComponent < 0 && verticalComponent > 0)
            {
                return 180 - finalAngle;
            }
            //Quadrant III
            if (horizontalComponent < 0 && verticalComponent < 0)
            {
                return 180 + finalAngle;
            }
            //Quadrant IV
            if (horizontalComponent > 0 && verticalComponent < 0)
            {
                return 360 - finalAngle;
            }
            return finalAngle;
        }

        /// <summary>
        /// Calculates the angle of prism for the left eye (OS) in degrees. Inputs are the horizontal and vertical prism components in diopters.
        /// </summary>
        /// <param name="verticalComponent">In is +. Out is -. In diopters.</param>
        /// <param name="horizontalComponent">Up is +. Down is -. In diopters.</param>
        /// <returns>Resultant prism angel for the left eye</returns>
        public static double ResultantPrismAngleLeftEye(double verticalComponent, double horizontalComponent)
        {
            //Finds the arctangent of the two prism components
            double componentRatio = verticalComponent / horizontalComponent;
            double inverseTangentRadians = Math.Atan(componentRatio);
            double tangentRadiansToDegrees = inverseTangentRadians * (180 / Math.PI);
            double finalAngle = Math.Abs(tangentRadiansToDegrees);

            //Logic to determine quadrant by sign of the prism components
            //When there's no horizontal prism and base up vertical prism

            //**When calculating the left eye, the horizontal axis must be flipped to bi-nasal form.
            if (horizontalComponent == 0 && verticalComponent > 0)
            {
                return 90;
            }
            //When there's no horizontal prism and base down vertical prism
            if (horizontalComponent == 0 && verticalComponent < 0)
            {
                return 270;
            }
            //Quadrant I
            if (horizontalComponent < 0 && verticalComponent > 0)
            {
                return finalAngle;
            }
            //Quadrant II
            if (horizontalComponent > 0 && verticalComponent > 0)
            {
                return 180 - finalAngle;
            }
            //Quadrant III
            if (horizontalComponent > 0 && verticalComponent < 0)
            {
                return 180 + finalAngle;
            }
            //Quadrant IV
            if (horizontalComponent < 0 && verticalComponent < 0)
            {
                return 360 - finalAngle;
            }
            return finalAngle;
        }

        /// <summary>
        /// Resolves the horizontal component of a given power and angle. Inputs are prism power in diopters and angle in degrees.
        /// </summary>
        /// <param name="prismPower">In diopters</param>
        /// <param name="angle">In degrees</param>
        /// <returns>Resolved horizontal prism component</returns>
        public static double ResolvingPrismHorizontal(double prismPower, double angle)
        {
            double radians = angle * Math.PI / 180;
            double horizontalComponent = prismPower * Math.Cos(radians);
            return horizontalComponent;
        }

        /// <summary>
        /// Resolves the vertical component of a given power and angle. Inputs are prism power in diopters and angle in degrees.
        /// </summary>
        /// <param name="prismPower">In diopters</param>
        /// <param name="angle">In degrees</param>
        /// <returns>Resolved vertical prism component</returns>
        public static double ResolvingPrismVertical(double prismPower, double angle)
        {
            double radians = angle * Math.PI / 180;
            double verticalComponent = prismPower * Math.Sin(radians);
            return verticalComponent;
        }

        /// <summary>
        /// Determines which eye is being calculated. Inputs are the prism base angle, as well as the vertical and horizontal base directions
        /// </summary>
        /// <param name="prismBaseAngle">Prism base angle in degrees</param>
        /// <param name="verticalBaseDirection">Entered as a String in the format "Base Up" or "Base Down"</param>
        /// <param name="horizontalBaseDirection">Entered as a String in the format "Base In" or "Base Out"</param>
        /// <returns>Eye being calculated</returns>
        public static string EyeResolver(double prismBaseAngle, string verticalBaseDirection, string horizontalBaseDirection)
        {
            string s = String.Empty;

            if (verticalBaseDirection.Equals("Base Up") && horizontalBaseDirection.Equals("Base In") && prismBaseAngle < 90)
            {
                return "Right Eye (OD) Quadrant I";
            }

            if (verticalBaseDirection.Equals("Base Up") && horizontalBaseDirection.Equals("Base In") && prismBaseAngle > 90 && prismBaseAngle < 180)
            {
                return "Left Eye (OS) Quadrant II";
            }

            if (verticalBaseDirection.Equals("Base Up") && horizontalBaseDirection.Equals("Base Out") && prismBaseAngle < 180 && prismBaseAngle > 90)
            {
                return "Right Eye (OD) Quadrant II";
            }

            if (verticalBaseDirection.Equals("Base Up") && horizontalBaseDirection.Equals("Base Out") && prismBaseAngle < 90)
            {
                return "Left Eye (OS) Quadrant I";
            }

            if (verticalBaseDirection.Equals("Base Down") && horizontalBaseDirection.Equals("Base Out") && prismBaseAngle < 270 && prismBaseAngle > 180)
            {
                return "Right Eye (OD) Quadrant III";
            }
            if (verticalBaseDirection.Equals("Base Down") && horizontalBaseDirection.Equals("Base Out") && prismBaseAngle < 360 && prismBaseAngle > 270)
            {
                return "Left Eye (OS) Quadrant IV";
            }

            if (verticalBaseDirection.Equals("Base Down") && horizontalBaseDirection.Equals("Base In") && prismBaseAngle < 360 && prismBaseAngle > 270)
            {
                return "Right Eye (OD) Quadrant IV";
            }

            if (verticalBaseDirection.Equals("Base Down") && horizontalBaseDirection.Equals("Base In") && prismBaseAngle < 270 && prismBaseAngle > 180)
            {
                return "Left Eye (OS) Quadrant III";
            }
            return s;
        }
    }
}
