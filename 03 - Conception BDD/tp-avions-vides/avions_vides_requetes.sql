-- 1 Quels sont les vols au départ de Paris entre 12h et 14h ?

SELECT vol 'numéro du vol', vd 'ville de départ', va 'ville d\'arrivée', hd 'heure de départ', ha 'heure d\'arrivée'
FROM vol
WHERE hd BETWEEN '12'AND '14'
HAVING vd = 'Paris';

-- 2 Quels sont les pilotes dont le nom commence par "S" ?

SELECT pil 'Numéro du pilote', pilnom 'Nom du pilote' FROM pilote
WHERE pilnom LIKE 'S%';

-- 3 Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent.

SELECT loc 'Ville', COUNT(av) 'Nombre d\'avions', MIN(cap) 'Capacité minimum', MAX(cap) 'Capacité maximum'
FROM avion
GROUP BY loc;

-- 4 Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et cela par type d'avion.

SELECT loc 'Ville', ROUND(AVG(cap)) 'Capacité moyenne', avtype 'Type d\'avion'
FROM avion
GROUP BY loc, avtype; 

-- 5 Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 avion ?

SELECT loc 'Ville', ROUND(AVG(cap)) 'Capacité moyenne', COUNT(av) 'Nombre d\'avions'
FROM avion
GROUP BY loc
HAVING COUNT(av) >= 2;

-- 6 Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un Airbus ?

SELECT pilnom
FROM pilote
WHERE adr IN (SELECT loc FROM avion WHERE avmarq = 'AIRBUS') AND
pil IN (SELECT pil FROM vol, avion WHERE avion.av = vol.av AND avmarq = 'AIRBUS');
SELECT DISTINCT pilnom, adr
FROM vol, avion, pilote
WHERE vol.av = avion.av AND pilote.pil = vol.pil AND avmarq = 'AIRBUS' AND adr IN (SELECT loc FROM avion WHERE avmarq = 'AIRBUS');

-- 7 Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans la ville de localisation d'un Airbus ?

SELECT pilnom FROM pilote
WHERE adr IN (SELECT loc FROM avion WHERE avmarq = "AIRBUS")
AND pil IN (SELECT pil FROM vol, avion WHERE avion.av = vol.av AND avmarq = "AIRBUS");

SELECT pil FROM vol, avion WHERE avion.av = vol.av AND avmarq = "AIRBUS";

SELECT loc FROM avion WHERE avmarq = "AIRBUS"; 

/* SELECT DISTINCT pilnom, adr FROM vol, avion, pilote
WHERE vol.av = avion.av AND pilote.pil = vol.pil
AND avmarq = "AIRBUS" AND adr 
IN (SELECT loc FROM avion WHERE avmarq = "AIRBUS"); */

-- 8 Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans la ville de localisation d'un Airbus ?

SELECT pilnom FROM pilote
WHERE adr IN (SELECT loc FROM avion WHERE avmarq = "AIRBUS")
OR pil IN (SELECT pil FROM vol, avion WHERE avion.av = vol.av AND avmarq = "AIRBUS");

-- 9 Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ?

SELECT pilnom FROM pilote
WHERE adr NOT IN (SELECT loc FROM avion WHERE avmarq = "AIRBUS")
AND pil IN (SELECT pil FROM vol, avion WHERE avion.av = vol.av AND avmarq = "AIRBUS");

-- NOT IN ou != ALL

-- 10 Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ?

SELECT vol, pilnom, vd, va FROM vol, pilote
WHERE vol.pil = pilote.pil
AND vd IN (SELECT vd FROM vol, pilote WHERE vol.pil = pilote.pil AND pilnom = 'SERGE')
AND va IN (SELECT va FROM vol, pilote WHERE vol.pil = pilote.pil AND pilnom = 'SERGE') AND pilnom <> 'SERGE';

-- 11 Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).

SELECT p1.pilnom, p2.pilnom FROM pilote p1, pilote p2
WHERE p1.adr = p2.adr AND p1.pilnom < p2.pilnom;

-- 12 Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le pilote n°1 ?

-- 13 Donner toutes les paires de villes telles qu'un avion localisé dans la ville de départ soit conduit par un pilote résidant dans la ville d'arrivée.

-- 14 Sélectionner les numéros des pilotes qui conduisent tous les Airbus ?