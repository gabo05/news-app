((app) => {
    'use strict';
    app.controller('searchController', ['$scope', 'newsFactory', ($scope, newsFact) => {
        $scope.news = [];
        $scope.search = {};
        $scope.already=false;
        $scope.find = () => {
            if($scope.search.end)
                $scope.search.end.setTime($scope.search.end.getTime() + 86399999);
            newsFact.search($scope.search)
            .then((result)=>{
                $scope.news = result;
                $scope.$apply();
                $scope.already=true;
            }).catch((error)=>{
                console.error(error);
                $scope.already=true;
            });
        };
    }]);
})(angular.module('newsapp'));