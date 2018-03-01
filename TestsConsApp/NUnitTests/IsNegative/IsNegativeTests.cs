using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;

namespace IsNegative
{
    [Parallelizable(ParallelScope.Fixtures)]
    class IsNegativeTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "NegativeInt")]
        public void CheckIsNegative_PassNegativeInt(int a)
        {
            var expectedResult = a < 0;
            Assert.That(Calc.isNegative(a), Is.EqualTo(expectedResult));
        }
        [TestCase(0, false)]
        public void CheckIsNegative_PassIntZero(int a, bool expectedResult)
        {
            Assert.That(Calc.isNegative(a), Is.EqualTo(expectedResult));
        }
        [TestCase(0.0, false)]
        public void CheckIsNegative_PassRealZero(double a, bool expectedResult)
        {
            Assert.That(Calc.isNegative(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveInt")]
        public void CheckIsNegative_PassPositiveInt(double a, bool expectedResult)
        {
            Assert.That(Calc.isNegative(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "NotNumberArgs")]
        public void CheckIsNegative_PassStringArgs(string a)
        {
            Assert.IsTrue(Calc.isNegative(a));
        }
    }
}
