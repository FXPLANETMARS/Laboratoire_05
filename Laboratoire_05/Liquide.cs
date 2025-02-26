using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Liquide : EtatMatiere
    {
        public Liquide() : base("Liquide") { }

        public override EtatMatiere ChangerEtat(double temperature)
        {
            if (temperature < 0)
            {
                Console.WriteLine("\n\tLe liquide gèle et devient solide");
                return new Solide();
            }
            else if (temperature >= 100)
            {
                Console.WriteLine("\n\tLe liquide s'évapore");
                return new Gaz();
            }
            return this; //Reste un liquide si aucun des ifs n'est utile



        }
    }
}
