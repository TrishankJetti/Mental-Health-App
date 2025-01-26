// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.addEventListener("load", () => {
    const loader = document.querySelector(".loader");
    let animationCount = 0;

    const bars = document.querySelectorAll(".bar1, .bar2, .bar3, .bar4");
    bars.forEach((bar) => {
        bar.addEventListener("animationiteration", () => {
            animationCount++;
            if (animationCount >= 8) { // 2 full animations for all bars
                loader.classList.add("loader--hidden");
                loader.addEventListener("transitionend", () => {
                    document.body.removeChild(loader);
                });
            }
        });
    });
});