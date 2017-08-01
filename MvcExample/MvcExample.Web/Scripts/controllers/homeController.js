var homeController = {
    display : function() {
        $.post("/Home/Display",
            function() {
                
                $('#myModal').modal('show');
            });
    },
    addNewsPopup: function () {
        $.post("/Home/AddNewsModalDisplay", function (data) {
            $('#divmodal').html(data);
            $('#myModal').modal('show');
        });
    }
}