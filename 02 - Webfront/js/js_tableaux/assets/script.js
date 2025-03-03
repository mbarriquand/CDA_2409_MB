const people = ['Mike Dev', 'John Makenzie', 'Léa Grande'];

const liste = document.querySelector("#inscrit");
const monTab = document.querySelector("#monTableau");

liste.setAttribute("style", "list-style:none; color:#ACCBE1");

document.body.style.backgroundColor="#536B78";
document.body.style.color="#ACCBE1";
document.querySelector("h1").setAttribute("style", "margin-left:50px; font-family:tahoma;text-transform:uppercase");

document.querySelector("#filet").setAttribute("style", "border:2px solid   #ACCBE1");
monTab.setAttribute("style", "background-color: #637081");


for (let i = 0; i < people.length; i++) {
   
    let monItem= document.createElement("li");
    monItem.setAttribute("style", "font-family:tahoma; font-size:1.6rem");
    monItem.textContent=people[i];
    liste.appendChild(monItem);
    
}

monTab.setAttribute("cellspacing", "0");
monTab.setAttribute("style", "background-color: #637081; margin: 10px 10px");


function addCellTitle(row, text){
let myCell = document.createElement("th");
myCell.setAttribute("style", "border: 1px solid #ACCBE1; padding:20px;");
myCell.textContent = text;
row.appendChild(myCell);
}

function addCell(row, text){
  let myCell = row.insertCell();
  myCell.setAttribute("style", "border: 1px solid #ACCBE1; padding :10px; font-family: verdana; ");
  myCell.textContent = text;
  
  }

  const titleArray = ["Nom", "Prenom", "Email"];

  let header = monTab.createTHead();
  let myRow = header.insertRow();

  for (let i=0; i < titleArray.length; i++){
    addCellTitle(myRow, titleArray[i]);
  }

  let myBody = monTab.createTBody();


  
  for(let i= 0; i < people.length; i++){
    let myRowBody = myBody.insertRow();
    let tabLocal = people[i].split(' ');
    
    addCell(myRowBody, tabLocal[1]);
    addCell(myRowBody, tabLocal[0]);
    let chaineEmail = `${tabLocal[0]}.${tabLocal[1]}@example.com`.toLowerCase();

    addCell(myRowBody, chaineEmail);
  }
