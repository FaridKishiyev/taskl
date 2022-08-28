const searchButton = document.getElementById("search-button");
const searcMenu = document.getElementById("seacrh-menu");
const searchButtonIcon = document.getElementById("search-buttonI");
const formBox = document.getElementById("form-box");
const sliderBox = document.getElementById("slider-box");
const logoItem = document.querySelectorAll(".slider-box a");
const sliderLenght = logoItem.length;
console.log(sliderLenght);
searchButton.addEventListener("click", function () {
  if (formBox.style.display == "block") {
    formBox.style.display = "none";
    searchButtonIcon.className = "fa-solid fa-angle-down";
    searchButton.style.padding = "0px";
  } else {
    formBox.style.display = "block";
    searchButtonIcon.className = "fa-solid fa-angle-up";
    searchButton.style.padding = "30px";
  }
});
