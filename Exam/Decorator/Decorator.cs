using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Decorator : LeMagasin
    {
        protected LeMagasin composant;

        public Decorator(LeMagasin composant)
        {
            this.composant = composant;
        }

        public virtual void printSynopsis()
        {
            composant.printSynopsis();
        }
    }
}
