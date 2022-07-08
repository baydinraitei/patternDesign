using Bridge;
using Common;

string synopsis = @"
Boutique de réparation de téléphone avec plusieurs gammes l'ajout de nouveau modèle et les test de compatibilité entre accesoire / téléphone se fait via le patron de conception structurelle Bridge pour d'avoir un nombre trop important de classes
";
string sujet = "L'abstraction est faite par les accessoires et l'implementation par les téléphones";

Design.header("Bridge", synopsis, sujet);

Console.WriteLine();
chargeur chargeur = new chargeur(new samsung());
chargeur.connecter();
chargeur.Setmarque("Induction");
chargeur.deconnecter();

Console.WriteLine();
ecouteurs ecouteurs = new ecouteurs(new iphone());
ecouteurs.connecter();
ecouteurs.Setmarque("Airpodspro");
ecouteurs.deconnecter();

Console.WriteLine();
chargeur chargeur2 = new chargeur(new ipad());
chargeur2.connecter();
chargeur2.Setmarque("chargeur haute vitesse");
chargeur2.deconnecter();

Console.ReadKey();