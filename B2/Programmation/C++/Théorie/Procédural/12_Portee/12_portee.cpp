#include <iostream>

using namespace std;

int x = 10;

int main(int argc, char *argv[])
{
    cout << x << endl;

    char x = 'b';

    //A partir du moment où une variale locale à le même nom qu'une variable globale ce sera elle qui sera utilisé
    //Variable locale la plus "haute" dans le stack
    cout << x << endl;

    //Variable globale
    cout << ::x << endl;
    //Sous bloc
    {
        cout << "Sous-bloc" << endl;

        cout << x << endl;

        //Imaginons un système "d'écrasement" des variables locales. En fonction du scope où l'on est ce sera telle ou telle variable x qui va être utilisé,
        //voici une représentation de quand on créé un sous-bloc
        //X global = int x
        //X local = char x
        //On déclare la variable
        double x = 2.15;
        //X global = int x (inchangé)
        //X local = double x
        //La variable X local qui était la variable X (char) à été remplacée par la variable X (double)

        //
        cout << x << endl;
        cout << ::x << endl;
    }
    //X local récupère la valeur qui à été écrasée et redeviens :
    //X global = int x (inchangé)
    //X local = char x
    cout << x << endl;

    return 0;
}