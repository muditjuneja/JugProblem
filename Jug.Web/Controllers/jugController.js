(function () {
    'use strict';

    angular
        .module('JugProblem')
        .controller('jugController', jugController);

    function jugController($scope,Jug) {
		$scope.jugSize1 = 1;
		$scope.jugSize2 = 1;
		$scope.requiredAmount = 0;
        $scope.onSubmit = function() {
            console.log("Submit clicked");
			Jug.getSolution($scope.jugSize1,$scope.jugSize2,$scope.requiredAmount).then(function(response){
			console.log(response.data);
			$scope.statusList = response.data[0];
			},function(err){
					$scope.statusList = [];
			})
          };
    }
})();

