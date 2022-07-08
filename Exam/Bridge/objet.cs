using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class objet
    {
        protected portable portable;

        public objet(portable portable)
        {
            this.portable = portable;
        }
        public abstract void connecter();
        public abstract void deconnecter();
        public abstract void Setmarque(string marque);
    }
}
