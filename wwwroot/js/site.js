// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showHide(id) {
    let answer = document.getElementById(id)
    let button = document.getElementById(`showHide${id}`)
    if (answer.className === "hidden") {
        answer.className = "visible"
        button.innerText = "Hide"
    } else {
        answer.className = "hidden"
        button.innerText = "Show"
    }
}
