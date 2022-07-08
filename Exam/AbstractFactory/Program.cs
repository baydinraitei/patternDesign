using AbstractFactory;
using Common;

string synopsis = @"Logique métier de constructeur automobile
Le but du design pattern Abstract Factory est de regrouper les objets en familles sans avoir à connaître les bases de ces objets.
";
string but = "Nous avons implémenter deux factory qui permet de construire des'voitureCourse' et des 'Berline'.";

Design.header("Abstract Factory", synopsis, but);

Voiture voitureCourse = new voitureCourse();
Supercar Mercedes = voitureCourse.ajouterSupercar("Mercedes");
Mercedes.afficherVehicule();

Hypercar Bugatti  = voitureCourse.ajouterHypercar("Bugatti");
Bugatti.afficherVehicule();

Voiture Berline = new Berline();
Supercar Audi = Berline.ajouterSupercar("Audi");
Audi.afficherVehicule();

Hypercar Ferrari = Berline.ajouterHypercar("Ferrari");
Ferrari.afficherVehicule();

Console.ReadKey();