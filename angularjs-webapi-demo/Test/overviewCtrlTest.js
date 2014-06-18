describe('OverviewCtrl:', function () {
    var overviewCtrl;

    beforeEach(function () {
        module('stockApp');

        inject(function ($controller, $rootScope, $httpBackend) {
            $httpBackend.whenGET('api/stocks/info').respond({});

            overviewCtrl = $controller('OverviewCtrl', { $scope: $rootScope.$new() });
        });
    });

    it("test() should return 1", function () {
        expect(overviewCtrl.test()).toBe(1);
    });
});