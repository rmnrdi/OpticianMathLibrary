using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpticianMathLibrary;

namespace OpticianMathLibraryTests
{
    /// <summary>
    /// Summary description for OpticianFormulasTest
    /// </summary>
    [TestClass]
    public class OpticianFormulasTests
    {
        public OpticianFormulasTests()
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
        public void AstigmatismEvaluatorTest_WhenLens_HasNoPower()
        {
            var opti = new OpticianFormulas();

            var expected = "The lens has no power.";

            var actual = opti.AstigmatismEvaluator(0, 0);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_HasNoCylinder()
        {
            var opti = new OpticianFormulas();

            var expected = "There is no cylinder, therefore no astigmatism.";

            var actual = opti.AstigmatismEvaluator(5, 0);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_PlusCy()
        {
            var opti = new OpticianFormulas();

            var expected = "Simple Hyperopic Astigmatism";

            var actual = opti.AstigmatismEvaluator(0, 5);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_PlusSphereAndNoTotalPower()
        {
            var opti = new OpticianFormulas();

            var expected = "Simple Hyperopic Astigmatism";

            var actual = opti.AstigmatismEvaluator(5, -5);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_MinusCylOnly()
        {
            var opti = new OpticianFormulas();

            var expected = "Simple Myopic Astigmatism";

            var actual = opti.AstigmatismEvaluator(0, -5);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_MinusSphereAndNoTotalPower()
        {
            var opti = new OpticianFormulas();

            var expected = "Simple Myopic Astigmatism";

            var actual = opti.AstigmatismEvaluator(-5, 5);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_PlusSphereAndTotalPowerGreaterThanZero()
        {
            var opti = new OpticianFormulas();

            var expected = "Compound Hyperopic Astigmatism";

            var actual = opti.AstigmatismEvaluator(5, -4);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_MinusSphereAndTotalPowerLessThanZero()
        {
            var opti = new OpticianFormulas();

            var expected = "Compound Myopic Astigmatism";

            var actual = opti.AstigmatismEvaluator(-5, -6);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_PlusSphereAndTotalPowerLessThanZero()
        {
            var opti = new OpticianFormulas();

            var expected = "Mixed Astigmatism";

            var actual = opti.AstigmatismEvaluator(5, -6);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AstigmatismEvaluatorTest_WhenLens_MinusSphereAndTotalPowerGreaterThanZero()
        {
            var opti = new OpticianFormulas();

            var expected = "Mixed Astigmatism";

            var actual = opti.AstigmatismEvaluator(-5, 6);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BinocularDecentrationTest()
        {
            var opti = new OpticianFormulas();

            var expected = 0.0;

            var actual = opti.BinocularDecentration(55, 15, 70);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MonocularDecentrationTest()
        {
            var opti = new OpticianFormulas();

            var expected = 0.0;

            var actual = opti.MonocularDecentration(55, 15, 35);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SegDropTest()
        {
            var opti = new OpticianFormulas();

            var expected = 5.00;

            var actual = opti.SegDrop(30, 50);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimumBlankSizeTest_WhenChipFactor_EqualsFalse()
        {
            var opti = new OpticianFormulas();

            var expected = 40.0;

            var actual = opti.MinimumBlankSize(26, 7, false);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinimumBlankSizeTest_WhenChipFactor_EqualsTrue()
        {
            var opti = new OpticianFormulas();

            var expected = 42.0;

            var actual = opti.MinimumBlankSize(26, 7, true);

            Assert.AreEqual(expected, actual);
        }


    }
}
