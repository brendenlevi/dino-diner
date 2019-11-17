// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function hideAllMenu() {
    var elements = document.getElementsByClassName("menu-div");

    for (var i = 0; i < elements.length; i++) {
        elements[i].style.display = "none";
    }
}

function onClickCombos() {
    hideAllMenu();
    document.getElementById("CombosDiv").style.display = "block";
}

function onClickEntrees() {
    hideAllMenu();
    document.getElementById("EntreesDiv").style.display = "block";
}

function onClickSides() {
    hideAllMenu();
    document.getElementById("SidesDiv").style.display = "block";
}

function onClickDrinks() {
    hideAllMenu();
    document.getElementById("DrinksDiv").style.display = "block";
}