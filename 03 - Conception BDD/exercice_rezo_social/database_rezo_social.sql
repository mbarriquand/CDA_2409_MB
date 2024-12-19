/* SUPPRIMER LA BASE DE DONNEES SI ELLE EXISTE */
DROP DATABASE IF EXISTS rezo;

/* CREER LA BASE DE DONNEES */

CREATE DATABASE rezo;

/* PRECISER QU'IL FAUT UTILISER CETTE BDD */

USE rezo;

/* CREER LA TABLE utilisateur */

CREATE TABLE utilisateur
(
id INT PRIMARY KEY AUTO_INCREMENT,
nom_utilisateur VARCHAR(32) NOT NULL,
email VARCHAR(128)
);

/* CREER LA TABLE PUBLICATION */

CREATE TABLE publication
(
pub_id INT AUTO_INCREMENT,
pub_date DATETIME,
pub_titre VARCHAR(255),
pub_contenu TEXT,
id INT,
PRIMARY KEY(pub_id),
FOREIGN KEY (id) REFERENCES utilisateur(id)
);

/* CREER LA TABLE aimer */

CREATE TABLE aimer
(
id INT,
pub_id INT,
PRIMARY KEY(id, pub_id),
FOREIGN KEY (id) REFERENCES utilisateur(id),
FOREIGN KEY (pub_id) REFERENCES publication(pub_id)
);