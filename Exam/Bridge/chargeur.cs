using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class chargeur : objet
    {
        public chargeur(portable portable) : base(portable) {
            Console.WriteLine($"L'accesoire est référencé compatible avec {portable.compatible()}");
        }

        public override void connecter()
        {
            portable.connecter();
        }
        public override void deconnecter()
        {
            portable.deconnecter();
        }
        public override void Setmarque(string gamme)
        {
            portable.Setmarque(gamme);
        }
    }
}
