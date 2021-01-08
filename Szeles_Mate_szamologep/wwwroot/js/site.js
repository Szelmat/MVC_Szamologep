// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

currentTypingRow = "firstTypingRow";

function typeNum(num) {
    if (document.getElementById(currentTypingRow).value.length < 10) {
        document.getElementById(currentTypingRow).value = document.getElementById(currentTypingRow).value + num;
    }
}

function typeSign(sign) {
    if (currentTypingRow == "firstTypingRow") {
        document.getElementById("firstTypingRow").value = document.getElementById("firstTypingRow").value + " " + sign;
        currentTypingRow = "secondTypingRow";
    }
}
