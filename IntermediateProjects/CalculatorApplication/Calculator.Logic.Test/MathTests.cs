using System;
using Calculator.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Logic.Test
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void AddNumbers_WhenCalled_ReturnsTheSumOfTwoNumbers()
        {
            Math math = new Math();

            var answer = math.AddNumbers(2, 4);

            Assert.AreEqual(answer, 6);
        }

        [TestMethod]
        public void SubtractNumbers_WhenCalled_ReturnsSubtractionOfTwoNumbers()
        {
            Math math = new Math();

            var answer = math.SubtractNumbers(4, 2);

            Assert.AreEqual(answer, 2);
        }

        [TestMethod]
        public void DivideNumbers_WhenCalled_ReturnsDivisionOfTwoNumbers()
        {
            Math math = new Math();

            var answer = math.DivideNumbers(4, 2);

            Assert.AreEqual(answer, 2);
        }

        [TestMethod]
        public void MultiplyNumbers_WhenCalled_ReturnsMultiplicationOfTwoNumbers()
        {
            Math math = new Math();

            var answe = math.MultiplyNumbers(2, 4);

            Assert.AreEqual(answe, 8);
        }


    }
}
