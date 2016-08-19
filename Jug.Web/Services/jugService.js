(function () {
    'use strict';
    angular
        .module('JugProblem')
        .factory('Jug', jugService);
    function jugService(appSetting,$http) {
        var baseUrl = appSetting.serviceBaseUrl;
        console.log('Entered into service');
		function getSolution(jug1,jug2,required){
			console.log('Submitting...');
			 var url = baseUrl + "api/Jugs/GetSolution?jug1="+ jug1+"&jug2="+jug2+ "&final=" + required;
			 return $http.get(url);
		}
		return {
			getSolution:getSolution
			
		}
		
    };
})();