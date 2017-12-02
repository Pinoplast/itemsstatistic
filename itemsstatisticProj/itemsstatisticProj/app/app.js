(function (angular) {
    'use strict';
    angular.module('app',
        [
            'ngRoute',
            'bw.paging',
            'ui.bootstrap'
        ])
        .controller('TabsCtrl', ['$scope', '$routeParams', function TabsCtrl($scope, $routeParams) {
            $scope.tabs = [{
                id: 1,
                title: 'Items',
                url: 'app/templates/items-partial.html',
                hide: false
            }, {
                id: 2,
                title: 'Types',
                url: 'app/templates/types-partial.html',
                hide: false
            },
            {
                id: 3,
                title: 'Item',
                url: 'app/templates/item-partial.html',
                hide: true
            }];


            $scope.currentTab = 'app/templates/items-partial.html';

            $scope.onClickTab = function (tab) {
                $scope.currentTab = tab.url;
            }

            $scope.linkToEditItem = function (id) {
                
                $routeParams.id = id;
                $scope.currentTab = 'app/templates/item-partial.html';
                
            }

            $scope.isActiveTab = function (tabUrl) {
                return tabUrl == $scope.currentTab;
            }
        }])
        .controller("ItemsCtrl", ['$location', '$http', '$scope', '$routeParams', '$rootScope', function ItemsCtrl($location, $http, $scope, $routeParams, $rootScope) {
            $scope.items = [];
            $scope.page = null;
            $scope.pageSize = null;
            $scope.total = null;
            var getItems = function (page) {
                return $http.get('api/items?page=' + page + '&amount=' + 4);
            };
            var getItem = function () {
                return $http.get('api/items?id=' + $routeParams.id);
            };
            var handleGetItemsSuccess = function (data, status) {
                $scope.items = JSON.parse(data.data).Items;
                var pager = JSON.parse(data.data).Pager;
                $scope.page = pager.CurrentPage;
                $scope.pageSize = pager.AmountItems;
                $scope.total = pager.TotalAmount;
            };
            var handleGetItemSuccess = function (data, status) {
                $scope.item = JSON.parse(data.data).Item;
                alert($routeParams.id);
            };

            if ($routeParams.page === undefined) {
                var page = 1;
                getItems(page).then(handleGetItemsSuccess);
            }
            else {
                getItems($routeParams.page).then(handleGetItemsSuccess);
            }

        }])
        .controller("ItemCtrl", ['$location', '$http', '$scope', '$routeParams', '$rootScope', function ItemCtrl($location, $http, $scope, $routeParams, $rootScope) {
            $scope.item = {
                Id: null,
                Name: null,
                Type: null
            };
            
            var getItem = function (id) {
                return $http.get('api/items?id=' + id);
            };

            $scope.save = function () {
                //$scope.item.Name


            };

            var handleSuccess = function (data, status) {
                $scope.item = JSON.parse(data.data);
            };

            var DoCtrlPagingAct = function (page) {
                getItems(page).then(handleSuccess);
            }

            if ($routeParams.id === undefined) {
                $scope.item.id = 1;
                getItem($scope.item.id).then(handleSuccess);
            }
            else {
                getItem($routeParams.id).then(handleSuccess);
            }

        }])
        .controller("TypesCtrl", ['$location', '$http', '$scope', '$routeParams', '$rootScope', function TypesCtrl($location, $http, $scope, $routeParams, $rootScope) {
            $scope.types = [];
            $scope.page = null;
            $scope.pageSize = null;
            $scope.total = null;

            var getTypes = function (page) {
                return $http.get('api/types?page=' + page + '&amount=' + 3);
            };
            var handleSuccess = function (data, status) {
                $scope.types = JSON.parse(data.data).Types;
                var pager = JSON.parse(data.data).Pager;
                $scope.page = pager.CurrentPage;
                $scope.pageSize = pager.AmountItems;
                $scope.total = pager.TotalAmount;
            };

            var page = null;
            if ($routeParams.page === undefined) {
                page = 1;
            }
            else {
                page = $routeParams.page;
            }

            var DoCtrlPagingAct = function (page) {
                getTypes(page).then(handleSuccess);
            }

            getTypes(page).then(handleSuccess);
        }])
})(window.angular);
