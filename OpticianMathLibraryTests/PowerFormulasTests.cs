using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpticianMathLibrary;

namespace OpticianMathLibraryTests
{
    /// <summary>
    /// Summary description for PowerFormulasTests
    /// </summary>
    [TestClass]
    public class PowerFormulasTests
    {
        public PowerFormulasTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void VergenceTest()
        {
            var pow = new Power();

            double expected = -1.818;

            double actual = pow.Vergence(55);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DiopterTest()
        {
            var pow = new Power();
            //Doesn't round up .0625?
            double expected = .062;

            double actual = pow.Diopter(16.0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FocalDistanceTest()
        {
            var pow = new Power();
            //Doesn't round up .0625?
            double expected = .125;

            double actual = pow.FocalDistance(8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SurfacePowerTest()
        {
            var pow = new Power();
            //Doesn't round up .0625?
            double expected = 10;

            double actual = pow.SurfacePower(1.498, 49.8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RadiusOfCurvatureTest()
        {
            var pow = new Power();

            double expected = 422.86;

            double actual = pow.RadiusOfCurvature(1.74, 1.75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NominalPowerTest()
        {
            var pow = new Power();

            double expected = -2.0;

            double actual = pow.NominalPower(2.25, -4.25);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NominalBacksidePowerTest()
        {
            var pow = new Power();

            double expected = -7.50;

            double actual = pow.NominalBacksidePower(5.25, -2.25);

            Assert.AreEqual(expected, actual);
        }
        //Change naming convention of tests to MethodName_Scenario_ExpectedBehavior
        [TestMethod]
        public void LensMakerEquation_Calculate_ReturnsPointTwoPointSixOne()
        {
            var pow = new Power();

            double expected = 2.61;

            double actual = pow.LensMakersEquation(1.523, 10, -20);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SphericalEquivelant_Calculate_ReturnsOnePointFive()
        {
            var pow = new Power();

            double expected = 1.5;

            double actual = pow.SpericalEquivalant(1, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SphericalEquivelant_Calculate_ReturnsPointEightSevenFive()
        {
            var pow = new Power();

            double expected = .875;

            double actual = pow.SpericalEquivalant(1, -.25);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SphericalEquivelant_Calculate_ReturnsPointOneTwoFive()
        {
            var pow = new Power();

            double expected = .125;

            double actual = pow.SpericalEquivalant(.25, -.25);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerMeridian180_Calculate_ReturnsZero()
        {
            var pow = new Power();

            double expected = 0;

            double actual = pow.PowerMeridian180(+5.50, -5.50, 90);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PowerMeridian180_Calculate_ReturnNegativeSixPointOneEight()
        {
            var pow = new Power();

            double expected = -6.18;

            double actual = pow.PowerMeridian180(-4.5, -2.50, 125);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerMeridian180_Calculate_ReturnPlusOnePointFive()
        {
            var pow = new Power();

            double expected = 1.50;

            double actual = pow.PowerMeridian180(2.25, -1.00, 060);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PowerMeridian90_Calculate_ReturnZero()
        {
            var pow = new Power();

            double expected = 0;

            double actual = pow.PowerMeridian90(1, -1, 180);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerMeridian90_Calculate_ReturnNegativeOnePointFive()
        {
            var pow = new Power();

            double expected = -1.50;

            double actual = pow.PowerMeridian90(-1, -2, 60);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EffectivePower_Calculate_ReturnZero()
        {
            var pow = new Power();

            double expected = 0;
            //Closer + and further -
            double actual = pow.EffectivePower(0, -3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EffectivePower_Calculate_ReturnMinusFivePointEightNine()
        {
            var pow = new Power();

            double expected = -5.89;
            //Closer + and further -
            double actual = pow.EffectivePower(-6.00, -3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompensatedPower_Calculate_ReturnZero()
        {
            var pow = new Power();

            double expected = 0;

            double actual = pow.CompensatedPower(0, -3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompensatedPower_Calculate_ReturnMinusSixPointOneOne()
        {
            var pow = new Power();

            double expected = -6.11;

            double actual = pow.CompensatedPower(-6, -3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VertexPowerChangeAprox_Calculate_ReturnZero()
        {
            var pow = new Power();

            double expected = 0;

            double actual = pow.VertexPowerChangeApprox(0, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VertexPowerChangeAprox_Calculate_ReturnPointThreeZero()
        {
            var pow = new Power();

            double expected = .30;

            double actual = pow.VertexPowerChangeApprox(10, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BackVertexPower_Calculate_ReturnTenPointFiveTwo()
        {
            var pow = new Power();

            double expected = 10.52;

            double actual = pow.BackVertexPower(12, -3, 14, 1.498);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FrontVertexPower_Calculate_ReturnTenPointFiveTwo()
        {
            var pow = new Power();

            double expected = 9.08;

            double actual = pow.FrontVertexPower(12, -3, 14, 1.498);

            Assert.AreEqual(expected, actual);
        }



    }
}
