using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Hypercar
    {
        public string Name { get; set; }
        public Hypercar(string name)
        {
            this.Name = name;
        }

        public abstract void afficherVehicule();
    }
}
