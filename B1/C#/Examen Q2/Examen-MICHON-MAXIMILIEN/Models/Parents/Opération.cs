using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_MICHON_MAXIMILIEN.Models.Parents
{
    public abstract class Opération
    {
        //Je ne veux pas qu'on puisse "écraser" ma listeOpérations donc je vais faire une propriété static avec un private set
        private static List<Opération> _ListeOpérations = new List<Opération>();

        private string GetNomClasse
        {
            get
            {
                return GetType().Name;
            }
        }
        public static List<Opération> ListeOpérations
        {
            get
            {
                return _ListeOpérations;
            }
            private set
            {
                if (value != _ListeOpérations)
                    _ListeOpérations = value;
            }
        }

        public abstract string GetDétails();
        public abstract double GetPrix();

        public string GetToutesLesInformations()
        {
            return $"{GetNomClasse} | {GetDétails()}";
        }

    }
}
