/// <reference path="/Assets/admin/libs/angular/angular.js" />
(function () {
    angular.module('chidaotuyen.daoTaoLienTuc', ['chidaotuyen.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('daoTaoLienTuc', {
            url: "/dao_tao_lien_tuc",
            templateUrl: "/app/components/dao_tao_lien_tuc/daoTaoLienTucListView.html",
            controller: "daoTaoLienTucListController "
        }).state('daoTaoLienTuc_add', {
            url: "/dao_tao_lien_tuc_add",
            templateUrl: "/app/components/dao_tao_lien_tuc/daoTaoLienTucAddView.html",
            controller: "daoTaoLienTucAddController "
        })
    }
})