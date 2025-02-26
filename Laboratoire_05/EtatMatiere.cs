using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class EtatMatiere
    {
        string nom;
        

        public EtatMatiere(string nom)
        {
            this.nom = nom;
        }


        public virtual EtatMatiere ChangerEtat(double temperature)
        {
            return this; //Par defaut, pas de changements
        }

        public void AfficherEtat()
        {
            Console.WriteLine($"\n\nL'état actuel est {nom}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
