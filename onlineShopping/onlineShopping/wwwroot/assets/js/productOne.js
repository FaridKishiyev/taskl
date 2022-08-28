let buy = document.querySelectorAll(".buy");
let remove = document.querySelectorAll(".remove");

buy.forEach((element) => {
  element.addEventListener("click", function () {
    element.parentElement.parentElement.classList.add("clicked");
  });
});
remove.forEach((element) => {
  element.addEventListener("click", function () {
    element.parentElement.parentElement.classList.remove("clicked");
  });
});
