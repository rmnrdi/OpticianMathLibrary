using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpticianMathLibrary;

namespace OpticianMathLibraryTests
{
    /// <summary>
    /// Summary description for PhysicsFormulasTests
    /// </summary>
    [TestClass]
    public class PhysicsFormulasTests
    {
        public PhysicsFormulasTests()
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
        public void WaveFormulaVelocityTest()
        {
            var phys = new PhysicsFormulas();

            double expected = 1;

            double actual = phys.WaveFormulaVelocity(1, 1);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void WaveFormulaFrequencyTest()
        {
            var phys = new PhysicsFormulas();

            double expected = .333;

            double actual = phys.WaveFormulaFrequency(1, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WaveFormulaWaveLengthTest()
        {
            var phys = new PhysicsFormulas();

            double expected = .125;

            double actual = phys.WaveFormulaWavelength(1,8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IlluminationTest()
        {
            var phys = new PhysicsFormulas();

            double expected = .004;

            double actual = phys.Illumination(16);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOfRefractionTest()
        {
            var phys = new PhysicsFormulas();

            double expected = 2.9979e10;

            double actual = phys.IndexOfRefraction(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpeedOfLightTest()
        {
            var phys = new PhysicsFormulas();

            double expected = 2.9979e10;

            double actual = phys.SpeedOfLightInMaterial(1);

            Assert.AreEqual(expected, actual);
        }
    }
}
