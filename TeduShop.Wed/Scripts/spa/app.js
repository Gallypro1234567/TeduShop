/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("StudentController", StudentController);
myApp.controller("TeacherController", TeacherController);
myApp.controller("SchoolController", SchoolController);
 

// khoi tao controll
function StudentController($scope) {
    $scope.message = "this is my love when i was student";
}
function TeacherController($scope) {
    $scope.message = " this is my teacher in life";
}
function SchoolController($scope) {
    $scope.message= "this is my school THPT Thuanhoa"
}