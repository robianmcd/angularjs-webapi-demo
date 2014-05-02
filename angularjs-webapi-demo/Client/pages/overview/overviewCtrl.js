var OverviewCtrl = function ($http, $location) {
    var _this = this;
    this.$location = $location;

    $http.get('api/stocks/info').success(function (data) {
        _this.stocksInfo = data;
    });

    /*
    clippy.load('Clippy', function (agent) {
        agent.show();
        agent.animate();
        agent.animate();
        agent.speak('Need help learning angular?');
    });
    */
};

OverviewCtrl.prototype.goToStockDetails = function (stockInfo) {
    this.$location.path('details').search('symbol', stockInfo.symbol);
};