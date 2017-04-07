(function() {
    'use strict';

    angular
        .module('app')
        .controller('TodoController', TodoController);

    TodoController.$inject = ['todoFactory'];


    function TodoController(todoFactory) {

        var vm = this;
        vm.todos = [];

        vm.addTodo = function() {
          todoFactory
          .create({
                "item": vm.item,
                "priority": vm.priority
            })
            .then(function(data){
              vm.todos.push(data);
            })

            activate();

            function activate() {
              todoFactory
              .getAll()
              .then(function(data) {
                vm.todos = data
              });
            }
        }
    }

})();
