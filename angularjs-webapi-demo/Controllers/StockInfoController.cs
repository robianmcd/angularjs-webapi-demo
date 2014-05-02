using angularjs_webapi_demo.Models;
using angularjs_webapi_demo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace angularjs_webapi_demo.Controllers
{
    [RoutePrefix("api/stocks/info")]
    public class StockInfoController : ApiController
    {
        private StockService stockService = new StockService();


        [Route("")]
        public IEnumerable<StockInfo> GetAllStockInfo() {
            return this.stockService.GetAllStockInfo();
        }

        [Route("{symbol}")]
        public StockInfo GetStockInfoBySymbol(string symbol)
        {
            return this.stockService.GetStockInfoBySymbol(symbol);
        }
    }
}
