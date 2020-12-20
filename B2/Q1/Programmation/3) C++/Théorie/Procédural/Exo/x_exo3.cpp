#include <iostream>
using namespace std;

int main(int argc, char const *argv[])
{
  int n = 10, p = 5, q = 10, r;

  r = n == (p = q);
  //p = 10
  //q = 10
  //n = 10
  //r = 1

  cout << "A ; n = " << n << " p = " << p << " q = " << q << " r = " << r << "\n";

  n = p = q = 5;
  //q = 5
  //p = 5
  //n = 5

  n += p += q;
  //q = 5
  //p = 10
  //n = 15

  cout << "B : n = " << n << " p = " << p << " q = " << q << "\n";

  q = n < p ? n++ : p++;
  //ce qui est renvoyé et la valeur avant l'incrémentation car c'est une post incrémentation
  //p = 11
  //q = 10 (p valait 10 avant d'être incrémenté)

  cout << "C : n = " << n << " p = " << p << " q = " << q << "\n";

  q = n > p ? n : p++;
  //n = 16
  //p = 11
  //q = 15

  cout << "D : n = " << n << " p = " << p << " q = " << q << "\n";
  return 0;
}