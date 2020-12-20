#include <iostream>

using namespace std;

class Personne
{
    string nom;

public:
    void setNom(string nom)
    {
        this->nom = nom;
        //=
        //(*this)nom = nom;
        //(*this) est la référence de la classe et le mot clé "this->" permet de dire la même chose
    }
    string getNom()
    {
        return this->nom;
    }
};

using namespace std;

int main(int argc, char *argv[])
{

    Personne p1;

    p1.setNom("Max");
    cout << p1.getNom() << endl;

    Personne *p2 = new Personne();
    p2->setNom("Maxou");
    (*p2).setNom("Rodolphe");

    cout << p2->getNom() << endl;

    delete p2; //On le delete car on l'a affecté dynamiquement (le new)

    return 0;
}