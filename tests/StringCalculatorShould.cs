using NUnit.Framework;

namespace coding_dojo_dotnetcore.tests
{
    class StringCalculatorShould
    {
        readonly StringCalculator stringCalculator = new StringCalculator();

        [Test]
        public void ReturnZeroWhenInputIsNull()
        {
            Assert.AreEqual(0, stringCalculator.Compute(null));
        }

        [Test]
        public void ReturnZeroWhenInputIsEmptyString()
        {
            Assert.AreEqual(0, stringCalculator.Compute(""));
        }

        [Test]
        public void Return1WhenInputIs1()
        {
            Assert.AreEqual(1, stringCalculator.Compute("1"));
        }

        [Test]
        public void Return2WhenInputIs1And1()
        {
            Assert.AreEqual(2, stringCalculator.Compute("1,1"));
        }

        [Test]
        public void Return2WhenInputIs1And1With2Arguments()
        {
            Assert.AreEqual(2, stringCalculator.Compute("1", "1"));
        }

        [Test]
        public void Return6WhenInputIs11And1With2Arguments()
        {
            Assert.AreEqual(6, stringCalculator.Compute("1,2", "3"));
        }
    }
}
