DROP USER 'titi'@'localhost';

CREATE USER 'titi'@'localhost' IDENTIFIED BY 'azer';

GRANT ALL PRIVILEGES ON mini_faq.* TO 'titi'@'localhost';

