// Récupération du json

fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
  // établir la promesse avec le json
  .then((Reponse) => {
    return Reponse.json();
  })

  // puis quand la promesse est établie, on fait ça :
  .then((data) => {
    // console.log(data);
    remplirDataList(data);

    const btnValidation = document.querySelector("#valider");
    btnValidation.addEventListener("click", function () {
      const zip = document.querySelector("#cp");
      let arraySolution = []; // vider l'affichage
      arraySolution = data.filter(
        (obj) => obj.nomCommune == zip.value || obj.codePostal == zip.value
      );

      if (arraySolution != "undefined") {
        document.querySelector("#result").innerHTML = "";
        arraySolution.forEach((objetVille) => {
          document.querySelector("#result").innerHTML +=
          `Nom Commune : ${objetVille.nomCommune}<br>Code Postal : ${objetVille.codePostal}<br> Code Commune : ${objetVille.codeCommune}<br><br>`;
        });

        // vider le champ de saisie

        zip.value = "";
        zip.focus();

      } else {
        document.querySelector("#result").innerHTML = `Commune non trouvée`;
      }
    });
  })

  // si la promesse échoue, on renvoie un message d'erreur
  .catch((error) => alert("message : " + error));

// création d'une fonction pour afficher les suggestions
function remplirDataList(data) {
  const datalist = document.getElementById("suggestions");

  for (let i = 0; i < data.length; i++) {
    const myOption = new Option(); // création d'un constructeur
    myOption.value = data[i].codeCommune;
    myOption.textContent = data[i].nomCommune + " cp : " + data[i].codePostal;

    datalist.appendChild(myOption);
  }
}
