function CreerCookie(nomCookie, valeurCookie) {
  let datejour = new Date();

  let dateExpire = new Date(
    datejour.getFullYear(),
    datejour.getMonth(),
    datejour.getDate(),
    datejour.getHours() + 2,
    datejour.getMinutes(),
    datejour.getSeconds()
  );

  let dateExpireTest = dateExpire.toUTCString();
  document.cookie =
    nomCookie +
    "=" +
    valeurCookie +
    ";expires=" +
    dateExpireTest +
    ";SameSite=Strict";
}

const btnC = document.querySelector("#btnCookie");
btnC.addEventListener("click", function () {
  let user = document.querySelector("#username").value;
  CreerCookie("Nom", user);
  window.location.href ="/js_cookies/intro_cookies_destination.html";
});

