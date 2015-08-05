(function () {
    'use strict';
    angular
        .module('ProductApp', [])
        .constant('productServiceURLs', { get: '/api/products/', post: '/api/products/' });
})();