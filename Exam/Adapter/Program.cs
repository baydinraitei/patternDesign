using Adapter;
using Common;

string synopsis = "Un outil de communication interne en entreprise via les cannaux mail sms et appel via le pattern Adapter";


Design.header("Adapter", synopsis);

Console.WriteLine("Génération d'un adaptateur pour le email");
communicationstart email = new email();
email.envoyer("baha_ben_hassen@hotmail.fr", "TEST");

Console.WriteLine("Génération d'un adaptateur pour le sms");
communicationstart sms = new sms();
sms.envoyer("0650990475", "TEST");

Console.ReadKey();