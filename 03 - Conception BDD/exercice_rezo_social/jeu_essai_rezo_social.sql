/* SELECTIONNER LA BASE DE DONNEES A UTILISER */

USE rezo_social;


INSERT INTO utilisateur
VALUES
(NULL, "Zorro", "zorb@example.com"),
(NULL, "Patchouli", "patchouli@example.fr"),
(NULL, "Eva", "eva.stt@example.com");


INSERT INTO publication
(pub_id, pub_date, pub_titre, pub_contenu, id)
VALUES
(1, "2024-11-23 14:30", "Il fait beau", "Quel beau soleil aujourd'hui !", 3),
(2, "2024-11-23 09:15", "Les bonbons",	"Les bonbons, c'est bon", 2),
(3,	"2024-11-27 08:17",	"Super resto",	"J'ai découvert un super restaurant hier soir.", 1),
(4, "2024-12-05 17:52",	"Album disponible", "Nouvel album de mon groupe préféré !",	2),
(5,	"2024-12-15 10:05",	"Aidez-moi", "Je cherche une recette de gâteau au chocolat.", 3);