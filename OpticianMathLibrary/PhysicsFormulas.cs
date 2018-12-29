using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Physics Formulas
    /// </summary>
    public static class PhysicsFormulas
    {
        /// <summary>
        /// Speed of light constant
        /// </summary>
        public const double lightSpeed = 2.9979e10;

        /// <summary>
        /// Calculates the velocity of a wave. Inputs are frequency and wavelength.
        /// </summary>
        /// <param name="frequency">Frequency of light ray</param>
        /// <param name="wavelength">Wavelength of light ray</param>
        /// <returns>Velocity of a light wave</returns>
        public static double WaveFormulaVelocity(double frequency, double wavelength)
        {
            return Math.Round(frequency * wavelength, 3);
        }

        /// <summary>
        /// Calculates the frequency of a wave. Inputs are velocity and wavelength.
        /// </summary>
        /// <param name="velocity">velocity of light ray</param>
        /// <param name="wavelength">wavelength of light ray</param>
        /// <returns>Frequency of a light wave</returns>
        public static double WaveFormulaFrequency(double velocity, double wavelength)
        {
            return Math.Round(velocity / wavelength, 3);
        }

        /// <summary>
        /// Calculates the wavelength of light. Inputs are velocity and frequency.
        /// </summary>
        /// <param name="velocity">velocity of light ray</param>
        /// <param name="frequency">frequency of light ray</param>
        /// <returns>Wavelength of a light wave</returns>
        public static double WaveFormulaWavelength(double velocity, double frequency)
        {
            return Math.Round(velocity / frequency, 3);
        }

        /// <summary>
        /// Calculates illumination at a given distance in meters. 
        /// </summary>
        /// <param name="distance">In meters</param>
        /// <returns>Illumination</returns>
        public static double Illumination(double distance)
        {
            return Math.Round(1 / (distance * distance), 3);
        }

        /// <summary>
        /// Calculates Index of refraction of a material. Input is speed of light in material in m/s.
        /// </summary>
        /// <param name="cInMaterial">Speed of light in material. In meters per second</param>
        /// <returns>Index of refraction</returns>
        public static double IndexOfRefraction(double cInMaterial)
        {

            return lightSpeed / cInMaterial;
        }

        /// <summary>
        /// Calculates the speed of light in a material of a given index. Input is the refractive index.
        /// </summary>
        /// <param name="index">Index of refraction</param>
        /// <returns>Speed of light in a material</returns>
        public static double SpeedOfLightInMaterial(double index)
        {
            return lightSpeed / index;
        }
    }
}
