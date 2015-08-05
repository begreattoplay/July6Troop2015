(function () {
    'use strict';

    angular
        .module('TaskApp', ['ngAnimate', 'ngRoute'])
        .config(Config);

    function Config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/app/views/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'vm'
            })
            .when('/viewA', {
                templateUrl: '/app/views/viewA.html',
                controller: 'ViewAController',
                controllerAs: 'vm'
            })
            .when('/viewB/:id', {
                templateUrl: '/app/views/viewB.html',
                controller: 'ViewBController',
                controllerAs: 'vm'
            })
            .when('/taskList', {
                templateUrl: '/app/views/taskView.html',
                controller: 'TasksController',
                controllerAs: 'vm'
            });
    }
})();