using System;

public class ConstructeurLiasseVehiculec :
 ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculec()
    {
        liasse = new Liassec();
    }

    public override void construitBonDeCommande(string
      nomClient)
    {
        string document;
        document = "<c> Bon de commande Client : " +
          nomClient + "</c>";
        liasse.ajouteDocument(document);
    }

    public override void construitDemandeImmatriculation
      (string nomDemandeur)
    {
        string document;
        document = "<c> Demande d'immatriculation Demandeur : " +
          nomDemandeur + "</c>";
        liasse.ajouteDocument(document);
    }
}