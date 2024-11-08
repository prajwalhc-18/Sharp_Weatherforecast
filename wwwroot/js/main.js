// Typed.js Typing Animation for Title
window.onload = () => {
    var options = {
        strings: ["Enter a city to see the weather!", "The weather is just a click away!", "Get your forecast now!"],
        typeSpeed: 50,
        backSpeed: 25,
        loop: true,
    };

    var typed = new Typed("#typed-output", options);
};
