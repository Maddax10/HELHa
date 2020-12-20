#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    const int TAILLE_TB = 10;

    int t[TAILLE_TB] = {1, 89, -3, 4, 5, 6, 7, 8, 9, 10};

    int *pt = t;

    //___Formalisme tableau___

    cout << "__Formalisme tableau__"
         << "\n";

    for (int i = 0; i < TAILLE_TB; i++)
    {
        cout << t[i] << " ";
    }

    int max = INT32_MIN, min = INT32_MAX;

    for (int i = 0; i < TAILLE_TB; i++)
    {
        if (t[i] > max)
            max = t[i];

        if (t[i] < min)
            min = t[i];
    }

    //_Recherche du max et du min_
    cout << "\n";

    cout << "Maximum : " << max << endl;
    cout << "Minimum : " << min << endl;

    cout << "\n";

    cout << "__Formalisme pointeur__"
         << "\n";

    //___Formalisme pointeur___
    for (pt; pt < t + TAILLE_TB; pt++) //pt contient l'adresse de la première case et à chaque itération on augmente d'une case (le +1)
    {
        cout << *pt << " ";
    }

    //_Recherche du max et du min_

    for (pt; pt < t + TAILLE_TB; pt++)
    {
        if (*pt > max)
            max = *pt;

        if (*pt < min)
            min = *pt;
    }
    cout << "\n";

    cout << "Maximum : " << max << endl;
    cout << "Minimum : " << min << endl;

    //Gestion de la mémoire

    delete pt;
    pt = nullptr;

    return 0;
}