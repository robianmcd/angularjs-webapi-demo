describe('OverviewCtrl:', function () {
    var $httpBackend;
    var $location;
    var overviewCtrl;

    var stockInfo = { sample: 'sample' };

    beforeEach(function () {
        module('stockApp');

        inject(function ($controller, $rootScope, _$httpBackend_, _$location_) {
            $location = _$location_;
            $httpBackend = _$httpBackend_;
            $httpBackend.whenGET('api/stocks/info').respond(stockInfo);

            overviewCtrl = $controller('OverviewCtrl', { $scope: $rootScope.$new() });
        });
    });

    it("should retrieve and store the stock info from the API", function () {
        $httpBackend.flush();

        expect(overviewCtrl.stocksInfo).toEqual(stockInfo);
    });

    it("goToStockDetails() should set the location", function () {
        overviewCtrl.goToStockDetails({ symbol: 'TEST' });

        expect($location.url()).toEqual('/details?symbol=TEST');
    });

    it("test() should return 1", function () {
        expect(overviewCtrl.test()).toEqual(1);
    });
});