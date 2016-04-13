$("document").ready(function () {
    $(".subMenu").on("click", function (e) {
        $($(e)[0].currentTarget.children).toggle(function () {
            $(this).animate({ height: "100%" });
        });
    });
    $("li.subMenu > ul").on("click", function (e) {
        e.stopPropagation();
    });
    $("li.subMenu>ul>li").on("click", function (e) {
        e.stopPropagation();
        var url = $(this).children("a").attr("href");
        window.open(url);
    });
    $("div.leftMenu").css("height")
});