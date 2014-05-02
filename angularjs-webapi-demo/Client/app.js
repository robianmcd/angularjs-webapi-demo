var app = angular.module('stockApp', ['ngRoute', 'mgcrea.ngStrap']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider
        .when('/overview', {
            templateUrl: 'client/pages/overview/overview.html'
        })
        .when('/details', {
            templateUrl: 'client/pages/details/details.html'
        })
        .otherwise({
            redirectTo: '/overview'
        });
  }]);