const people = ["Mike Dev", "John Mackenzie", "Léa Grande"];

const liste = document.querySelector("#inscrit");

liste.setAttribute("style", "list-style:none; color: #ACCBE1");

for (let i = 0; i < people.length; i++) {

  let monItem = document.createElement("li");
  
  monItem.setAttribute("style", "font-family:tahoma; font-size: 1.6em");

  monItem.textContent=people[i];

  liste.appendChild(monItem);

}
