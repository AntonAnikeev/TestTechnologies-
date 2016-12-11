
describe('SimpleSample directive test', function() {
    var compile,
        scope;

    beforeEach(function(){
       module('AppForTest'); 

       inject(function($compile, $rootScope){
            compile = $compile;
            scope = $rootScope.$new();
       });
    });

    
    it('should replaces the element with the appropriate content', function(){
        //arrange
        var element = angular.element('<simple-sample></simple-sample>');
        //act       
        var compiledElement = compile(element)(scope);
        scope.$digest();
        //assert    
        expect(compiledElement).toBeDefined();
        expect(compiledElement.html()).toContain("You should write more tests... 2");               
    });                
});
    