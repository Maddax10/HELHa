#1) Lister le contenu de la table Produit
select * from produit

#2) N'afficher que les 10 premiers produits
Select * from produit
	Limit 10

#3) Trier tous les produits par leur prix unitaire (attribut PrixUnit)
select * from produit
	ORDER BY PrixUnit ASC

#4) Lister les trois produits les plus chers
select * from produit
	ORDER BY PrixUnit DESC
	Limit 3

#5)Lister les clients fran�ais install�s � Paris
select * from Client
	Where Ville = 'Paris'

#6) Lister les clients suisses, allemands et belges
Select * from Client
	where Pays IN("Suisse", "Allemagne", "Belgique")

#7) Lister les clients dont le num�ro de fax n'est pas renseign�
Select * from Client
	where Fax is null

#8) Lister les clients dont le nom contient "restaurant" (nom pr�sent dans la colonne Societe)
select * from client
	where Societe like '%restaurant%'

#10) Lister uniquement la description des cat�gories de produits (table Categorie)
select Description from Categorie

#11) Lister les diff�rents pays des clients
select distinct Pays from Client

#12) Idem en ajoutant les villes, le tout tri� par ordre alphab�tique du pays et de la ville
select distinct Pays, Ville
	from Client
	order by 1, 2 ASC

#13) Lister tous les produits vendus en bouteilles ou en canettes
select * from produit
	where QteParUnit like "%bouteille%" or
	QteParUnit like "%canette%"

#14) Lister les fournisseurs fran�ais, en affichant uniquement le nom, le contact et la ville, tri�s par ville
select Societe, Contact, Ville from Fournisseur
   	where Pays = "France"
	order by Ville ASC

#15) Lister les produits (nom en majuscule et r�f�rence) du fournisseur n� 8 dont le prix unitaire est entre 10 et 100 euros, en renommant les attributs pour que ce soit explicite
select UPPER(NomProd) as "Produit du fournisseur 8", UPPER(RefProd)  as "R�f�rence"
	from Produit as P
	where P.NoFour == 8 and 
	P.PrixUnit between 10 and 100

#16) Lister les num�ros d'employ�s ayant r�alis� une commande (cf table Commande) � livrer en France, � Lille, Lyon ou Nantes
Select distinct NoEmp from Commande
	where PaysLiv = "France" and 
	VilleLiv in("Lille","Lyon","Nantes")
	order by 1;

#17) Lister les produits dont le nom contient le terme "tofu" ou le terme "choco", dont le prix est inf�rieur � 100 euros (attention � la condition � �crire)

select * from produit
	where (Nomprod like "%tofu%" or
	Nomprod like "%choco%") and 
	PrixUnit < 100

#18) La table DetailCommande contient l'ensemble des lignes d'achat de chaque commande. Calculer, pour la commande num�ro 10251, pour chaque produit achet� dans celle-ci, le montant de la ligne d'achat en incluant la remise (stock�e en proportion dans la table). Afficher donc :

- le prix unitaire, 
- la remise, 
- la quantit�, 
- le montant de la remise, 
- le montant � payer pour ce produit

select PrixUnit, Remise, Qte,  
round(PrixUnit * Remise,2) as "Montant Remise", 
Round(PrixUnit * Qte * (1-Remise), 2) as "Prix produit TTC"
	from DetailCommande
	where Nocom = 10251


#19) Dans une m�me requ�te, sur la table Client :

Concat�ner les champs Adresse, Ville, CodePostal et Pays dans un nouveau champ nomm� Adresse compl�te, pour avoir :
Adresse, CodePostal Ville, Pays
Extraire les deux derniers caract�res des codes clients
Mettre en minuscule le nom des soci�t�s
Remplacer le terme "marketing" par "mercatique" dans la fonction des contacts
Indiquer la pr�sence du terme "Chef" dans la fonction du contact

select  
(Adresse || "," || CodePostal || " " || Ville|| "," || Pays) as "Adresse compl�te",
(substr(CodeCli, LENGTH(CodeCli)-1, 2)) as "2 derniers caract CodeCli",
(LOWER(Societe)) as "Soci�t�",
(REPLACE(Contact, "marketing","mercatique")) as "Remplacement"
	from Client
    where instr(fonction, "Chef") > 0

#20) Afficher le jour de la semaine en lettre pour toutes les dates de commande
select 
    case STRFTIME("%w", DateCom)    
        when "0" then "Dimanche"
        when "1" then "Lundi"        
        when "2" then "Mardi"
        when "3" then "Mercredi"        
        when "4" then "Jeudi"
        when "5" then "Vendredi"        
        when "6" then "Samedi"
    end as "Jour de la semaine"

from Commande

