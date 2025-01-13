-- 1. Donner nom, job, numéro et salaire de tous les employés,

SELECT ename, job, empno, sal FROM emp;

-- 1.5 puis seulement des employés du département 10 

SELECT ename, job, empno, sal FROM emp
WHERE deptno = 10;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800

SELECT ename, job, sal FROM emp
WHERE job = 'manager' AND sal >= 2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30

SELECT ename FROM emp
WHERE job = 'manager' AND deptno <> 30;


-- 4. Liste des employés de salaire compris entre 1200 et 1400

SELECT ename FROM emp
WHERE sal BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique

SELECT ename FROM emp
WHERE deptno = 10 OR deptno = 30
ORDER BY ename ASC;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants

SELECT ename FROM emp
WHERE deptno = 30
ORDER BY sal ASC;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants

SELECT ename, job, sal FROM emp
ORDER BY job, sal DESC;

-- 8. Liste des différents emplois

SELECT job FROM emp
GROUP BY job;

-- 9. Donner le nom du département où travaille ALLEN

SELECT d.dname AS 'department name', e.ename AS 'employe name' FROM dept d
INNER JOIN emp e ON d.deptno = e.deptno
WHERE ename = 'ALLEN';

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.

SELECT d.dname, e.ename, e.job, e.sal FROM emp e
INNER JOIN dept d ON e.deptno = d.deptno
ORDER BY d.dname ASC, sal DESC;

-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'