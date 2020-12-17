create table Réponse(
    Réponse_id integer PRIMARY KEY AUTOINCREMENT,
    Date datetime,
    Reponse String,
    Entrée_id integer,
    Personne_id integer
);

create table Entrée(
    Entrée_id integer PRIMARY KEY AUTOINCREMENT,
    Date datetime,
    Heure integer,
    Sondage_id integer
);

create table Sondage(
    Sondage_id integer PRIMARY KEY AUTOINCREMENT,
    DateCreation datetime,
    Nom String,
    Description String,
    Createur_id integer
);

create table SondageParGroupe(
    SondageParGroupe_id integer PRIMARY KEY AUTOINCREMENT,
    Sondage_id integer,
    Groupe_id integer
);

create table Groupe(
    Groupe_id integer PRIMARY KEY AUTOINCREMENT,
    nom String
);

create table RoleDansGroupe(
    Role String,
    Groupe_id integer,
    Personne_id integer
);

drop table Personne
create table Personne(
    Personne_id integer PRIMARY KEY AUTOINCREMENT,
    Nom String,
    Prenom String
);