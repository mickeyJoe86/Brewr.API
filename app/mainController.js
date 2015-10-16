(function () {
    
    angular
        .module("Brewr")
        .controller("mainController", ['$scope', function ($scope) {

            $scope.message = "Hello Brewrs!"
        }]);
}());