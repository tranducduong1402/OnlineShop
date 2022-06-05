var CategoryController = {
    init: function () {
        CategoryController.registerEvent();
        CategoryController.loadData();
    },
    registerEvent: function () {
        
    },
    loadData: function () {
        $.ajax({
            url: '/Category/LoadData',
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response.status) {
                    alert(response.status);
                }
            }
        });
    }
}
CategoryController.init();