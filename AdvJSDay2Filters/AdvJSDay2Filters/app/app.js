(function () {
    'use strict';
    angular.module('MyApp', []).filter('unique', unique);

    function unique() {
        return function (input) {
            var filteredSet = new Set(input);

            var filteredArray = [];
            filteredSet.forEach(function (item) {
                filteredArray.push(item);
            });

            return filteredArray;
        };
    }
})();