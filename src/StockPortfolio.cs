using System.Collections.Generic;

namespace coding_dojo_dotnetcore.src
{
    public class StockPortfolio
    {
        readonly IDictionary<string, int> stocks = new Dictionary<string, int>();

        public StockPortfolio()
        {
        }

        public void Add(string stockName, int stockCount)
        {
            stocks[stockName] = (stocks.ContainsKey(stockName) ? stocks[stockName] : 0) + stockCount;
        }

        public int GetSize()
        {
            return stocks.Count;
        }

        public int GetStockCount(string stockName)
        {
            return stocks[stockName];
        }

        public bool IsEmpty()
        {
            return GetSize() == 0;
        }
    }
}
