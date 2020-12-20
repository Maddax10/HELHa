#include <iostream>

using namespace std;

/*
Ecrire un programme qui affiche le nombre d'arguments, les arguments et les variables d'environnements.

tester l'execution (pas la compilation !) avec des argumments bidons pour voir si ça fonctionne
    .\5_main.exe -test1 -param2
*/

int main(int argc, char *argv[], char *envp[])
{

    cout << "Nombre d'arguments [" << argc << "]" << endl;

    for (int i = 0; i < argc; i++)
    {
        cout << "Argument[" << i << "] : " << argv[i] << endl;
    }

    cout << "Variables d'environnement : " << endl;

    for (int i = 0; envp[i]; i++)
    {
        cout << envp[i] << endl;
    }

    return 0;
}
