var app = angular.module('app', [
    'ngRoute',
    'ngCookies',
    'ngAnimate',
    'ngSanitize',
    'pedido'
]);

app.config(['$provide', '$routeProvider', function ($provide, $routeProvider) {
    $routeProvider.when('/pedido', {
        templateUrl: '/Content/templates/pedido.html',
        controller: 'pedidoCtrl'
    });
}]);

//GLOBAL FUNCTIONS - pretty much a root/global controller.
//Get username on each page
//Get updated token on page change.
//Logout available on each page.
app.run(['$rootScope', '$http', '$cookies', '$cookieStore', '$location', function ($rootScope, $http, $cookies, $cookieStore, $location) {

}]);

$(document).ready(function () {
    $('.table .valor').click(function () {
        $(this).css('background-color', 'aquablue')
    })
})
