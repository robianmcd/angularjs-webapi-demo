using angularjs_webapi_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angularjs_webapi_demo.Services
{
    public class StockService
    {
        private static readonly List<StockInfo> allStockInfo = new List<StockInfo>() { 
                new StockInfo(
                    symbol: "ADBE",
		            name: "Adobe Systems Inc.",
		            change: -1.21,
		            percentChange: -1.96,
		            value: 60.40,
		            volume: 3699758
                ),
                new StockInfo(
                    symbol: "GOOG",
		            name: "Google Inc.",
		            change: 0.97,
		            percentChange: 0.19,
		            value: 517.15,
		            volume: 2803252
                ),
                new StockInfo(
                    symbol: "AAPL",
		            name: "Apple Inc.",
		            change: 22.15,
		            percentChange: 3.87,
		            value: 594.09,
		            volume: 20841477
                ),
                new StockInfo(
                    symbol: "MSFT",
		            name: "Microsoft Corporation",
		            change: 0.96,
		            percentChange: 2.41,
		            value: 40.87,
		            volume: 49005058
                ),
                new StockInfo(
                    symbol: "AMKR",
		            name: "Amkor Technology, Inc.",
		            change: -0.09,
		            percentChange: -1.26,
		            value: 7.07,
		            volume: 1801758
                ),
                new StockInfo(
                    symbol: "HPQ",
		            name: "Hewlett Packard Company",
		            change: 0.61,
		            percentChange: 1.93,
		            value: 32.19,
		            volume: 10614887
                ),
                new StockInfo(
                    symbol: "LXK",
		            name: "Lexmark International Inc.",
		            change: 0.77,
		            percentChange: 1.85,
		            value: 42.38,
		            volume: 1317686
                ),
                new StockInfo(
                    symbol: "SNDK",
		            name: "SanDisk Corp.",
		            change: 0.03,
		            percentChange: 0.04,
		            value: 84.38,
		            volume: 3084649
                ),
                new StockInfo(
                    symbol: "TEL",
		            name: "TE Connectivity Ltd.",
		            change: -0.90,
		            percentChange: -1.52,
		            value: 58.34,
		            volume: 2079001
                ),
                new StockInfo(
                    symbol: "AVX",
		            name: "AVX Corp.",
		            change: 0.53,
		            percentChange: 4.02,
		            value: 13.70,
		            volume: 442165
                ),
                new StockInfo(
                    symbol: "INTC",
		            name: "Intel Corporation",
		            change: 0.07,
		            percentChange: 0.27,
		            value: 26.33,
		            volume: 31255106
                ),
                new StockInfo(
                    symbol: "INTU",
		            name: "Intuit Inc.",
		            change: -0.65,
		            percentChange: -0.86,
		            value: 74.69,
		            volume: 589952
                ),
            };

        public IEnumerable<StockInfo> GetAllStockInfo() {
            return allStockInfo;
        }

        public StockInfo GetStockInfoBySymbol(string symbol)
        {
            return allStockInfo.FirstOrDefault((stockInfo) => stockInfo.symbol == symbol);
        }

        public IEnumerable<IEnumerable<double>> GetDailyStockPrices(string stockId) {
            double unixMilisecondTimNow = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalMilliseconds;
            int milisecondsPerDay = 1000 * 60 * 60 * 24;
            Random rand = new Random();

            //Timestamp for Jan 2007
            double unixMilisecondTime = 1167609600000;
            double value = 100;
            var dailyPrices = new List<List<double>>();

            while (unixMilisecondTime < unixMilisecondTimNow)
            {
                dailyPrices.Add(new List<double>() { unixMilisecondTime, value });

                value += (rand.NextDouble() - 0.5) * 2;
                value = Math.Round(value, 2);
                unixMilisecondTime += milisecondsPerDay;
            }


            return dailyPrices;
        }
    }
}