using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Magasin : LeMagasin
    {
        public void printSynopsis()
        {
            Console.WriteLine("Le magasin ou se trouve l'article");
        }
    }
}
