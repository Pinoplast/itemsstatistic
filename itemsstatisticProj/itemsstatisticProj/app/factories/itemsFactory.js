angular.module("app")
    .factory("itemsFactory", function () {
        return {
            getItems: function () {
                var items = [
                    {
                        name: "1",
                        type: "1"
                    }, {
                        name: "2",
                        type: "2"
                    }, {
                        name: "3",
                        type: "3"
                    }, {
                        name: "4",
                        type: "4"
                    }, {
                        name: "5",
                        type: "5"
                    }, {
                        name: "6",
                        type: "6"
                    }, {
                        name: "7",
                        type: "7"
                    }, {
                        name: "8",
                        type: "8"
                    }
                ];
                return items;
            }
        }
    });