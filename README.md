# patternDesignC-

#Initialisation repo


Abstract Factory


Abstract Factory est un pattern qui aide à la création d'objet, le but est de regrouper les objets en famille sans avoir à connaitre les bases de ces objets.

Abstract Factory va permettre de déresponsabiliser la classe mère. Pour cela, nous utilisons une interface qui va contenir des signatures de méthodes.

![Schéma UML 1](img/pattern_builder.png)

« L’abstract Factory » est un pattern de création (Creational Pattern) : il va donc nous servir pour instancier des objets.

Pour retenir facilement ce Patron de conception, on va essayer de comprendre ses termes : Factory et Abstract :

Factory : En développement orienté objet, une Factory (Fabrique) est un bout de code dédié qui a pour fonction de construire des objets : d’où son nom « Fabrique ».

Abstract : l’abstraction en développement objet permet de regrouper des comportements communs à une famille d’objets. Par exemple, un carré, un rectangle et un triangle vont hériter d’une classe « abstraite » « Forme Géométrique » qui contient un nombre de cotés, une superficie, etc.

Le pattern abstract Factory permet de rassembler des méthodes communes à des familles d’objets différents dans une classe commune : la fabrique abstraite, afin d’éviter au client d’appeler des méthodes différentes (concrètes) par famille d’objets.

Pour implémenter ce pattern, on fait intervenir en règle générale :

L’Abstract Factory : contient les interfaces pour les opérations communes de construction d’objets,
La Concrete Factory : contient l’implémentation concrète de construction d’un objet donné,
Les Abstract Products : déclarent les interfaces des produits,
Les concrete Products : déclarent les produits à implémenter,
Un client : le client utilisera uniquement les interfaces de l’abstract Factory pour implémenter les objets concrets.
abstractFActory

Architecture de l'application

Ici FabriqueVehicule est une interface qui contient deux signatures de méthodes créeAutomobile() et créeScooter().

La classe Scooter est une classe mère d'héritage, les classes filles ScooterElectricité et ScooterEssence utilisent extends Scooter pour étendre cette classe.

![Schéma UML 7](img/abstractFActory.png)

![Schéma UML 2](img/pattern_builder_2.png)


Architecture de l'application

Dans le second schéma, version générique du pattern, les structures sont affichées de façon plus générique FabriqueConcrète1 et FabriqueConcrète2 correspondraient à FabriqueVéhiculeElectricité et FabriqueVehiculeEssence.

ProduitAbstraitA correspond à scooter et ProduitAbstraitB à Automobile.

Pattern Builder
Création d'objets complexes sans avoir à s'occuper des problèmes d'implémentations


![Schéma UML 3](img/abstract_factory.png)
![Schéma UML 4](img/abstract_factory.png)


Ce pattern est utilisé pour séparer l'implémentation d'un cas spécifique de la logique/ du client.

ConstructeurAbstrait

ConstructeurLiasseVéhiculeHtml et ConstructeurLiasseVehiculePdf correspondent à ConstructeurConcret


Factory method
Généraliser la construction Builder pour préparer la création d'objet

![Schéma UML 5](img/factory_method.png)

Version générique vue en cours

![Schéma UML 6](img/factory_method_2.png)

Version concrète vue en cours
il s'agit d un modèle de création qui utilise des méthodes d'usine pour traiter le problème de la création d'objets sans avoir à spécifier la classe exacte de l'objet qui sera créé. Cela se fait en créant des objets en appelant une méthode de fabrique - soit spécifiée dans une interface et implémentée par des classes enfants, soit implémentée dans une classe de base et éventuellement remplacée par des classes dérivées - plutôt qu'en appelant un constructeur .

![Schéma UML 7](img/factory_method2.png)

Singleton


En génie logiciel, le singleton est un patron de conception (design pattern), appartenant à la catégorie des patrons de création, dont l'objectif est de restreindre l'instanciation d'une classe à un seul objet. On fournira alors un accès global à celui-ci. Il s'agit d'un des patrons de création les plus simples mais les plus couramment utilisés. 1

Il est utilisé lorsqu'on a besoin d'exactement un objet pour coordonner des opérations dans un système. Le modèle est parfois utilisé pour son efficacité, lorsque le système est plus rapide ou occupe moins de mémoire avec un seul objet qu'avec beaucoup d'objets similaires.

Exemple : 


Voici une class template écrite en D du pattern singleton :

class Singleton(T)  
{
	public
	{
		static T getSingleton() 
		{

			if(_instance is null) 
				_instance = new T;
			
			return _instance;
		}
	}
	private
	{
		this()
		{
		     	_instance = cast(T) this;
		}
		~this()
		{}
	
		static T _instance; 
	}
}
Java


 // La classe est finale, car un singleton n'est pas censé avoir d'héritier.
 public final class Singleton {

     // L'utilisation du mot clé volatile, en Java version 5 et supérieure,
     // empêche les effets de bord dus aux copies locales de l'instance qui peuvent être modifiées dans le thread principal.
     // De Java version 1.2 à 1.4, il est possible d'utiliser la classe ThreadLocal.
     private static volatile Singleton instance = null;
 
     // D'autres attributs, classiques et non "static".
     private String xxx;
     private int zzz;

     /**
      * Constructeur de l'objet.
      */
     private Singleton() {
         // La présence d'un constructeur privé supprime le constructeur public par défaut.
         // De plus, seul le singleton peut s'instancier lui-même.
         super();
     }
     
     /**
      * Méthode permettant de renvoyer une instance de la classe Singleton
      * @return Retourne l'instance du singleton.
      */
     public final static Singleton getInstance() {
         //Le "Double-Checked Singleton"/"Singleton doublement vérifié" permet 
         //d'éviter un appel coûteux à synchronized, 
         //une fois que l'instanciation est faite.
         if (Singleton.instance == null) {
            // Le mot-clé synchronized sur ce bloc empêche toute instanciation
            // multiple même par différents "threads".
            // Il est TRES important.
            synchronized(Singleton.class) {
              if (Singleton.instance == null) {
                Singleton.instance = new Singleton();
              }
            }
         }
         return Singleton.instance;
     }

     // D'autres méthodes classiques et non "static".
     public void faireXxx(...) {
       ...
       this.xxx = "bonjour";
     }

     public void faireZzz(...) {
       ...
     }
    
 }