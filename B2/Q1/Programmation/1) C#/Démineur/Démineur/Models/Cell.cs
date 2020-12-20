using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démineur.Models
{
    class Cell
    {

        private bool _IsVisible;
        private bool _HasBomb;
        private int _NbBombsAround;

        public bool IsVisible
        {
            get => _IsVisible;
            set
            {
                if (value != _IsVisible)
                    _IsVisible = value;

            }
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

        public Cell()
        {
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
