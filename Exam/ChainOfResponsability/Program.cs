using ChainOfResponsibility;
using Common;

string synopsis = @"
Nous somme une banque et nous affectons des restriction pour les payement en ligne via le pattern ChainOfResponsability.
";
string sujet = @"
Pour toute les transaction de moins de 100 euros aucun signature numérique n'est requis.
pour les montant entre 100 et 40 euros le codeSMS est requis.
pour les montant plus de 40 euros le signature numérique est requiré.
";
string delimiter = "----------------------------------------------------------------------------------------------------------";

Design.header("Chain of Responsibility", synopsis, sujet);

Gestionnaire paysimple = new PaySimpleGestionnaire();
Gestionnaire paysms = new PaySmsGestionnaire();
Gestionnaire paynum = new PayNumGestionnaire();

paysimple.Next = paysms;
paysms.Next = paynum;

int[] payements = { 40, 160, 4000};

Console.WriteLine(delimiter);

foreach (int montant in payements)
{
    Console.WriteLine(delimiter);

    paysimple.GetMontant(montant);
}
Console.WriteLine(delimiter);

Console.WriteLine("Si le montant excéde la limite autorisé, le système requiert une signature supérieure.");

Console.ReadKey();