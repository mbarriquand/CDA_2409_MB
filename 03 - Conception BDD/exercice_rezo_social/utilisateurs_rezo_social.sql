/* CREER UN UTILISATEUR */

DROP USER 'toto'@'localhost';

CREATE USER 'toto'@'localhost' IDENTIFIED BY 'azer';

/* ACCORDER TOUS LES PRIVILEGES A TOTO 
sur la base de données rezo_social*/

GRANT ALL PRIVILEGES ON rezo_social.* TO 'toto'@'localhost';

/* RECHARGE LES DROITS AU NIVEAU DU SERVEUR
l'utilisateur n'a pas besoin de se reconnecter pour une MAJ des droits */
FLUSH PRIVILEGES;