var OverviewCtrl = function ($http, $location, $rootScope) {
    var _this = this;
    this.$location = $location;
    this.$rootScope = $rootScope;

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
    this.$rootScope.viewAnimation = 'slide-left';
    this.$location.path('details').search('symbol', stockInfo.symbol);
};

OverviewCtrl.prototype.test = function () {
    return 1;
};