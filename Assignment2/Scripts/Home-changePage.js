/*Home页面评论的分页功能*/
document.addEventListener("DOMContentLoaded", function () {
    // Get references to the page elements and buttons
    const page1 = document.getElementById("page1");
    const page2 = document.getElementById("page2");
    const previousButton = document.getElementById("previousButton");
    const nextButton = document.getElementById("nextButton");

    // Add an event listener to the "Next" button
    nextButton.addEventListener("click", function () {
        page1.style.display = "none"; 
        page2.style.display = "flex";
        previousButton.classList.remove("disabled");
        nextButton.classList.add("disabled");
    });

    // Add an event listener to the "Previous" button
    previousButton.addEventListener("click", function () {
        page1.style.display = "flex";
        page2.style.display = "none";
        previousButton.classList.add("disabled"); 
        nextButton.classList.remove("disabled");
    });
});

