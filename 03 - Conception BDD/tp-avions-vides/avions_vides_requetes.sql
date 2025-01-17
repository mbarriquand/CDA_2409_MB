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

/* SELECT pilnom 'Nom du pilote', loc 'Ville', avmarq 'Marque de l\'avion'
FROM pilote 
JOIN avion ON avion.loc = pilote.adr
WHERE avion.avmarq = 'AIRBUS';

-- 7 Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans la ville de localisation d'un Airbus ?

SELECT pilnom 'Nom du pilote', loc 'Ville', avmarq 'Marque de l\'avion'
FROM pilote
JOIN avion ON pilote.adr = avion.loc
WHERE avion.loc = pilote.adr AND avion.loc = 'AIRBUS'; */

-- 8 Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans la ville de localisation d'un Airbus ?

-- 9 Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ?

-- 10 Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ?

-- 11 Donner toutes les paires de pilotes habitant la même ville ( sans doublon ).

-- 12 Quels sont les noms des pilotes qui conduisent un avion que conduit aussi le pilote n°1 ?

-- 13 Donner toutes les paires de villes telles qu'un avion localisé dans la ville de départ soit conduit par un pilote résidant dans la ville d'arrivée.

-- 14 Sélectionner les numéros des pilotes qui conduisent tous les Airbus ?