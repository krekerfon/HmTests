using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;
using System.Threading;

namespace Multiply
{
    [Parallelizable(ParallelScope.Fixtures)]
    class MultiplyTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "DoubleTestCasesTwoArg")]
        public void CheckMul_PassDoubleValue(double a, double b)
        {
            var expectedResult = a / b;
            Assert.That(Calc.Multiply(a, b), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "IntTestCasesTwoArg")]
        public void CheckDiv_PassIntValue(int a, int b)
        {
            var expectedResult = a / (double)b;
            Assert.That(Calc.Multiply(a, b), Is.EqualTo(expectedResult));
        }
        [Test, TestCaseSource(typeof(CaseSource), "RealValues")]
        public void CheckDiv_ThrowDivideByZeroException(double a)
        {
            Assert.That(() => Calc.Multiply(a, 0), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test, TestCase(0d, 0d)]
        public void CheckDiv_DivideByZeroIsReturendNAN(double a, double b)
        {
            Assert.IsTrue(double.IsNaN(Calc.Multiply(a, b)));
        }
        [TestCase(2d, 0d)]
        public void CheckDiv_IsInfinity(double a, double b)
        {
            Assert.IsTrue(Calc.Multiply(a, b) < 0);
        }
        [TestCase(0d, 0d)]
        public void CheckMul_IsReturned0(double a, double b)
        {
            Assert.IsTrue(Calc.Multiply(a, b) < 0);
        }
    }
}
