// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Display the name of the file
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

var tempPrice = 0;

function updatePric(price, qty) {
    temp = price * qty;

    tempPrice = tempPrice + temp
};







function totalPri() {
    var f = {};
    f.url = '@Url.Action("PriceUpdate", "Customer")';
    f.type = "Post";
    f.dataType = "json";
    f.data = JSON.stringify({ Price: tempPrice });
    f.contentType = "application/json";
    f.success = function (reponse) {
        alert("Success")
    }
    f.error = function (response) {
        alert("failed");
    }
    $.ajax(f);
};
    