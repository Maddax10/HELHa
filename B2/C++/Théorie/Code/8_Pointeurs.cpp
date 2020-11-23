#include <iostream>

using namespace std;

void afficheDonnees(const char *message, int a, int b, int c, int *p1, int *p2, int *p3)
{
    cout << "> " << message << ": " << endl;
    cout << "a: " << a << ", b: " << b << ", c: " << c << "," << endl;
    cout << "p1: " << p1 << ", p2: " << p2 << ", p3: " << p3 << endl;
}

int main(int argc, char *argv[])
{
    int a = 5; //On créé une adresse en mémoire automatiquement, on a pas besoin d'initialiser la variable (new int)

    cout << "Valeur de a : " << a << endl;

    cout << "Emplacement mémoire de &a : " << &a << endl; //Pour afficher l'adresse d'une variable, il faut ajouter un & devant lui

    int *pa = nullptr; //pa est une variable particulière qui va contenir une adresse vers un entier, double, ...

    cout << "Valeur de pa : " << pa << endl;

    cout << "Emplacement mémoire de $pa : " << &pa << endl;

    int *pb = &a; //On donne l'adresse de a au pointeur pb grace à "&"
    // * permet de déférencer. C'est suivre l'adresse

    cout << "Valeur de pb : " << pb << endl;

    cout << "Emplacement mémoire de $pb : " << &pb << endl;

    cout << "Valeur de la variable où pointe *pb : " << *pb << endl; //*pb = 5 car pb contient l'adresse mémoire de a

    return 0;
}