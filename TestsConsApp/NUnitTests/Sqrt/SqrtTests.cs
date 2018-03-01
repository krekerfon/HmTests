using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace Sqrt
{
    [Parallelizable(ParallelScope.All)]
    class SqrtTests : Base
    {
        [TestCase(double.MaxValue)]
        public void CheckSqrt_PassDoubleMaxValue(double a)
        {
            var expectedResult = Math.Sqrt(a);
            Assert.That(Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "NegativeDouble")]
        public void CheckSqrt_PassNegativeDouble(double a)
        {
            var expectedResult = Math.Sqrt(a);
            Assert.That(Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveDouble")]
        public void CheckSqrt_PassPositiveDouble(double a)
        {
            var expectedResult = Math.Sqrt(a);
            Assert.That(Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }
      
        [Test, TestCase(0)]
        public void CheckSqrt_PassZero(double a)
        {
            var expectedResult = Math.Sqrt(a);

            Assert.That(Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "PositiveInt")]

        public void CheckSqrt_PassPositiveInt(int a)
        {
            var expectedResult = Math.Sqrt(a);

            Assert.That(Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "NegativeInt")]
        public void CheckSqrt_PassNegativeInt(int a)
        {
            var expectedResult = Math.Sqrt(a);
            Assert.That(Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringIntValues")]
        public void CheckSqrt_PassStringIntValues(string a)
        {
            var expectedResult = Math.Sqrt(Convert.ToInt32(a));
            Assert.That(() => Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringRealValues")]
        public void CheckSqrt_PassStringRealValues(string a)
        {
            var expectedResult = Math.Sqrt(Convert.ToDouble(a));
            Assert.That(() => Calc.Sqrt(a), Is.EqualTo(expectedResult));
        }
        [Test, TestCase(null)]
        public void CheckSqrt_PassNull_ThrowNullRefEx(object a)
        {
            Assert.That(() => Calc.Sqrt(a), Throws.Exception.TypeOf<NullReferenceException>());
        }
        [Test, TestCase(null)]
        public void CheckSqrt_PassNull_NullReferenceException(string a)
        {
            Assert.That(() => Calc.Sqrt(a), Throws.Exception.TypeOf<NullReferenceException>());
        }
    }
}
