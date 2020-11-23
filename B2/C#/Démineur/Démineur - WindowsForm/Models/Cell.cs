using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur.Models
{
    public class Cell
    {

        public const int Size = 25;

        private bool _IsVisible;
        private bool _HasBomb;
        private int _NbBombsAround;

        private int _X;
        private int _Y;

        public bool IsVisible
        {
            get => _IsVisible;
            set
            {
                if (value != _IsVisible)
                    _IsVisible = value;

            }
        }

        public int X
        {
            get => _X;
        }
        public int Y
        {
            get => _Y;
        }

        public bool HasBomb
        {
            //Même comportement que Get{}
            get => _HasBomb;

        }
        public int NbBombsAround
        {
            get => _NbBombsAround;
            set
            {
                if (value != _NbBombsAround)
                    _NbBombsAround = value;
            }
        }

        public Cell(int x, int y)
        {
            _X = x;
            _Y = y;
        }

        public void PlaceBomb()
        {
            _HasBomb = true;
        }

        internal void Show()
        {
            _IsVisible = true;
        }

        internal void IncNbBombs()
        {
            _NbBombsAround++;
        }
    }
}
