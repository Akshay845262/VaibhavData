using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MathClassLibrary;
namespace MathClassLibrary.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void Maths_Add_Should_Return_Add_Value()
        {
            //Prepare
            Maths maths = new Maths();
            int a = 2;
            int b = 3;

            int expected = 5;
            //Execute
            int result = maths.Add(a, b);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result == expected);
            Assert.AreEqual(expected, result);
            Assert.IsFalse(result != expected);
        }
        [TestMethod]
        public void Maths_Sub_Should_Sub_Value()
        {
            Maths maths = new Maths();
            int x = 7;
            int y = 2;
            int expected = 5;
            int result1 = maths.Sub(x, y);
            Assert.IsNotNull(result1);
            Assert.IsTrue(result1 == expected);
            Assert.AreEqual(expected, result1);
            Assert.IsFalse(result1 != expected);
        }
        [TestMethod]
        public void Maths_Mul_Should_Mul_Value()
        {
            Maths maths = new Maths();
            int x = 7;
            int y = 2;
            int expected = 14;
            int result1 = maths.Mul(x, y);
            Assert.IsNotNull(result1);
            Assert.IsTrue(result1 == expected);
            Assert.AreEqual(expected, result1);
            Assert.IsFalse(result1 != expected);
        }
        [TestMethod]
        public void Maths_Div_Should_Div_Value()
        {
            Maths maths = new Maths();
            int x = 6;
            int y = 2;
            float expected = x / y;
            float result1 = maths.Divide(x, y);
            Assert.IsNotNull(result1);
            Assert.IsTrue(result1 == expected);
            Assert.AreEqual(expected, result1);
            Assert.IsFalse(result1 != expected);
        }
        [TestMethod]
        public void RandomClass_getRandomNumber_Return_Random_Value()
        {
            Random rand = new Random();
            RandomClass rnd = new RandomClass();
            int result = rnd.getRandomNumber();
            double result2 = rand.NextDouble();
            Assert.IsTrue(result > 0 && result <= 10 && result != result2);
        }
        [TestMethod]
        public void MathsClass_calc_Return_Add_value()
        {
            Mock<IRandomClass> mockRandom = new Mock<IRandomClass>();
            //mockRandom.Setup(m => m.getRandomNumber()).Returns(4);
            mockRandom.Setup(m => m.getRandomNumber()).Returns(()=>4);
            Maths maths = new Maths(mockRandom.Object);
            int a = 4;
            int b = 6;
            int expected;

            expected = 10;
            //expected = 24;

            int result = maths.calc(a, b);
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void MathsClass_calc_Return_Mul_value()
        {
            Mock<IRandomClass> mockRandom = new Mock<IRandomClass>();
            //mockRandom.Setup(m => m.getRandomNumber()).Returns(4);
            mockRandom.Setup(m => m.getRandomNumber()).Returns(() => 6);
            Maths maths = new Maths(mockRandom.Object);
            int a = 4;
            int b = 6;
            int expected;

            //expected = 10;
            expected = 24;

            int result = maths.calc(a, b);
            Assert.IsTrue(result == expected);
        }
    }
}
