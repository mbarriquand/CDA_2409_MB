# TP Mini Rezo Social (version NoSQL)

## Sélectionner tous les utilisateurs (nom d’utilisateur + email).

- db.publications.find({},{nom_utilisateur : 1, email : 1})

## Sélectionner toutes les publications (titre, contenu, id utilisateur) triées par le titre et par ordre alphabétique.

- db.publications.find({},{pub_titre : 1, pub_contenu : 1, id : 1}).sort({pub_titre :1})

## Sélectionner les publications (pub_id, date, titre) de l’utilisateur N°2.

- db.publications.find({user_id : 2},{nom_utilisateur : 1, pub_id :1, pub_titre : 1})

## Sélectionner les publications (pub_id, titre, contenu) dont le titre contient la lettre “a”. Le résultat est trié par le titre et par ordre décroissant.

- db.publications.find({"nom_utilisateur" : {$regex : "a"}}, {pub_id : 1, pub_titre : 1, pub_contenu : 1})

## Sélectionner les utilisateurs (id, nom, email) dont l’adresse email se termine par “com”.

- db.publications.find({"email" : {$regex : ".com$"}},{user_id : 1, nom_utilisateur : 1, email : 1})

## Sélectionner les publications triées par titre (ordre alphabétique) avec le nom d’utilisateur de l’auteur (nécessite une jointure).

db.publications.find({},{pub_titre : 1, nom_utilisateur : 1}).sort({pub_titre : 1})