
using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;

namespace Pow
{
    [Parallelizable(ParallelScope.Fixtures)]
    class PowTests : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "IntTestCasesTwoArg")]
        public void CheckPow_PassIntValue(int a, int b)
        {
            var expectedResult = Math.Pow(a, b);
            Assert.That(Calc.Pow(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCase(2, 2.3d)]
        public void CheckPow_PassIntAndDouble(int a, double b)
        {
            var expectedResult = Math.Pow(a, b);

            Assert.That(Calc.Pow(a, b), Is.EqualTo(expectedResult));
        }
        [Test, TestCase(1, -1)]
        public void CheckPow(int a, double b)
        {
            var expectedResult = Math.Pow(Convert.ToDouble(a), b);
            var s = Math.Pow(a, b);

            Assert.That(Calc.Pow(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringTestCasesTwoArg")]
        public void CheckPow_PassStringValue(string a, string b)
        {
            var expectedResult = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));

            Assert.That(Calc.Pow(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "DoubleTestCasesTwoArg")]
        public void CheckPow_PassDoubleValue(double a, double b)
        {
            var expectedResult = Math.Pow(a, b);
            Assert.That(Calc.Pow(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCase(2d, null)]
        public void ThorwNullRefEx_PassNullValueLastArg(double a, object b)
        {
            Assert.That(() => Calc.Pow(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
        [Test, TestCase(null, 22d)]
        public void ThorwNullRefEx_PassNullValueFirstArg(object a, double b)
        {
            Assert.That(() => Calc.Pow(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
        [Test, TestCase(null, null)]
        public void ThorwNullRefEx_PassNullValues(object a, double b)
        {
            Assert.That(() => Calc.Pow(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
        [TestCase(int.MaxValue, double.MaxValue)]
        public void CheckPow_IsInfinity(int a, double b)
        {
            var expectedResut = Math.Pow(a, b);
            Assert.AreEqual(Calc.Pow(a, b), expectedResut);
        }
        [TestCase(2, double.NaN)]
        public void CheckPow_IsNaN(int a, double b)
        {
            var expectedResut = Math.Pow(a, b);
            Assert.AreEqual(Calc.Pow(a, b), expectedResut);
        }
    }
}
