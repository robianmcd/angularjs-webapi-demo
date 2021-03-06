﻿var DetailsCtrl = function ($http, $location, $timeout, $rootScope) {
    var _this = this;

    this.$http = $http;
    this.$location = $location;
    this.$timeout = $timeout;
    this.$rootScope = $rootScope;

    $http.get('api/stocks/info').success(function (data) {
        _this.stocksInfo = data;
        var searchedSymbol = $location.search().symbol;

        if (searchedSymbol) {
            _this.selectedStockInfo = _this.stocksInfo.filter(
                function (stockInfo) {
                    return stockInfo.symbol === searchedSymbol
                })[0];
            _this.loadStockPricesForSymbol(searchedSymbol);
        }

    });

    
};

angular.module('stockApp').controller('DetailsCtrl', DetailsCtrl);

DetailsCtrl.prototype.onSelectedStockChange = function () {
    this.$rootScope.viewAnimation = '';
    this.$location.search('symbol', this.selectedStockInfo.symbol);
};

DetailsCtrl.prototype.loadStockPricesForSymbol = function (symbol) {
    var _this = this;

    this.$http.get('api/stocks/price/' + symbol).success(function (data) {
        _this.rowAnimateClass = '';
        _this.$timeout(function () {
            _this.rowAnimateClass = 'row-slide-end';
        },100);

        _this.stockPrices = data;
    });
}