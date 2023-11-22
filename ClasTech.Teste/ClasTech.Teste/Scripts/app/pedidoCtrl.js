angular.module('pedido', [])
.controller('pedidoCtrl', ['$rootScope', '$scope', '$http', function ($rootScope, $scope, $http) {
    $scope.init = function () {
        $scope.titulo = "pedidos";
 
        $http.post("/api/")
        .then(function (response) {
         
        })
        .catch(function (error) {

        })
        .finally(function () {

        });
    };

    $scope.init();
}
]);
