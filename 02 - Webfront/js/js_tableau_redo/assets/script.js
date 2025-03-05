const utilisateurs = ["Mike Dev", "John Makenzie", "Léa Grande"];

for(let i = 0; i < utilisateurs.length; i++){
    console.log(utilisateurs[i]);
}

document.querySelector("h1").setAttribute("style", "text-transform: uppercase");

const maListe = document.querySelector("#listeInscrits");


for(let i = 0; i < utilisateurs.length; i++){

   const monLi = document.createElement('li');
   monLi.textContent = utilisateurs[i];
   maListe.appendChild(monLi);

}

function genererTableau(){
 
    const monTableau = document.createElement("table");

    const monHeader = monTableau.createTHead();

    const ligneHeader = monHeader.insertRow();
    
    const titreTableau = ["Nom", "Prenom", "Email", "Supprimer"];
    
    function creerCelluleTitre(text, row){
    
        let maCellule = document.createElement("th");
        maCellule.textContent = text;
        row.appendChild(maCellule);
    }
    
    for(let i= 0; i < titreTableau.length; i++){
        creerCelluleTitre(titreTableau[i], ligneHeader);
    }
    
    const monBody = monTableau.createTBody();
    
    function creerCellule(text, row){
        let maCellule = row.insertCell();
        maCellule.textContent = text;
        // pas d'appendchild parce que le row est fait tout seul comme insertCell est une fonction built-in de JS
        return maCellule;
    }
    
    for(let i=0; i < utilisateurs.length; i++){
       const nouvelleLigneBody = monBody.insertRow();
       let prenom = utilisateurs[i].split(" ")[0];
       let nom = utilisateurs[i].split(" ")[1];
       let email = `${prenom}.${nom}@example.com`;
       let supprimer = "x";
       creerCellule(nom, nouvelleLigneBody);
       creerCellule(prenom, nouvelleLigneBody);
       creerCellule(email, nouvelleLigneBody);
       let sup = creerCellule(supprimer, nouvelleLigneBody);
       sup.setAttribute("style", "text-align:center");
    }

    document.querySelector(".container").appendChild(monTableau);
}

genererTableau();

const monBouton = document.querySelector("#btnInscription");

const prenom = document.querySelector("#txtPrenom");
const nom = document.querySelector("#txtNom");

monBouton.addEventListener('click', function(){

    let chaineInscription = prenom.value + " " + nom.value;
    utilisateurs.push(chaineInscription);
    document.querySelector("table").remove();
    genererTableau();
});


