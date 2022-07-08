using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Ferrari : Hypercar
    {
        public Ferrari(string name) : base(name) { }

        public override void afficherVehicule()
        {
            Console.WriteLine($"Nouvelle voiture crée de la marque{Name}");
        }
    }
}
