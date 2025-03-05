const paragraphe = document.querySelector("#paragraphe");
const btnPlus = document.querySelector("#btnPlus");
const btnMoins = document.querySelector("#btnMoins");
const btnReset = document.querySelector("#btnReset");
let compteur = 0;

btnPlus.addEventListener('click', function(){
    compteur++;
    paragraphe.textContent = `Vous avez cliqué ${compteur} fois`;
});

btnMoins.addEventListener('click', function(){
    compteur--;
    paragraphe.textContent = `Vous avez cliqué ${compteur} fois`;
});

btnReset.addEventListener('click', function(){
    compteur = 0 ;
    paragraphe.textContent = `Vous avez cliqué ${compteur} fois`;
});
