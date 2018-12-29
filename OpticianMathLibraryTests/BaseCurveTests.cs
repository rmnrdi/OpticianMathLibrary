using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpticianMathLibrary;

namespace OpticianMathLibraryTests
{
    /// <summary>
    /// Summary description for VogelsRuleTest
    /// </summary>
    [TestClass]
    public class BaseCurveTests
    {
        public BaseCurveTests()
        {

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
        public void VogelsRulePlusTest()
        {
            var vogel = new BaseCurve();

            double expected = 12;

            double actual = vogel.VogelsRulePlus(6, 0);

            Assert.AreEqual(expected, actual, "No match");
        }
        [TestMethod]
        public void VogelsRuleMinusTest()
        {
            var vogel = new BaseCurve();

            double expected = 9;

            double actual = vogel.VogelsRuleMinus(6, 0);

            Assert.AreEqual(expected, actual, "No match");
        }
        [TestMethod]
        public void BoddyFormulaPlusTest()
        {
            var boddy = new BaseCurve();

            double expected = 3.5;

            double actual = boddy.BoddyFormulaPlus(0, 0, 0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void BoddyFormulaMinusTest()
        {
            var boddy = new BaseCurve();

            double expected = 4.25;

            double actual = boddy.BoddyFormulaMinus(0, 0, 0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void BoddyForumlaTest()
        {
            var boddy = new BaseCurve();

            double expected = 3.75;

            double actual = boddy.BoddyFormula(-1, 0, 0);

            Assert.AreEqual(expected, actual);
        }
    }
}
;