#include <iostream>
#include <typeinfo>

using namespace std;

int main()
{
  char c = '\x05';
  int n = 5;
  long p = 1000;
  float x = 1.25;
  double z = 5.5;

  cout << "n + c + p : " << n + c + p << " (" << typeid(n + c + p).name() << ")" << endl;
  //Long
  cout << "2 * x + c : " << 2 * x + c << " (" << typeid(2 * x + c).name() << ")" << endl;
  //Float
  cout << "(char) n + c : " << ((char)n) + c << " (" << typeid((char)n + c).name() << ")" << endl;
  //char
  cout << "(float) z + n / 2 : " << (float)z + n / 2 << " (" << typeid((float)z + n / 2).name() << ")" << endl;
  //Float
}