using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Solide : EtatMatiere
    {
        public Solide() : base("Solide") { }

        public override EtatMatiere ChangerEtat(double temperature)
        {
            if (temperature >= 0)
            {
                Console.WriteLine("\n\tLe solide fond et devient liquide");
                return new Liquide();
            }
            return this; //Reste un solide
        }
        
    }
}
