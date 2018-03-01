using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace Sub
{
    [Parallelizable(ParallelScope.Fixtures)]
    class SubTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "IntTestCasesTwoArg")]
        public void CheckSub_PassIntValue(int a, int b)
        {
            var expectedResult = (double)(a - b);
            Assert.That(Calc.Sub(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringTestCasesTwoArg")]
        public void CheckSub_PassStringValue(string a, string b)
        {
            var expectedResult = Convert.ToDouble(a) - Convert.ToDouble(b);
            Assert.That(Calc.Sub(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "DoubleTestCasesTwoArg")]
        public void CheckSub_PassDoubleValue(double a, double b)
        {
            var expectedResult = a - b;
            Assert.That(Calc.Sub(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCase(2d, null)]
        public void ThorwNullRefEx_PassNullValueLastArg(double a, object b)
        {
            Assert.That(() => Calc.Sub(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
        [Test]
        public void CheckCos_PassStrGreaterDecimalMaxValue_StackOverflowException()
        {
            var val = "79228162514264337593543950339";
            Assert.That(() => Calc.Sub(val,1), Throws.Exception.TypeOf<StackOverflowException>());
        }
        [Test, TestCase(null, 22d)]
        public void ThorwNullRefEx_PassNullValueFirstArg(object a, double b)
        {
            Assert.That(() => Calc.Sub(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
    }
}
