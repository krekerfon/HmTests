using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace IsPostitive
{
    [Parallelizable(ParallelScope.Fixtures)]
    class IsPositiveTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "NegativeInt")]
        public void CheckIsPositive_PassNegativeInt(int a)
        {
            var expectedResult = a < 0;
            Assert.That(Calc.isPositive(a), Is.EqualTo(expectedResult));
        }
        [TestCase(0, false)]
        public void CheckIsPositive_PassIntZero(int a, bool expectedResult)
        {
            Assert.That(Calc.isPositive(a), Is.EqualTo(expectedResult));
        }
        [TestCase(0.0, false)]
        public void CheckIsPositive_PassRealZero(double a, bool expectedResult)
        {
            Assert.That(Calc.isPositive(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveInt")]
        public void CheckIsPositive_PassPositiveInt(double a, bool expectedResult)
        {
            Assert.That(Calc.isPositive(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "NotNumberArgs")]
        public void CheckIsPositive_PassStringArgs(string a)
        {
            Assert.That(() => Calc.isPositive(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
    }
}
