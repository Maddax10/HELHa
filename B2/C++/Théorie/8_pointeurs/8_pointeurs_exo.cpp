#include <iostream>

using namespace std;

void afficheDonnees(const char *message, int a, int b, int c, int *p1, int *p2, int *p3)
{
    cout << "> " << message << ": " << endl;
    cout << "a: " << a << ", b: " << b << ", c: " << c << "," << endl;
    cout << "&a: " << &a << ", &b: " << &b << ", &c: " << &c << "," << endl;
    cout << "p1: " << p1 << ", p2: " << p2 << ", p3: " << p3 << endl;
}

int main(int argc, char const *argv[])
{
    int a = 1, b = 2, c = 3;
    int *p1 = nullptr, *p2 = nullptr, *p3 = nullptr;

    afficheDonnees("Init", a, b, c, p1, p2, p3);
    return 0;
}