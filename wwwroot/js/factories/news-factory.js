((app)=>{
    'use strict';
    app.factory('newsFactory', ['$http', ($http)=>{
        return{
            getFeatured: (limit)=>{
                return new Promise((resolve, reject)=>{
                    return $http.get(`News/Featured/${limit}`)
                    .then((response) => {
                        if(response.status === 200)
                            resolve(response.data);
                        else
                            reject(response);
                    }, (error) => {
                        reject(error);
                    });
                });
            },
            search: (s) => {
                return new Promise((resolve, reject)=>{
                    return $http.get('/News/Find', {params: s})
                    .then((response) => {
                        if(response.status === 200)
                            resolve(response.data);
                        else
                            reject(response);
                    }, (error) => {
                        reject(error);
                    });
                });
            }
        }
    }]);
})(angular.module('newsapp'));