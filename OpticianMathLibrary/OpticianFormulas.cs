using System;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Optician Calculations
    /// </summary>
    public static class OpticianFormulas
    {
        /// <summary>
        /// Evaluates the type of astigmatism based on lens power. Inputs are sphere and cylinder.
        /// </summary>
        /// <param name="sphere">In diopters.</param>
        /// <param name="cylinder">In diopters.</param>
        /// <returns>Astigmatism type</returns>
        public static string AstigmatismEvaluator(double sphere, double cylinder)
        {
            double sum = sphere + cylinder;
            string output = String.Empty;

            if (sphere == 0 && cylinder == 0)
            {
                output = "The lens has no power.";
            }
            else if (cylinder == 0)
            {
                return output = "There is no cylinder, therefore no astigmatism.";
            }
            if (sphere == 0 && cylinder > 0 || sphere > 0 && sum == 0)
            {
                output = "Simple Hyperopic Astigmatism";
            }
            if (sphere == 0 && cylinder < 0 || sphere < 0 && sum == 0)
            {
                output = "Simple Myopic Astigmatism";
            }
            if (sphere > 0 && sum > 0)
            {
                output = "Compound Hyperopic Astigmatism";
            }
            if (sphere < 0 && sum < 0)
            {
                output = "Compound Myopic Astigmatism";
            }
            if (sphere > 0 && sum < 0 || sphere < 0 && sum > 0)
            {
                output = "Mixed Astigmatism";
            }
            return output;
        }
        /// <summary>
        /// Calculates the total binocular decentration of lenses in a frame. Inputs are the A measurement, B measurement and binocular pupil distance in millimeters.
        /// </summary>
        /// <param name="aMeasure">In millimeters.</param>
        /// <param name="dblMeasure">In millimeters.</param>
        /// <param name="binocularPD">In millimeters.</param>
        /// <returns>Binocular decentration</returns>
        public static double BinocularDecentration(double aMeasure, double dblMeasure, double binocularPD)
        {
            return Math.Round((aMeasure + dblMeasure) - binocularPD, 1);
        }
        /// <summary>
        /// Calculates the monocular decentration of a lens in a frame. Inputs are the A measurement, DBL measurement and monocular pd in millimeters.
        /// </summary>
        /// <param name="aMeasure">In millimeters.</param>
        /// <param name="dblMeasure">In millimeters.</param>
        /// <param name="monoPD">In millimeters</param>
        /// <returns>Monocular decentration</returns>
        public static double MonocularDecentration(double aMeasure, double dblMeasure, double monoPD)
        {
            return Math.Round(((aMeasure + dblMeasure) / 2) - monoPD, 2);
        }
        /// <summary>
        /// Calculates the bifocal segment drop. Inputs are the segment height and B measurement in millimeters. 
        /// </summary>
        /// <param name="segmentHeight">In millimeters</param>
        /// <param name="bMeasure">In millimeters</param>
        /// <returns>Bifocal segment drop</returns>
        public static double SegDrop(double segmentHeight, double bMeasure)
        {
            return Math.Round(segmentHeight - (bMeasure / 2), 2);
        }
        /// <summary>
        /// Calculates the minimum blank size with optional 2mm compensation for chip factor. Inputs are effective diameter, monocular decentration in millimeters and true/false if you want to include/exclude chip factor compensation.
        /// </summary>
        /// <param name="effectiveDiamater">In millimeters</param>
        /// <param name="monoDecentration">In millimeters</param>
        /// <param name="chipFactor">In millimeters</param>
        /// <returns>Minimum blank size with or without chip factor</returns>
        public static double MinimumBlankSize(double effectiveDiamater, double monoDecentration, bool chipFactor)
        {
            if (chipFactor == true)
            {
                return Math.Round(effectiveDiamater + (2 * monoDecentration) + 2, 2);
            }
            return Math.Round(effectiveDiamater + (2 * monoDecentration), 2);
        }
    }
}
