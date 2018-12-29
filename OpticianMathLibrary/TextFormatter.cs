using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Formats double input values into strings
    /// </summary>
    public static class TextFormatter
    {
        /// <summary>
        /// Converts a double to a string formatted in standard dioptric form. Ex. +#.##, -#.##, +##.##, -##.##
        /// </summary>
        /// <param name="doubleValue">Value of type double</param>
        /// <returns>Standard diopter format to two decimal places</returns>
        public static string ToDiopterFormatTwoPlaces(this double doubleValue)
        {
            string doubleToFormattedString = doubleValue.ToString("+0.00;-0.00;0.00");
            return doubleToFormattedString;
        }

        /// <summary>
        /// Converts a double to a string formatted in standard dioptric form. Ex. +#.##, -#.##, +##.##, -##.##
        /// </summary>
        /// <param name="doubleValue">Value of type double</param>
        /// <returns>Standard diopter format to three decimal places</returns>
        public static string ToDiopterFormatThreePlaces(this double doubleValue)
        {
            string doubleToFormattedString = doubleValue.ToString("+0.000;-0.000;0.000");
            return doubleToFormattedString;
        }

        /// <summary>
        /// Converts a double to a string formatted in standard cylinder form. Ex. 001
        /// </summary>
        /// <param name="cylinderAxis">Cylinder axis</param>
        /// <returns>Standard cylinder format</returns>
        public static string ToCylinderAxisFormat(this int cylinderAxis)
        {
            string cylAxisToFormattedString = cylinderAxis.ToString("000.;");
            return cylAxisToFormattedString;
        }
        /// <summary>
        /// Appends the string "mm" to a double input.
        /// </summary>
        /// <param name="distance">Distance value</param>
        /// <returns>Appends "mm" to as a string</returns>
        public static string ToDistanceInMMFormat(this double distance)
        {
            string distanceToFormattedString = $"{distance.ToString()}mm";
            return distanceToFormattedString;

        }


    }
}
