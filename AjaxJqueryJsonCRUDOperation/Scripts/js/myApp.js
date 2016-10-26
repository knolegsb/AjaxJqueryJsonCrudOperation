var myApp = angular.module('myApp', []);
myApp.controller('employeeCtrl', function ($scope, $http) {

    $scope.employees = "";

    $http.get("/NgEmployee/GetEmployee")
    .success(function (result) {
        $scope.employees = result;
    })
    .error(function (result) {
        console.log(result);
    });

    $scope.savedata = function (employee) {
        $http.post("/Employee/SaveEmployee", { _oEmployee: employee })
        .success(function (result) {
            $scope.employees = result;
        })
        .error(function (result) {
            console.log(result);
        })
    }
})