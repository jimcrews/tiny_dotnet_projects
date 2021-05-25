using System;
using lib;
using NUnit.Framework;

namespace testsLib
{
    public class MemCalculatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            // arrange
            var calc = MakeCalc();

            //Act
            int lastSum = calc.Sum();

            // assert
            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            // arrange
            var calc = MakeCalc();

            //Act
            calc.Add(1);
            int sum = calc.Sum();

            // assert
            Assert.AreEqual(1, sum);
        }



        /*
        use a factory method to initialize MemCalculator. 
        This saves time writing the tests, makes the code inside each test smaller and a little more readable, 
        and makes sure MemCalculator is always initialized the same way.
        */
        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();
        }

    }
}