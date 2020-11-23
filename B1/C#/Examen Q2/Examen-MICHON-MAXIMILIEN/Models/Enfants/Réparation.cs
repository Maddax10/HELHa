using Examen_MICHON_MAXIMILIEN.Models.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Examen_MICHON_MAXIMILIEN.Models
{
    public class Réparation : Opération
    {

        private string Motif;
        private int NbHeure;
        private int NbMinute;
        private double PrixALHeure;

        public Réparation(string motif, int nbHeure, int nbMinute, double prixALHeure)
        {
            Motif = motif;
            NbHeure = nbHeure;
            NbMinute = nbMinute;
            PrixALHeure = prixALHeure;
        }

        public override double GetPrix()
        {
            double NbHeureTmp = NbHeure;

            if (NbMinute > 0)
            {
                if (NbMinute <= 15)
                    NbHeureTmp += 0.25;
                else if (NbMinute <= 30)
                    NbHeureTmp += 0.5;
                else if (NbMinute <= 45)
                    NbHeureTmp += 0.75;
                else
                    NbHeureTmp++; 
            }

            return NbHeureTmp * PrixALHeure;
        }

        public override string GetDétails()
        {
            return $"{Motif} ({NbHeure}:{NbMinute}) à {PrixALHeure}€/h) : {GetPrix()}€";
        }

    }
}
