#include <iostream>
#include <Math.h>

using namespace std;

int main(int argc, char *argv[])
{
    int nb;

    do
    {

        cout << "Veuillez entrer un nombre positif : ";
        cin >> nb;

        if (cin.fail() || nb < 0)
        {

            cout.clear();
            cout << "Un nombre positif stp" << endl;

            cin.clear();

            cout << "Veuillez entrer un nombre positif : ";
            cin >> nb;
        }
        else if (nb > 0)
        {
            cout << "La raciné carré de " << nb << " est " << sqrt(nb) << endl;
        }

        cout.clear();

    } while (nb != 0);
    return 0;
}