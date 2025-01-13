-- 1. Donner nom, job, numéro et salaire de tous les employés :

SELECT ename, job, empno, sal FROM emp;

-- 1.5 puis seulement des employés du département 10.

SELECT ename, job, empno, sal FROM emp
WHERE deptno = 10;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800.

SELECT ename, job, sal FROM emp
WHERE job = 'manager' AND sal >= 2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30.

SELECT ename FROM emp
WHERE job = 'manager' AND deptno <> 30;


-- 4. Liste des employés de salaire compris entre 1200 et 1400.

SELECT ename FROM emp
WHERE sal BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique.

SELECT ename FROM emp
WHERE deptno = 10 OR deptno = 30
ORDER BY ename ASC;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants.

SELECT ename FROM emp
WHERE deptno = 30
ORDER BY sal ASC;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants.

SELECT ename, job, sal FROM emp
ORDER BY job, sal DESC;

-- 8. Liste des différents emplois.

SELECT job FROM emp
GROUP BY job;

-- solution alternative : 'SELECT DISTINCT job FROM emp'

-- 9. Donner le nom du département où travaille ALLEN.

SELECT d.dname AS 'department name', e.ename AS 'employe name' FROM dept d
INNER JOIN emp e ON d.deptno = e.deptno
WHERE ename = 'ALLEN';

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.

SELECT d.dname, e.ename, e.job, e.sal FROM emp e
INNER JOIN dept d ON e.deptno = d.deptno
ORDER BY d.dname ASC, sal DESC;

-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions.

SELECT ename, sal, comm, sal + comm AS 'salaire et comissions' FROM emp
WHERE job = 'SALESMAN';

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'.
SET lc_time_names = "fr_FR";
SELECT ename, job, UPPER(DATE_FORMAT(hiredate, "%a %e %b %Y")) AS 'Date d\'embauche' FROM emp
WHERE deptno = 20;

-- 13. Donner le salaire le plus élevé par département.

SELECT e.deptno, d.dname, MAX(sal) FROM emp e
INNER JOIN dept d ON e.deptno = d.deptno
GROUP BY deptno;

-- 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.

SELECT
e.deptno AS '# du departement',
d.dname AS 'nom du département', 
e.job AS 'type d\'emploi',
SUM(sal + IFNULL(comm,0)) AS 'masse salariale',
COUNT(*) AS 'nombre d\'employés',
ROUND(AVG(sal),2) AS 'salaire moyen'
FROM emp e
INNER JOIN dept d ON e.deptno = d.deptno
GROUP BY d.deptno, e.job;

-- 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés

SELECT deptno AS '# du département',
job AS 'nom du sous-ensemble',
SUM(sal + IFNULL(comm,0)) AS 'masse salariale',
COUNT(*) AS 'nombre d\'employés',
ROUND(AVG(sal),2) AS 'salaire moyen'
FROM emp
GROUP BY job, deptno
HAVING COUNT(*) >= 2;

-- 16. Liste des employés (Nom, département, salaire) de même emploi que JONES

SELECT ename, deptno, sal
FROM emp
WHERE job = ( SELECT job FROM emp WHERE ename = 'JONES');

-- 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires

SELECT ename, sal
FROM emp
WHERE sal >= (SELECT AVG(sal) FROM emp);

-- 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet

-- deux inner join ?

-- 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet
