#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{

    int t[3];
    //ou
    //int *t = new int[3] //On initialise le pointeur avec la création en mémoire de 3 cases de types int et ça renvoit l'adresse mémoire du premier élément

    int i, j = 0;
    int *adt;

    for (i = 0; i < 3; i++)
    {
        t[i] = j++ + 1;
    }

    for (int i = 0; i < 3; i++)
    {
        cout << t[i] << " ";
    }

    cout << endl;

    for (int i = 0; i < 3; i++)
    {
        cout << *(t + i) << " ";
    }

    cout << endl;

    for (adt = t; adt < t + 3; adt++)
    {
        cout << *adt << " ";
    }

    cout << endl;

    for (adt = t + 2; adt >= t; adt--)
    {
        cout << *adt << " ";
    }

    cout << endl;

    //Donc on peut changer les valeurs dans le tableau grâce à l'arithmétique des pointeurs
    //Exercice : Changer la case 3 du tableau via un pointeur

    int *pointeurT = t;

    //3e case
    *(pointeurT + 2) = 7;

    //La 1ère case

    *pointeurT = 5;

    cout << "Test pointeur :" << endl;

    for (pointeurT; pointeurT < t + 3; pointeurT++)
    {
        cout << *pointeurT << " ";
    }

    //Gestion de la mémoire

    delete[] adt;
    delete[] pointeurT;

    adt = nullptr;
    pointeurT = nullptr;

    return 0;
}