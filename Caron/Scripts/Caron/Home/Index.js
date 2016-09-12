$(function () {

    // Delete a description section
    $(".deleteButton").click(function () {
        var url = $(this).data("action");
        var id = $(this).data("id");
        var $section = $(this).closest(".container");
        $.ajax({
            url: url,
            method: "POST",
            data: {descriptionSectionId:id},
        }).done(function () {
            $section.remove();
        })
    })
})