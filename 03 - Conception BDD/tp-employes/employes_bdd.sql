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

