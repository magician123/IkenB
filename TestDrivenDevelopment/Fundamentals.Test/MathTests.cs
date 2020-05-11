using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Test
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_TwoNumbersAdded_ReturnsTheSum()
        {
            Math math = new Math();

            var sum = math.Add(2,2);

            Assert.AreEqual(sum,4);

        }

        [TestMethod]
        public void Max_TwoNumbersGiven_ReturnsMaximumNumber()
        {
            Math math = new Math();

            var max = math.Max(5, 3);

            Assert.AreEqual(max, 5);
        }

        [TestMethod]
        public void Max_TwoNumbersGiven_ReturnsSmall()
        {
            Math math = new Math();

            var min = math.Max(5, 3);

            Assert.AreNotEqual(3, min);
        }

        [TestMethod]
        public void GetOddNumber_GivenNumber_ReturnsOddNumber()
        {
            Math math = new Math();

            var odd = math.GetOddNumbers(4);

            Assert.AreEqual(odd, 2);
        }
    }
}
