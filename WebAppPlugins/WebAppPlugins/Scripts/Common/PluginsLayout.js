$("document").ready(function () {
    $(".subMenu").on("click", function (e) {
        $($(e)[0].currentTarget.children).toggle(function () {
            $(this).animate({ height: "100%" });
        });
    });
});