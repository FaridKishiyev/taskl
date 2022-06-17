const slider = document.getElementById("slider");
const leftBtn = document.querySelector(".fa-angle-left");
setInterval(function () {
  slider.style.right = "1400px";
}, 100);

leftBtn.addEventListener("click", function () {
  slider.style.backgroundPositionX = "1400px";
});
