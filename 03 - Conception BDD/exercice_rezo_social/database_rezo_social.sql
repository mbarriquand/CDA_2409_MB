/* SUPPRIMER LA BASE DE DONNEES SI ELLE EXISTE */
DROP DATABASE IF EXISTS rezo_social;

/* CREER LA BASE DE DONNEES */

CREATE DATABASE rezo_social;

/* PRECISER QU'IL FAUT UTILISER CETTE BDD */

USE rezo_social;

/* CREER LA TABLE utilisateur */

CREATE TABLE utilisateur
(
id INT PRIMARY KEY,
nom_utilisateur VARCHAR(32) NOT NULL UNIQUE,
email VARCHAR(128) UNIQUE NOT NULL
);

/* CREER LA TABLE PUBLICATION */

CREATE TABLE publication
(
pub_id INT AUTO_INCREMENT,
pub_date DATETIME NOT NULL,
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
PRIMARY KEY(id, pub_id)
);

/* MODIFIER LA TABLE ET Y AJOUTER UNE CLE ETRANGERE */
ALTER TABLE publication ADD FOREIGN KEY (id) REFERENCES utilisateur(id);

/* MODIFIER LA TABLE ET Y AJOUTER UNE CLE ETRANGERE DONT ON PERSONNALISE LE NOM */
ALTER TABLE aimer ADD CONSTRAINT fk_aimer_utilisateur FOREIGN KEY (id) REFERENCES utilisateur(id);

/* SUPPRIMER UNE CONTRAINTE :
 ALTER TABLE aimer DROP CONSTRAINT fk_aimer_utilisateur; */

ALTER TABLE aimer ADD CONSTRAINT fk_aimer_publication FOREIGN KEY (pub_id) REFERENCES publication(pub_id);

/* SYNTAXE ALTERNATIVE : 

ALTER TABLE aimer
	ADD CONSTRAINT fk_aimer_utilisateur FOREIGN KEY (id) REFERENCES utilisateur(id);
    ADD CONSTRAINT fk_aimer_publication FOREIGN KEY (pub_id) REFERENCES publication(pub_id); */
    

