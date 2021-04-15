using NUnit.Framework;
using lib;

namespace tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Car car = new Car("Yellow");
            string description = car.Describe();
            Assert.IsTrue(description == "This car is Yellow");
        }
    }
}