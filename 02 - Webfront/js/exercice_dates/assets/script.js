let maDate = new Date();

let maChaine = "";
let annee = maDate.getFullYear();
// let mois = maDate.getMonth() + 1;
// let jour = maDate.getDate();

// forcer l'ajout du zéro devant les mois et jours < 10
// pour avoir une date sur deux jours

let mois = (maDate.getMonth() + 1 < 10)?"0"+(maDate.getMonth() + 1):maDate.getMonth() + 1;
// exemple de ternaire 
// ? = if
// : = else

let jour = (maDate.getDate() < 10)?"0"+maDate.getDate():maDate.getDate();

//maChaine += annee + "-" + mois + "-" + jour;
maChaine += jour + "/" + mois + "/" + annee;

document.getElementById("btnDate").addEventListener("click", function(){
    document.getElementById("maDate").value = maChaine;
});


function afficherHeure(){

    let monHeure = new Date();
    let heure = (monHeure.getHours() < 10 )?"0"+monHeure.getHours():monHeure.getHours();
    let minute = (monHeure.getMinutes() < 10 )?"0"+monHeure.getMinutes():monHeure.getMinutes();
    let seconde = (monHeure.getSeconds() < 10 )?"0"+monHeure.getSeconds():monHeure.getSeconds();
    
    let maChaineHeure = heure + ":" + minute + ":" + seconde;
    document.getElementById("monHeure").value = maChaineHeure;
    
    }
  
document.getElementById("btnHeure").addEventListener("click",function(){

 const timer = setInterval(afficherHeure, 1000);    

} );

