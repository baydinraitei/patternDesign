using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Etalage : Decorator
    {
        public Etalage(LeMagasin composant) : base(composant) { }

        protected void printEtalageSynopsis()
        {
            Console.WriteLine("Etalage du magasin ou se trouve l'article");
        }

        public override void printSynopsis()
        {
            base.printSynopsis();
            this.printEtalageSynopsis();
        }
    }
}
