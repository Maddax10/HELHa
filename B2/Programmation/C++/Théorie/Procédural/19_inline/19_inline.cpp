#include <iostream>

using namespace std;

//Le mot de clé "inline" permet de gagner du temps lors de la compilation
//inline type nomFonc(attributs){code}

inline int aLotOfCode(const int a, const int b, const int c)
{
    return (a + b + c) * (a + b - c) * (a / b + c);
}

int main(int argc, char *argv[])
{
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);
    aLotOfCode(1, 1, 1);
    aLotOfCode(3, 3, 3);

    return 0;
}
