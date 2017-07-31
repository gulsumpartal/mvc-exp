var homeController = {
    display : function() {
        $.post("/Home/Display",
            function() {
                
                $('#myModal').modal('show');
            });
    }
}