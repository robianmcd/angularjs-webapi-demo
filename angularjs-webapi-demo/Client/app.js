var app = angular.module('stockApp', ['ngRoute', 'mgcrea.ngStrap']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider
        .when('/overview', {
            templateUrl: 'client/overview/overview.html'
        })
        .when('/details', {
            templateUrl: 'client/details/details.html'
        })
        .otherwise({
            redirectTo: '/overview'
        });
  }]);