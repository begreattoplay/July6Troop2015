(function () {
    angular
        .module('TaskApp')
        .controller('TasksController', TasksController)
        .controller('AnotherController', AnotherController)
        .controller('YetAnotherController', YetAnotherController);

    function TasksController() {
        var vm = this;
        vm.addTask = addTask;

        vm.tasks = [
            { name: 'Feed dog' },
            { name: 'Take out garbage' },
            { name: 'Water lawn' }
        ];

        function addTask() {
            vm.tasks.push({ name: vm.newTask });
            vm.newTask = '';
        }
    }

    function AnotherController() {

    }

    function YetAnotherController() {

    }
})();