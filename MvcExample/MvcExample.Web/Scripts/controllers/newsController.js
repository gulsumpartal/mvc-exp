var newsController = {
    save: function () {
        var data = $('#frmAddNews').serialize();

        $.post("/News/Add", data, function (response) {
            if (response === "ok") {
                $('#myModal').modal('hide');
                $.post("/News/AddNewsPartial", function (response) {
                    $('#divmodal').html(response);
                });
            } else {
                alert("error");
            }
        });
    }
}