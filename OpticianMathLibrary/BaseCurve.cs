using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpticianMathLibrary
{
    /// <summary>
    /// Base Curve Calculations
    /// </summary>
    public static class BaseCurve
    {
        /// <summary>
        /// Calculates an approximate base curve for a plus lens based on Vogel's rule.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// /// <param name="cylinder">In diopters</param>
        /// <returns>Base curve choice for plus lens</returns>
        public static double VogelsRulePlus(double sphere, double cylinder)
        {
            double spherEquivelant = sphere + (cylinder / 2);
            return spherEquivelant + 6;
        }
        /// <summary>
        /// Calculates an approximate base curve for a minus lens based on Vogel's rule.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <returns>Base curve choice for minus lens</returns>
        public static double VogelsRuleMinus(double sphere, double cylinder)
        {
            double spherEquivelant = sphere + (cylinder / 2);
            return (spherEquivelant / 2) + 6;
        }
        /// <summary>
        /// Calculates approximate front base curve choice of a plus progressive lens based on the Boddy Formula. Inputs are sphere, cylinder and add power in diopters.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <param name="addPower">In diopters</param>
        /// <returns>Base curve choice for plus lens</returns>
        public static double BoddyFormulaPlus(double sphere, double cylinder, double addPower)
        {
            double spherEquivalent = sphere + (cylinder / 2);
            return ((addPower / 2) + spherEquivalent) + 3.50;
        }
        /// <summary>
        /// Calculates approximate front base curve choice of a minus progressive lens based on the Boddy Formula. Inputs are sphere, cylinder and add power in diopters.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <param name="addPower">In diopters</param>
        /// <returns>Base curve choice for progressive minus lens</returns>
        public static double BoddyFormulaMinus(double sphere, double cylinder, double addPower)
        {
            double spherEquivalent = sphere + (cylinder / 2);
            return ((spherEquivalent + addPower) / 2) + 4.25;
        }
        /// <summary>
        /// Calculates approximate front base curve choice of plus or minus lens based on the Boddy Formula. Inputs are sphere, cylinder and add power in diopters.
        /// </summary>
        /// <param name="sphere">In diopters</param>
        /// <param name="cylinder">In diopters</param>
        /// <param name="addPower">In diopters</param>
        /// <returns>Base curve choice for a progressive lens</returns>
        public static double BoddyFormula(double sphere, double cylinder, double addPower)
        {
            double spherEquivalent = sphere + (cylinder / 2);
            if (sphere > 0)
            {
                return ((addPower / 2) + spherEquivalent) + 3.50;
            }
            else
            {
                return ((spherEquivalent + addPower) / 2) + 4.25;
            }

        }


    }
}
