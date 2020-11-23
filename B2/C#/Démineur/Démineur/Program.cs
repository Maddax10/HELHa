using Démineur.Models;
using Démineur.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur
{
    class Program
    {
        /// <summary>
        /// Programme du prof : https://gitlab.com/devexos/DemineurG1CSHARP
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            int X_Choice;
            int Y_Choice;

            Board board = new Board();
            ConsoleView consoleView = new ConsoleView(board);

            while (board.GetNbBombs > 0 && board.Loose == false)
            {
                Console.WriteLine("Quelle case voulez-vous dévoiler ?");
                Console.Write("X : ");

                while (!int.TryParse(Console.ReadLine(), out X_Choice))
                {
                    Console.WriteLine($"{X_Choice} n'est pas valide !\nX : ");
                }
                Console.Write("Y : ");

                while (!int.TryParse(Console.ReadLine(), out Y_Choice))
                {
                    Console.Write($"{Y_Choice} n'est pas valide !\nY : ");
                }

                board.ShowCellAt(X_Choice, Y_Choice);

                consoleView.RefreshAffichage(); 
            }

            consoleView.ShowAllBoard();

            Console.WriteLine("Perdu !");

            Console.Read();

        }
    }
}
