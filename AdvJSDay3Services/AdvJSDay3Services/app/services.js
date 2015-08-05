(function () {
    'use strict';
    angular
        .module('ProductApp')
        .factory('productService', productService);

    productService.$inject = ['$http', 'productServiceURLs', '$q'];

    function productService($http, productServiceURLs, $q) {
        var service = {};
        var products = [];

        service.getProducts = getProducts;
        service.createProduct = createProduct;
        service.update = update;
        service.delete = deleteProduct;

        function getProducts() {
            var deferred = $q.defer();

            $http.get(productServiceURLs.get).success(function (result) {
                products.length = 0;

                result.forEach(function (product) {
                    products.push(product);
                });

                deferred.resolve(products);
            }).error(function () {
                deferred.reject();
            });

            return deferred.promise;
        }

        function createProduct(product) {
            var deferred = $q.defer();

            $http.post(productServiceURLs.post, product).success(function () {
                products.unshift(product);
                deferred.resolve();
            }).error(function (modelState) {
                deferred.reject(modelState);
            });

            return deferred.promise;
        }

        function update() {

        }

        function deleteProduct() {

        }

        return service;
    }    
})();