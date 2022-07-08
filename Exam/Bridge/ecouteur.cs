using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ecouteurs : objet
    {
        public ecouteurs(portable portable) : base(portable) {
            Console.WriteLine($"airpods est compatible {portable.compatible()}");
        }

        public override void connecter()
        {
            portable.connecter();
        }
        public override void deconnecter()
        {
            portable.deconnecter();
        }
        public override void Setmarque(string gamme)
        {
            portable.Setmarque(gamme);
        }
    }
}
