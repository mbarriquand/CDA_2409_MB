// variable pour déclarer le tableau de base
const utilisateurs = ["Mike Dev", "John Makenzie", "Léa Grande"];
// variable d'affichage du paragraphe du formulaire
const ajout = document.querySelector("#validationAjout");
// remplissage du paragraphe du formulaire
ajout.textContent = "Saisissez un utilisateur pour l'ajouter.";

// console log des utilisateurs
for (let i = 0; i < utilisateurs.length; i++) {
  console.log(utilisateurs[i]);
}

// changement du style appliqué au titre H1
document.querySelector("h1").setAttribute("style", "text-transform: uppercase");

// fonction pour générer la liste des utilisateurs à partir du tableau
function genererListeUtilisateurs() {
  const maListe = document.querySelector("#listeInscrits");
  maListe.innerHTML = ""; // Efface la liste existante

  // ajout d'une ligne à la liste pour chaque occurence dans l'array utilisateurs
  for (let i = 0; i < utilisateurs.length; i++) {
    const monLi = document.createElement("li"); // création des éléments 'li' dans l'élément 'ul'
    monLi.textContent = utilisateurs[i];
    maListe.appendChild(monLi);
  }
}

// fonction pour générer la table dans le HTML
function genererTableau() {
  // création d'un élément table dans le HTML
  const monTableau = document.createElement("table");
  // création de l'entête de cette table
  const monHeader = monTableau.createTHead();
  // insertion de l'entête
  const ligneHeader = monHeader.insertRow();
  // array qui stocke les textes d'entête
  const titreTableau = ["Nom", "Prenom", "Email", "Supprimer"];

  // fonction pour créer l'entête de la table
  function creerCelluleTitre(text, row) {
    let maCellule = document.createElement("th"); // création d'une cellule thead
    maCellule.textContent = text;
    row.appendChild(maCellule);
  }

  // boucle pour que la création se répète autant de fois qu'il y a d'entrée dans l'array
  for (let i = 0; i < titreTableau.length; i++) {
    creerCelluleTitre(titreTableau[i], ligneHeader);
  }

  // création du body de la table
  const monBody = monTableau.createTBody();

  // fonction pour créer des cellules tr dans la table (les lignes / row)
  function creerCellule(text, row, index) {
    let maCellule = row.insertCell(); // création d'une cellule tr
    maCellule.textContent = text;

    // condition pour supprimer une entrée de la liste ET de la table quand le "x" est cliqué
    if (text === "x") {
      maCellule.classList.add("supprimer-cellule"); // Ajout de la classe
      maCellule.addEventListener("click", function () {
        utilisateurs.splice(index, 1);
        document.querySelector("table").remove();
        ajout.textContent = `Un utilisateur a été supprimé.`;
        genererTableau();
        genererListeUtilisateurs();
      });
    }

    return maCellule;
  }

  // fonction pour retirer les accents pour l'adresse mail

  function normaliserChaine(chaine) {
    return chaine
      .normalize("NFD")
      .replace(/[\u0300-\u036f]/g, "")
      .toLowerCase(); // + mettre l'adresse mail en minuscule
  }

  // création et remplissage des lignes à partir de la liste et des entrées utilisateurs

  for (let i = 0; i < utilisateurs.length; i++) {
    const nouvelleLigneBody = monBody.insertRow();
    let prenom = utilisateurs[i].split(" ")[0]; // on prend l'objet de l'array et on le divise 
    let nom = utilisateurs[i].split(" ")[1]; // avant et après le " "
    let prenomNormalise = normaliserChaine(prenom);
    let nomNormalise = normaliserChaine(nom);
    let email = `${prenomNormalise}.${nomNormalise}@example.com`; // concaténation pour reconstruire une adresse mail
    let supprimer = "x"; // futur """bouton""" pour supprimer les lignes
    creerCellule(nom, nouvelleLigneBody, i); // Passage de l'indice i
    creerCellule(prenom, nouvelleLigneBody, i); // Passage de l'indice i
    creerCellule(email, nouvelleLigneBody, i); // Passage de l'indice i
    let sup = creerCellule(supprimer, nouvelleLigneBody, i); // Passage de l'indice i
    sup.setAttribute("style", "text-align:center");
  }

  document.querySelector(".container").appendChild(monTableau);
}

// appel des fonctions pour générer le tableau et la liste (MAJ)
genererTableau();
genererListeUtilisateurs();


const monBouton = document.querySelector("#btnInscription");
const prenom = document.querySelector("#txtPrenom");
const nom = document.querySelector("#txtNom");

// évenement pour ajouter des utilisateurs à partir du formulaire

monBouton.addEventListener("click", function () {
  let chaineInscription = prenom.value + " " + nom.value;
  utilisateurs.push(chaineInscription);
  ajout.textContent = `L'utilisateur ${prenom.value} ${nom.value} a été ajouté(e).`;
  document.querySelector("table").remove();
  genererTableau();
  genererListeUtilisateurs();
  prenom.value = "";
  nom.value = "";
});
