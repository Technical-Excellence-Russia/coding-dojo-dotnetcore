using coding_dojo_dotnetcore.src;
using NUnit.Framework;

namespace coding_dojo_dotnetcore.tests
{
    public class StockPortfolioShould
    {

        StockPortfolio stockPortfolio;

        [SetUp]
        public void SetUp()
        {
            stockPortfolio = new StockPortfolio();
        }

        [Test]
        public void ReturnBeEmptyAtStart()
        {
            Assert.IsTrue(stockPortfolio.IsEmpty());
        }


        [Test]
        public void ReturnZeroAsSizeOfPortfolioAtStart()
        {
            Assert.AreEqual(0, stockPortfolio.GetSize());
        }

        [Test]
        public void GiveAbilityToAddStock()
        {
            stockPortfolio.Add("APPL", 1);
            Assert.IsFalse(stockPortfolio.IsEmpty());
            Assert.AreEqual(1, stockPortfolio.GetSize());
        }

        [Test]
        public void GiveAbilityToCountOfUniqueStock()
        {
            stockPortfolio.Add("APPL", 1);
            Assert.IsFalse(stockPortfolio.IsEmpty());
            Assert.AreEqual(1, stockPortfolio.GetStockCount("APPL"));
        }

        [Test]
        public void GiveAbilityToAddMoreThenOneStock()
        {
            stockPortfolio.Add("APPL", 1);
            stockPortfolio.Add("APPL", 1);
            Assert.IsFalse(stockPortfolio.IsEmpty());
            Assert.AreEqual(1, stockPortfolio.GetSize());
            Assert.AreEqual(2, stockPortfolio.GetStockCount("APPL"));
        }

    }

}
