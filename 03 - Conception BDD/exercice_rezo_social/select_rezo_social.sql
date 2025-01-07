USE rezo_social;

/* AFFICHER TOUTES LES DONNEES DE TOUTES LES COLONNES ET TOUTES LES LIGNES */
SELECT * FROM utilisateur;
SELECT * FROM publication;
SELECT * FROM aimer;

-- Sélectionner tous les utilisateurs (nom d’utilisateur + email).

SELECT nom_utilisateur, email FROM utilisateur;

-- Sélectionner toutes les publications (titre, date, contenu, id utilisateur) triées par date de la plus récente à la plus ancienne.

SELECT pub_titre, pub_date, pub_contenu, id 
FROM publication
ORDER BY pub_date DESC;

-- Sélectionner toutes les publications triées par id utilisateur puis par date, de la plus récente à la plus ancienne.

SELECT * FROM publication ORDER BY id DESC, pub_date ASC;

-- Sélectionner les publications (pub_id, date, titre) de l’utilisateur N°2.

SELECT pub_id, pub_date, pub_titre FROM publication
WHERE id = '2';

-- Sélectionner les publications (pub_id, titre, contenu) dont le titre contient la lettre “a”.
-- Le résultat est trié par le titre et par ordre décroissant.

SELECT pub_id, pub_titre, pub_contenu
FROM publication
WHERE pub_titre LIKE '%a%'
ORDER BY pub_titre DESC;

-- Sélectionner les publications (pub_id, titre, contenu) dont le titre NE contient PAS la lettre “a”.
-- Le résultat est trié par le titre et par ordre décroissant.

SELECT pub_id, pub_titre, pub_contenu
FROM publication
WHERE pub_titre NOT LIKE '%a%'
ORDER BY pub_titre DESC;

-- Sélectionner les utilisateurs (id, nom, email) dont l'adresse email se termine par "com".

SELECT id, nom_utilisateur, email
FROM utilisateur
WHERE email like '%com';

-- Sélectionner les publications triées par titre (ordre alphabétique)
-- avec le nom d'utilisateur de l'auteur (nécessite une jointure)

-- version sans jointure
SELECT * FROM publication, utilisateur
WHERE publication.id = utilisateur.id;

-- version avec jointure, à privilégier pour des raisons de performances
SELECT pub_id, pub_date, pub_titre, pub_contenu, nom_utilisateur
FROM publication
INNER JOIN utilisateur ON publication.id = utilisateur.id
ORDER BY pub_titre;