(function () {
    'use strict';
    angular.module('MyApp').controller('FoodController', FoodController);

    function FoodController() {
        var vm = this;

        vm.food = [
            'Milk',
            'Eggs',
            'Marzipan',
            'Eggs',
            'Milk',
            'Mustard',
            'Marzipan',
            'Eggs'
        ];
    }
})();