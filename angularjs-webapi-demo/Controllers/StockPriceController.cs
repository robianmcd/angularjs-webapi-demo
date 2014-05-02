using angularjs_webapi_demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace angularjs_webapi_demo.Controllers
{
    [RoutePrefix("api/stocks/price")]
    public class StockPriceController : ApiController
    {
        private StockService stockService = new StockService();

        [Route("{symbol}")]
        public IEnumerable<IEnumerable<double>> GetPricesForStockBySymbol(string symbol)
        {
            return this.stockService.GetDailyStockPrices(symbol);
        }

    }
}
