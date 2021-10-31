using NUnit.Framework;

namespace NunitTestProject1
{
    public class UnitTestSuite1
    {
        [SetUp]
        public void Setup()
        {
        }
        public int Square(int x) => x * x;
        public int Big(int a, int b) =>  a > b ? a : b;
        [Test]
        public void Test1()
        {
            //Assign
            int inputNumber = 5;
            int expectedSquare = 25;

            //Act
            int actualSquare = Square(inputNumber);

            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
        [Test]
        public void Test2()
        {
            //Assign
            int inputFirstNumber = 5, inputSecondNumber = 10;
            int expectedBig= 10;

            //Act
            int actualBig = Big(inputFirstNumber, inputSecondNumber);

            //Assert
            Assert.AreEqual(expectedBig,actualBig);
        }
    }
}