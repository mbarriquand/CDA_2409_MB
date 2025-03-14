const btnAdd = document.querySelector("#add");
const btnEmpty = document.querySelector("#empty");
const inputName = document.querySelector("#name");
const inputAge = document.querySelector("#age");
const textUpdate = document.querySelector("#text");
const ofAgeUpdate = document.querySelector("#ofAge");
const retraiteUpdate = document.querySelector("#retraite");

/*
let tabParagrah = document.querySelectorAll("p");

tabParagrah.forEach((element) => {
    element.style.fontSize = "1.5em";
    element.style.fontWeight = "bold";
    element.style.color = "blue";
});
/*

/* console.log(btnAdd);
console.log(inputName); */

btnAdd.addEventListener("click", function() {

if (inputName.value.length < 1) {
    textUpdate.innerHTML = "<i>Veuillez saisir un nom valide.</i>";
}

else if (inputAge.value <= 0 || inputAge.value === "") {
    textUpdate.innerHTML = "Veuillez saisir un âge valide.";
}

else {
    textUpdate.innerHTML = "Bonjour <span class='rouge'>" + inputName.value +
     "</span>, vous avez <span class='rouge'>" + inputAge.value + "</span> ans.";

    if (inputAge.value < 18) {
        ofAgeUpdate.innerHTML += " Vous êtes <span class='rouge'>mineur(e)</span>.";
    }

    else {
        ofAgeUpdate.innerHTML += " Vous êtes majeur(e).";

        if (inputAge.value >= 65) {
            retraiteUpdate.innerHTML += " Vous êtes à la retraite depuis" + (inputAge.value - 64) + " ans.";
        }

        else if (inputAge.value == 64) {
            retraiteUpdate.innerHTML += " Vous allez prendre votre retraite cette année.";
        }

        else {
            retraiteUpdate.innerHTML += " Vous serez à la retraite dans " + (65 - inputAge.value) + " ans.";
        }
    }
}

});

btnEmpty.addEventListener("click", () => {
    textUpdate.innerHTML = "Completer / corriger le formulaire";
    ofAgeUpdate.innerHTML = "";
    retraiteUpdate.innerHTML = "";
    inputName.value = "";
    inputAge.value = "";
});
