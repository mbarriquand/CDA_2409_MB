// Génération et remplissage du tableau

generateTable('cardTable');

function generateTable(tableId) {
    fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json")
      .then((response) => {
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.json();
      })
      .then((data) => {
        if (!data || !Array.isArray(data) || data.length === 0) {
          console.error('Invalid or empty JSON data.');
          return;
        }

      let mostPlayed = 0;
      let playerName = "";
      let amountOfVictory = 0;

        data.forEach(card => {
      
            if(mostPlayed < card.played ){
                mostPlayed = card.played;
                playerName = card.name;
                amountOfVictory = card.victory
            }
        });

        const pone = document.querySelector("#one");
        pone.innerText = `La carte avec le plus de parties jouées est : "${playerName}" avec ${amountOfVictory} victoires`;

        let ratio = 0;
        let bestRatio = 0;
        let playerName2 = "";
        let amountOfGame2 = "";
        let amountOfVictory2 = 0;

        data.forEach(card2 => {

        ratio =  card2.victory / card2.played;

            if(bestRatio < ratio){
                bestRatio = ratio;
                playerName2 = card2.name;
                amountOfGame2 = card2.played;
                amountOfVictory2 = card2.victory;
            }
        })

        const ptwo = document.querySelector("#two");
        ptwo.textContent = `La carte avec le meilleur ratio est "${playerName2}" avec ${amountOfGame2} parties jouées et ${amountOfVictory2} parties gagnées pour un ratio de : ${bestRatio.toFixed(3)}`;
        
        const table = document.getElementById(tableId);
        if (!table) {
          console.error(`Table with ID "${tableId}" not found.`);
          return;
        }
  
        // Génération du table header
        const headers = Object.keys(data[0]);
        const thead = table.createTHead();
        const headerRow = thead.insertRow();
  
        headers.forEach(headerText => {
          const myTh = document.createElement('th');
          const text = document.createTextNode(headerText);
          myTh.appendChild(text);
          headerRow.appendChild(myTh);
        });
  
        // Génération du table body
        const tbody = table.createTBody();
  
        data.forEach(rowData => {
          const row = tbody.insertRow();
  
          headers.forEach(header => {
            const cell = row.insertCell();
            const cellText = document.createTextNode(rowData[header] !== undefined ? rowData[header] : "Power");
            cell.appendChild(cellText);
          });
        });
      })
      .catch((error) => {
        console.error("Error fetching: ", error);
        alert("message : " + error);
      });
  }
  