using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class iphone : portable
    {
        public void connecter()
        {
            Console.WriteLine($"{this.compatible()}: \t connecté");
        }
        public void deconnecter()
        {
            Console.WriteLine($"{this.compatible()}: \t déconnecté");
        }
        public void Setmarque(string marque)
        {
            Console.WriteLine($"{this.compatible()}: \t est compatible avec la marque{marque}");
        }
        public string compatible()
        {
            return "Iphone";
        }

    
    }
}
