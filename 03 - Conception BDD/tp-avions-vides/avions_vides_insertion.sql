USE avions_vides;

INSERT INTO avion
(av, avmarq, avtype, cap, loc)
VALUES
(100, 'AIRBUS', 'A320', 300, 'Nice'),
(101, 'BOIENG', 'B707', 250, 'Paris'),
(102, 'AIRBUS', 'A320', 300, 'Toulouse'),
(103, 'CARAVELLE', 'Caravelle', 200, 'Toulouse'),
(104, 'BOEING', 'B747', 400, 'Paris'),
(105, 'AIRBUS','A320', 300,'Paris'),
(106, 'ATR', 'ATR42', 50, 'Grenoble'),
(107, 'BOEING', 'B727', 300, 'Lyon'),
(108, 'BOEING', 'B727', 300, 'Nantes'),
(109, 'AIRBUS', 'A340', 250, 'Bastia');

INSERT INTO pilote
(pil, pilnom, adr)
VALUES
(NULL, 'Serge', 'Nice'),
(NULL, 'Jean', 'Paris'),
(NULL, 'Claude', 'Grenoble'),
(NULL, 'Robert', 'Nantes'),
(NULL, 'Simon', 'Paris'),
(NULL, 'Lucien', 'Toulouse'),
(NULL, 'Bertrand', 'Lyon'),
(NULL, 'Herve', 'Bastia'),
(NULL, 'Luc', 'Paris');

INSERT INTO vol
(vol, av, pil, vd, va, hd, ha)
VALUES
('IT100', 100, 1, 'NICE', 'PARIS', 7, 9),
('IT101', 100, 2, 'PARIS', 'TOULOUSE', 11, 12),
('IT102', 101, 1, 'PARIS', 'NICE', 12, 14),
('IT103', 105, 3, 'GRENOBLE', 'TOULOUSE', 9, 11),
('IT104', 105, 3, 'TOULOUSE', 'GRENOBLE', 17, 19),
('IT105', 107, 7, 'LYON', 'PARIS', 6, 7),
('IT106', 109, 8, 'BASTIA', 'PARIS', 10, 13),
('IT107', 106, 9, 'PARIS', 'BRIVE', 7, 8),
('IT108', 106, 9, 'BRIVE', 'PARIS', 19, 20),
('IT109', 107, 7, 'PARIS', 'LYON', 18, 19),
('IT110', 102, 2, 'TOULOUSE', 'PARIS', 15, 16),
('IT111', 101, 4, 'NICE', 'NANTES', 17, 19),
('IT112', 103, 5, 'PARIS', 'NICE', 11, 13),
('IT113', 104, 6, 'NICE', 'PARIS', 13, 15);