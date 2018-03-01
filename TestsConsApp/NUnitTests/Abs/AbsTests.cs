using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace Abs
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class AbsTests : Base
    {
        [Test]
        public void CheckAbs_PassDecimalMaxValue()
        {
            var val = decimal.MaxValue;
            var expectedResult = Math.Abs(val);
            Assert.That(Calc.Abs(val), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "NegativeDouble")]
        public void CheckAbs_PassNegativeDouble(double a)
        {
            var expectedResult = Math.Abs(a);

            Assert.That(Calc.Abs(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveDouble")]
        public void CheckAbs_PassPositiveDouble(double a)
        {
            var expectedResult = Math.Abs(a);

            Assert.That(Calc.Abs(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCase(0)]
        public void CheckAbs_PassZero(double a)
        {
            var expectedResult = Math.Abs(a);

            Assert.That(Calc.Abs(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveInt")]

        public void CheckAbs_PassPositiveInt(int a)
        {
            var expectedResult = Math.Abs(a);

            Assert.That(Calc.Abs(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "NegativeInt")]
        public void CheckAbs_PassNegativeInt(int a)
        {
            var expectedResult = Math.Abs(a);

            Assert.That(Calc.Abs(a), Is.EqualTo(expectedResult));
        }


        [Test, TestCaseSource(typeof(CaseSource), "NotNumberArgs")]
        public void CheckAbs_ThrowNotFiniteNumberException(string a)
        {
            Assert.That(() => Calc.Abs(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
        [Test, TestCase(null)]
        public void CheckAbs_PassNull_ThrowNullRefEx(object a)
        {
            Assert.That(() => Calc.Abs(a), Throws.Exception.TypeOf<NullReferenceException>());
        }

    }
}
