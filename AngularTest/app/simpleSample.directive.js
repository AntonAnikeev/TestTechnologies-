angular.module('AppForTest')
    .directive('simpleSample', function(){
        return {
            restrict: 'E',
            replace: true,
            template: '<span>You should write more tests... {{1 + 1}}</span>'
        };
    });