using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;


namespace Sin
{
    [Parallelizable(ParallelScope.All)]
    class SinTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "NegativeDouble")]
        public void CheckSin_PassNegativeDouble(double a)
        {
            var expectedResult = Math.Sin(a);

            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveDouble")]
        public void CheckSin_PassPositiveDouble(double a)
        {
            var expectedResult = Math.Sin(a);

            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCase(0)]
        public void CheckSin_PassZero(double a)
        {
            var expectedResult = Math.Sin(a);

            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveInt")]
        public void CheckSin_PassPositiveInt(int a)
        {
            var expectedResult = Math.Sin(a);
            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "NegativeInt")]
        public void CheckSin_PassNegativeInt(int a)
        {
            var expectedResult = Math.Sin(a);
            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "StringIntValues")]
        public void CheckSin_PassStringIntValues(string a)
        {
            var expectedResult = Math.Sin(Convert.ToInt32(a));
            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringRealValues")]
        public void CheckSin_PassStringRealValues(string a)
        {
            var expectedResult = Math.Sin(Convert.ToDouble(a));
            Assert.That(Calc.Sin(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCase(null)]
        public void CheckSin_NullReferenceException(string a)
        {
            Assert.That(() => Calc.Sin(a), Throws.Exception.TypeOf<NullReferenceException>());
        }

        [Test, TestCase(Double.PositiveInfinity)]
        public void CheckSin_PassInfinity_NotFiniteNumberException(double a)
        {
            Assert.That(() => Calc.Sin(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }

        [Test, TestCase(Double.NegativeInfinity)]
        public void CheckSin_PassInfinty_NotFiniteNumberException(double a)
        {
            Assert.That(() => Calc.Sin(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }

        [Test, TestCase(Double.NaN)]
        public void CheckSin_PassNAN_NotFiniteNumberException(double a)
        {
            Assert.That(() => Calc.Sin(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }

        [Test, TestCaseSource(typeof(CaseSource), "NotNumberArgs")]
        public void CheckSin_PassNotNumberArgs_NotFiniteNumberException(string a)
        {
            Assert.That(() => Calc.Sin(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
        [Test]
        public void CheckSin_PassGreaterThanDoubleMaxValue_StackOverflowException()
        {
            var val = "1.79769313486231599E+308";
            Assert.That(() => Calc.Sin(val), Throws.Exception.TypeOf<StackOverflowException>());
        }
        [Test]
        public void CheckSin_LessThanDoubleMinValue_StackOverflowException()
        {
            var val = "-1.79769313486231599E+308";
            Assert.That(() => Calc.Sin(val), Throws.Exception.TypeOf<StackOverflowException>());
        }
    }
}
