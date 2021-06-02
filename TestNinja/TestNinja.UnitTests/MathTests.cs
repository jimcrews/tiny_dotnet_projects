using NUnit.Framework;
using TestNinja.Lib.Fundamentals;

namespace TestNinja.UnitTests
{
    public class MathTests
    {
        private Math _math;

        // fires for each test
        // Setup methods are called on base classes first, then on derived classes. If any setup method throws an exception, no further setups are called. 
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("because i wanted to..")]
        public void Add_WhenCalled_ReturnTheSum()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }


    }
}