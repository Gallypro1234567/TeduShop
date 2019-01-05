/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("SchoolController", SchoolController);
myApp.service('Validator', Validator);
SchoolController.$inject = ['$scope', 'Validator'];

// khoi tao controll
 
function SchoolController($scope, Validator) {
   
    $scope.CheckNumber = function () {
        $scope.message = Validator.checknumber($scope.num);
    }
    $scope.num = 1;
}
function Validator($window) {
    return {
        checknumber: checknumber
    }
    function checknumber(input) {
        if (input % 2 == 0) {
            return 'this is even';
        }
        else return 'this is odd';
    }
}