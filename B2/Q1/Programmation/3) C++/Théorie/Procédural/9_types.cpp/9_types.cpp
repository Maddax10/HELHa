#include <iostream>

using namespace std;

void Afficher(const char *message, long long nb)
{

    cout << message << ": " << nb << endl;
}

int main(int argc, char *argv[])
{
    //char, int, short int, long int, long long int, float, double
    cout << "Taille d'un char : " << sizeof(char) << endl;
    cout << "Taille d'un int : " << sizeof(int) << endl;
    cout << "Taille d'un short int : " << sizeof(short int) << endl;
    cout << "Taille d'un long int : " << sizeof(long int) << endl;
    cout << "Taille d'un long long int : " << sizeof(long long int) << endl;
    cout << "Taille d'un long : " << sizeof(long) << endl;
    cout << "Taille d'un float : " << sizeof(float) << endl;
    cout << "Taille d'un double : " << sizeof(double) << endl;
    cout << endl;

    int i = 2147486647;
    Afficher("i", i);

    int xi = 0xF00ABC;
    Afficher("xi", xi);

    xi = 0xFF;
    Afficher("xi", xi);

    int oi = 0112; // Attention, en base octale ici, en base 7 pas en base 10 car on commence par 0
    Afficher("oi", oi);

    int bi = 0b011001; //0b c'est du binaire
    Afficher("bi", bi);

    int li = 2147483647;
    Afficher("li", li);
    Afficher("li+1", li + 1); //Overflow, on a dépassé la capacité de la variable

    //____Overflow____
    //    11111111 11111111 11111111 11111111 (32 bits)
    //   +1
    //(1) 00000000 00000000 00000000 00000000
    // Le (1) est perdu car la capacité totale du type int est de 32 bits et pas 33. Donc on arrive avec 32 "0", ce qui représente la valeur minimale d'une variable int.
    // Même démarche avec +2, +5, +105342, ...

    long bad_li = 2147483647uLL + 7; //uLL = Nombre unsigned et de type Long Long
    cout << "bad_li : " << bad_li << endl;

    // Afficher("bad_li", bad_li);

    bad_li = 2147483647;
    Afficher("bad_li (avec cast)", bad_li);
}