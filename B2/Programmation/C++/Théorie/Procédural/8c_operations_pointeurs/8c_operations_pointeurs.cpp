#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    /*
        Quand on fait un "++"" sur un pointeur (ex: adi++), ça ne fait pas +1, ça fait +4 car int est codé sous 4 octets. 
        
        __Pourquoi ?__ 
        Car quand on fait un "adi++" on lui dit d'aller à l'adresse mémoire suivante (on incrémente la valeur de l'adresse mémoire vers lequel *adi pointe). 
        Vu qu'un int est codé sous 4 bytes (4 octets), pour passer à la case mémoire suivant il suffit de faire +4.
        Si le type n'est pas "int" mais "char" alors "char++" fera +1 car il ne suffit que d'un +1 pour passer à la case suivante
        de la mémoire vu que le type char est codé sur 1 octet

        --------------------------------------------
        Ps : Petit tips pour bien se l'imaginer :

        La mémoire est composé de petits carré vides (□) de 1 octet et ça pourrait ressembler à ça :

        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□

        Imaginons qu'on ai un pointeur de type char et qu'on lui fasse un new char. Le pointeur va pointer vers la case mémoire N° 1 (normalement aléatoirement) :

        ■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□

        l'adresse mémoire vers lequel *adi pointe est 0x000000

        on fait +1 à l'adresse mémoire vers lequel le pointeur pointe "adi++" et du coup on se retrouve à la case suivante (n°2) :

        □■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□

        l'adresse mémoire vers lequel *adi pointe est 0x000001

        -----------------------------------------------

        La même chose mais avec un int

        Imaginons qu'on ai un pointeur de type "int" et qu'on lui fasse un new int. Le pointeur va pointer vers la case mémoire N° 1 (normalement aléatoirement) 
        et va s'étendre sur les 3 cases d'après (car int est codé sous 4 octets) :

        ■■■■□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        l'adresse mémoire vers lequel *adi pointe est 0x000000

        on fait +1 à l'adresse mémoire vers lequel le pointeur pointe "adi++" et du coup on se retrouve à la case suivante (n°2) :

        □□□□■■■■□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        l'adresse mémoire vers lequel *adi pointe est 0x000004

        __On refait adi++__
        □□□□□□□□■■■■□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□
        □□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□

        l'adresse mémoire vers lequel *adi pointe est 0x000008

    */
    int *adi = new int;

    cout << "*adi = " << *adi << " (" << adi << ")" << endl;
    adi = new int;
    cout << "*adi = " << *adi << " (" << adi << ")" << endl;
}