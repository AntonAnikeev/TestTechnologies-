describe('withWatch directive test', function() {
    var compile,
        scope;

    beforeEach(function(){
       module('AppForTest'); 

       inject(function($compile, $rootScope){
            compile = $compile;
            scope = $rootScope.$new();
       });
    });


    it('should compile directive with empty span', function(){
        //arrange
        var element = angular.element('<with-watch></with-watch>');
        //act       
        var compiledElement = compile(element)(scope);
        scope.$digest();          
        //assert    
        expect(compiledElement.find('span')).toBeDefined();
    });   
    
    it('should compile the element with the appropriate content', function(){
        //arrange
        var element = angular.element('<with-watch></with-watch>');
        //act       
        var compiledElement = compile(element)(scope);
        scope.$digest();
        scope.text = "foo"
        scope.$digest();
                
        //assert    
        expect(compiledElement).toBeDefined();
        expect(compiledElement.text()).toContain("foo");               
    });                
})