(function () {
    'use strict';
    angular
        .module('MyApp')
        .controller('FavoriteColorController', FavoriteColorController);

    function FavoriteColorController() {
        var vm = this;

        vm.color = 'green';

        function changeColor(color) {
            vm.color = color;
        }

        vm.pickColor = function (color) {
            changeColor(color);
        };
    }
})();