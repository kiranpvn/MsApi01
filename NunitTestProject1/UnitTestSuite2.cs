using NUnit.Framework;
using CalculationLibrary;
namespace NunitTestProject1
{
    public class UnitTestSuite2
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            //Assign
            int inputNumber = 5;
            int expectedFactorial = 120;

            //Act
            int actualFactorial = Calculator.Factorial(inputNumber);

            //Assert
            Assert.AreEqual(expectedFactorial, actualFactorial);
        }
        [Test]
        public void Test2()
        {
            //Assign
            int inputNumber = 3456;
            int expectedReverse = 6543;

            //Act
            int actualReverse = Calculator.Reverse(inputNumber);

            //Assert
            Assert.AreEqual(expectedReverse, actualReverse);
        }
    }
}