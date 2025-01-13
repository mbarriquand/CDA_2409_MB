DROP DATABASE IF EXISTS employes;

CREATE DATABASE employes;

USE employes;

CREATE TABLE dept (
deptno TINYINT PRIMARY KEY,
dname VARCHAR(50) NOT NULL,
loc VARCHAR(100) NOT NULL);

CREATE TABLE emp (
empno INT PRIMARY KEY,
ename VARCHAR(50) NOT NULL,
job VARCHAR(50) NOT NULL,
mgr INT,
hiredate DATE NOT NULL,
sal INT NOT NULL,
comm INT,
deptno TINYINT NOT NULL);

-- insérer les valeurs du jeu d'essai avant d'insérer les clés étrangères

ALTER TABLE emp ADD CONSTRAINT fk_dept FOREIGN KEY (deptno) REFERENCES dept(deptno);
ALTER TABLE emp ADD CONSTRAINT fk_empmgr FOREIGN KEY (mgr) REFERENCES emp(empno);

-- 

CREATE TABLE project (
pnum SMALLINT AUTO_INCREMENT,
pname CHAR(5) NOT NULL,
pbudg DECIMAL(8,2) NOT NULL, CONSTRAINT pk_projet PRIMARY KEY(pnum)
);

 ALTER TABLE project AUTO_INCREMENT = 101;
 ALTER TABLE EMP ADD pnum SMALLINT;
 
UPDATE emp SET pnum = 101
WHERE deptno = 30 AND job = 'salesman';

UPDATE emp SET pnum = 102
WHERE deptno != 30;

