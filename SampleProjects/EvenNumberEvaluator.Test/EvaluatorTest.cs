using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvenNumberEvaluator;

namespace EvaluatorEvaluator.Test
{
    [TestClass]
    public class EvaluatorTest
    {
        [TestMethod]
        public void EvaluateNumber_Prints_NumberIsEven()
        {
            Evaluator Evaluator = new Evaluator();

            string actualMessage = Evaluator.EvaluateNumber(2);
            string expectedMessage = "The number is Even";

            Assert.AreEqual(actualMessage, expectedMessage);
        }

        [TestMethod]
        public void EvaluateNumber_Prints_NumberIsOdd()
        {
            Evaluator Evaluator = new Evaluator();

            string actualMessage = Evaluator.EvaluateNumber(3);
            string expectedMessage = "The number is Odd";

            Assert.AreEqual(actualMessage, expectedMessage);
        }

        [TestMethod]

        public void IsEvaluator_ReturnTrue_WhenNumberIsEven()
        {
            Evaluator Evaluator = new Evaluator();

            bool result = Evaluator.IsEvenNumber(4);

            Assert.IsTrue(result);

        }

        [TestMethod]

        public void IsEvaluator_ReturnFalse_WhenNumberIsOdd()
        {
            Evaluator Evaluator = new Evaluator();

            bool result = Evaluator.IsEvenNumber(3);

            Assert.IsFalse(result);

        }
    }
}
