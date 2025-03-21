use mini_faq;

SELECT * FROM users;
SELECT * FROM categories;
SELECT * FROM questions;
SELECT * FROM categories_questions;

-- Sélectionner tous les utilisateurs (identifiant, nom, prénom, email).

SELECT user_id, user_lastname, user_firstname, user_email
FROM users;

-- Sélectionner toutes les questions (date, intitulé, réponse, identifiant utilisateur)
-- triées par date de la plus ancienne à la plus récente.

SELECT question_date, question_label, question_response, user_id
FROM questions
ORDER BY question_date ASC;

-- Sélectionner les questions (identifiant, date, intitulé, réponse) de l’utilisateur n°2.

SELECT question_id, question_date, question_label, question_response
FROM questions
WHERE user_id = "2";

-- Sélectionner les questions (date, intitulé, réponse, identifiant utilisateur) de l’utilisateur Eva Satiti.

SELECT q.question_date, q.question_label, q.question_response, q.user_id /*, u.user_id, u.user_firstname, u.user_lastname */
FROM questions q
INNER JOIN users u ON q.user_id = u.user_id
WHERE u.user_lastname = "Satiti" AND u.user_firstname = "Eva";

/* SANS JOINTURE */
SELECT question_date, question_label, question_response, questions.user_id
FROM questions, users
WHERE questions.user_id = users.user_id AND user_lastname = "Satiti" AND user_firstname = "Eva";

-- Sélectionner les questions (identifiant, date, intitulé, réponse, identifiant utilisateur) dont l’intitulé contient “SQL”. Le résultat est trié par le titre et par ordre décroissant.

SELECT question_id, question_date, question_label, question_response, user_id
FROM questions
WHERE UPPER(question_label) LIKE "%sql%"
ORDER BY question_label DESC;

-- Sélectionner les catégories (nom, description) sans question associée.

SELECT c.category_name, c.category_description
FROM categories c
LEFT JOIN categories_questions cq ON c.category_name = cq.category_name
WHERE cq.question_id IS NULL;

-- Sélectionner les questions triées par titre (ordre alphabétique) avec le nom et prénom de l’auteur (nécessite une jointure).

SELECT question_label, question_response, user_lastname, user_firstname
FROM questions q JOIN users u ON q.user_id = u.user_id
ORDER BY question_label ASC;

-- Sélectionner les catégories (nom) avec, pour chaque catégorie le nombre de questions associées (nécessite une jointure).

SELECT c.category_name AS 'Titre de la catégorie', COUNT(cq.question_id) AS '# de la question'
FROM categories c
LEFT JOIN categories_questions cq ON c.category_name = cq.category_name
GROUP BY c.category_name;