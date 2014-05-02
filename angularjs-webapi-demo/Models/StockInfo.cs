using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angularjs_webapi_demo.Models
{
    public class StockInfo
    {
        public readonly string name;
        public readonly string symbol;
        public readonly double change;
        public readonly double percentChange;
        public readonly double value;
        public readonly int volume;

        public StockInfo(string name) {
            this.name = name;
        }

        public StockInfo(string symbol, string name, double change, double percentChange, double value, int volume)
        {
            this.symbol = symbol;
            this.name = name;
            this.change = change;
            this.percentChange = percentChange;
            this.value = value;
            this.volume = volume;
        }
    }
}