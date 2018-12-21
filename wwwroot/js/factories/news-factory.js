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
            search: (search) => {
                return new Promise((response, reject)=>{
                    return $http.get('News/Search', search)
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