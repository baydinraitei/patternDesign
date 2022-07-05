using System;

public class Liassec# : Liasse
{
    public override void ajouteDocument(string document)
    {
        if (document.StartsWith("<c#>"))
            contenu.Add(document);
    }

    public override void imprime()
    {
        Console.WriteLine("Liasse c#");
        foreach (string s in contenu)
            Console.WriteLine(s);
    }
}