function CreerCookies(nomCookie, valeurCookie){

    let dateJour = new Date();
    let dateExpire = new Date(dateJour.getFullYear(), dateJour.getMonth(), dateJour.getDate(), (dateJour.getHours()+2));

    dateExpire += dateExpire.toUTCString();

    document.cookie = nomCookie + "=" + valeurCookie + ";expires=" + dateExpire + ";SameSite=Strict";
}

const btnC = document.querySelector("#btnCookie");
btnC.addEventListener("click", function(){
let user = document.querySelector("#username").value;

CreerCookies("Nom", user);

window.location.assign("./intro_cookies_destination.html");

});
