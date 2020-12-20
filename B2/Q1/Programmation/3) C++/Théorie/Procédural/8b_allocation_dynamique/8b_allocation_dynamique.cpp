#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    //Déclaration statique, c'est quand ont déclare un nouveau type (ex: int nbr;)
    //Déclaration dynamique, c'est quand on affecte une adresse mémoire avec le mot clé "new" à un pointeur (ex: int *nbr = new int)

    int *adi = new int; //Création dynamique d'un objet de type entier (sur le heap (tas)), ça va renvoyer au hasard un emplacement mémoire qui aura été initialisé en fonction du type (ici int)

    *adi = 5; // Assignation d'une valeur dans l'entier
    cout << "*adi = " << *adi << endl;
    int* ptAdi = adi;
    *ptAdi = *ptAdi + 1;

    cout << "t*adi = " << *adi << endl;

    delete adi;    // Suppresion de la zone pointée par le pointeur (on ne supprime pas le pointeur *adi ni son contenu mais on supprimé les informations stocké dans l'emplacement mémoire qui est ciblé !!)
    adi = nullptr; //Vu que adi contient encore une valeur (5) et qu'on veut être sûre qu'elle ne soit pas utilisée (car on en a plus besoin), on lui affecte nullptr et on est sûr

    //======Fuite mémoire======

    adi = new int;                     // Création d'un objet dynamique de type entier, "Tiens adi, je t'envoi une nouvelle adresse mémoire"
    cout << "*adi = " << *adi << endl; // On affiche l'adresse mémoire vers qui adi pointe
    adi = new int;                     // On a perdu l'adresse mémoire stockée précédemment => fuite de mémoire car l'emplacement dans la mémoire à été créé (Ligne 19)
                                       // mais il n'a pas été supprimé (le delete + affectation nullptr), de ce fait l'emplacement existe toujours mais n'est pointé par aucun pointeur

    cout << "*adi = " << *adi << endl;
    delete adi;
    adi = nullptr;
    cout << "*adi = " << *adi << endl; //Il n'existe plus, adi ne pointe plus vers un emplacement mémoire

    return 0;
}