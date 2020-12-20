#include <iostream>

using namespace std;

//argc = nombre d'argument
// *argv[] = un tableau de pointeur qui va pointer vers des pointeurs de char (des pointeurs qui pointent vers des tableaux de char)
int main(int argc, char *argv[])
{
    int t[4] = {10, 20, 30, 40};
    int *ad[4];
    int i;

    //On va ajouter l'adresse mémoire des cases au pointeur
    for (int i = 0; i < 4; i++)
        ad[i] = t + i;

    for (int i = 0; i < 4; i++)
        cout << *ad[i] << "";

    cout << "\n";

    cout << *(ad[1] + 1) << *ad[1] + 1 << "\n";

    //__gestion de la mémoire__

    //Vu qu'on a un tableau, on doit boucler pour assigner le nullptr car ad est un tableau (donc un pointeur) et chaque case pointe vers un nom de tableau (donc un autre pointeur).
    //Donc les cases de ad sont des pointeurs
    for (int i = 0; i < 4; i++)
    {
        delete ad[i];
        ad[i] = nullptr;
    }

    //delete[] ad; // Complètement inutile

    return 0;
}