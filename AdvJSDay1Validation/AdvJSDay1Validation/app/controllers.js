(function () {
    'use strict';

    angular.module('CarApp').controller('CarController', CarController);

    function CarController() {
        var vm = this;
        vm.add = add;
        vm.isSedan = isSedan;
        vm.types = [
            'sedan',
            'coupe'
        ];

        function isSedan() {
            return vm.selectedType === 'sedan';
        }

        function add() {
            vm.message = 'You entered Model: ' + vm.model + ', Price: ' + vm.price;
        }
    }
})();