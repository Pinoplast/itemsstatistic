angular.module('app', ['components', 'controllers'])

    .controller('BeerCounter', function ($scope, $locale) {
        $scope.beers = [0, 1, 2, 3, 4, 5, 6];
        if ($locale.id == 'en-us') {
            $scope.beerForms = {
                0: 'no beers',
                one: '{} beer',
                other: '{} beers'
            };
        } else {
            $scope.beerForms = {
                0: 'žiadne pivo',
                one: '{} pivo',
                few: '{} pivá',
                other: '{} pív'
            };
        }
    });
    //.filter("startFrom", function () {
    //    return function (input, start) {
    //        start = +start;
    //        return input.slice(start);
    //    };
    //})
    //.controller("paginationController", function ($scope) {
    //    $scope.currentPage = 0;
    //    $scope.itemsPerPage = 5;
    //    $scope.items = [];
    //    for (var i = 0; i < 25; i++) {
    //        $scope.items.push("Product " + i);
    //    }
    //    $scope.firstPage = function () {
    //        return $scope.currentPage == 0;
    //    };
    //    $scope.lastPage = function () {
    //        var lastPageNum = Math.ceil(
    //            $scope.items.length / $scope.itemsPerPage - 1
    //        );
    //        return $scope.currentPage == lastPageNum;
    //    };
    //    $scope.numberOfPages = function () {
    //        return Math.ceil($scope.items.length / $scope.itemsPerPage);
    //    };
    //    $scope.startingItem = function () {
    //        return $scope.currentPage * $scope.itemsPerPage;
    //    };
    //    $scope.pageBack = function () {
    //        $scope.currentPage = $scope.currentPage - 1;
    //    };
    //    $scope.pageForward = function () {
    //        $scope.currentPage = $scope.currentPage + 1;
    //    };
    //});