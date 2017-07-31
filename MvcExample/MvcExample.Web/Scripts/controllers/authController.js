var authController = {
    
    login: function () {
        var data = $("#frmLogin").serialize();
        $.post("/Auth/Login/",
            data,
            function(response) {
                if (response == "OK") {
                    location.href = "/";
                } else {
                    alert("Fail");
                }
            });
    }
}