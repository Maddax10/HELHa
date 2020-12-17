using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur.Models
{
    class Board
    {
        //[0] = NbColonnes, [1] = NbLignes
        public const int NbColones = 30;
        public const int NbLignes = 20;

        private int NbBombs = 0;

        public bool Loose = false;

        private Cell[,] Cells;

        private Random random = new Random();

        public Board()
        {
            this.Cells = new Cell[NbColones, NbLignes];
            AddCells();
            PlaceBombs();
            CountBombs();
        }
        public int GetNbBombs
        {
            get => NbBombs;
        }

        private void AddCells()
        {
            for (int x = 0; x < NbColones; x++)
            {
                for (int y = 0; y < NbLignes; y++)
                {
                    Cells[x, y] = new Cell();
                }
            }
        }

        public Cell GetCellAt(int x, int y)
        {
            if (!PositionIsInBoard(x, y))
                throw new Exception("Position is not in the board");
            return Cells[x, y];
        }

        private bool PositionIsInBoard(int x, int y)
        {
            return x >= 0 && x < NbColones && y >= 0 && y < NbLignes;
        }

        private void PlaceBombs()
        {

            //Cells[0, 0].PlaceBomb();
            //SetNbBombsArround(0, 0);

            //Cells[10, 10].PlaceBomb();
            //SetNbBombsArround(10, 10);

            //Cells[10, 12].PlaceBomb();
            //SetNbBombsArround(10, 12);

            //Cells[15, 12].PlaceBomb();
            //SetNbBombsArround(15, 12);

            //Cells[20, 15].PlaceBomb();
            //SetNbBombsArround(20, 15);

            //Cells[25, 19].PlaceBomb();
            //SetNbBombsArround(25, 19);

            for (int x = 0; x < NbColones; x++)
            {
                for (int y = 0; y < NbLignes; y++)
                {
                    if (!Cells[x, y].HasBomb)
                    {
                        if (random.Next(0, 10) == 0)
                        {
                            Cells[x, y].PlaceBomb();
                            SetNbBombsArround(x, y);
                        }
                    }
                }
            }
        }

        private void SetNbBombsArround(int x, int y)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (PositionIsInBoard(x + i, y + j))
                        Cells[x + i, y + j].IncNbBombs();
                }
            }
        }

        private void CountBombs()
        {
            for (int x = 0; x < NbColones; x++)
            {
                for (int y = 0; y < NbLignes; y++)
                {
                    if (Cells[x, y].HasBomb)
                        NbBombs++;
                }
            }
        }

        public void ShowCellAt(int x, int y)
        {
            if (!PositionIsInBoard(x, y))
                throw new Exception("Position is not in the board");
            
            if (Cells[x, y].HasBomb)
            {
                Loose = true;
                return;
            }

            ClearArea(x, y);
        }

        private void ClearArea(int x, int y)
        {
            //Je regarde si la position est valide, si elle ne l'est pas j'arrête
            if (!PositionIsInBoard(x, y))
                return;

            if (Cells[x, y].IsVisible)
                return;

            Cells[x, y].Show();

            if (Cells[x, y].NbBombsAround > 0)
                return;

            ClearArea(x + 1, y);
            ClearArea(x, y + 1);
            ClearArea(x, y - 1);
            ClearArea(x - 1, y);

        }
    }
}
