$(document).ready(function () {
    var x = document.getElementById('bazz-input');
    var y = document.getElementById('bazz-predicate');
    if ($('#bazz-toggle').is(':checked')) {
        x.classList.remove("hide");
        y.classList.remove("hide");
    }
    else {
        x.classList.add("hide");
        y.classList.add("hide");
    }
});

$(function () {
    $('#bazz-toggle').change(function () {
        var x = document.getElementById('bazz-input');
        var y = document.getElementById('bazz-predicate');
        if (x.classList.contains("hide") && y.classList.contains("hide")) {
            x.classList.remove("hide");
            y.classList.remove("hide");
        } else {
            x.classList.add("hide");
            y.classList.add("hide");
        }
    })
});