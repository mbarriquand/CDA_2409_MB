// Génération et remplissage du tableau



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
  
  generateTable('cardTable');
  
  const pone = document.querySelector("#one");
  pone.textContent = `ici un affichage`;
  
  const ptwo = document.querySelector("#two");
  ptwo.textContent = `ici un autre affichage`;