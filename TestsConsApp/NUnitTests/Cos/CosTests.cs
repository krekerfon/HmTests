using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace Cos
{
    [Parallelizable(ParallelScope.All)]
    class CosTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "NegativeDouble")]
        public void CheckCos_PassNegativeDouble(double a)
        {
            var expectedResult = Math.Cos(a);

            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveDouble")]
        public void CheckCos_PassPositiveDouble(double a)
        {
            var expectedResult = Math.Cos(a);

            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCase(0)]
        public void CheckCos_PassZero(double a)
        {
            var expectedResult = Math.Cos(a);

            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveInt")]
        public void CheckCos_PassPositiveInt(int a)
        {
            var expectedResult = Math.Cos(a);
            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "NegativeInt")]
        public void CheckCos_PassNegativeInt(int a)
        {
            var expectedResult = Math.Cos(a);
            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "StringIntValues")]
        public void CheckCos_PassStringIntValues(string a)
        {
            var expectedResult = Math.Cos(Convert.ToInt32(a));
            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringRealValues")]
        public void CheckCos_PassStringRealValues(string a)
        {
            var expectedResult = Math.Cos(Convert.ToDouble(a));
            Assert.That(Calc.Cos(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCase(null)]
        public void CheckCos_NullReferenceException(string a)
        {
            Assert.That(() => Calc.Cos(a), Throws.Exception.TypeOf<NullReferenceException>());
        }
     
        [Test, TestCase(Double.PositiveInfinity)]
        public void CheckCos_PassInfinity_NotFiniteNumberException(double a)
        {
            Assert.That(() => Calc.Cos(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }

        [Test, TestCase(Double.NegativeInfinity)]
        public void CheckCos_PassInfinty_NotFiniteNumberException(double a)
        {
            Assert.That(() => Calc.Cos(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
        
        [Test, TestCase(Double.NaN)]
        public void CheckCos_PassNAN_NotFiniteNumberException(double a)
        {
            Assert.That(() => Calc.Cos(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
      
        [Test, TestCaseSource(typeof(CaseSource), "NotNumberArgs")]
        public void CheckCos_PassNotNumberArgs_NotFiniteNumberException(string a)
        {
            Assert.That(() => Calc.Cos(a), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
        [Test]
        public void CheckCos_PassGreaterThanDoubleMaxValue_StackOverflowException()
        {
            var val = "1.79769313486231599E+308";
            Convert.ToDouble(val);
            Assert.That(() => Calc.Cos(val), Throws.Exception.TypeOf<StackOverflowException>());
        }
        [Test]
        public void CheckCos_LessThanDoubleMinValue_StackOverflowException()
        {
            var val = "-1.79769313486231599E+308";
            Assert.That(() => Calc.Cos(val), Throws.Exception.TypeOf<StackOverflowException>());
        }

    }
}
