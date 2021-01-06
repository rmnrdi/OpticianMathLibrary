using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OpticianMathLibrary.Tests
{
    [TestClass()]
    public class BaseCurveTests
    {
        [TestMethod()]
        public void VogelsRulePlusTest()
        {
            var baseCurve = BaseCurve.VogelsRulePlus(2.00,-1.00);
            var expected = 7.5;
            Assert.AreEqual(expected,baseCurve);
            Assert.IsTrue(baseCurve >= 0, "Base curve is greater than or equal to 0");
        }

        [TestMethod()]
        public void VogelsRuleMinusTest()
        {
            var baseCurve = BaseCurve.VogelsRuleMinus(-3.00, -1.00);
            var expected = 4.25;
            Assert.AreEqual(expected,baseCurve);
            Assert.IsTrue(baseCurve >= 0, "Base curve is greater than or equal to 0");
        }

        [TestMethod()]
        public void BoddyFormulaPlusTest()
        {
            var baseCurve = BaseCurve.BoddyFormulaPlus(4.00, -1.00, 1.5);
            var expected = 7.75;
            Assert.AreEqual(expected, baseCurve);
            Assert.IsTrue(baseCurve >= 0, "Base curve is greater than or equal to 0");
        }

        [TestMethod()]
        public void BoddyFormulaMinusTest()
        {
            var baseCurve = BaseCurve.BoddyFormulaMinus(-2.00, -2.00, 2.00);
            var expected = 3.75;
            Assert.AreEqual(expected, baseCurve);
            Assert.IsTrue(baseCurve >= 0, "Base curve is greater than or equal to 0");
        }

        [TestMethod()]
        public void BoddyFormulaTest()
        {
            var baseCurveMinus = BaseCurve.BoddyFormula(-2.00, -2.00, 2.00);
            var expectedMinus = 3.75;
            Assert.AreEqual(expectedMinus, baseCurveMinus);
            Assert.IsTrue(baseCurveMinus >= 0, "Base curve is greater than or equal to 0");

            var baseCurvePlus = BaseCurve.BoddyFormula(4.00, -1.00, 1.5);
            var expectedPlus = 7.75;
            Assert.AreEqual(expectedPlus, baseCurvePlus);
            Assert.IsTrue(baseCurvePlus >= 0, "Base curve is greater than or equal to 0");
        }
    }
}