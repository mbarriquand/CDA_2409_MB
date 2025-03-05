let userDob = document.querySelector("#dob");
let today = Date.now();
let result = document.querySelector("#result");

let btn = document.querySelector("#btn")

btn.addEventListener('click', function(){

    if(userDob > today){
        result.textContent = "La date doit être dans le passé"
    }

    else{

    }

});