$(function () {
    // For all modal buttons
    $("button[data-toggle='modal']").click(function () {
        $("#myModal").load($(this).data("action"));
    })

})