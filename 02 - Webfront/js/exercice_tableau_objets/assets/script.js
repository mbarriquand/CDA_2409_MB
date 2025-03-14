const myH1 = document.querySelector("#myH1");

const login = document.querySelector("#loginBtn");

const memberId = document.querySelector("#id");
const password = document.querySelector("#mdp");



myH1.innerHTML = "Espace Membres";

fetch("/assets/data.json")
.then(response =>{
    return response.json()
})
.then((data) => {
    console.log(data);
    afficherTableau(data);

})


/*

function afficherTableau(data){
    let myData = data;
    const myTable = document.createElement("table");

    const myTH = myTable.createTHead();
    const myTHRow = myTH.insertRow();

    for(const key in data[0]){
        const myCell = document.createElement("th");
        myCell.textContent = key;
        myTHRow.appendChild(myCell);
    }

    const wrap = document.querySelector(".wrapper")
    wrap.appendChild(myTable);
    
}
    */
