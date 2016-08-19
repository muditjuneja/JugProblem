var app = angular.module('JugProblem', ['ngRoute','ngResource','angular-loading-bar', 'toaster','kendo.directives']);

app.constant('appSetting', {
	"serviceBaseUrl": "http://localhost:55247/"
});
app.config(function ($routeProvider) {
	$routeProvider
		.when('/',{
			templateUrl:'Views/jug.html',
			controller:'jugController'
		})
		.otherwise({redirectTo:'/'});

})