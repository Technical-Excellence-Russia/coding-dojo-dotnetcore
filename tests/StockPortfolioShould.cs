using coding_dojo_dotnetcore.src;
using NUnit.Framework;

namespace coding_dojo_dotnetcore.tests
{
    partial class StockPortfolioShould
    {
        private StockPortfolio stockPortFolio;

        [SetUp]
        public void Setup()
        {
            stockPortFolio = new StockPortfolio();
        }

        [Test]
        public void ReturnZeroStocksOnStart()
        {
            Assert.AreEqual(0, stockPortFolio.GetStockCount());
        }

        [Test]
        public void ReturnZeroStocksByTicker()
        {
            Assert.AreEqual(0, stockPortFolio.GetStockCountByTicker("SBER"));
        }

        [Test]
        public void GiveAbilityToBuy2DifferentStocks()
        {
            stockPortFolio.BuyStocks("SBER", 1);
            stockPortFolio.BuyStocks("APPLE", 1);

            Assert.AreEqual(1, stockPortFolio.GetStockCountByTicker("SBER"));
            Assert.AreEqual(1, stockPortFolio.GetStockCountByTicker("APPLE"));
            Assert.AreEqual(2, stockPortFolio.GetStockCount());
        }

        [Test]
        public void ThrowNoMoreStocksExceptionWhenTryToSellMoreThenHave()
        {
            Assert.Throws<NoMoreStocksException>(() => stockPortFolio.SellStocks("ALFA", 100));
        }

        [Test]
        public void GiveAbilityToSellStocks()
        {
            stockPortFolio.BuyStocks("SBER", 1);
            stockPortFolio.SellStocks("SBER", 1);
            stockPortFolio.BuyStocks("APPLE", 1);

            Assert.AreEqual(0, stockPortFolio.GetStockCountByTicker("SBER"));
            Assert.AreEqual(1, stockPortFolio.GetStockCountByTicker("APPLE"));
        }
    }
}
