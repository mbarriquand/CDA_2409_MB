USE employes;

-- DELIMITER |
-- CREATE PROCEDURE salariessup ( IN niv_sal DECIMAL(8,2))
-- BEGIN

-- SELECT ename, job, sal FROM emp WHERE sal>= niv_sal;

-- END |
-- DELIMITER ;

-- SET @niv_sal_souhaite:=2000.9;

-- CALL salariessup( @niv_sal_souhaite);

DELIMITER |
CREATE PROCEDURE effectif_job(IN job_souhaite VARCHAR(50))
BEGIN

SELECT COUNT(empno), job, AVG(sal)
FROM emp
WHERE job = job_souhaite
GROUP BY job;

END |
DELIMITER ;

SET @job_souhaite:= 'CLERK';

CALL effectif_job(@job_souhaite);