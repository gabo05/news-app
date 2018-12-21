((app) => {
    'use strict';
    app.controller('featuredController', ['$scope', 'newsFactory', ($scope, newsFact) => {
        $scope.news = [];
        var loadNews = () => {
            newsFact.getFeatured(3)
            .then((result)=>{
                $scope.news = result;
                $scope.$apply();
            }).catch((error)=>{
                console.error(error);
            });
        };
        loadNews();
    }]);
})(angular.module('newsapp'));