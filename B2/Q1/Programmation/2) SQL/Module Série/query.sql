-- SQlite

drop table Acteur;
drop table Realisateur;
drop table Serie;
drop table ActeurDeSerie;

Create table Acteur (
    Id integer PRIMARY KEY AUTOINCREMENT,
    Nom VARCHAR(50) DEFAULT NULL,
    Prenom VARCHAR(50)DEFAULT NULL
);

Create table Realisateur (
    Id integer PRIMARY KEY AUTOINCREMENT,
    Nom VARCHAR(50) DEFAULT NULL,
    Prenom VARCHAR(50)DEFAULT NULL
);

Create table Serie (
    Id integer PRIMARY KEY AUTOINCREMENT,
    Nom VARCHAR(50) DEFAULT NULL,
    Annee int DEFAULT NULL,
    RealisateurId int REFERENCES Realisateur
);

Create table ActeurDeSerie (
    ActeurId int REFERENCES Acteur,
    SerieId int REFERENCES Serie,
    estDansTousLesEpisodes BOOL DEFAULT False,
    PRIMARY KEY(ActeurId, SerieId)
);

INSERT INTO Acteur (Nom, Prenom) VALUES
('Mic','Max'),
('DeNil','Théo'),
('Gueret','Chloé'),
('Voisin','Jérémy');

SELECT * from Acteur;

INSERT INTO Realisateur(Nom, Prenom) VALUES('Robert', 'DeNiro');
INSERT INTO Realisateur VALUES(556, 'Riberta', 'Dinora');

SELECT * from Realisateur;

INSERT INTO Serie (Nom, Annee, RealisateurId) VALUES('TicTacNic', 1998 , 1);
INSERT INTO Serie (Nom, Annee, RealisateurId) VALUES('Les moulins', 2001 , 556);
INSERT INTO Serie (Nom, Annee, RealisateurId) VALUES('Blanche fesse et les 7 mains', 2005 , 556);

SELECT * from Serie

INSERT INTO ActeurDeSerie VALUES(4,2, TRUE);

select * from ActeurDeSerie;