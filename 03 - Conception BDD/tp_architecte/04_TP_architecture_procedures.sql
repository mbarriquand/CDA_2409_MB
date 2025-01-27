-- Afficher les projets d'un architecte --- Pour un nom d'architecte en variable, donner la référence des projets dont il est responsable (vérifier sa fonction)

DELIMITER |
CREATE PROCEDURE rechercheProjetsArchitecte (IN nom_emp VARCHAR(50))
BEGIN
	SELECT projet_ref
    FROM projets
    INNER JOIN employes ON projets.emp_matricule = employes.emp_matricule
    WHERE employes.emp_nom = nom_emp;
END | 
DELIMITER ;

-- DROP PROCEDURE rechercheProjetsArchitecte;

-- + sa fonction

DELIMITER |
CREATE PROCEDURE rechercheProjets (IN nom_emp VARCHAR(50))
BEGIN
	SELECT projet_ref, fonctions.fonction_nom
    FROM projets
    INNER JOIN employes ON projets.emp_matricule = employes.emp_matricule
    NATURAL JOIN fonctions
    WHERE employes.emp_nom = nom_emp;
END | 
DELIMITER ;

-- DROP PROCEDURE rechercheProjets;

SET @nom_employes :="Roussotte";

CALL RechercheProjetsArchitecte( @nom_employes);
CALL RechercheProjetsArchitecte("Golay");

CALL RechercheProjets( @nom_employes);

-- Créer une procédure stockée qui pour un nom de salarié renvoie
-- dans une  variable le budget total des projets dont il est responsable,
-- et renvoie 0 si pas de projet en responsabilité

DELIMITER |
CREATE PROCEDURE budgetTotal (IN nom_emp VARCHAR(50), OUT totalBudget DECIMAL(10,2), OUT nbProjets INT)
BEGIN
SELECT fonctions.fonction_nom 
FROM fonctions
NATURAL JOIN employes
WHERE employes.emp_nom = nom_emp;

SELECT IFNULL(SUM(projet_prix),0) INTO totalBudget
FROM projets
INNER JOIN employes ON employes.emp_matricule = projets.emp_matricule
WHERE employes.emp_nom = nom_emp;

SELECT IFNULL(COUNT(projet_ref),0) INTO nbProjets
FROM projets
INNER JOIN employes ON employes.emp_matricule = projets.emp_matricule
WHERE employes.emp_nom = nom_emp;

END | 
DELIMITER ;

-- DROP PROCEDURE budgetTotal;

SET @nom := "Golay";
CALL budgetTotal(@nom, @montant, @nb);
SELECT @montant AS "Somme des projets";
SELECT @nb AS "Nombre de projets";

-- Définir une variable qui sera le cumul des montants projets ( @cumul_projet_test )
-- Définir une stored procedure qui en fonction du numéro de projet choisit ajoutera son montant au cumul_projet_test pour avoir le montant global 

DELIMITER |
CREATE PROCEDURE ajouterBudgetProj(IN numero_projet INT, INOUT cumul_projet DECIMAL(10,2))
-- INOUT : la variable existe avant, elle est modifiée par la procédure, elle existe après en étant modifiée
-- passage de la variable en référence

BEGIN
	SELECT (cumul_projet + projets.projet_prix) INTO cumul_projet
    FROM projets
    WHERE projet_ref = numero_projet;
END |
DELIMITER ;

DROP PROCEDURE ajouterBudgetProj;

SET @cumul_projet_test := 0;

SELECT @cumul_projet_test AS "Résultat départ";

CALL ajouterBudgetProj(4, @cumul_projet_test);

SELECT @cumul_projet_test AS "Résultat intermédiaire";

CALL ajouterBudgetProj(2, @cumul_projet_test);

SELECT @cumul_projet_test AS "Résultat final";