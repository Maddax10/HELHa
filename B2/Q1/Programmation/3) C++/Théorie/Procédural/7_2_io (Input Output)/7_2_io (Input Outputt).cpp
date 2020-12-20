#include <iostream>
#include <windows.h>

using namespace std;

int main(int argc, char *argv[])
{

   SetConsoleOutputCP(65001); // Console en UTF8

   int i = 0;

   do
   {
      cout << "Veuillez entrer un nombre entre 0 et 10 : "; //Sortie standard pour tout ce qui est console
      cin >> i;                                             //Possibilité de lire plusieurs variables directement
      // cin >> var1 >> var2

      if (cin.fail())
      {
         cerr << "Mauvaise entrée !" << endl; //Console uniquement pour les erreurs, utile quand on fait tourner des processus

         i = 0;
         cin.clear();                 //Permet de vider le buffer de cin et donc d'enlever le flag de la fonction .fail()
         cin.ignore(INT32_MAX, '\n'); //Retire tout ce qu'il y dans le buffer en fonction de la variable utilisé ou jusqu'a la fin de la ligne et tu regardes la ligne d'après
      }
   } while (i <= 0 || i > 10);

   cout << "Le nombre entré est " << i << endl;

   return 0;
}