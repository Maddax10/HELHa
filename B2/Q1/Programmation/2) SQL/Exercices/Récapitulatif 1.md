=================================================================================
=================================================================================
=================================================================================
##___Page 2___
#__Simple__
1) Lister le contenu de la table Seances
2) Lister les sportifs par ordre croissant d'âge
3) Lister les 5 gymnases les plus grands

1)
select * from Seances

2)
select * from Sportifs
order by age ASC

3)
select * from Gymnases
order by Surface DESC
limit 5

#__Restriction__
1) Lister les sportifs (nom et prénom) agés strictement de plus de 30 ans
2) Lister les gymnases de la ville de "Stains"
3) Lister les sportifs n'ayant pas de conseiller

1) 
select Nom, Prenom from sportifs
where age > 30

2)
select * from gymnases
where Ville like "Stains"

3)
select * from sportifs
where IdSportifConseiller is null

=================================================================================
=================================================================================
=================================================================================

##___Page 3___
__Calculs arithmétiques__
1) Afficher en heure la durée de chaque séance (stockée en minute dans la table)
2) Convertir la surface (en m2 dans la table) en pieds carrés (voir la définition) des gymnases de "Pierrefitte"

1)
select *, (Duree/60) as "Durée en heure" from Seances

2)
Select *, ROUND((Surface * 10.7639),1) as "Surface en p²"  from Gymnases
where Ville like "PIERREFITTE"

__Fonctions sur chaînes de caractères__
1) Concaténer le nom des sportifs avec la première lettre du prénom suivie d'un point, le tout en minuscules (par exemple "jollois f.")
2) Afficher les gymnases situées sur une place (cf Adresse)

1)
select nom, prenom, Lower(Nom || "." || SUBSTR(prenom,1,1) ) as "Concaténation" from sportifs

2)
select * from Gymnases
where Adresse like "%Place%"

__Fonctions sur les dates__
1) Donner la date du jour
2) Donner le jour de la semaine du 1er janvier de l'année de naissance de chaque sportif

1)
select Date("now") as "aujourd'hui"

2)
select  2020-Age as "Année de naissance",
    case STRFTIME("%w", Date((2020-Age)||"-01-01")) 
        when "0" then "Dimanche"
        when "1" then "Lundi"
        when "2" then "Mardi"
        when "3" then "Mercredi"
        when "4" then "Jeudi"
        when "5" then "Vendredi"
        when "6" then "Samedi"
    end as "Jour du 1er janvier de l'année de naissance"
        
from sportifs

__Traitement conditionnel__
1) Afficher une nouvelle variable nommée Civilite, qui prendra "M." pour les hommes et "Mme" pour les femmes)
2) Afficher une nouvelle variable TypeGymnase, qui prendra comme valeur "petit" si la surface est inférieure strictement à 400 m2, "moyen" si elle est entre 400 et 550 m2, et "grand" si elle est strictement supérieure à 550 m2

1)
select *,
    case LOWER(Sexe)
        when "m" then "M."
        when "f" then "Mme"
        end as "civilité"
from sportifs

2)
select *,
    case 
        when Surface < 400 then "petit"
        when Surface < 550 then "Moyen"
        else "Grand"
        end as "TypeGymnase"
from gymnases

=================================================================================
=================================================================================
=================================================================================

##___Page 4___

__Dénombrements__
1) Compter le nombre de sportifs
2) Compter le nombre de sportifs ayant un conseiller
3) Compter le nombre de villes distinctes

1)
select count(*) from sportifs

2)
select count(*) from sportifs
where IdSportifConseiller is not null

3)
select count(distinct Ville) from Gymnases

__Calculs statistiques simples__
1) Calculer la surface moyenne des gymnases
2) Calculer l'âge moyen, l'âge minimum et l'âge maximum des sportifs

1)
select round(avg(Surface),2) as "Surface moyenne des gymnases" from gymnases

2)
select round(avg(Age)) as "Age moyen", MIN(Age) as "Age minimum", MAX(Age) as "Age Maximum" from Sportifs

__Agrégats selon attribut(s)__
1) Calculer le nombre de sportifs par sexe, ainsi que l'âge moyen
2) Calculer pour chaque ville la surface du plus petit et du plus grand gymnase

1)
select Sexe, count(Sexe), round(avg(Age)) as "Age moyen"
from sportifs
group by UPPER(Sexe)

2)
select Ville, MIN(Surface) as "Plus petit gymnase", Max(Surface) as "Plus grand gymnase"
from Gymnases
group by Ville

__Restriction sur agrégats__
1) Lister les villes ayant plus de 5 gymnases, dans l'ordre décroissant du nombre de gymnases

1)
select Ville as "Nombre de villes avec plus de 5 gymnases", count(Ville) as "Nombre de gymnases"
from Gymnases
    
group by Ville
having count(Ville) >= 5

order by count(Ville) DESC

=================================================================================
=================================================================================
=================================================================================

##___Page 5___

__Exercices complémentaires__
1) Lister les 5 sportifs masculins les plus âgés
2) Lister les villes dans lesquelles il y a des gymnases d'au moins 500 m2
3) Concaténer le nom des sportifs avec la première lettre du prénom suivie d'un point, en tenant compte des prénoms composés, suivi de l'année de naissance 
(par exemple "JOLLOIS F.-X. - 1977")
4) Lister les identifiants de sports ayant le plus de joueur
5) Donner le nombre de sportifs pour la répartition "junior" (de 20 à 24 ans), "senior 1" (de 25 à 30), "senior 2" (de 31 à 45)
6) Sachant des les heures de début de séances sont stockées en réel, avec 19.3 pour "19h30" par exemple, calculer l'heure de fin de chaque séance

1)
select Nom, Prenom, Age
from sportifs
where UPPER(Sexe) = "M"
order by Age desc
limit 5

2)
select distinct Ville
from gymnases
where Surface >=500

3)
select Nom, Prenom,
        UPPER(Nom) || " " || UPPER(substr(Prenom,1,1)) ||
            case
                when INSTR(Prenom, "-") then ".-" || substr(Prenom, (INSTR(Prenom, "-") +1), 1)
                when INSTR(Prenom, " ") then ".-" || substr(Prenom, (INSTR(Prenom, " ") +1), 1)
                else ""
            end || "-" || (STRFTIME("%Y", Date("now")) - Age) as "test"
from sportifs

