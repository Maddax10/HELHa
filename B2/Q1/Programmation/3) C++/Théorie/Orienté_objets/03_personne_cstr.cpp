#include <iostream>

using namespace std;

class Personne
{

    string nom, prenom;

public:
    // Personne()
    // {
    //     nom = "Max";
    //     prenom = "Michon";

    //     cout << "Constructeur par Défaut" << endl;
    // }

    // Personne(string nom, string prenom)
    // {
    //     this->nom = nom;
    //     this->prenom = prenom;

    //     cout << "Constructeur personnalisé" << endl;
    // }

    Personne(string nom = "Max", string prenom = "Michon")
    {
        this->nom = nom;
        this->prenom = prenom;

        cout << "Constructeur par défault ou personnalisé" << endl;
    }

    Personne(const Personne &p)
    {
        this->nom = p.nom;
        this->prenom = p.prenom;

        cout << "Constructeur par recopie" << endl;
    }

    string getNom()
    {
        return nom;
    }

    //Destructeur
    //On doit détruire explicitement
    ~Personne()
    {
        cout << "Destruction de l'objet personne de " << nom << " " << prenom << endl;
    }
};

void afficher(Personne p)
{
    cout << p.getNom() << endl;
}

int main(int argc, char *argv[])
{
    Personne p1;                          // Constructeur par défaut
    Personne p2("Robert", "DeauDeville"); //Constructeur personnalisé
    Personne p3 = p2;
    //Personne p3(p2); //C'est le même

    Personne *pp1 = new Personne();
    Personne *pp2 = new Personne("p2Nom", "P2Prenom");
    Personne *pp3 = new Personne(p1);

    Personne *pp4 = &p1; //*pp4 pointe vers l'objet p1. Ils pointent tous les 2 vers le même emplacement mémoire

    afficher(p1);

    delete pp1;
    delete pp2;
    delete pp3;
    delete pp4;

    //Suppression automatique de p1,p2,p3 car ils ont été créés implicitement

    return 0;
}