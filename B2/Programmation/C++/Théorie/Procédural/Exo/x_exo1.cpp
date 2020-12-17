#include <iostream>
#include <typeinfo>

using namespace std;

int main()
{
  char c = '\x01';
  short int p = 10;
  cout << "p + 3 : " << p + 3 << " (" << typeid(p + 3).name() << ")" << endl;                         //Entier
  cout << "c + 1 : " << c + 1 << " (" << typeid(c + 1).name() << ")" << endl;                         //Entier
  cout << "p + c : " << p + c << " (" << typeid(p + c).name() << ")" << endl;                         //Entier
  cout << "3 * p + 5 * c : " << 3 * p + 5 * c << " (" << typeid(3 * p + 5 * c).name() << ")" << endl; //Entier
}