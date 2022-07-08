using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Uttilisateur
    {
        public string Name { get; set; }
        private Planificateur Planificateur { get; set; }

        public Uttilisateur(string name)
        {
            this.Name = name;
            this.Planificateur = Planificateur.Instance();
            Console.WriteLine($"L'uttilsateur {Name} a été ajouté à la planification");
        }

        public void Ajouter(Planification e)
        {
            Planificateur.AjouterPlanification(e);    
        }

        public void Consulter()
        {
            Console.WriteLine($"\n{Name} s'affiche bien dans le planificateur:");
            Planificateur.Consulter();
        }

    }
}
