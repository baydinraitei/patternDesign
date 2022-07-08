using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Aller : Decorator
    {
        public Aller(LeMagasin composant) : base(composant) { }

        protected void printAllerSynopsis()
        {
            Console.WriteLine("Aller du magasin ou se trouve l'article");
        }

        public override void printSynopsis()
        {
            base.printSynopsis();
            this.printAllerSynopsis();
        }
    }
}
