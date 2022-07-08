using Decorator;
using Common;

var synopsis = @"
Nous voulons définir l'encapsulation de plusieurs éléments à travers la conception structurelle Decorator 
";

var sujet = @"Le but ici est de décrire l'organisation d'un magasin de type supermarché";
Design.header("Decorator", synopsis , sujet);


Magasin magasin = new Magasin();
Rayon rayon = new Rayon(magasin);
Aller aller = new Aller(rayon);
Etalage etalage = new Etalage(aller);
etalage.printSynopsis();

Console.ReadKey();