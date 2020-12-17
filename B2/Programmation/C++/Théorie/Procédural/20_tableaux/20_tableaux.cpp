#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    //Tableau float "tf" de 10 éléments et pas initialisé
    float tf[10];
    for (int i = 0; i <= 10; i++)
    {
        cout << "tf[" << i << "] = " << tf[i] << endl;
    }

    cout << endl;

    tf[0] = 1.55;

    for (int i = 0; i <= 10; i++)
    {
        cout << "tf[" << i << "] = " << tf[i] << endl;
    }
    //Créer un tableau à 2 dimensions de caractères de taille 3 pour chaque dimensions avec les caractères "Helha"

    const int NB_TC = 3;
    char tc[NB_TC][NB_TC] = {{'H', 'e', 'l'}, {'h', 'a'}};

    cout << endl;

    for (int i = 0; i < NB_TC; i++)
    {
        for (int j = 0; j < NB_TC; j++)
        {
            cout << tc[i][j];
        }
        cout << endl;
    }

    //Il est possible de sortir des dimensions du tableau et d'aller lire de la ram (c'est aléatoire dans ce cas)
    //ici un tableau[3][3]

    cout << tc[0][20] << endl;

    //SegmentFault, c'est quand on va trop loin quand on parcours un tableau
    cout << tc[0][2000000000000000] << endl;

    return 0;
}