#include <iostream>
using namespace std;

int main(int argc, char const *argv[])
{
  int i, n;

  for (i = 0, n = 0; i < 5; i++)
    n++;
  cout << "A : i  = " << i << " n = " << n << "\n";

  for (i = 0, n = 0; i < 5; i++, n++)
    ;
  cout << "B : i  = " << i << " n = " << n << "\n";

  for (i = 0, n = 50; n > 10; i++, n -= i)
  {
  }
  cout << "C : i  = " << i << " n = " << n << "\n";
  //i = 0, n = 50 -> i = 1, n = 49
  //i = 1, n = 49 -> i = 2, n = 47
  //i = 2, n = 47 -> i = 3, n = 44
  //i = 3, n = 44 -> i = 4, n = 40
  //i = 4, n = 40 -> i = 5, n = 35
  //i = 5, n = 40 -> i = 6, n = 29
  //i = 6, n = 29 -> i = 7, n = 22
  //i = 7, n = 22 -> i = 8, n = 14
  //i = 8, n = 14 -> i = 9, n = 5
  // i = 9, n = 5

  for (i = 0, n = 0; i < 3;
       i++,
      n += i,
      cout << "D : i  = " << i << " n = " << n << "\n")
    ;

  //i = 0, n = 0, i++, n += i
  //i = 1, n = 1
  //i = 2, n = 3
  //i = 3, n = 6

  cout << "E : i  = " << i << " n = " << n << "\n";

  for (int j = 0; j < 5; j++)
    ;

  {
    cout << "icie" << endl;
  }
  //5x "ici"

  return 0;
}