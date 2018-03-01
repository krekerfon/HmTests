using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace Divide
{
    [Parallelizable(ParallelScope.All)]
    class DivTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "DoubleTestCasesTwoArg")]
        public void CheckDiv_PassDoubleValue(double a, double b)
        {
            var expectedResult = a / b;
            Assert.That(Calc.Divide(a, b), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "IntTestCasesTwoArg")]
        public void CheckDiv_PassIntValue(double a, double b)
        {
            var expectedResult = a / b;
            Assert.That(Calc.Divide(a, b), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "RealValues")]
        public void CheckDiv_DivideByZeroException(double a)
        {
            Assert.That(() => Calc.Divide(a,0),Throws.Exception.TypeOf<DivideByZeroException>());
        }
        [Test, TestCase(Double.NaN,2d)]
        public void CheckSin_PassInfinity_NotFiniteNumberException(double a, double b)
        {
            Assert.That(() => Calc.Divide(a, b), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
        [Test, TestCase(Double.PositiveInfinity, Double.PositiveInfinity)]
        public void CheckSin_PassNInfinity_NotFiniteNumberException(double a, double b)
        {
            Assert.That(() => Calc.Divide(a, b), Throws.Exception.TypeOf<NotFiniteNumberException>());
        }
        [Test, TestCase(Double.NegativeInfinity, Double.PositiveInfinity)]
        public void CheckSin_PassPInfinity_NotFiniteNumberException(double a, double b)
        {
            Assert.That(() => Calc.Divide(a, b), Throws.Exception.TypeOf<DivideByZeroException>());
        }
        [Test, TestCase(0d, 0d)]
        public void CheckDiv_DivideByZeroException(double a, double b)
        {
            Assert.That(() => Calc.Divide(a, b), Throws.Exception.TypeOf<DivideByZeroException>());
        }
    }
}
