#include <iostream>

using namespace std;
//On peut déclarer des valeurs d'attributs par défaut dans une fonction via le prototype
void afficheMessage(const string msg = "avertissement", bool stop = true);

int main(int argc, char *argv[])
{
    afficheMessage();
    afficheMessage("Test", false);
    return 0;
}

void afficheMessage(const string msg, bool stop)
{
    cout << msg << " ";
    if (stop)
    {
        cout << "STOP" << endl;
    }
    else
    {
        cout << endl;
    }
}