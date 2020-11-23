using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Q3.Model
{
    class GestionScore
    {

        private int _Score;

        public GestionScore()
        {
            _Score = 0;
        }

        public int Score
        {
            get
            {
                return _Score;
            }
            private set
            {
                if (value != _Score)
                    _Score = value;
            }
        }

        public void 

    }
}
