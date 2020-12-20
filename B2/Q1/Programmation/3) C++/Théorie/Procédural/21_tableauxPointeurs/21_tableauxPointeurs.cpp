#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    //Un nom de tableau n'est qu'un pointeur

    int ti[10];

    for (int i = 0; i < 10; i++)
    {
        ti[i] = i + 5;
    }
    for (int i = 0; i < 10; i++)
    {
        cout << ti[i] << endl;
    }

    cout << endl;
    cout << endl;
    cout << endl;

    int pti = &ti; // ti[nb] est interdit, vu que ce n'est pas un pointeur, il faut renseigner l'adresse de ti[nb] -> &ti[nb]

    pti[5] = 42; //Je change indirectement la case 5 du tableau ti car le pointeur pointe sur l'adresse mémoire de la case 5

    return 0;
}