const btn = document.getElementById("#valider");

btn.addEventListener('click', function(){

async function fetchCP(){
    try {
        const cpSearch = document.getElementById("#cp").value;
    const response = await fetch(`https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json`);

    if(!response.ok){
        throw new Error("Could not fetch resource");
    }

    console.log(btn);


    }
catch(error){
    console.error(error);
}
}
});