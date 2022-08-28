const lesson = document.getElementById("downDrop");
const lessonMenu = document.getElementById("downDrop-menu");
const downIcon = document.getElementById("downDropI");
lesson.addEventListener("click", function () {
  if (lessonMenu.style.display == "block") {
    lessonMenu.style.display = "none";
    downIcon.className = "fa-solid fa-angle-down";
  } else {
    lessonMenu.style.display = "block";
    downIcon.className = "fa-solid fa-angle-up";
  }
});
