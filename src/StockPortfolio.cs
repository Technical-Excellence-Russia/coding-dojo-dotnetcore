using System;
using System.Collections.Generic;
using System.Linq;

namespace coding_dojo_dotnetcore.src
{
    public class StockPortfolio
    {
        private Dictionary<string, int> stocks = new Dictionary<string, int>();
        private int contractsCount = 0;

        internal int GetStockCount()
        {
            return stocks.Select(_ => _.Value).Sum();
        }

        internal void BuyStocks(string ticker, int count)
        {
            if (stocks.ContainsKey(ticker))
            {
                var currentCount = stocks[ticker];
                stocks[ticker] = currentCount + count;
            }
            else
            {
                stocks.Add(ticker, count);
            }
            
            contractsCount+=count;
        }

        internal int GetStockCountByTicker(string ticker)
        {
            if (stocks.ContainsKey(ticker))
            {
                return stocks[ticker];
            }

            return 0;
        }

        internal void SellStocks(string ticker, int count)
        {
            var currentCount = GetStockCountByTicker(ticker);
            if (count > currentCount)
            {
                throw new NoMoreStocksException();
            }
            
            stocks[ticker] = currentCount - count;

            contractsCount += count;
        }

        internal int GeAllSoldAndBoughtStocks()
        {
            return contractsCount;
        }
    }
}
