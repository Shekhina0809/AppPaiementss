using AppPaiementss;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carte1 = new CarteCredit(14.68, "Le Beau", 509089123);
        CarteCredit carte2 = new CarteCredit(20.99, "Canada WonderLand", 618119893);
        CarteCredit carte3 = new CarteCredit(80.56, "No Frills", 763248654);


        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();


        Paypal pay1 = new Paypal(75.98, "Zara paiement", "princess@gmail.com");
        Paypal pay2 = new Paypal(11.02, "Amazon paiement", "princ@gmail.com");
       

        pay1.AfficherDetails();
        pay2.AfficherDetails();

        Utilisateur user1 = new Utilisateur("OGOU");

        user1.AjouterPaiement(carte1);
        user1.AjouterPaiement(carte2);
        user1.AjouterPaiement(carte3);
        user1.AjouterPaiement(pay1);
        user1.AjouterPaiement(pay2);

        user1.AfficherInfos();

    }
}