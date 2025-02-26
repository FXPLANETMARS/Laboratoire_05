using Exercice_01;

namespace Laboratoire_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EtatMatiere etat = new Solide();
            etat.AfficherEtat();

            etat = etat.ChangerEtat(-10);
            etat.AfficherEtat();

            etat = etat.ChangerEtat(10);
            etat.AfficherEtat();

            etat = etat.ChangerEtat(150);
            etat.AfficherEtat();

            etat = etat.ChangerEtat(50);
            etat.AfficherEtat();

            etat = etat.ChangerEtat(-5);
            etat.AfficherEtat();
        }
    }
}
