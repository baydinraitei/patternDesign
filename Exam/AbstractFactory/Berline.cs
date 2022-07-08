using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Berline : Voiture
    {
        public Supercar ajouterSupercar(string denominationCommerciale)
        {
            return new Audi(denominationCommerciale);
        }

        public Hypercar ajouterHypercar(string denominationCommerciale)
        {
            return new Ferrari(denominationCommerciale);
        }
    }
}
