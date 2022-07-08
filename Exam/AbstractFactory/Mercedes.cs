using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Mercedes : Supercar
    {
        public Mercedes(string denominationCommerciale) : base(denominationCommerciale) { }

        public override void afficherVehicule()
        {
            Console.WriteLine($"Nouvelle voiture crée de la marque {denominationCommerciale}");
        }
    }
}