#21) Compl�ter en affichant "week-end" pour les samedi et dimanche, et "semaine" pour les autres jour
SELECT DateCom, 
        CASE STRFTIME("%w", DateCom) 
            WHEN "0" THEN "Dimanche"
            WHEN "1" THEN "Lundi"
            WHEN "2" THEN "Mardi"
            WHEN "3" THEN "Mercredi"
            WHEN "4" THEN "Jeudi"
            WHEN "5" THEN "Vendredi"
            WHEN "6" THEN "Samedi"
        END as "Jour de la semaine",
        CASE 
            WHEN STRFTIME("%w", DateCom) IN ("0", "6") THEN "Week-end"
            ELSE "Semaine"
        END as "Week-end"
    FROM Commande;

#22) Calculer le nombre de jours entre la date de la commande (DateCom) et la date butoir de livraison (ALivAvant), pour chaque commande
Select JULIANDAY(ALivAvant) - JULIANDAY(DateCom) as "Nb Jours avant date butoir" from Commande

#23) On souhaite aussi contacter les clients 1 an, 1 mois et 1 semaine apr�s leur commande. Calculer les dates correspondantes pour chaque commande
select Date(Datecom, "+1 year","+1 month", "+7 day") from commande

#24) A partir de la table Produit, afficher "Produit non disponible" lorsque l'attribut Indisponible vaut 1, et "Produit disponible" sinon.
select 
	case Indisponible
		when "1" then "Produit non disponible"
		else "Produit disponible"
	End as Disponibilit�
from Produit

#25) Dans la table DetailCommande, indiquer les infos suivantes en fonction de la remise
	si elle vaut 0 : "aucune remise"
	si elle vaut entre 1 et 5% (inclus) : "petite remise"
	si elle vaut entre 6 et 15% (inclus) : "remise mod�r�e"
	sinon :"remise importante"
select 
case 
    when Remise == "0" then "Aucune remise"
    when Remise <= 0.05 then "Petite remise"
    when Remise <= 0.15 then "Remise mod�r�e"
    else "Remise importante"
end as "D�tail remise"

from DetailCommande

#26) Indiquer pour les commandes envoy�es si elles ont �t� envoy�es en retard (date d'envoi DateEnv sup�rieure (ou �gale) � la date butoir ALivAvant) ou � temps
ALiveAvant > DateEnv

select case
    when DateEnv is not null then 
        case
            when DateEnv >= ALivAvant then "En retard"
            else "A temps"
        end
    else "A envoyer"
    
    end as "Envoi"

from Commande

#27) R�cup�rer l'ann�e de naissance et l'ann�e d'embauche des employ�s
select Nom, Prenom,
SUBSTR(DateEmbauche,6,4) - SUBSTR(DateNaissance,6,4) as "�ge d'embauche",  
STRFTIME("%Y","now") - SUBSTR(DateEmbauche,6,4) as "Nombre d'ann�e dans l'entreprise"
from Employe

#28) Calculer � l'aide de la requ�te pr�c�dente l'�ge d'embauche et le nombre d'ann�es dans l'entreprise
select Nom, Prenom,
SUBSTR(DateEmbauche,6,4) - SUBSTR(DateNaissance,6,4) as "�ge d'embauche",  
STRFTIME("%Y","now") - SUBSTR(DateEmbauche,6,4) as "Nombre d'ann�e dans l'entreprise"
from Employe

#29) Afficher le prix unitaire original, la remise en pourcentage, le montant de la remise et le prix unitaire avec remise (tous deux arrondis aux centimes), pour les lignes de commande dont la remise est strictement sup�rieure � 10%

select PrixUnit,
Remise * 100 as "Pourcentage de remise",
Round(PrixUnit * Remise) as "Montant de la remise", 
round(PrixUnit * (1-Remise),2) as "Prix avec remise"
from detailCommande
Where Remise > 0.1


#30) Calculer le d�lai d'envoi (en jours) pour les commandes dont l'envoi est apr�s la date butoir, ainsi que le nombre de jours de retard
select *,
    JulianDay(DateEnv) - JulianDay(DateCom) as "D�lai de livraison",
    JulianDay(DateEnv) - JulianDay(ALivAvant) as "NbJours de retard"

from commande
where DateEnv > ALivAvant

#31) Rechercher les soci�t�s clientes, dont le nom de la soci�t� contient le nom du contact de celle-ci

select *,"%"+contact+"%"
from client
    where Societe like "%" || contact || "%"
	
	
#32) Calculer le nombre d'employ�s qui sont "Repr�sentant(e)"
select count(Fonction) 
from Employe
where Fonction == "Repr�sentant(e)"

