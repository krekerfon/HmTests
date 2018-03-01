using NUnit.Framework;
using NUnitTests.Base;
using NUnitTests.CaseData;
using System;


namespace Add
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    class TestAdd : Base
    {
        [Test, TestCaseSource(typeof(CaseSource), "IntTestCasesTwoArg")]
        public void CheckSumm_PassIntValue(int a, int b)
        {
            var expectedResult = (double)(a + b);
            Assert.That(Calc.Add(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "StringTestCasesTwoArg")]
        public void CheckSumm_PassStringValue(string a, string b)
        {
            var expectedResult = Convert.ToDouble(a) + Convert.ToDouble(b);
            Assert.That(Calc.Add(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCaseSource(typeof(CaseSource), "DoubleTestCasesTwoArg")]
        public void CheckSumm_PassDoubleValue(double a, double b)
        {
            var expectedResult = a + b;
            Assert.That(Calc.Add(a, b), Is.EqualTo(expectedResult));
        }

        [Test, TestCase(2d,null)]
        public void ThorwNullRefEx_PassNullValueLastArg(double a, object b)
        {
            Assert.That(() => Calc.Add(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
        [Test, TestCase(null, 22d)]
        public void ThorwNullRefEx_PassNullValueFirstArg(object a, double b)
        {
            Assert.That(() => Calc.Add(a, b), Throws.Exception.TypeOf<NullReferenceException>());
        }
    
    }
}
