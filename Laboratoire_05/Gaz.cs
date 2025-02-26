using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Gaz : EtatMatiere
    {
        public Gaz() : base("Gaz") { }

        public override EtatMatiere ChangerEtat(double temperature)
        {
            if (temperature < 100)
            {
                Console.WriteLine("\n\tLe gaz devient liquide");
                return new Liquide();
            }
            return this;
        }
    }
}
