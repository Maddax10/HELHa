#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    cout << 'a' + 'b' << endl;
    cout << (char)('a' + 5) << endl;
    cout << 5.1 + 5 << endl; //Transformation implicite de 5.1 en long -> float (c++ le fait tout seul, magique)
    return 0;
}