#33) Calculer le nombre de produits de moins de 50 euros
select count(PrixUnit)
    from Produit
    where PrixUnit < 50

#34) Calculer le nombre de produits de cat�gorie 2 et avec plus de 10 unit�s en stocks
select count(*)
    from Produit
    where UnitesStock > 10 and
    CodeCateg == "2"

#35) Calculer le nombre de produits de cat�gorie 1, des fournisseurs 1 et 18
select count(*)
from Produit
    where CodeCateg == 1 and
    (NoFour == 1 or
    noFour == 18)

#36) Calculer le nombre de pays diff�rents de livraison
select count(distinct PaysLiv)
from Commande

#37) Calculer le nombre de commandes r�alis�es le 28/03/2016.
select count(*)
from Commande
    where STRFTIME("%Y","2016-03-28") = STRFTIME("%Y", DateCom)
    and STRFTIME("%m","2016-03-28") = STRFTIME("%m", DateCom)
    and STRFTIME("%d","2016-03-28") = STRFTIME("%d", DateCom)


#Calculer le co�t moyen du port pour les commandes du client dont le code est "QUICK" (attribut CodeCli)
select AVG(Port)
from commande
    where CodeCli = "QUICK"

#Calculer le co�t du port minimum et maximum des commandes
select Min(Port), Max(Port)
from commande;

#Pour chaque messager (par leur num�ro : 1, 2 et 3), donner le montant total des frais de port leur correspondant
#il faut faire 3 requ�tes diff�rentes donc
select NoMess, SUM(Port) as "Montant total des frais de port"
from commande
    where NoMess = "1"
	
select NoMess, SUM(Port) as "Montant total des frais de port"
from commande
    where NoMess = "2"
	
select NoMess, SUM(Port) as "Montant total des frais de port"
from commande
    where NoMess = "3"
	
#Donner le nombre d'employ�s par fonction
--Je trie d'abord toutes les entr�es avec le groupe by fonction et ensuite pour chaque fonction je reprends sa Fonction et la somme du nombre de ligne dans cette Fonction (C'est le select Fonction, count(*))
select Fonction, count(*)
from Employe

group by Fonction

#Donner le montant moyen du port par messager
select NoMess, round(AVG(Port),2)
from Commande

group by NoMess

#Donner le nombre de cat�gories de produits fournis par chaque fournisseur
select NoFour as "Num�ro Fournisseur", count(CodeCateg) as "Cat�gories de prduits"
from produit

group by NoFour

#Donner le prix moyen des produits pour chaque fournisseur et chaque cat�gorie de produits fournis par celui-ci
select NoFour, CodeCateg, round(AVG(PrixUnit),2)
from produit

group by NoFour, CodeCateg

#Lister les fournisseurs ne fournissant qu'un seul produit
select NoFour, count(*)
from fournisseur

group by NoFour
having count(*) =1

#Lister les cat�gories dont les prix sont en moyenne sup�rieurs strictement � 150 euros
select CodeCateg
from Produit

group by CodeCateg
having AVG(PrixUnit) > 150

#Lister les fournisseurs ne fournissant qu'une seule cat�gorie de produits
Select NoFour
from Produit

group by NoFour
having count(distinct CodeCateg) = 1

#Lister les fonctions pour lesquelles la moyenne d'�ge des employ�s d�passe les 45 ans
select Fonction, AVG(STRFTIME("%Y", "now") - substr(DateNaissance,6,4)) as "Age"
from employe

group by Fonction
having AVG(STRFTIME("%Y", "now") - substr(DateNaissance,6,4)) > 45

#Donner la quantit� totale command�e par les clients, pour chaque produit
SELECT RefProd, SUM(qte) as "Qte totale"
	FROM DetailCommande
	
group by RefProd

#Donner les cinq clients avec le plus de commandes, tri�s par ordre d�croissant
Select CodeCli, count(NoCom) as "Nombre de commandes"
from commande

group by CodeCli
order by 2

limit 5

#Calculer le montant total des lignes d'achats de chaque commande, sans et avec remise sur les produits
select Nocom,
    sum(PrixUnit) as "Montant total sans remise", 
    round(sum(PrixUnit*(1-Remise)),2) as "Avec remise"
from DetailCommande

group by Nocom

#Pour chaque cat�gorie avec au moins 10 produits, calculer le montant moyen des prix
select CodeCateg, count(RefProd) as "Quantit� produit", round(AVG(PrixUnit),2) as "Montant moyen des prix"
from Produit

group by CodeCateg
having count(RefProd) > 10

#Donner le num�ro de l'employ� ayant fait le moins de commandes
select NoEmp
from commande

group by NoEmp
Order by 2 ASC
limit 1
