-- Afficher les projets d'un architecte : pour un nom d'architecte, 

DELIMITER |
CREATE PROCEDURE nom_de_la_procedure (IN procedure_id INT)
BEGIN
	SELECT id, nom, prix
    FROM table_exemple
    WHERE espece_id = procedure_id;
END |
DELIMITER ;