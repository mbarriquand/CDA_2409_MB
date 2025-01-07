-- Sélectionner tous les utilisateurs (identifiant, nom, prénom, email).

SELECT user_id, user_lastname, user_firstname, user_email FROM users;

-- Sélectionner toutes les questions (date, intitulé, réponse, identifiant utilisateur) triées par date de la plus ancienne à la plus récente.

SELECT question_date, question_label, question_response, user_id FROM questions ORDER BY question_date ASC;

-- Sélectionner les questions (identifiant, date, intitulé, réponse) de l’utilisateur n°2.

SELECT question_id, question_date, question_label, question_response FROM questions WHERE user_id = "2";

-- Sélectionner les questions (date, intitulé, réponse, identifiant utilisateur) de l’utilisateur Eva Satiti.

SELECT q.question_date, q.question_label, q.question_response, q.user_id /*, u.user_id, u.user_firstname, u.user_lastname */
FROM questions q
INNER JOIN users u ON q.user_id = u.user_id
WHERE u.user_lastname = "Satiti" AND u.user_firstname = "Eva";

-- Sélectionner les questions (identifiant, date, intitulé, réponse, identifiant utilisateur) dont l’intitulé contient “SQL”. Le résultat est trié par le titre et par ordre décroissant.

SELECT question_id, question_date, question_label, question_response, user_id
FROM questions
WHERE question_label LIKE "%SQL%"
ORDER BY question_label DESC;

-- Sélectionner les catégories (nom, description) sans question associée.

SELECT categorie_name, categorie_description
FROM categories

-- Sélectionner les questions triées par titre (ordre alphabétique) avec le nom et prénom de l’auteur (nécessite une jointure).

-- Sélectionner les catégories (nom) avec, pour chaque catégorie le nombre de questions associées (nécessite une jointure).
