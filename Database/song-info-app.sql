CREATE TABLE admins (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `surname` VARCHAR(45) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE);

CREATE TABLE `Z6AJNSMv02`.`performers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `surname` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`));

CREATE TABLE `Z6AJNSMv02`.`songs` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `performer_id` INT NOT NULL,
  `title` VARCHAR(60) NOT NULL,
  `created_at` DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
  `picture_url` VARCHAR(255) NOT NULL,
  `genre` VARCHAR(45) NOT NULL,
  `admin_id` INT NOT NULL,
  `jim_rating` DECIMAL(4,2) NOT NULL,
  `youtube_url` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`, `performer_id`),
  UNIQUE INDEX `title_UNIQUE` (`title` ASC) VISIBLE,
  INDEX `fk_admin_id_idx` (`admin_id` ASC) VISIBLE,
  INDEX `fk_performer_id_idx` (`performer_id` ASC) VISIBLE,
  CONSTRAINT `fk_admin_id`
    FOREIGN KEY (`admin_id`)
    REFERENCES `Z6AJNSMv02`.`admins` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_performer_id`
    FOREIGN KEY (`performer_id`)
    REFERENCES `Z6AJNSMv02`.`performers` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


desc songs;
/*--------------------------------------------------INSERT INTO---------------------------------------------------------------------*/

INSERT INTO admins (name, surname, username, password) VALUES ('Ivan', 'Krstic', 'ik123',md5('Ikrstic1234'));
INSERT INTO performers (name, surname) VALUES ('Aleksandra', 'Mladenovic'), ('Miloje','Pantic'), ('Zivadin','Zivkovic'), ('Katarina','Grujic');
INSERT INTO songs (performer_id, title, picture_url, genre, admin_id, jim_rating, youtube_url) VALUES (2, 'Pandica','Slike.com', 'Ma hiphop', 9, 8.45, 'www.youtube.com');
INSERT INTO performers (name, surname) VALUES ('Mile', 'Kitic');

/*-------------------------------------------------- SELECT -----------------------------------------------------------------*/
select * from admins;

SELECT * FROM admins WHERE username = 'milekiti' AND password = md5('Amileuy5');
SELECT * FROM performers WHERE name = 'Mile' AND surname = 'Kitic';
SELECT * FROM performers;

SELECT
	songs.id,
	CONCAT(performers.name, ' ', performers.surname) 'Izvodjac',
	created_at AS 'Datum unosa', 
	genre as 'Zanr', 
    jim_rating AS 'Rating',
	CONCAT(admins.name,' ', admins.surname) 'Ime admina'
FROM songs
JOIN admins
	ON songs.admin_id = admins.id
JOIN performers
	ON performers.id = songs.performer_id;

-- Get All Songs
SELECT
	songs.id AS 'song id',
	performers.id AS 'performer id',
    performers.name AS,
    performers.surname,
    songs.title,
	created_at, 
    songs.picture_url,
    genre,
	admins.id,
    admins.name,
    admins.surname,
    jim_rating,
    youtube_url
FROM songs
JOIN admins
	ON songs.admin_id = admins.id
JOIN performers
	ON performers.id = songs.performer_id;

/*-------------------------------------------------- DELETE -----------------------------------------------------------------*/
DELETE from performers where id < 10;
SET SQL_SAFE_UPDATES = 0;
DELETE from songs where genre = 'Balada';
/*-------------------------------------------------- UPDATE -----------------------------------------------------------------*/
SET SQL_SAFE_UPDATES = 0;
UPDATE admins SET name = 'Marko' WHERE name = 'Ivan';
UPDATE performers SET name = 'Stojan', surname = 'Stojkovic' WHERE id = 9;
UPDATE songs SET title = 'Belo koza kao Panda', genre = 'Hiphop', jim_rating = 9.41, youtube_url = 'youtube.com' WHERE songs.id = 2;

UPDATE songs SET title = 'Jedi pite', genre = 'kurcoguz', jim_rating = 5.41, youtube_url = 'www.youtube.com' WHERE songs.id = 9;
/*-------------------------------------------------- UPDATE -----------------------------------------------------------------*/
TRUNCATE table songs;
TRUNCATE table performers;
TRUNCATE table admins;