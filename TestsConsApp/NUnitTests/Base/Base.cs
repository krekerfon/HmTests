using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests.Base
{
    class Base
    {
        protected Calculator Calc { get; set; }

        [SetUp]
        public void Init()
        { 
            Calc = new Calculator();
        }
    }
}
