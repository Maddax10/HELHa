using Démineur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur.View
{
    public class ConsoleView
    {
        private Board Board;

        public ConsoleView(Board board)
        {
            this.Board = board;
            RefreshAffichage();
        }

        public void RefreshAffichage()
        {

            Console.Clear();

            Console.WriteLine();
            for (int y = 0; y < Board.NbColones; y++)
            {
                for (int x = 0; x < Board.NbLignes; x++)
                {
                    Cell cell = Board.GetCellAt(y, x);

                    if (cell.IsVisible)
                    {

                        if (cell.HasBomb)
                            Console.Write(" B ");

                        if (cell.NbBombsAround == 0)
                            Console.Write(" _ ");
                        else
                            Console.Write(" " + cell.NbBombsAround + " ");

                    }
                    else
                        Console.Write(" . ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void ShowAllBoard()
        {
            Console.Clear();
            for (int y = 0; y < Board.NbColones; y++)
            {
                for (int x = 0; x < Board.NbLignes; x++)
                {
                    Cell cell = Board.GetCellAt(y, x);

                    if (cell.HasBomb)
                        Console.Write(" B ");

                    else if (cell.NbBombsAround == 0)
                        Console.Write(" _ ");
                    else
                        Console.Write(" " + cell.NbBombsAround + " ");

                }
                Console.WriteLine();
            }
        }

    }
}
