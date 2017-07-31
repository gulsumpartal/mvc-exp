var authController = {
    
    login: function () {
        var data = $("#frmLogin").serialize();
        $.post("/Auth/Login/",
            data,
            function(response) {
                if (response === "Ok") {
                    location.href = "/";
                } else {
                    alert("Fail");
                }
            });
    },
    logout: function () {
        alert("logout");
        $.post("/Auth/Logout", function (response) {
            if (response==="OK") {
                location.href = "/Auth/Login";
            }
        });
    },
    display: function () {
        $.get("/Auth/Display", function (data) {
       
                $('#divmodal').html(data);

                $('#myModal').modal('show');
          
        });
    }
}