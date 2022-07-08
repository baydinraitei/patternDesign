using Singleton;
using Common;

string synopsis = "Un utilisateur peut ajouter un événement dans l'agenda partagé visible par tous en utilisant le Singleton";

Design.header("Singleton", synopsis);

Uttilisateur uttilisateurA = new Uttilisateur(" Baha-eddine");
Uttilisateur uttilisateurB = new Uttilisateur("Inés");

uttilisateurA.Ajouter(new Planification($"Planification crée par {uttilisateurA.Name}", new DateTime(2022, 07, 01)));

uttilisateurA.Consulter();
uttilisateurB.Consulter();

Console.WriteLine($"Voici une consultation par {uttilisateurB.Name} de la plannication crée par {uttilisateurA.Name}.");
Console.WriteLine($"Nous allons faire l'approche contraire {uttilisateurA.Name} peut consulter la plannication crée par {uttilisateurB.Name}\n");

uttilisateurA.Ajouter(new Planification($"Planification crée par {uttilisateurB.Name}", new DateTime(2022, 07, 02)));

uttilisateurA.Consulter();
uttilisateurA.Consulter();

Console.WriteLine("Voici un représention fonctionnelle du Singleton");

Console.ReadKey();