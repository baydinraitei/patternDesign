using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class voitureCourse : Voiture
    {
        public Supercar ajouterSupercar(string denominationCommerciale)
        {
            return new Mercedes(denominationCommerciale);
        }

        public Hypercar ajouterHypercar(string denominationCommerciale)
        {
            return new Bugatti(denominationCommerciale);
        }
    }
}
