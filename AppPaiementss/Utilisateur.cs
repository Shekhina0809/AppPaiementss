using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiementss
{
    internal class Utilisateur

    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom)
        {

            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public virtual void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
        public virtual void AfficherInfos()
        {
            Console.WriteLine($"L'utilisateur est {Nom}.");
            Console.WriteLine($"La liste de ses paiements:");

            foreach (var paiement in Paiements)
            {

                paiement.AfficherDetails();

            }

        }

       


    }
}
