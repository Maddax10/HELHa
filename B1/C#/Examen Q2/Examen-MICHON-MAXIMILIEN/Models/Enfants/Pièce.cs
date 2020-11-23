using Examen_MICHON_MAXIMILIEN.Models.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MICHON_MAXIMILIEN.Models
{
    public class Pièce : Opération
    {

        private string Nom;
        private double Quantité;
        private double PrixALaPièce;

        public Pièce(string nom, double quantité, double prixALaPièce)
        {
            Nom = nom;
            Quantité = quantité;
            PrixALaPièce = prixALaPièce;
        }

        public override double GetPrix()
        {
            return Quantité * PrixALaPièce;
        }

        public override string GetDétails()
        {
            return $"{Quantité}x {Nom} ({PrixALaPièce}€/p) : {GetPrix()}€";
        }

    }
}
