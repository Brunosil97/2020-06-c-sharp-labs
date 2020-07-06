
--create database bruno_db
--go

--THIS IS CREATING A TABLE
--CREATE TABLE film_table
--(
 --   filmID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
  --  film_name VARCHAR(30),
  --  film_director VARCHAR(30),
   -- film_writer VARCHAR(30),
   -- date_of_release DATE,
   -- film_star VARCHAR(30),
   -- film_type VARCHAR(6),
   -- film_language VARCHAR(30),
   -- plot_summary VARCHAR(250)
--);

--this is how you insert data into database

--INSERT INTO film_table
--(
  --  film_name, 
   -- film_director, 
    --film_writer, 
    --date_of_release, 
    --film_star, 
    --film_type, 
    --film_language,
    --plot_summary
--)
--VALUES
--(
  --  'avengers',
   -- 'russo brothers',
   -- 'a writer',
   -- '2019-04-16',
    --'Chris Hemsworth',
    --'super',
    --'English',
    --'a superhero film with all the superheros'
--);

-- updates a specific value
-- UPDATE film_table
-- SET film_director='joe russo'
-- WHERE film_director='russo brothers';

-- can delete specific coloumns
--ALTER TABLE film_table
-- COLUMN plot_summary;

--Deletes all data in a table but not the table itself
--TRUNCATE TABLE film_table;

--creating 2 tables to join

-- CREATE TABLE video_games
-- (
--     gameID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
--     videoName VARCHAR(30),
--     rating INTEGER
-- )

-- CREATE TABLE games_developer
-- (
--     devName VARCHAR(30),
--     office VARCHAR(30)
-- )

-- ALTER TABLE games_developer
-- ADD devID INT IDENTITY (1,1) PRIMARY KEY NOT NULL 

-- ALTER TABLE video_games
-- ADD devID INT, 
-- FOREIGN KEY (devID) REFERENCES games_developer(devID)


-- INSERT INTO video_games
-- (
--     videoName,
--     rating
-- )
-- VALUES
-- (
--     'ZELDA',
--     9
-- );

-- INSERT INTO games_developer
-- (
--     devName,
--     office
-- )
-- VALUES
-- (
--     'nintendo',
--     'tokyo'
-- );



-- SELECT * FROM video_games;
-- SELECT * FROM games_developer;

--CREATE TABLE trainees
--(
--    traineeID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
--    trainerID INT,
--    FOREIGN KEY (trainerID) REFERENCES trainers(trainerID),
--    traineeName VARCHAR(15)
--);
--CREATE TABLE trainers
--(
--    trainerID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
--    academyID INT,
--    FOREIGN KEY (academyID) REFERENCES academy(academyID),
--    trainerName VARCHAR(15)
--);
--CREATE TABLE academy
--(
--    academyID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
--    academyName VARCHAR(15)
--);

--INSERT INTO trainees
--(
--    trainerID,
--    traineeName
--)
--VALUES
--(
--    1,
--    'Bruno'
--);
--INSERT INTO trainers
--(
--    academyID,
--    trainerName
--)
--VALUES
--(
--    1,
--    'Nish'
--);
--INSERT INTO trainers
--(
--    academyID,
--    trainerName
--)
--VALUES
--(
--    1,
--    'Phil'
--);
--INSERT INTO academy
--(
--    academyName
--)
--VALUES
--(
--    'Sparta Global'
--);

SELECT * FROM academy;
SELECT * FROM trainers;
SELECT * FROM trainees;

SELECT tr.traineeName, t.trainerName
FROM trainees tr
INNER JOIN trainers t ON tr.trainerID = t.trainerID;

