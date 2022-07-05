using System; 
 
public class ClientVehicule
{
    static void Main(string[] args)
    {
        ConstructeurLiasseVehicule constructeur;
        Console.WriteLine("Voulez-vous construire " +
          "des liasses c# (1) ou c (2) :");
        string choix = Console.ReadLine();
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculec#();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculec();
        }
        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.construit("BAYDIN");
        liasse.imprime();
    }
}