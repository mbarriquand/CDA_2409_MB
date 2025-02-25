const btnAdd = document.querySelector("#add");
const btnEmpty = document.querySelector("#empty");
const inputName = document.querySelector("#name");
const inputAge = document.querySelector("#age");
const textUpdate = document.querySelector("#text");

/* console.log(btnAdd);
console.log(inputName); */

btnAdd.addEventListener("click", () => {

if (inputName.value.length < 1) {
    textUpdate.innerHTML = "Veuillez saisir un nom valide.";
}

else if (inputAge.value <= 0 || inputAge.value === "") {
    textUpdate.innerHTML = "Veuillez saisir un âge valide.";
}

else {
    textUpdate.innerHTML = "Bonjour " + inputName.value +
     ", vous avez " + inputAge.value + " ans.";
}

});

btnEmpty.addEventListener("click", () => {
    textUpdate.innerHTML = "Completer / corriger le formulaire";
});
