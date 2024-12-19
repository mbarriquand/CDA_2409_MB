USE rezo;

-- Sélectionner tous les utilisateurs (nom d'utilisateur + email).

SELECT nom_utilisateur, email FROM utilisateur;

-- Sélectionner toutes les publications (titre, date, contenu, id utilisateur) triées par date de la plus récente à la plus ancienne.

SELECT pub_titre, pub_date, pub_contenu, id
FROM publication
ORDER BY pub_date DESC;

-- Sélectionner les publications (pub_id, date, titre) de l'utilisateur N°2.

SELECT pub_id, pub_date, pub_titre
FROM publication
WHERE id = 2;

-- Sélectionner les publications (pub_id, titre, contenu) dont le titre contient la lettre "a". Le résultat est trié par le titre et par ordre décroissant.

SELECT pub_id, pub_titre, pub_contenu
FROM publication
WHERE pub_titre LIKE '%a%'
ORDER BY pub_titre DESC;

-- Sélectionner les utilisateurs (id, nom, email) dont l'adresse email se termine par "com".

SELECT id, nom_utilisateur, email
FROM utilisateur
WHERE email like '%.com%'

-- Sélectionner les publications triées par titre (ordre alphabétique) avec le nom d'utilisateur de l'auteur (nécessite une jointure).

SELECT