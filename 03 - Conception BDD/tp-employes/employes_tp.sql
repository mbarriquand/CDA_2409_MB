-- 1. Donner nom, job, numéro et salaire de tous les employés, puis seulement des employés du département 10
SELECT ename, job, empno, sal
FROM emp
WHERE deptno = 10;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800
SELECT ename, job, sal
FROM emp
WHERE job = 'MANAGER' AND sal > 2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30
SELECT *
FROM emp
WHERE job = 'MANAGER' AND deptno != 30;

-- 4. Liste des employés de salaire compris entre 1200 et 1400
SELECT *
FROM emp
WHERE sal BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique
SELECT *
FROM emp
WHERE deptno IN (10, 30)
ORDER BY ename;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants
SELECT *
FROM emp 
WHERE deptno = 30
ORDER BY sal;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants
SELECT *
FROM emp
ORDER BY job ASC, sal DESC;

-- 8. Liste des différents emplois
SELECT job
FROM emp
GROUP BY job;

-- 9. Donner le nom du département où travaille ALLEN
SELECT dname 
FROM dept
JOIN emp 
ON emp.deptno = dept.deptno
WHERE ename = 'ALLEN';

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.
SELECT dept.dname, ename, job, sal
FROM emp
JOIN dept
ON dept.deptno = emp.deptno
ORDER BY dname AND sal DESC;

-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions
SELECT ename, sal, comm, sal + comm AS ' salComm'
FROM emp
WHERE job = 'SALESMAN';

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'
SELECT ename, job, DATE_FORMAT(hiredate, "%W %e %M %Y")
FROM emp
WHERE deptno = 20;

-- 13. Donner le salaire le plus élevé par département
SELECT MAX(sal)
FROM emp
GROUP BY deptno;

-- 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.
SELECT SUM(sal), COUNT(empno), AVG(sal)
FROM emp
GROUP BY deptno;

-- 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés
SELECT SUM(sal), COUNT(empno), AVG(sal)
FROM emp
GROUP BY deptno
HAVING COUNT(empno) >= 2;

-- 16. Liste des employés (Nom, département, salaire) de même emploi que JONES
SELECT ename, dname, sal
FROM emp, dept
WHERE dept.deptno = emp.deptno AND job = (SELECT job FROM emp WHERE ename = 'JONES') AND ename != 'JONES'; 

-- 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires
SELECT ename, sal
FROM emp
WHERE sal > (SELECT AVG(sal) FROM emp);

-- 18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
-- 101, ALPHA, 96000
-- 102, BETA, 82000
-- 103, GAMMA, 15000

DROP TABLE IF EXISTS project;
CREATE TABLE project (
num_proj SMALLINT AUTO_INCREMENT,
name_proj CHAR(5) NOT NULL,
budget_proj DECIMAL(8,2) NOT NULL,
CONSTRAINT PK_project PRIMARY KEY(num_proj)
);

ALTER TABLE project AUTO_INCREMENT = 101;

INSERT INTO project 
(name_proj, budget_proj)
VALUES
('alpha',96000),
('beta',82000),
('gamma',15000);

-- 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102
ALTER TABLE emp ADD num_proj SMALLINT;

UPDATE emp SET num_proj = 101
WHERE deptno = 30 AND job = 'salesman';

UPDATE emp SET num_proj = 102
WHERE num_proj IS NULL;

-- 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet
CREATE VIEW view_employe AS
SELECT ename, job, dname, name_proj
FROM emp
JOIN dept
ON dept.deptno = emp.deptno
JOIN project
ON project.num_proj = emp.num_proj;

-- 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet
SELECT ename, job, dname, name_proj
FROM view_employe
ORDER BY dname ASC, name_proj ASC;

-- 22.Donner le nom du projet associé à chaque manager

SELECT ename, name_proj FROM emp
JOIN project
ON project.num_proj = emp.num_proj
WHERE job = 'manager';

-- Deuxième partie
-- 1. Afficher la liste des managers des départements 20 et 30

SELECT ename, job, deptno FROM emp
WHERE job = "manager" AND deptno != 10;

-- 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81

SELECT ename, job, hiredate FROM emp
WHERE job != 'manager' AND hiredate LIKE '%81%';

-- 3. Afficher la liste des employés ayant une commission

SELECT ename, job, comm FROM emp
WHERE comm IS NOT NULL AND comm > 0;

-- 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord.

SELECT ename, deptno, job, hiredate FROM emp
ORDER BY deptno, job, hiredate DESC;

-- 5. Afficher la liste des employés travaillant à DALLAS

SELECT ename, job, loc FROM emp
INNER JOIN dept
ON dept.deptno = emp.deptno
WHERE loc = 'dallas';

-- 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.



-- 7. Lister les numéros des employés n'ayant pas de subordonné.

SELECT ename, job FROM emp
WHERE mgr IS NULL;

-- 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.



-- 9. Afficher les employés embauchés le même jour que FORD.

-- 10. Lister les employés ayant le même manager que CLARK.

-- 11. Lister les employés ayant même job et même manager que TURNER.

-- 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.