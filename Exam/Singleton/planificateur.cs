using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Planificateur
    {
        public List<Planification> planifications;
        private static Planificateur _instance = null;

        private Planificateur()
        {
            planifications = new List<Planification>();
        }

        public static Planificateur Instance()
        {
            if (_instance == null)
                _instance = new Planificateur();
            return _instance;
        }

        public bool AjouterPlanification(Planification e)
        {
            if(planifications.Contains(e))
            {
                Console.WriteLine($"Laplanification '{e.Name}' est déjà présente dans la planification l'insertion est impossible");
                return false;
            }

            planifications.Add(e);
            Console.WriteLine($"Laplanification '{e.Name}' a été ajouté planificateur");
            return true;
        }

        public bool SupprimerPlanification(Planification e)
        {
            if(!planifications.Contains(e))
            {
                Console.WriteLine($"Laplanification '{e.Name}' n'existe pas dans la planification la supression est impossible");
                return false;
            }
                
            planifications.Remove(e);
            Console.WriteLine($"Laplanification '{e.Name}'est supprimé");
            return true;
        }

        public void Consulter()
        {
            Console.WriteLine("////////////////////////////////////////////////////////////////////");
            Console.WriteLine("| \t Date \t\t | \t\t Name \t\t\t |");
            Console.WriteLine("////////////////////////////////////////////////////////////////////");
            foreach(Planification e in planifications)
            {
                Console.WriteLine($"| \t {e.Date.ToString("dd/MM/yyyy")} \t | \t {e.Name} \t |");
            }
            Console.WriteLine("////////////////////////////////////////////////////////////////////\n");
        }
    }
}
