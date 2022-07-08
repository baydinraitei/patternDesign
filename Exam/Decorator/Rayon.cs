using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Rayon : Decorator
    {
        public Rayon(LeMagasin composant) : base(composant) { }

        protected void printRayonSynopsis()
        {
            Console.WriteLine("Rayon du magasin ou se trouve l'article");
        }

        public override void printSynopsis()
        {
            base.printSynopsis();
            this.printRayonSynopsis();
        }
    }
}
