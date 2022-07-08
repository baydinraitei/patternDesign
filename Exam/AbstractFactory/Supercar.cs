using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Supercar
    {
        public string denominationCommerciale { get; set; }
        public Supercar(string denominationCommerciale)
        {
            this.denominationCommerciale = denominationCommerciale;
        }

        public abstract void afficherVehicule();
    }
}
