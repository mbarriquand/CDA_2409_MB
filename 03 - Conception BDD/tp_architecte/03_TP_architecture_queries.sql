/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */

SELECT client_ref AS "Référence client",
client_nom AS "Nom client",
client_telephone AS "# client"
FROM clients
WHERE client_telephone LIKE '04%';

/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */

SELECT client_ref AS "Référence client",
client_nom AS "Nom client",
type_clients.type_client_id AS "ID type de client",
type_clients.type_client_libelle AS "Libellé type de client"
FROM clients
JOIN type_clients ON type_clients.type_client_id = clients.type_client_id
WHERE type_client_libelle = "particulier"; 

SELECT client_ref, client_nom
FROM clients
NATURAL JOIN type_clients
WHERE type_client_libelle = "particulier";

/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */

SELECT client_ref AS "Référence client",
client_nom AS "Nom client",
type_clients.type_client_id AS "ID type de client",
type_clients.type_client_libelle AS "Libellé type de client"
FROM clients
JOIN type_clients ON type_clients.type_client_id = clients.type_client_id
WHERE type_client_libelle != "particulier"; 

/* 4. Sélectionner les projets qui ont été livrés en retard */

SELECT projet_ref AS "Référence projet",
projets.client_ref AS "Référence client",
clients.client_nom AS "Nom du client"
FROM projets
JOIN clients ON clients.client_ref = projets.client_ref
WHERE projet_date_fin_prevue < projet_date_fin_effective;

/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets
    avec le nom du client et le nom de l'architecte associés au projet */
    
    SELECT projet_date_depot AS "Date de dépôt",
    projet_date_fin_prevue AS "Date de fin prévue",
    projet_superficie_totale AS "Superficie totale",
    projet_superficie_batie AS "Superficie batie",
    projet_prix AS "Prix du projet",
    clients.client_nom AS "Nom du client",
    employes.emp_nom AS "Architecte associé"
    FROM projets
    JOIN clients ON clients.client_ref = projets.client_ref
    JOIN employes ON employes.emp_matricule = projets.emp_matricule
    JOIN fonctions ON fonctions.fonction_id = employes.fonction_id
    WHERE fonctions.fonction_nom = "Architecte";

/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */
-- A REVOIR !!

SELECT projets.projet_ref AS "Référence projet",
projets.projet_date_depot AS "Date de dépôt",
projets.projet_date_fin_prevue AS "Date de fin prévue", 
projets.projet_superficie_totale AS "Superficie totale", 
projets.projet_superficie_batie AS "Superficie batie", 
projets.projet_prix AS "Prix du projet", 
COUNT(*) - 2 AS "Nombre d'intervenants"
FROM projets
INNER JOIN participer ON projets.projet_ref = participer.projet_ref
GROUP BY projets.projet_ref;

SELECT projets.projet_ref, projet_date_depot, projet_superficie_totale, projet_prix, COUNT(participer.emp_matricule)
FROM projets
JOIN participer ON projets.projet_ref = participer.projet_ref
GROUP BY participer.projet_ref
ORDER BY participer.projet_ref DESC;

/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */

SELECT type_projet_libelle AS "Libellé type de projet",
COUNT(projet_ref) AS "Nombre de projets",
ROUND(AVG(projet_prix), 2) AS "Prix moyen"
FROM projets
JOIN type_projets ON projets.type_projet_id = type_projets.type_projet_id
GROUP BY type_projets.type_projet_libelle;


/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */

SELECT type_travaux.type_travaux_libelle AS "type de travaux",
MAX(projets.projet_superficie_totale) AS "superficie la plus grande"
FROM projets
JOIN type_travaux ON projets.type_travaux_id = type_travaux.type_travaux_id
GROUP BY type_travaux.type_travaux_libelle;

/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */

SELECT projets.projet_ref AS "Référence projet",
projets.projet_date_depot AS "Date de dépôt",
projets.projet_date_fin_prevue AS "Date de fin prévue",
projets.projet_date_fin_effective AS "Date de fin effective",
projets.projet_prix AS "Prix du projet",
clients.client_nom AS "Nom du client",
clients.client_telephone AS "Téléphone client",
CONCAT(adresses.adresse_code_postal, ' ', adresses.adresse_ville, ' ', adresses.adresse_num_voie, ' ', adresses.adresse_voie) AS "Adresse du client",
type_travaux.type_travaux_libelle AS "Type de travaux",
type_projets.type_projet_libelle AS "Type de projet"
FROM projets
JOIN clients ON projets.client_ref = clients.client_ref
JOIN adresses ON adresses.adresse_id = clients.adresse_id
JOIN type_projets ON type_projets.type_projet_id = projets.type_projet_id
JOIN type_travaux ON type_travaux.type_travaux_id = projets.type_travaux_id;

/* 10. Sélectionner les projets dont l'adresse est identique au client associé */

SELECT projets.projet_ref AS "Référence projet",
clients.client_ref AS "Référence client"
FROM projets
JOIN clients ON projets.client_ref = clients.client_ref
JOIN adresses ON adresses.adresse_id = clients.adresse_id
WHERE projets.adresse_id = clients.adresse_id;



