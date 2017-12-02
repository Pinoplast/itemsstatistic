//var controllers = angular.module("controllers", []);

//controllers
//    .controller("ItemsController", ['$http', '$scope', '$log', function ($http, $scope) {
//        $scope.items = [];
//        $scope.page = null;
//        $scope.pageSize = null;
//        $scope.total = null;

//        var getItems = function (page) {
//            return $http.get('api/values?page=' + page + '&count=' + 4);
//        };
//        var handleSuccess = function (data, status) {
//            $scope.items = JSON.parse(data.data).Items;
//            var pager = JSON.parse(data.data).Pager;
//            $scope.page = pager.CurrentPage;
//            $scope.pageSize = pager.AmountItems;
//            $scope.total = pager.TotalAmount;
//        };

//        getItems(4).then(handleSuccess);

//        $scope.DoCtrlPagingAct = function (text, page, pageSize, total) {
//            $log.info({
//                text: text,
//                page: page,
//                pageSize: pageSize,
//                total: total
//            });
//        };
//    }]);


//    //.controller('sampleCtrl', function ($scope, $log) {

//    //    // A function to do some act on paging click
//    //    // In reality this could be calling a service which
//    //    // returns the items of interest from the server
//    //    // based on the page parameter
//    //    $scope.DoCtrlPagingAct = function (text, page, pageSize, total) {
//    //        //console.log()
//    //        $log.info({
//    //            text: text,
//    //            page: page,
//    //            pageSize: pageSize,
//    //            total: total
//    //        });
//    //    };

//    //}]);

