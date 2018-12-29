using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpticianMathLibrary;

namespace OpticianMathLibraryTests
{
    /// <summary>
    /// Summary description for MagnifcationFormulaTests
    /// </summary>
    [TestClass]
    public class MagnifcationFormulaTests
    {
        public MagnifcationFormulaTests()
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
        //Testing using optical formulas handbook page 165
        [TestMethod]
        public void SpectacleMagnifcationTestOD()
        {
            var mag = new Magnification();

            double expected = 1.036;

            double actual = mag.SpectacleMagnification(6.25, 1.50, 1.498, 3, 12);

            Assert.AreEqual(expected, actual);
        }
        //Testing using optical formulas handbook page 165
        [TestMethod]
        public void SpectacleMagnifcationTestOS()
        {
            var mag = new Magnification();

            double expected = 1.107;

            double actual = mag.SpectacleMagnification(9.25,4.50,1.498,5,12);

            Assert.AreEqual(expected, actual);
        }
      
        [TestMethod]
        public void MagnificationPercentTestOD()
        {
            var mag = new Magnification();

            double expected = 3.6;

            double actual = mag.MagnificationPercent(1.036);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MagnificationPercentTestOS()
        {
            var mag = new Magnification();

            double expected = 10.7;

            double actual = mag.MagnificationPercent(1.107);

            Assert.AreEqual(expected, actual);
        }


    }
}
