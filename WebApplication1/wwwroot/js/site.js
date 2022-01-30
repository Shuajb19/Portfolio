let navbar = document.querySelector('.navbars').querySelectorAll('a')
console.log(navbar)

navbar.forEach(element => {
    element.addEventListener("click", function () {
        navbar.forEach(nav => nav.classList.remove("active"))
        console.log("active success");
        this.classList.add("active");

    });
});


let counter = 0;

let images = ["~/Assets/Images/Medreseja_Alauddin_Prishtinë.jpg", "~/Assets/Images/Riinvest-foto.png", "~/Assets/Images/shuajb.jpg"];

function changeImageNext() {
    const image = document.getElementById("myImage1");
    counter++;
    console.log(image.src)
    if (counter > images.length - 1) {
        console.log("Poo")
        counter = images.length - 1
    } else {
        image.src = images[counter];
    }
}

function changeImagePrev() {
    const image = document.getElementById("myImage1");
    counter--;
    if (counter < 0) {
        counter = 0
    } else {
        image.src = images[counter];
    }
}