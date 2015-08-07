(function () {
    'use strict';

    angular
        .module('EuropeanImportsApp')
        .controller('HomeController', HomeController)
        .controller('LoginController', ['loginService', '$location', LoginController])
        .controller('CarsController', ['carsService', CarsController])
        .controller('HeaderController', ['loginService', '$location', HeaderController])
        .controller('RegisterController', ['loginService', '$location', RegisterController]);

    function RegisterController(loginService, $location) {
        var vm = this;
        vm.isLoading = false;
        vm.register = register;

        function register() {
            vm.isLoading = !vm.isLoading;
            loginService.register(vm.email, vm.password, vm.confirmPassword).then(success, fail);
        }

        function success() {
            vm.isLoading = !vm.isLoading;
            $location.path('/login');
        }

        function fail(data) {
            vm.isLoading = !vm.isLoading;
            alert(data.message);
        }
    }

    function HeaderController(loginService, $location) {
        var vm = this;

        vm.isLoggedIn = isLoggedIn;
        vm.logout = logout;

        function isLoggedIn() {
            return loginService.isLoggedIn();
        }

        function logout() {
            loginService.logout();
            $location.path('/');
        }
    }

    function HomeController() {

    }

    function LoginController(loginService, $location) {
        var vm = this;
        vm.login = login;
        vm.isLoading = isLoading;
        vm.loading = false;

        function isLoading() {
            return vm.loading;
        }

        function login() {
            vm.loading = true;
            loginService.login(vm.username, vm.password).then(success, fail);
        }

        function success() {
            vm.loading = false;
            $location.path('/cars');
        }

        function fail() {
            vm.loading = false;
            alert('Login failed!');
        }
    }

    function CarsController(carsService) {
        var vm = this;

        carsService.getCars().then(success, fail);

        function success(data) {
            vm.cars = data;
        }

        function fail() {
            alert('Failed to retrieve your cars');
        }
    }
})();