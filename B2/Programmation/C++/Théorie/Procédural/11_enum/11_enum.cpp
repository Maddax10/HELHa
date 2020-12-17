#include <iostream>

using namespace std;

/*
Faire une énum "Color" avec 3 attributs (red, green, blue) et red est le premier élément et il vaut 5
*/
enum Color
{
    red = 5,
    green,
    blue
};
int main(int argc, char *argv[])
{
    Color r = blue;

    switch (r)
    {
    case red:
        cout << "Red = " << red << endl;
        break;

    case green:
        cout << "Green = " << green << endl;
        break;

    case blue:
        cout << "Blue = " << blue << endl;
        break;
    }
    return 0;
}